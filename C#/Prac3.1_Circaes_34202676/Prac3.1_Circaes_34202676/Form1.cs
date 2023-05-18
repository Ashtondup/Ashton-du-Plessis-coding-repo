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

namespace Prac3._1_Circaes_34202676
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double radius;
        private double area;
        private double height;

        private void btnAreaofcircal_Click(object sender, EventArgs e)
        {
            txtRadius.Focus();

            try
            {
                radius = double.Parse(txtRadius.Text);

                area = Math.PI * Math.Pow(radius, 2);

                txtAreacircal.Text = area.ToString("n1");
            }

            catch
            {
                MessageBox.Show("Input string was not correct format");
            }
        }

        private void btnAreaofcylinder_Click(object sender, EventArgs e)
        {
            try
            {
                radius = double.Parse(txtRadius.Text);
                height = double.Parse(txtHeight.Text);

                area = 2 * Math.PI * Math.Pow(radius, 2) + 2 * Math.PI * radius * height;

                txtAreacyinder.Text = area.ToString("n1");
            }

            catch
            {
                MessageBox.Show("Input string was not correct format");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtRadius.Text = "";
            txtHeight.Text = "";
            txtAreacyinder.Text = "";
            txtAreacircal.Text = "";

            txtRadius.Focus();
        }
    }
}
