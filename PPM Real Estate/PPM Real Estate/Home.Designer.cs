
namespace PPM_Real_Estate
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buyProperties = new System.Windows.Forms.Button();
            this.bookViewingButton = new System.Windows.Forms.Button();
            this.logOut = new System.Windows.Forms.Button();
            this.darkModeBtn = new System.Windows.Forms.Button();
            this.rentProperties = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(224, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(396, 223);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // buyProperties
            // 
            this.buyProperties.BackColor = System.Drawing.Color.Teal;
            this.buyProperties.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buyProperties.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buyProperties.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buyProperties.Location = new System.Drawing.Point(304, 263);
            this.buyProperties.Name = "buyProperties";
            this.buyProperties.Size = new System.Drawing.Size(258, 58);
            this.buyProperties.TabIndex = 9;
            this.buyProperties.Text = "To Buy";
            this.buyProperties.UseVisualStyleBackColor = false;
            this.buyProperties.Click += new System.EventHandler(this.button1_Click);
            // 
            // bookViewingButton
            // 
            this.bookViewingButton.BackColor = System.Drawing.Color.Teal;
            this.bookViewingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookViewingButton.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookViewingButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bookViewingButton.Location = new System.Drawing.Point(304, 391);
            this.bookViewingButton.Name = "bookViewingButton";
            this.bookViewingButton.Size = new System.Drawing.Size(258, 58);
            this.bookViewingButton.TabIndex = 11;
            this.bookViewingButton.Text = "Book Viewing ";
            this.bookViewingButton.UseVisualStyleBackColor = false;
            this.bookViewingButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // logOut
            // 
            this.logOut.BackColor = System.Drawing.Color.Maroon;
            this.logOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logOut.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOut.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.logOut.Location = new System.Drawing.Point(783, 12);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(96, 37);
            this.logOut.TabIndex = 13;
            this.logOut.Text = "Log Out";
            this.logOut.UseVisualStyleBackColor = false;
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // darkModeBtn
            // 
            this.darkModeBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.darkModeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.darkModeBtn.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.darkModeBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.darkModeBtn.Location = new System.Drawing.Point(640, 14);
            this.darkModeBtn.Name = "darkModeBtn";
            this.darkModeBtn.Size = new System.Drawing.Size(137, 35);
            this.darkModeBtn.TabIndex = 14;
            this.darkModeBtn.Text = "Dark Mode";
            this.darkModeBtn.UseVisualStyleBackColor = false;
            this.darkModeBtn.Click += new System.EventHandler(this.darkModeBtn_Click);
            // 
            // rentProperties
            // 
            this.rentProperties.BackColor = System.Drawing.Color.Teal;
            this.rentProperties.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rentProperties.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentProperties.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rentProperties.Location = new System.Drawing.Point(304, 327);
            this.rentProperties.Name = "rentProperties";
            this.rentProperties.Size = new System.Drawing.Size(258, 58);
            this.rentProperties.TabIndex = 10;
            this.rentProperties.Text = "To Rent ";
            this.rentProperties.UseVisualStyleBackColor = false;
            this.rentProperties.Click += new System.EventHandler(this.button2_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(891, 469);
            this.Controls.Add(this.darkModeBtn);
            this.Controls.Add(this.logOut);
            this.Controls.Add(this.bookViewingButton);
            this.Controls.Add(this.rentProperties);
            this.Controls.Add(this.buyProperties);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buyProperties;
        private System.Windows.Forms.Button bookViewingButton;
        private System.Windows.Forms.Button logOut;
        private System.Windows.Forms.Button darkModeBtn;
        private System.Windows.Forms.Button rentProperties;
    }
}