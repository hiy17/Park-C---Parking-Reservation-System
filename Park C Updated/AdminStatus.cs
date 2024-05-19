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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Park_C_Updated
{
    public partial class AdminStatus : Form
    {
        private string userName;
        public AdminStatus(string username)
        {
            InitializeComponent();
            this.userName = username;
        }

        private void aDashboardButton_Click(object sender, EventArgs e)
        {
            new AdminDashboard(userName).Show();
            this.Hide();
        }

        private void aTransactionButton_Click(object sender, EventArgs e)
        {
            new AdminStatus(userName).Show();
            this.Hide();
        }

        private void aAccountButton_Click(object sender, EventArgs e)
        {
            new AdminAccount(userName).Show();
            this.Hide();
        }

        private void AdminStatus_Load(object sender, EventArgs e)
        {
            LoadDataFromCSV();
        }

        public List<Admin> ReadReservationData()
        {
            string filepath = "Admin.csv";
            List<Admin> reservations = new List<Admin>();

            try
            {
                using (StreamReader reader = new StreamReader(filepath))
                {
                    string line;
                    reader.ReadLine();
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] data = line.Split(',');
                        Admin reservation = new Admin
                        {
                            usernames = data[0],
                            slot = data[1],
                            dateReserved = data[2],
                            timeArrival = data[3],
                            hours = int.Parse(data[4]),
                            price = int.Parse(data[5])
                        };
                        reservations.Add(reservation);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading from CSV");
            }
            return reservations;
        }

        public void PopulateDataGridView(List<Admin> reservations)
        {
            adminReservation.Columns.Clear();
            adminReservation.Columns.Add("Usernames", "Usernames");
            adminReservation.Columns.Add("ParkingSlot", "Parking Slot");
            adminReservation.Columns.Add("Date", "Date");
            adminReservation.Columns.Add("Time", "Time Arrival");
            adminReservation.Columns.Add("Hours", "Hours");
            adminReservation.Columns.Add("Price", "Price");

            foreach (Admin reservation in reservations)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(adminReservation);
                row.SetValues(reservation.usernames, reservation.slot, reservation.dateReserved, reservation.timeArrival, reservation.hours, reservation.price);
                adminReservation.Rows.Add(row);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (adminReservation.SelectedRows.Count > 0)
            {
                int selectedIndex = adminReservation.SelectedRows[0].Index;
                if (selectedIndex != -1)
                {
                    string username = adminReservation.Rows[selectedIndex].Cells[0].Value.ToString();
                    string slot = adminReservation.Rows[selectedIndex].Cells[1].Value.ToString();
                    string dateReserved = adminReservation.Rows[selectedIndex].Cells[2].Value.ToString();
                    string timeArrival = adminReservation.Rows[selectedIndex].Cells[3].Value.ToString();
                    int hours = Convert.ToInt32(adminReservation.Rows[selectedIndex].Cells[4].Value);
                    int price = Convert.ToInt32(adminReservation.Rows[selectedIndex].Cells[5].Value);

                    adminReservation.Rows.RemoveAt(selectedIndex);
                    UpdateCsvFiles(username, slot, dateReserved, timeArrival, hours, price);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void UpdateCsvFiles(string username, string slot, string dateReserved, string timeArrival, int hours, int price)
        {
            string adminFilePath = "Admin.csv";
            string adminLineToRemove = $"{username},{slot},{dateReserved},{timeArrival},{hours},{price}";
            RemoveEntryFromCsv(adminFilePath, adminLineToRemove);

            string userFilePath = $"{username}.csv";
            string userLineToRemove = $"{slot},{dateReserved},{timeArrival},{hours},{price}";
            RemoveEntryFromCsv(userFilePath, userLineToRemove);
        }

        private void RemoveEntryFromCsv(string filePath, string lineToRemove)
        {
            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath).ToList();
                if (lines.Remove(lineToRemove))
                {
                    File.WriteAllLines(filePath, lines);
                }
                else
                {
                    MessageBox.Show($"Entry not found in {filePath}: {lineToRemove}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"File not found: {filePath}", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDataFromCSV()
        {
            List<Admin> reservations = ReadReservationData();
            PopulateDataGridView(reservations);
        }
    }
}
