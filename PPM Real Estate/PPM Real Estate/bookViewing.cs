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
            if (check.dark == false)
            {
                this.BackColor = Color.FromArgb(0, 51, 102);
            }

            else
            {
                this.BackColor = Color.White;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
