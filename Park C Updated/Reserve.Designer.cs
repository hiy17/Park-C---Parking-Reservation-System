namespace Park_C_Updated
{
    partial class Reserve
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
            this.unavailableLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.reserveButton = new System.Windows.Forms.Button();
            this.slotValue = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.hours = new System.Windows.Forms.TextBox();
            this.dateReserved = new System.Windows.Forms.DateTimePicker();
            this.timeArrived = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // unavailableLabel
            // 
            this.unavailableLabel.AutoSize = true;
            this.unavailableLabel.BackColor = System.Drawing.Color.Salmon;
            this.unavailableLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unavailableLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unavailableLabel.ForeColor = System.Drawing.Color.White;
            this.unavailableLabel.Location = new System.Drawing.Point(133, 25);
            this.unavailableLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.unavailableLabel.Name = "unavailableLabel";
            this.unavailableLabel.Size = new System.Drawing.Size(449, 37);
            this.unavailableLabel.TabIndex = 18;
            this.unavailableLabel.Text = "Do you want to reserve this parking?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Salmon;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(68, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 30);
            this.label1.TabIndex = 19;
            this.label1.Text = "Parking Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Salmon;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(68, 137);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 30);
            this.label2.TabIndex = 20;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Salmon;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(68, 194);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 30);
            this.label3.TabIndex = 21;
            this.label3.Text = "Time of Arrival (24 hr)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Salmon;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(68, 245);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 30);
            this.label4.TabIndex = 22;
            this.label4.Text = "Hours";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Salmon;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(68, 297);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 30);
            this.label5.TabIndex = 23;
            this.label5.Text = "Price Per Hour";
            // 
            // reserveButton
            // 
            this.reserveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(129)))), ((int)(((byte)(187)))));
            this.reserveButton.FlatAppearance.BorderSize = 0;
            this.reserveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reserveButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reserveButton.ForeColor = System.Drawing.Color.White;
            this.reserveButton.Location = new System.Drawing.Point(512, 347);
            this.reserveButton.Margin = new System.Windows.Forms.Padding(2);
            this.reserveButton.Name = "reserveButton";
            this.reserveButton.Size = new System.Drawing.Size(120, 30);
            this.reserveButton.TabIndex = 24;
            this.reserveButton.Text = "Reserve";
            this.reserveButton.UseVisualStyleBackColor = false;
            this.reserveButton.Click += new System.EventHandler(this.reserve_clicked);
            // 
            // slotValue
            // 
            this.slotValue.BackColor = System.Drawing.Color.Gainsboro;
            this.slotValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.slotValue.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slotValue.ForeColor = System.Drawing.Color.DimGray;
            this.slotValue.Location = new System.Drawing.Point(344, 90);
            this.slotValue.Margin = new System.Windows.Forms.Padding(2);
            this.slotValue.Name = "slotValue";
            this.slotValue.Size = new System.Drawing.Size(288, 28);
            this.slotValue.TabIndex = 25;
            this.slotValue.TabStop = false;
            this.slotValue.WordWrap = false;
            // 
            // price
            // 
            this.price.BackColor = System.Drawing.Color.Gainsboro;
            this.price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.price.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.ForeColor = System.Drawing.Color.DimGray;
            this.price.Location = new System.Drawing.Point(344, 298);
            this.price.Margin = new System.Windows.Forms.Padding(2);
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Size = new System.Drawing.Size(288, 28);
            this.price.TabIndex = 26;
            this.price.TabStop = false;
            this.price.Text = " 20";
            this.price.WordWrap = false;
            this.price.Enter += new System.EventHandler(this.price_enter);
            this.price.Leave += new System.EventHandler(this.price_leave);
            // 
            // hours
            // 
            this.hours.BackColor = System.Drawing.Color.Gainsboro;
            this.hours.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hours.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hours.ForeColor = System.Drawing.Color.DimGray;
            this.hours.Location = new System.Drawing.Point(344, 246);
            this.hours.Margin = new System.Windows.Forms.Padding(2);
            this.hours.Name = "hours";
            this.hours.Size = new System.Drawing.Size(288, 28);
            this.hours.TabIndex = 27;
            this.hours.TabStop = false;
            this.hours.Text = "Hours";
            this.hours.WordWrap = false;
            this.hours.Enter += new System.EventHandler(this.hours_enter);
            this.hours.Leave += new System.EventHandler(this.hours_leave);
            // 
            // dateReserved
            // 
            this.dateReserved.AllowDrop = true;
            this.dateReserved.CalendarFont = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateReserved.CalendarForeColor = System.Drawing.Color.Black;
            this.dateReserved.CalendarMonthBackground = System.Drawing.Color.Black;
            this.dateReserved.CalendarTitleBackColor = System.Drawing.Color.Black;
            this.dateReserved.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dateReserved.CalendarTrailingForeColor = System.Drawing.Color.Black;
            this.dateReserved.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateReserved.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateReserved.Location = new System.Drawing.Point(344, 142);
            this.dateReserved.Name = "dateReserved";
            this.dateReserved.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateReserved.Size = new System.Drawing.Size(288, 29);
            this.dateReserved.TabIndex = 28;
            // 
            // timeArrived
            // 
            this.timeArrived.CalendarForeColor = System.Drawing.Color.Black;
            this.timeArrived.CalendarMonthBackground = System.Drawing.Color.Black;
            this.timeArrived.CalendarTitleBackColor = System.Drawing.Color.Black;
            this.timeArrived.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.timeArrived.CalendarTrailingForeColor = System.Drawing.Color.Black;
            this.timeArrived.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeArrived.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeArrived.Location = new System.Drawing.Point(344, 194);
            this.timeArrived.Name = "timeArrived";
            this.timeArrived.ShowUpDown = true;
            this.timeArrived.Size = new System.Drawing.Size(288, 29);
            this.timeArrived.TabIndex = 29;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Park_C_Updated.Properties.Resources.Reserve;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(719, 392);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Reserve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(717, 414);
            this.Controls.Add(this.timeArrived);
            this.Controls.Add(this.dateReserved);
            this.Controls.Add(this.hours);
            this.Controls.Add(this.price);
            this.Controls.Add(this.slotValue);
            this.Controls.Add(this.reserveButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.unavailableLabel);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Reserve";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reserve";
            this.Load += new System.EventHandler(this.Reserve_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label unavailableLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button reserveButton;
        private System.Windows.Forms.TextBox slotValue;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox hours;
        private System.Windows.Forms.DateTimePicker dateReserved;
        private System.Windows.Forms.DateTimePicker timeArrived;
    }
}