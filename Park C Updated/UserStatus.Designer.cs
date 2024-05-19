namespace Park_C_Updated
{
    partial class UserStatus
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uAccountButton = new System.Windows.Forms.Button();
            this.uTransactionButton = new System.Windows.Forms.Button();
            this.uDashboardButton = new System.Windows.Forms.Button();
            this.number = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.userReservation = new System.Windows.Forms.DataGridView();
            this.time = new System.Windows.Forms.Label();
            this.hours = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.userReservation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // uAccountButton
            // 
            this.uAccountButton.BackColor = System.Drawing.Color.Gainsboro;
            this.uAccountButton.FlatAppearance.BorderSize = 0;
            this.uAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uAccountButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uAccountButton.ForeColor = System.Drawing.Color.Black;
            this.uAccountButton.Location = new System.Drawing.Point(846, 36);
            this.uAccountButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uAccountButton.Name = "uAccountButton";
            this.uAccountButton.Size = new System.Drawing.Size(133, 45);
            this.uAccountButton.TabIndex = 19;
            this.uAccountButton.Text = "Account";
            this.uAccountButton.UseVisualStyleBackColor = false;
            this.uAccountButton.Click += new System.EventHandler(this.uAccountButton_Click);
            // 
            // uTransactionButton
            // 
            this.uTransactionButton.BackColor = System.Drawing.Color.Gainsboro;
            this.uTransactionButton.FlatAppearance.BorderSize = 0;
            this.uTransactionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uTransactionButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uTransactionButton.ForeColor = System.Drawing.Color.Black;
            this.uTransactionButton.Location = new System.Drawing.Point(624, 36);
            this.uTransactionButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uTransactionButton.Name = "uTransactionButton";
            this.uTransactionButton.Size = new System.Drawing.Size(136, 45);
            this.uTransactionButton.TabIndex = 18;
            this.uTransactionButton.Text = "Transactions";
            this.uTransactionButton.UseVisualStyleBackColor = false;
            this.uTransactionButton.Click += new System.EventHandler(this.uTransactionButton_Click);
            // 
            // uDashboardButton
            // 
            this.uDashboardButton.BackColor = System.Drawing.Color.Gainsboro;
            this.uDashboardButton.FlatAppearance.BorderSize = 0;
            this.uDashboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uDashboardButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uDashboardButton.ForeColor = System.Drawing.Color.Black;
            this.uDashboardButton.Location = new System.Drawing.Point(412, 36);
            this.uDashboardButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uDashboardButton.Name = "uDashboardButton";
            this.uDashboardButton.Size = new System.Drawing.Size(128, 45);
            this.uDashboardButton.TabIndex = 17;
            this.uDashboardButton.Text = "Dashboard";
            this.uDashboardButton.UseVisualStyleBackColor = false;
            this.uDashboardButton.Click += new System.EventHandler(this.uDashboardButton_Click);
            // 
            // number
            // 
            this.number.AutoSize = true;
            this.number.BackColor = System.Drawing.Color.Gainsboro;
            this.number.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.number.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number.ForeColor = System.Drawing.Color.Black;
            this.number.Location = new System.Drawing.Point(142, 218);
            this.number.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(124, 21);
            this.number.TabIndex = 21;
            this.number.Text = "Parking Number";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.BackColor = System.Drawing.Color.Gainsboro;
            this.date.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.date.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.ForeColor = System.Drawing.Color.Black;
            this.date.Location = new System.Drawing.Point(356, 218);
            this.date.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(42, 21);
            this.date.TabIndex = 22;
            this.date.Text = "Date";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.BackColor = System.Drawing.Color.Gainsboro;
            this.price.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.price.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.ForeColor = System.Drawing.Color.Black;
            this.price.Location = new System.Drawing.Point(833, 218);
            this.price.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(44, 21);
            this.price.TabIndex = 23;
            this.price.Text = "Price";
            // 
            // userReservation
            // 
            this.userReservation.AllowUserToAddRows = false;
            this.userReservation.AllowUserToResizeRows = false;
            this.userReservation.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.userReservation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.userReservation.BackgroundColor = System.Drawing.Color.Salmon;
            this.userReservation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userReservation.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userReservation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.userReservation.ColumnHeadersHeight = 29;
            this.userReservation.ColumnHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.userReservation.DefaultCellStyle = dataGridViewCellStyle4;
            this.userReservation.GridColor = System.Drawing.Color.Salmon;
            this.userReservation.Location = new System.Drawing.Point(112, 271);
            this.userReservation.Margin = new System.Windows.Forms.Padding(0);
            this.userReservation.Name = "userReservation";
            this.userReservation.RowHeadersWidth = 51;
            this.userReservation.Size = new System.Drawing.Size(848, 322);
            this.userReservation.TabIndex = 24;
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.BackColor = System.Drawing.Color.Gainsboro;
            this.time.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.time.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.ForeColor = System.Drawing.Color.Black;
            this.time.Location = new System.Drawing.Point(474, 218);
            this.time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(112, 21);
            this.time.TabIndex = 25;
            this.time.Text = "Time of Arrival";
            // 
            // hours
            // 
            this.hours.AutoSize = true;
            this.hours.BackColor = System.Drawing.Color.Gainsboro;
            this.hours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hours.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hours.ForeColor = System.Drawing.Color.Black;
            this.hours.Location = new System.Drawing.Point(677, 218);
            this.hours.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hours.Name = "hours";
            this.hours.Size = new System.Drawing.Size(52, 21);
            this.hours.TabIndex = 26;
            this.hours.Text = "Hours";
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(703, 613);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(96, 32);
            this.deleteButton.TabIndex = 27;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(129)))), ((int)(((byte)(187)))));
            this.editButton.FlatAppearance.BorderSize = 0;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.ForeColor = System.Drawing.Color.White;
            this.editButton.Location = new System.Drawing.Point(837, 613);
            this.editButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(96, 32);
            this.editButton.TabIndex = 28;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Park_C_Updated.Properties.Resources.Transaction2;
            this.pictureBox2.Location = new System.Drawing.Point(-2, 124);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1067, 563);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Park_C_Updated.Properties.Resources.Header1;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1067, 617);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // UserStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1064, 675);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.hours);
            this.Controls.Add(this.time);
            this.Controls.Add(this.userReservation);
            this.Controls.Add(this.price);
            this.Controls.Add(this.date);
            this.Controls.Add(this.number);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.uAccountButton);
            this.Controls.Add(this.uTransactionButton);
            this.Controls.Add(this.uDashboardButton);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "UserStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserStatus";
            this.Load += new System.EventHandler(this.UserStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userReservation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uAccountButton;
        private System.Windows.Forms.Button uTransactionButton;
        private System.Windows.Forms.Button uDashboardButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label number;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.DataGridView userReservation;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label hours;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
    }
}