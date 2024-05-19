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
    public partial class Reserve : Form
    {
        public string username { get; set; }
        public string slot { get; set; }
        public bool isEditing = false;
        public User editingUserReservation { get; set; }
        public Admin editingAdminReservation { get; set; }
        public bool isConfirmed = false;

        public Reserve()
        {
            InitializeComponent();
        }

        private void hours_enter(object sender, EventArgs e)
        {
            if (hours.Text == "Hours")
            {
                hours.Text = "";
                hours.ForeColor = Color.DimGray;
            }
        }

        private void hours_leave(object sender, EventArgs e)
        {
            if (hours.Text == "")
            {
                hours.Text = "Hours";
                hours.ForeColor = Color.DimGray;
            }
        }

        private void price_enter(object sender, EventArgs e)
        {
            if (price.Text == "Price")
            {
                price.Text = "";
                price.ForeColor = Color.DimGray;
            }
        }

        private void price_leave(object sender, EventArgs e)
        {
            if (price.Text == "")
            {
                price.Text = "Price";
                price.ForeColor = Color.DimGray;
            }
        }

        private void Reserve_Load(object sender, EventArgs e)
        {
            if (isEditing)
            {
                if (editingUserReservation != null)
                {
                    slotValue.Text = editingUserReservation.slot;
                    dateReserved.Text = editingUserReservation.dateReserved;
                    timeArrived.Text = editingUserReservation.timeArrival;
                    hours.Text = editingUserReservation.hours.ToString();
                    price.Text = (editingUserReservation.price / editingUserReservation.hours).ToString();
                }
                else if (editingAdminReservation != null)
                {
                    slotValue.Text = editingAdminReservation.slot;
                    dateReserved.Text = editingAdminReservation.dateReserved;
                    timeArrived.Text = editingAdminReservation.timeArrival;
                    hours.Text = editingAdminReservation.hours.ToString();
                    price.Text = (editingAdminReservation.price / editingAdminReservation.hours).ToString();
                }
            }
            else
            {
                slotValue.Text = slot;
            }
        }

        private void reserve_clicked(object sender, EventArgs e)
        {
            bool isValid = ValidateUserInput(slotValue.Text, dateReserved.Value, timeArrived.Value, hours.Text);

            if (isValid)
            {
                User user = new User
                {
                    usernames = username,
                    slot = slotValue.Text,
                    dateReserved = dateReserved.Text,
                    timeArrival = timeArrived.Text,
                    hours = int.Parse(hours.Text),
                    price = int.Parse(price.Text) * int.Parse(hours.Text)
                };

                Admin admin = new Admin
                {
                    usernames = username,
                    slot = user.slot,
                    dateReserved = user.dateReserved,
                    timeArrival = user.timeArrival,
                    hours = user.hours,
                    price = user.price
                };

                if (isEditing && editingUserReservation != null)
                {
                    UpdateExistingUserReservation(user);
                }
                else if (isEditing && editingAdminReservation != null)
                {
                    UpdateExistingAdminReservation(admin);
                }
                else
                {
                    user.ReserveSlot(username);
                    admin.ReserveSlot(username);
                }
                isConfirmed = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please fill up all required fields before reserving.", "Reservation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateExistingAdminReservation(Admin updatedAdmin)
        {
            string filepath = "Admin.csv";
            var lines = File.ReadAllLines(filepath).ToList();
            var index = lines.FindIndex(line => line.StartsWith(editingUserReservation.slot + ","));

            if (index != -1)
            {
                lines[index] = $"{updatedAdmin.usernames},{updatedAdmin.slot},{updatedAdmin.dateReserved},{updatedAdmin.timeArrival},{updatedAdmin.hours},{updatedAdmin.price}";
                File.WriteAllLines(filepath, lines);
                MessageBox.Show("Reservation updated successfully.");

                Admin admin = new Admin
                {
                    usernames = username,
                    slot = updatedAdmin.slot,
                    dateReserved = updatedAdmin.dateReserved,
                    timeArrival = updatedAdmin.timeArrival,
                    hours = updatedAdmin.hours,
                    price = updatedAdmin.price
                };
                admin.UpdateAdminRecord(username, editingAdminReservation.slot);
            }
        }

        private void UpdateExistingUserReservation(User updatedUser)
        {
            string filepath = $"{username}.csv";
            var lines = File.ReadAllLines(filepath).ToList();
            var index = lines.FindIndex(line => line.StartsWith(editingUserReservation.slot + ","));

            if (index != -1)
            {
                lines[index] = $"{updatedUser.slot},{updatedUser.dateReserved},{updatedUser.timeArrival},{updatedUser.hours},{updatedUser.price}";
                File.WriteAllLines(filepath, lines);
                MessageBox.Show("Reservation updated successfully.");

                Admin admin = new Admin
                {
                    usernames = username,
                    slot = updatedUser.slot,
                    dateReserved = updatedUser.dateReserved,
                    timeArrival = updatedUser.timeArrival,
                    hours = updatedUser.hours,
                    price = updatedUser.price
                };
                admin.UpdateAdminRecord(username, editingUserReservation.slot);
            }
        }

        private bool ValidateUserInput(string slot, DateTime date, DateTime time, string hours)
        {
            if (string.IsNullOrEmpty(slot))
            {
                return false;
            }

            if (date.Date == DateTime.Today && time < DateTime.Now)
            {
                return false;
            }

            if (date.Date < DateTime.Today)
            {
                return false;
            }

            if (string.IsNullOrEmpty(hours))
            {
                return false;
            }

            return true;
        }
    }
}