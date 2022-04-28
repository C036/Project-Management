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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            var signUp = new signU();
            signUp.Show();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string email = emailLogin.Text;
            string password = passwordLogin.Text;


            if (email == "")
            {
                errorMessageTxt.ForeColor = Color.Red;
                errorMessageTxt.Text = ("Please make sure to enter a username");
            }
            else if (password == "")
            {
                errorMessageTxt.ForeColor = Color.Red;
                errorMessageTxt.Text = ("Please make sure to enter a password");
            }
            else
            {
                //Open connection to Database
                string connectionString = PPM_Real_Estate.Properties.Settings.Default.Primary_Database; //Database Connection Callup
                SqlConnection connect = new SqlConnection(connectionString);

                SqlCommand emailValidation = new SqlCommand("SELECT email FROM Users WHERE " + email + "", connect);
                SqlCommand passwordValidation = new SqlCommand("SELECT password FROM Users WHERE " + password + "", connect);

                //debug
                MessageBox.Show("SELECT email FROM Users WHERE " + email + "");
                MessageBox.Show("SELECT password FROM Users WHERE " + password + "");



                connect.Open();
                emailValidation.ExecuteNonQuery();
                passwordValidation.ExecuteNonQuery();
                connect.Close();
            }
        }
    }
}
