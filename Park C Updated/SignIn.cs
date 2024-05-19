using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Park_C_Updated
{
    public partial class SignIn : Form
    {
        private AccountFileHandling accfilehandling = new AccountFileHandling();
        public SignIn()
        {
            InitializeComponent();
        }

        private void username_enter(object sender, EventArgs e)
        {
            if (usernameTxtbx.Text == "Username / Email")
            {
                usernameTxtbx.Text = "";
                usernameTxtbx.ForeColor = Color.DimGray;
            }
        }

        private void username_leave(object sender, EventArgs e)
        {
            if (usernameTxtbx.Text == "")
            {
                usernameTxtbx.Text = "Username / Email";
                usernameTxtbx.ForeColor = Color.DimGray;
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
            string username = usernameTxtbx.Text.Trim();
            string password = passwordTxtbx.Text;

            if (username == "Username / Email" || password == "Password")
            {
                lblConfirmation.Text = "Please enter your username and password.";
                lblConfirmation.ForeColor = Color.Red;
                return;
            }

            bool accFound = accfilehandling.Validate(username, password);

            if (accFound)
            {
                Form nextForm = (username == "admin1" && password == "admin123") ? (Form)new AdminDashboard(username) : new UserDashboard(username);
                nextForm.ShowDialog();
                this.Hide();
            }
            else
            {
                lblConfirmation.Text = "Username/Email or Password incorrect.";
                lblConfirmation.ForeColor = Color.Red;
                lblConfirmation.Location = new Point(363, 303);
            }
        }


        private void signUpButton_Click(object sender, EventArgs e)
        {
            new SignUp().Show();
            this.Hide();
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }
    }
}
