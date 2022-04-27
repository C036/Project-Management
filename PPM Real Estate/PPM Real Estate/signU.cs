using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PPM_Real_Estate
{
    public partial class signU : Form
    {
        public signU()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void createBtn_Click(object sender, EventArgs e)
        {

            string firstNameString = firstNameInput.Text;
            string lastNameString = lastNameInput.Text;
            string emailString = emailInput.Text;
            string passwordString = passwordInput.Text;
            string passwordConfirmString = passwordInputConfirm.Text;

            if (firstNameString != "" | lastNameString != "" | emailString != "" | passwordString != "") {
                if (passwordString == passwordConfirmString)
                {

                    //Open connection to Database
                    string connectionString = PPM_Real_Estate.Properties.Settings.Default.Primary_Database; //Database Connection Callup
                    SqlConnection connect = new SqlConnection(connectionString);

                    //enter data entries into database
                    SqlCommand addEntry = new SqlCommand("INSERT Users (firstName, lastName, password, phoneNumber, email) VALUES('" + firstNameString + "', '" + lastNameString + "', '" + passwordString + "', '" + emailString + "')", connect);


                    connect.Open();
                    addEntry.ExecuteNonQuery();
                    connect.Close();
                }
                else {
                    System.Windows.Forms.MessageBox.Show("Passwords must match");
                    };
                }
            else {
                System.Windows.Forms.MessageBox.Show("Please make sure you have filled all the boxes");
            };
        }
    }
}
