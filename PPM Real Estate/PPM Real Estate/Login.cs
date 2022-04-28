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
            string emailVerification = emailLogin.Text;
            string passwordVerfication = passwordLogin.Text;

            //Open connection to Database
            string connectionString = PPM_Real_Estate.Properties.Settings.Default.Primary_Database; //Database Connection Callup
            SqlConnection connect = new SqlConnection(connectionString);

            SqlCommand loginValidation = new SqlCommand("SELECT Users WHERE (email = '" + emailVerification + "') AND password = ('" + passwordVerfication + "')", connect);
            
            connect.Open();
            loginValidation.ExecuteNonQuery();
            connect.Close();
        }
    }
}
