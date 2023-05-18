//Ashton du Plessis
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prac9._1_Shopper_Points_Calculator_34202676
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are about to cancel this program.");
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            CalculateDisplayPoints();
        }

        private void CalculateDisplayPoints()
        {
            int total;
            double points;
            const double tierone = 0.10;
            const double tiertwo = 0.20;
            const double tierthree = 0.30;

            if(int.TryParse(txtTotal.Text, out total))
            {
                if(rbTierOne.Checked)
                {
                    points = total * tierone;

                    lblPointsEarned.Text = ("Earnd Points: " + points.ToString());
                }
                else if (rbTierTwo.Checked)
                {
                    points = total * tiertwo;

                    lblPointsEarned.Text = ("Earnd Points: " + points.ToString());
                }
                else if (rbTierThree.Checked)
                {
                    points = total * tierthree;

                    lblPointsEarned.Text = ("Earnd Points: " + points.ToString());
                }
                else
                {
                    MessageBox.Show("Pleas select a tier.");
                }
            }
            else
            {
                MessageBox.Show("Invalid input, pleas enter an integer amount.");
            }
        }
    }
}
