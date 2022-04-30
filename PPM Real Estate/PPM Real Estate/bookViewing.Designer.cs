
namespace PPM_Real_Estate
{
    partial class bookViewing
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.userFirstName = new System.Windows.Forms.TextBox();
            this.userLastName = new System.Windows.Forms.TextBox();
            this.userEmail = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.bookingDate = new System.Windows.Forms.DateTimePicker();
            this.BookButton = new System.Windows.Forms.Button();
            this.propertyName = new System.Windows.Forms.TextBox();
            this.bookingTime = new System.Windows.Forms.DateTimePicker();
            this.errorMessageTxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "First name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Date and Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Property Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(51, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 22);
            this.label6.TabIndex = 13;
            this.label6.Text = "Last Name";
            // 
            // userFirstName
            // 
            this.userFirstName.Location = new System.Drawing.Point(206, 110);
            this.userFirstName.Name = "userFirstName";
            this.userFirstName.Size = new System.Drawing.Size(253, 20);
            this.userFirstName.TabIndex = 14;
            // 
            // userLastName
            // 
            this.userLastName.Location = new System.Drawing.Point(206, 166);
            this.userLastName.Name = "userLastName";
            this.userLastName.Size = new System.Drawing.Size(253, 20);
            this.userLastName.TabIndex = 15;
            // 
            // userEmail
            // 
            this.userEmail.Location = new System.Drawing.Point(206, 226);
            this.userEmail.Name = "userEmail";
            this.userEmail.Size = new System.Drawing.Size(253, 20);
            this.userEmail.TabIndex = 16;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Teal;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.backButton.Location = new System.Drawing.Point(494, 13);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(26, 44);
            this.backButton.TabIndex = 21;
            this.backButton.Text = "<";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(52, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(244, 22);
            this.label7.TabIndex = 22;
            this.label7.Text = "Request Viewing of property";
            // 
            // bookingDate
            // 
            this.bookingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.bookingDate.Location = new System.Drawing.Point(206, 351);
            this.bookingDate.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.bookingDate.Name = "bookingDate";
            this.bookingDate.Size = new System.Drawing.Size(135, 20);
            this.bookingDate.TabIndex = 23;
            // 
            // BookButton
            // 
            this.BookButton.BackColor = System.Drawing.Color.Teal;
            this.BookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BookButton.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BookButton.Location = new System.Drawing.Point(127, 473);
            this.BookButton.Name = "BookButton";
            this.BookButton.Size = new System.Drawing.Size(258, 58);
            this.BookButton.TabIndex = 24;
            this.BookButton.Text = "Book";
            this.BookButton.UseVisualStyleBackColor = false;
            this.BookButton.Click += new System.EventHandler(this.BookButton_Click);
            // 
            // propertyName
            // 
            this.propertyName.Location = new System.Drawing.Point(206, 287);
            this.propertyName.Name = "propertyName";
            this.propertyName.Size = new System.Drawing.Size(253, 20);
            this.propertyName.TabIndex = 17;
            // 
            // bookingTime
            // 
            this.bookingTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.bookingTime.Location = new System.Drawing.Point(347, 351);
            this.bookingTime.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.bookingTime.Name = "bookingTime";
            this.bookingTime.Size = new System.Drawing.Size(112, 20);
            this.bookingTime.TabIndex = 25;
            // 
            // errorMessageTxt
            // 
            this.errorMessageTxt.AutoSize = true;
            this.errorMessageTxt.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMessageTxt.ForeColor = System.Drawing.Color.White;
            this.errorMessageTxt.Location = new System.Drawing.Point(124, 412);
            this.errorMessageTxt.Name = "errorMessageTxt";
            this.errorMessageTxt.Size = new System.Drawing.Size(0, 17);
            this.errorMessageTxt.TabIndex = 26;
            // 
            // bookViewing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(532, 554);
            this.Controls.Add(this.errorMessageTxt);
            this.Controls.Add(this.bookingTime);
            this.Controls.Add(this.BookButton);
            this.Controls.Add(this.bookingDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.propertyName);
            this.Controls.Add(this.userEmail);
            this.Controls.Add(this.userLastName);
            this.Controls.Add(this.userFirstName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "bookViewing";
            this.Text = "bookViewing";
            this.Load += new System.EventHandler(this.bookViewing_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox userFirstName;
        private System.Windows.Forms.TextBox userLastName;
        private System.Windows.Forms.TextBox userEmail;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker bookingDate;
        private System.Windows.Forms.Button BookButton;
        private System.Windows.Forms.TextBox propertyName;
        private System.Windows.Forms.DateTimePicker bookingTime;
        private System.Windows.Forms.Label errorMessageTxt;
    }
}