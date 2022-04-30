using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPM_Real_Estate
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void darkModeBtn_Click(object sender, EventArgs e)
        {
                this.BackColor = Color.Navy;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var searchPage = new Houses();
            searchPage.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var searchPage = new Search();
            searchPage.ShowDialog();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            var newViewing = new bookViewing();
            newViewing.ShowDialog();
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            userLogin.loggedIn = false;
            this.Dispose();
        }
    }
}
