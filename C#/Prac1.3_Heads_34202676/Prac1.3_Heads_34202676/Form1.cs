using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prac1._3_Heads_34202676
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHeads_Click(object sender, EventArgs e)
        {
            pbHeads.Show();
            pbTails.Hide();
        }

        private void btnTails_Click(object sender, EventArgs e)
        {
            pbHeads.Hide();
            pbTails.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are about to close this application.");
            this.Close();
        }
    }
}
