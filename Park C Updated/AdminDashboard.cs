using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Park_C_Updated
{
    public partial class AdminDashboard : Form
    {
        private Dictionary<string, (bool, string)> parkingSlots = new Dictionary<string, (bool, string)>();
        private string username;
        public AdminDashboard(string username)
        {
            InitializeComponent();
            this.username = username;
            LoadParkingData();
        }

        private void aDashboardButton_Click(object sender, EventArgs e)
        {
            new AdminDashboard(username).Show();
            this.Hide();
        }

        private void aTransactionButton_Click(object sender, EventArgs e)
        {
            new AdminStatus(username).Show();
            this.Hide();
        }

        private void aAccountButton_Click(object sender, EventArgs e)
        {
            new AdminAccount(username).Show();
            this.Hide();
        }

        private void btnUp_clicked(object sender, EventArgs e)
        {
            if(prkngLayout1.Visible == true)
            {
                prkngLayout1.Visible = false;
                prkngLayout2.Visible = true;
                flrIndicator.Text = "FLOOR 2";
            }
            else if (prkngLayout2.Visible == true)
            {
                prkngLayout2.Visible = false;
                prkngLayout3.Visible = true;
                flrIndicator.Text = "FLOOR 3";
            }
            else
            {
                prkngLayout3.Visible = false;
                prkngLayout1.Visible = true;
                flrIndicator.Text = "FLOOR 1";
            }
        }

        private void btnDown_clicked(object sender, EventArgs e)
        {
            if (prkngLayout1.Visible == true)
            {
                prkngLayout1.Visible = false;
                prkngLayout3.Visible = true;
                flrIndicator.Text = "FLOOR 3";
            }
            else if (prkngLayout2.Visible == true)
            {
                prkngLayout2.Visible = false;
                prkngLayout1.Visible = true;
                flrIndicator.Text = "FLOOR 1";
            }
            else
            {
                prkngLayout3.Visible = false;
                prkngLayout2.Visible = true;
                flrIndicator.Text = "FLOOR 2";
            }
        }

        private void LoadParkingData()
        {
            if (File.Exists("parking_data.txt"))
            {
                parkingSlots.Clear();
                string[] lines = File.ReadAllLines("parking_data.txt");
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 3)
                    {
                        parkingSlots.Add(parts[0], (bool.Parse(parts[1]), parts[2]));
                    }

                }
            }
        }

        private void SaveParkingData()
        {
            string data = "";
            foreach (KeyValuePair<string, (bool, string)> slot in parkingSlots)
            {
                data += $"{slot.Key},{slot.Value.Item1},{slot.Value.Item2}\n";
            }
            File.WriteAllText("parking_data.txt", data);
        }

        private void slot_clicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            string slot = button.Text;
            (bool available, string buttonColor) = parkingSlots[slot];

            if (available)
            {
                parkingSlots[slot] = (false, "Salmon");
                button.BackColor = Color.Salmon;

                SaveParkingData();
                MessageBox.Show("Parking slot is made unavailable.");
            }
            else
            {
                parkingSlots[slot] = (true, "LightGreen");
                button.BackColor = Color.LightGreen;

                SaveParkingData();
                MessageBox.Show("Parking slot is made available.");
            }
        }

        private void UpdateButtonColors()
        {
            foreach (Panel panel in this.Controls.OfType<Panel>())
            {
                foreach (Button button in panel.Controls.OfType<Button>())
                {
                    string slot = button.Text;

                    if (parkingSlots.ContainsKey(slot))
                    {
                        (bool available, string color) = parkingSlots[slot];
                        button.BackColor = Color.FromName(available ? "LightGreen" : "Salmon");
                    }
                }
            }
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            UpdateButtonColors();
        }
    }
}
