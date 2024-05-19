namespace Park_C_Updated
{
    partial class SignUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.usernameTxtbx = new System.Windows.Forms.TextBox();
            this.emailTxtbx = new System.Windows.Forms.TextBox();
            this.passwordTxtbx = new System.Windows.Forms.TextBox();
            this.signUpButton = new System.Windows.Forms.Button();
            this.signInButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Salmon;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(176, 141);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(719, 86);
            this.label1.TabIndex = 8;
            this.label1.Text = "Create a Park C Account";
            // 
            // usernameTxtbx
            // 
            this.usernameTxtbx.BackColor = System.Drawing.Color.Gainsboro;
            this.usernameTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTxtbx.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxtbx.ForeColor = System.Drawing.Color.DimGray;
            this.usernameTxtbx.Location = new System.Drawing.Point(367, 324);
            this.usernameTxtbx.Margin = new System.Windows.Forms.Padding(2);
            this.usernameTxtbx.Name = "usernameTxtbx";
            this.usernameTxtbx.Size = new System.Drawing.Size(340, 32);
            this.usernameTxtbx.TabIndex = 9;
            this.usernameTxtbx.TabStop = false;
            this.usernameTxtbx.Text = "Username";
            this.usernameTxtbx.WordWrap = false;
            this.usernameTxtbx.TextChanged += new System.EventHandler(this.username_TextChanged);
            this.usernameTxtbx.Enter += new System.EventHandler(this.username_enter);
            this.usernameTxtbx.Leave += new System.EventHandler(this.username_leave);
            // 
            // emailTxtbx
            // 
            this.emailTxtbx.BackColor = System.Drawing.Color.Gainsboro;
            this.emailTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailTxtbx.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTxtbx.ForeColor = System.Drawing.Color.DimGray;
            this.emailTxtbx.Location = new System.Drawing.Point(367, 379);
            this.emailTxtbx.Margin = new System.Windows.Forms.Padding(2);
            this.emailTxtbx.Name = "emailTxtbx";
            this.emailTxtbx.Size = new System.Drawing.Size(340, 32);
            this.emailTxtbx.TabIndex = 10;
            this.emailTxtbx.TabStop = false;
            this.emailTxtbx.Text = "Email";
            this.emailTxtbx.WordWrap = false;
            this.emailTxtbx.TextChanged += new System.EventHandler(this.email_TextChanged);
            this.emailTxtbx.Enter += new System.EventHandler(this.email_enter);
            this.emailTxtbx.Leave += new System.EventHandler(this.email_leave);
            // 
            // passwordTxtbx
            // 
            this.passwordTxtbx.BackColor = System.Drawing.Color.Gainsboro;
            this.passwordTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTxtbx.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxtbx.ForeColor = System.Drawing.Color.DimGray;
            this.passwordTxtbx.Location = new System.Drawing.Point(367, 434);
            this.passwordTxtbx.Margin = new System.Windows.Forms.Padding(2);
            this.passwordTxtbx.Name = "passwordTxtbx";
            this.passwordTxtbx.Size = new System.Drawing.Size(340, 32);
            this.passwordTxtbx.TabIndex = 11;
            this.passwordTxtbx.TabStop = false;
            this.passwordTxtbx.Text = "Password";
            this.passwordTxtbx.UseSystemPasswordChar = true;
            this.passwordTxtbx.WordWrap = false;
            this.passwordTxtbx.TextChanged += new System.EventHandler(this.password_TextChanged);
            this.passwordTxtbx.Enter += new System.EventHandler(this.password_enter);
            this.passwordTxtbx.Leave += new System.EventHandler(this.password_leave);
            // 
            // signUpButton
            // 
            this.signUpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(129)))), ((int)(((byte)(187)))));
            this.signUpButton.FlatAppearance.BorderSize = 0;
            this.signUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signUpButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpButton.ForeColor = System.Drawing.Color.White;
            this.signUpButton.Location = new System.Drawing.Point(616, 488);
            this.signUpButton.Margin = new System.Windows.Forms.Padding(2);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(91, 32);
            this.signUpButton.TabIndex = 12;
            this.signUpButton.Text = "Sign Up";
            this.signUpButton.UseVisualStyleBackColor = false;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // signInButton
            // 
            this.signInButton.BackColor = System.Drawing.Color.Salmon;
            this.signInButton.FlatAppearance.BorderSize = 0;
            this.signInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signInButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInButton.ForeColor = System.Drawing.Color.White;
            this.signInButton.Location = new System.Drawing.Point(378, 489);
            this.signInButton.Margin = new System.Windows.Forms.Padding(2);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(223, 32);
            this.signInButton.TabIndex = 13;
            this.signInButton.Text = "Already have an account?";
            this.signInButton.UseVisualStyleBackColor = false;
            this.signInButton.Click += new System.EventHandler(this.accAlreadyButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Salmon;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(454, 279);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Enter the following";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Park_C_Updated.Properties.Resources.Background;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1066, 687);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1066, 687);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.signInButton);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.passwordTxtbx);
            this.Controls.Add(this.emailTxtbx);
            this.Controls.Add(this.usernameTxtbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign Up";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usernameTxtbx;
        private System.Windows.Forms.TextBox emailTxtbx;
        private System.Windows.Forms.TextBox passwordTxtbx;
        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.Button signInButton;
        private System.Windows.Forms.Label label2;
    }
}

