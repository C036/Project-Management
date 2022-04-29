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
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BookButton_Click(object sender, EventArgs e)
        {

        }
    }
}
