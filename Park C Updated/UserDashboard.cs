using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Park_C_Updated
{
    public partial class UserDashboard : Form
    {
        public static Dictionary<string, (bool, string)> parkingSlots = new Dictionary<string, (bool, string)>();
        private string username;

        public UserDashboard(string username)
        {
            InitializeComponent();
            this.username = username;

            LoadParkingData();

            int totalSlotsPerFloor = 24;

            if (parkingSlots.Count == 0)
            {
                for (int i = 1; i <= 3; i++)
                {
                    char floor = (char)(65 + i - 1);
                    for (int j = 1; j <= totalSlotsPerFloor; j++)
                    {
                        string slot = $"{floor}{j}";
                        parkingSlots.Add(slot, (true, "LightGreen"));
                    }
                }
            }

        }

        private void uDashboardButton_Click(object sender, EventArgs e)
        {
            new UserDashboard(username).Show();
            this.Hide();
        }

        private void uTransactionButton_Click(object sender, EventArgs e)
        {
            new UserStatus(username).Show();
            this.Hide();
        }

        private void uAccountButton_Click(object sender, EventArgs e)
        {
            new UserAccount(username).Show();
            this.Hide();
        }

        private void btnUp_clicked(object sender, EventArgs e)
        {
            if (prkngLayout1.Visible == true)
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

        private void slot_Clicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Reserve reserve = new Reserve();

            string slot = button.Text;
            (bool available, string buttonColor) = parkingSlots[slot];

            if (available)
            { 
                reserve.slot = slot;
                reserve.username = username;
                reserve.ShowDialog();
                if(reserve.isConfirmed == true)
                {
                    parkingSlots[slot] = (false, "Salmon");
                    button.BackColor = Color.Salmon;
                    SaveParkingData();

                    MessageBox.Show("Parking Slot Reserved Successfully.");
                }
            }
            else
            {
                MessageBox.Show("This parking slot is already reserved.");
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

        private void UserDashboard_Load_1(object sender, EventArgs e)
        {
            UpdateButtonColors();
        }
    }
}