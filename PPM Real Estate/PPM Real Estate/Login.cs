﻿using System;
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
            signUp.ShowDialog();
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

                SqlCommand emailValidation = new SqlCommand("SELECT email FROM Users WHERE email = '" + email + "'", connect);
                SqlCommand passwordValidation = new SqlCommand("SELECT password FROM Users WHERE password = '" + password + "'", connect);
                SqlCommand nameGrab = new SqlCommand("SELECT firstName, lastName from Users WHERE email ='" + email + "'", connect);

                //debug
                //MessageBox.Show("SELECT email FROM Users WHERE " + email + "");
                //MessageBox.Show("SELECT password FROM Users WHERE " + password + "");
                //end of debug


                string emailCheck = "";
                string passwordCheck = "";
                string firstName = "";
                string lastName = "";

                connect.Open();
                SqlDataReader emailRead = emailValidation.ExecuteReader();
                    while(emailRead.Read())
                    { Console.WriteLine("{0}", emailCheck = emailRead.GetString(0));
                    }
                connect.Close();
                connect.Open();
                SqlDataReader passwordRead = passwordValidation.ExecuteReader();
                    while (passwordRead.Read())
                    {
                        Console.WriteLine("{0}", passwordCheck = passwordRead.GetString(0));
                    }
                connect.Close();
                connect.Open();
                SqlDataReader nameRead = nameGrab.ExecuteReader();
                    while (nameRead.Read())
                    { Console.WriteLine("{0}{1}", firstName = nameRead.GetString(0), lastName = nameRead.GetString(1));
                    }
                connect.Close();

                //debug
                //MessageBox.Show(emailCheck);
                //MessageBox.Show(passwordCheck);
                //end of debug
                
                if(!(String.Equals (emailCheck, email, StringComparison.OrdinalIgnoreCase)))
                {
                    errorMessageTxt.ForeColor = Color.Red;
                    errorMessageTxt.Text = ("Please enter a valid email or password");
                }
                else if(!(String.Equals(passwordCheck, password, StringComparison.OrdinalIgnoreCase))) 
                {
                    errorMessageTxt.ForeColor = Color.Red;
                    errorMessageTxt.Text = ("Please enter a valid email or password");
                }
                else
                {
                    //debug
                    if (userLogin.loggedIn == true) {
                        //MessageBox.Show("true");
                        errorMessageTxt.ForeColor = Color.Brown;
                        errorMessageTxt.Text = ("How did you even get here?");
                    }
                    else {
                        //MessageBox.Show("False");
                        userLogin.loggedIn = true;
                        userLogin.email = emailCheck;
                        userLogin.firstName = firstName;
                        userLogin.lastName = lastName;

                        //debug
                        //MessageBox.Show(lastName);
                        //MessageBox.Show(firstName);


                        errorMessageTxt.ForeColor = Color.White;
                        errorMessageTxt.Text = ("");
                        emailLogin.Text = "";
                        passwordLogin.Text = "";
                        var homePage = new Home();
                        homePage.ShowDialog();
                    };

                };
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
