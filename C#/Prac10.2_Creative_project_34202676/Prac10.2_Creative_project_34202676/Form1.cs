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

namespace Prac10._2_Creative_project_34202676
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private double CalcLevel (int num1, double times = 0.1)
        {
            return Math.Round(Math.Sqrt(num1) * times);
        }

        private void btnCalculateLevel_Click(object sender, EventArgs e)
        {
            int points;

            if (int.TryParse(txtPoints.Text, out points))
            {
                if (rbnMage.Checked)
                {
                    MessageBox.Show("You are a Mage at level " + CalcLevel(points));
                }
                else if (rbnRoge.Checked)
                {
                    MessageBox.Show("You are a Roge at level " + CalcLevel(points));
                }
                else if (rbnWarrior.Checked)
                {
                    MessageBox.Show("You are a Warrior at level " + CalcLevel(points));
                }
                else if (rbnThief.Checked)
                {
                    MessageBox.Show("You are a Thief at level " + CalcLevel(points));
                }
                else
                {
                    MessageBox.Show("Pick a roll.");
                }
            }
            else
            {
                MessageBox.Show("Invalid player points.");
            }
        }
    }
}
