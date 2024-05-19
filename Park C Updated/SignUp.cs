using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Park_C_Updated
{
    public partial class SignUp : Form
    {
        private AccountFileHandling accfilehandling = new AccountFileHandling();
        public SignUp()
        {
            InitializeComponent();
        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^\S+@\S+\.\S+$";
            return Regex.IsMatch(email, pattern);
        }

        private void username_enter(object sender, EventArgs e)
        {
            if (usernameTxtbx.Text == "Username")
            {
                usernameTxtbx.Text = "";
                usernameTxtbx.ForeColor = Color.DimGray;
            }
        }

        private void username_leave(object sender, EventArgs e)
        {
            if (usernameTxtbx.Text == "")
            {
                usernameTxtbx.Text = "Username";
                usernameTxtbx.ForeColor = Color.DimGray;
            }
        }

        private void email_enter(object sender, EventArgs e)
        {
            if (emailTxtbx.Text == "Email")
            {
                emailTxtbx.Text = "";
                emailTxtbx.ForeColor = Color.DimGray;
            }
        }

        private void email_leave(object sender, EventArgs e)
        {
            if (emailTxtbx.Text == "")
            {
                emailTxtbx.Text = "Email";
                emailTxtbx.ForeColor = Color.DimGray;
            }
        }

        private void password_enter(object sender, EventArgs e)
        {
            if (passwordTxtbx.Text == "Password")
            {
                passwordTxtbx.Text = "";
                passwordTxtbx.ForeColor = Color.DimGray;
            }
        }

        private void password_leave(object sender, EventArgs e)
        {
            if (passwordTxtbx.Text == "")
            {
                passwordTxtbx.Text = "Password";
                passwordTxtbx.ForeColor = Color.DimGray;
            }
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            new SignIn().Show();
            this.Hide();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            string username = usernameTxtbx.Text;
            string email = emailTxtbx.Text;
            string password = passwordTxtbx.Text;

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            accfilehandling.username = username;
            accfilehandling.email = email;
            accfilehandling.password = password;

            try
            {
                accfilehandling.Save();
                MessageBox.Show("Account created successfully!");
                new SignIn().Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void accAlreadyButton_Click(object sender, EventArgs e)
        {
            new SignIn().Show();
            this.Hide();
        }
    }
}
