﻿using System;
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
    public partial class Rent : Form
    {
        public Rent()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var bookViewing = new bookViewing();
            bookViewing.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var bookViewing = new bookViewing();
            bookViewing.Show();
        }
    }
}
