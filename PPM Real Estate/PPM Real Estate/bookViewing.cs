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
using System.Web;
using System.Net.Mail;

namespace PPM_Real_Estate
{
    public partial class bookViewing : Form
    {
        public bookViewing()
        {
            InitializeComponent();
        }

        private void bookViewing_Load(object sender, EventArgs e)
        {
            userFirstName.Text = userLogin.firstName;
            userLastName.Text = userLogin.lastName;
            userEmail.Text = userLogin.email;
            propertyName.Text = property.propertyName;

            bookingTime.Format = DateTimePickerFormat.Custom;
            bookingTime.CustomFormat = "hh:mm";
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BookButton_Click(object sender, EventArgs e)
        {
            string email = userEmail.Text;
            string firstName = userFirstName.Text;
            string lastName = userLastName.Text;
            string property = propertyName.Text;
            string date = bookingDate.Value.ToString("yyyyMMdd");
            string time = bookingTime.Value.ToString("hh:mm");

            if (email == "" || firstName == "" || lastName == "" || property == "")
            {
                errorMessageTxt.Text = "Please make sure all boxes are filled out";
                errorMessageTxt.ForeColor = Color.Red;
            }
            else 
            {

                //Open connection to Database
                string connectionString = PPM_Real_Estate.Properties.Settings.Default.Primary_Database; //Database Connection Callup
                SqlConnection connect = new SqlConnection(connectionString);

                SqlCommand newBooking = new SqlCommand("INSERT bookViewing (firstName, lastName, email, propertyName, bookingDate, bookingTime) VALUES ('" + firstName + "', '" + lastName + "', '" + email + "', '" + property + "', '" + date + "', '" + time + "')", connect);

                connect.Open();
                newBooking.ExecuteNonQuery();
                connect.Close();

                //email replay with booking information - sourced from https://tutorialslink.com/Articles/How-to-send-emails-in-Csharp-windows-form-application/1954
                    MailMessage mail = new MailMessage("Pattison1995@hotmail.co.uk", email, "Your Booking Details", "Hello, your viewing booking is as follows; Property: " + property +" date: " + date + " time: " + time + ". we look forwards to seeing you soon!" );
                // Hotmail/outlook Smtp domain uncomment the line below to use it
                //SmtpClient client = new SmtpClient("smtp-mail.outlook.com");

                // Gmail Smtp domain uncomment the line below to use it 
                SmtpClient client = new SmtpClient("smtp.gmail.com");
                client.Port = 587;
                    client.Credentials = new System.Net.NetworkCredential(/*add account here*/"", /* add password here*/"");
                    client.EnableSsl = true;
                    client.Send(mail);

                MessageBox.Show("Your Booking is successful for " + property + " on the " + date);
                this.Dispose();

            }
        }
    }
}
