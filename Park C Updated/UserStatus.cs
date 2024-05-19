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
    public partial class UserStatus : Form
    {
        private string userName;
        public UserStatus(string username)
        {
            InitializeComponent();
            this.userName = username;
        }

        private void uDashboardButton_Click(object sender, EventArgs e)
        {
            new UserDashboard(userName).Show();
            this.Hide();
        }

        private void uAccountButton_Click(object sender, EventArgs e)
        {
            new UserAccount(userName).Show();
            this.Hide();
        }

        private void uTransactionButton_Click(object sender, EventArgs e)
        {
            new UserStatus(userName).Show();
            this.Hide();
        }

        private void UserStatus_Load(object sender, EventArgs e)
        {
            LoadDataFromCSV();

        }

        private List<User> ReadReservationData()
        {
            string filepath = $"{userName}.csv";
            List<User> reservations = new List<User>();
            try
            {
                using (StreamReader reader = new StreamReader(filepath))
                {
                    string line;
                    reader.ReadLine();
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] data = line.Split(',');
                        User reservation = new User
                        {
                            slot = data[0],
                            dateReserved = data[1],
                            timeArrival = data[2],
                            hours = int.Parse(data[3]),
                            price = int.Parse(data[4])
                        };
                        reservations.Add(reservation);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Transactions unavailable. Reserve a slot first.");
            }
            return reservations;
        }

        private void PopulateDataGridView(List<User> reservations)
        {
            userReservation.Columns.Clear();
            userReservation.Columns.Add("Parking Slot", "Parking Slot");
            userReservation.Columns.Add("Date", "Date");
            userReservation.Columns.Add("Time", "Time Arrival");
            userReservation.Columns.Add("Hours", "Hours");
            userReservation.Columns.Add("Price", "Price");

            foreach (User reservation in reservations)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(userReservation);
                row.SetValues(reservation.slot, reservation.dateReserved, reservation.timeArrival, reservation.hours, reservation.price);
                userReservation.Rows.Add(row);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (userReservation.SelectedRows.Count > 0)
            {
                int selectedIndex = userReservation.SelectedRows[0].Index;
                if (selectedIndex != -1)
                {

                    string row = userReservation.Rows[selectedIndex].Cells[0].Value.ToString();
                    if (UserDashboard.parkingSlots.ContainsKey(row))
                    {
                        UserDashboard.parkingSlots[row] = (true, "LightGreen");
                    }

                    string slot = userReservation.Rows[selectedIndex].Cells[0].Value.ToString();
                    string dateReserved = userReservation.Rows[selectedIndex].Cells[1].Value.ToString();
                    string timeArrival = userReservation.Rows[selectedIndex].Cells[2].Value.ToString();
                    int hours = Convert.ToInt32(userReservation.Rows[selectedIndex].Cells[3].Value);
                    int price = Convert.ToInt32(userReservation.Rows[selectedIndex].Cells[4].Value);

                    userReservation.Rows.RemoveAt(selectedIndex);

                    UpdateCSVAfterDeletion();

                    UpdateAdminCSV(slot, dateReserved, timeArrival, hours, price);

                    UpdateParkingDataTXT();
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void UpdateCSVAfterDeletion()
        {
            string filepath = $"{userName}.csv";
            List<User> updatedReservations = new List<User>();

            foreach (DataGridViewRow row in userReservation.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    updatedReservations.Add(new User
                    {
                        slot = row.Cells[0].Value.ToString(),
                        dateReserved = row.Cells[1].Value.ToString(),
                        timeArrival = row.Cells[2].Value.ToString(),
                        hours = Convert.ToInt32(row.Cells[3].Value),
                        price = Convert.ToInt32(row.Cells[4].Value)
                    });
                }
            }

            using (StreamWriter writer = new StreamWriter(filepath, false))
            {
                writer.WriteLine("PARKING SLOT,DATE OF RESERVATION,TIME OF ARRIVAL,HOURS,AMOUNT");
                foreach (var reservation in updatedReservations)
                {
                    writer.WriteLine($"{reservation.slot},{reservation.dateReserved},{reservation.timeArrival},{reservation.hours},{reservation.price}");
                }
            }
        }

        private void UpdateAdminCSV(string slot, string dateReserved, string timeArrival, int hours, int price)
        {
            string filepath = "Admin.csv";
            List<string> lines = File.ReadAllLines(filepath).ToList();
            string lineToRemove = $"{userName},{slot},{dateReserved},{timeArrival},{hours},{price}";

            lines.Remove(lineToRemove);

            File.WriteAllLines(filepath, lines);
        }

        private void LoadDataFromCSV()
        {
            List<User> reservations = ReadReservationData();
            PopulateDataGridView(reservations);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (userReservation.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = userReservation.SelectedRows[0];
                User editingUser = new User
                {
                    slot = selectedRow.Cells[0].Value.ToString(),
                    dateReserved = selectedRow.Cells[1].Value.ToString(),
                    timeArrival = selectedRow.Cells[2].Value.ToString(),
                    hours = Convert.ToInt32(selectedRow.Cells[3].Value),
                    price = Convert.ToInt32(selectedRow.Cells[4].Value)
                };

                Reserve reserveForm = new Reserve
                {
                    username = this.userName,
                    isEditing = true,
                    editingUserReservation = editingUser
                };

                reserveForm.ShowDialog();
                LoadDataFromCSV();
            }
            else
            {
                MessageBox.Show("Please select a row to edit.");
            }
        }

        private void UpdateParkingDataTXT()
        {
            string data = "";
            foreach (KeyValuePair<string, (bool, string)> slot in UserDashboard.parkingSlots)
            {
                data += $"{slot.Key},{slot.Value.Item1},{slot.Value.Item2}\n";
            }
            File.WriteAllText("parking_data.txt", data);
        }
    }
 
}