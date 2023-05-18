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

namespace Prac1._3_Creative_project_34202676
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int points;
        private bool grandmaster;
        private double level;

        private void btnCalculateLevel_Click(object sender, EventArgs e)
        {
            try
            {
                points = int.Parse(txtPoints.Text);

                if (points > 100000)
                {
                    grandmaster = true;
                }

                else
                {
                    grandmaster = false;
                }

                if (grandmaster)
                {
                    level = Math.Round(Math.Sqrt(points) * 0.1);
                }

                if (!grandmaster)
                {
                    level = Math.Round(Math.Sqrt(points) * 0.07);
                }

                if (rbtnMage.Checked)
                {
                    MessageBox.Show("You are a Mage at level " + level.ToString("n"));
                }

                else if (rbtnRoge.Checked)
                {
                    MessageBox.Show("You are a Roge at level " + level.ToString("n"));
                }

                else if (rbtnWarrior.Checked)
                {
                    MessageBox.Show("You are a Warrior at level " + level.ToString("n"));
                }

                else if (rbtnThief.Checked)
                {
                    MessageBox.Show("You are a Thief at level " + level.ToString("n"));
                }

                else
                {
                    MessageBox.Show("Pick a roll.");
                }
            }
            
            catch
            {
                MessageBox.Show("Input string was not in a correct format.");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are about to close this program.");

            this.Close();
        }
    }
}
