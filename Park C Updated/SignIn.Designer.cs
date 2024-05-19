namespace Park_C_Updated
{
    partial class SignIn
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblConfirmation = new System.Windows.Forms.Label();
            this.usernameTxtbx = new System.Windows.Forms.TextBox();
            this.passwordTxtbx = new System.Windows.Forms.TextBox();
            this.signUpButton = new System.Windows.Forms.Button();
            this.signInButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Park_C_Updated.Properties.Resources.bgSignIn;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1066, 687);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Salmon;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(180, 150);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(722, 71);
            this.label1.TabIndex = 9;
            this.label1.Text = "Sign In To Your Park C Acount";
            // 
            // lblConfirmation
            // 
            this.lblConfirmation.AutoSize = true;
            this.lblConfirmation.BackColor = System.Drawing.Color.Salmon;
            this.lblConfirmation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblConfirmation.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmation.ForeColor = System.Drawing.Color.White;
            this.lblConfirmation.Location = new System.Drawing.Point(455, 303);
            this.lblConfirmation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConfirmation.Name = "lblConfirmation";
            this.lblConfirmation.Size = new System.Drawing.Size(172, 25);
            this.lblConfirmation.TabIndex = 15;
            this.lblConfirmation.Text = "Enter the following";
            // 
            // usernameTxtbx
            // 
            this.usernameTxtbx.BackColor = System.Drawing.Color.Gainsboro;
            this.usernameTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTxtbx.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxtbx.ForeColor = System.Drawing.Color.DimGray;
            this.usernameTxtbx.Location = new System.Drawing.Point(366, 349);
            this.usernameTxtbx.Margin = new System.Windows.Forms.Padding(2);
            this.usernameTxtbx.Name = "usernameTxtbx";
            this.usernameTxtbx.Size = new System.Drawing.Size(340, 32);
            this.usernameTxtbx.TabIndex = 16;
            this.usernameTxtbx.TabStop = false;
            this.usernameTxtbx.Text = "Username / Email";
            this.usernameTxtbx.WordWrap = false;
            this.usernameTxtbx.TextChanged += new System.EventHandler(this.username_TextChanged);
            this.usernameTxtbx.Enter += new System.EventHandler(this.username_enter);
            this.usernameTxtbx.Leave += new System.EventHandler(this.username_leave);
            // 
            // passwordTxtbx
            // 
            this.passwordTxtbx.BackColor = System.Drawing.Color.Gainsboro;
            this.passwordTxtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTxtbx.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxtbx.ForeColor = System.Drawing.Color.DimGray;
            this.passwordTxtbx.Location = new System.Drawing.Point(366, 403);
            this.passwordTxtbx.Margin = new System.Windows.Forms.Padding(2);
            this.passwordTxtbx.Name = "passwordTxtbx";
            this.passwordTxtbx.Size = new System.Drawing.Size(340, 32);
            this.passwordTxtbx.TabIndex = 17;
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
            this.signUpButton.Location = new System.Drawing.Point(615, 458);
            this.signUpButton.Margin = new System.Windows.Forms.Padding(2);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(91, 32);
            this.signUpButton.TabIndex = 18;
            this.signUpButton.Text = "Sign In";
            this.signUpButton.UseVisualStyleBackColor = false;
            this.signUpButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // signInButton
            // 
            this.signInButton.BackColor = System.Drawing.Color.Salmon;
            this.signInButton.FlatAppearance.BorderSize = 0;
            this.signInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signInButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInButton.ForeColor = System.Drawing.Color.White;
            this.signInButton.Location = new System.Drawing.Point(417, 458);
            this.signInButton.Margin = new System.Windows.Forms.Padding(2);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(185, 32);
            this.signInButton.TabIndex = 19;
            this.signInButton.Text = "Don\'t have an account?";
            this.signInButton.UseVisualStyleBackColor = false;
            this.signInButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1066, 687);
            this.Controls.Add(this.signInButton);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.passwordTxtbx);
            this.Controls.Add(this.usernameTxtbx);
            this.Controls.Add(this.lblConfirmation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignIn";
            this.Load += new System.EventHandler(this.SignIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblConfirmation;
        private System.Windows.Forms.TextBox usernameTxtbx;
        private System.Windows.Forms.TextBox passwordTxtbx;
        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.Button signInButton;
    }
}