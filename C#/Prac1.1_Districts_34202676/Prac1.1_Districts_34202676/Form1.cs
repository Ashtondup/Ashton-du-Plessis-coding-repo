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

namespace Prac1._1_Districts_34202676
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDetermineDistrict_Click(object sender, EventArgs e)
        {
            if (txtTown.Text == "Vanderbijlpark")
            {
                lblDistricts.Text = "District: D8";
            }

            else if (txtTown.Text == "Vereeniging")
            {
                lblDistricts.Text = "District: D7";
            }

            else if (txtTown.Text == "Three Rivers")
            {
                lblDistricts.Text = "District: D7";
            }

            else
            {
                MessageBox.Show("Please enter the corect town: Vanderbijlpark, Vereeniging or Three Rivers.");
            }
        }
    }
}
