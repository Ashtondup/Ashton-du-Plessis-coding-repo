//Ashton du Plessis 34202676
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test1_34202676
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double F;
        private double C;

        private void btnFtoC_Click(object sender, EventArgs e)
        {
            try
            {
                F = double.Parse(txtFtemp.Text);

                lblDegreesF.Text = F.ToString("n1");

                C = (F - 32) * 5 / 9;

                lblDegreesC.Text = Math.Round(C, 1).ToString("n1");
            }
            catch
            {
                MessageBox.Show("Input string was not in a correct format.");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtFtemp.Text = "";
            lblDegreesC.Text = "";
            lblDegreesF.Text = "";

            txtFtemp.Focus();
        }
    }
}
