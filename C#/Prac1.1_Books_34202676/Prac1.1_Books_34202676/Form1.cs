﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prac1._1_Books_34202676
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnShowauthors_Click(object sender, EventArgs e)
        {
            lblAuthor1.Show();
            lblAuthor2.Show();
            lblAuthor3.Show();
        }
    }
}
