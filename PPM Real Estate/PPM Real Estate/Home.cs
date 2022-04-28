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

        private void button2_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.Show();
            this.Hide();
        }

        private void darkModeBtn_Click(object sender, EventArgs e)
        {
            
            
                this.BackColor = Color.Navy;
   

           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.Show();
            this.Hide();
        }
    }
}
