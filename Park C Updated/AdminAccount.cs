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
    public partial class AdminAccount : Form
    {
        private string Username;
        public AdminAccount(string username)
        {
            InitializeComponent();
            this.Username = username;
            LoadUserData();
        }

        private void LoadUserData()
        {
            string filepath = "accounts.csv";
            try
            {
                using (StreamReader reader = new StreamReader(filepath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length >= 4 && parts[0].Trim() == Username)
                        {
                            usernameTxt.Text = parts[0].Trim();
                            emailTxt.Text = parts[1].Trim();
                            passwordTxt.Text = parts[2].Trim();
                            numberTxt.Text = parts.Length > 3 ? parts[3].Trim() : "";
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load user data: " + ex.Message);
            }
        }


        private void UpdateUserData(Dictionary<string, string> updates)
        {
            string filepath = "accounts.csv";
            List<string> lines = new List<string>();
            bool userFound = false;

            try
            {
                using (StreamReader reader = new StreamReader(filepath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length >= 4 && parts[0].Trim() == Username)
                        {
                            for (int i = 0; i < parts.Length; i++)
                            {
                                string key = i == 0 ? "username" : i == 1 ? "email" : i == 2 ? "password" : "phone";
                                if (updates.ContainsKey(key))
                                {
                                    parts[i] = updates[key].Trim();
                                }
                            }
                            line = string.Join(",", parts);
                            userFound = true;
                        }
                        lines.Add(line);
                    }
                }

                if (!userFound)
                {
                    MessageBox.Show("User not found.");
                    return;
                }

                using (StreamWriter writer = new StreamWriter(filepath))
                {
                    foreach (string line in lines)
                    {
                        writer.WriteLine(line);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update user data: " + ex.Message);
            }
        }

        private void EnableAndFocusTextBox(TextBox textBox, string fieldKey)
        {
            textBox.Enabled = true;
            textBox.Focus();
            textBox.KeyDown += (sender, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Dictionary<string, string> updates = new Dictionary<string, string>
                    {
                        { fieldKey, textBox.Text }
                    };
                    UpdateUserData(updates);
                    textBox.Enabled = false;
                    e.SuppressKeyPress = true;
                }
            };
        }


        private void aDashboardButton_Click(object sender, EventArgs e)
        {
            new AdminDashboard(Username).Show();
            this.Hide();
        }

        private void aTransactionButton_Click(object sender, EventArgs e)
        {
            new AdminStatus(Username).Show();
            this.Hide();
        }

        private void aAccountButton_Click(object sender, EventArgs e)
        {
            var updates = new Dictionary<string, string>
    {
        { "username", usernameTxt.Text },
        { "email", emailTxt.Text },
        { "password", passwordTxt.Text },
                { "phone", numberTxt.Text }
            };

            UpdateUserData(updates);
            Username = usernameTxt.Text.Trim();
            new UserAccount(usernameTxt.Text.Trim()).Show();
            this.Hide();
        }

        private void changeUsername_Click(object sender, EventArgs e)
        {
            EnableAndFocusTextBox(usernameTxt, "username");
        }

        private void changePassword_Click(object sender, EventArgs e)
        {
            EnableAndFocusTextBox(passwordTxt, "password");
        }

        private void changeEmail_Click(object sender, EventArgs e)
        {
            EnableAndFocusTextBox(emailTxt, "email");
        }

        private void changeNumber_Click(object sender, EventArgs e)
        {
            EnableAndFocusTextBox(numberTxt, "phone");
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            new SignIn().Show();
            this.Hide();
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
