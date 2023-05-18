//Ashto du Plessis 34202676
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prac6._2_Creative_project_34202676
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double consumption;
        private int speed;
        private int hours;
        private int distance;
        private int liters = 2;

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int count = 1;

            if (cbYes.Checked)
            {
                if (int.TryParse(txtSpeedKmph.Text, out speed))
                {
                    if (int.TryParse(txtHoursTraveled.Text, out hours))
                    {
                        while (count <= hours)
                        {
                            distance = speed * count;

                            lbOutput.Items.Add("After hour " + count + " The distance traveled is " + distance + " km.");
                            count++;
                        }

                        consumption = distance / liters;

                        lbOutput.Items.Add("Your average fuel consumption is " + consumption + " km/L");
                    }

                    else
                    {
                        MessageBox.Show("Invalid input for hours traveled.");
                    }

                }

                else
                {
                    MessageBox.Show("Invalid input for vehicle speed.");
                }

            }

            else
            {
                if (int.TryParse(txtSpeedKmph.Text, out speed))
                {
                    if (int.TryParse(txtHoursTraveled.Text, out hours))
                    {
                        while (count <= hours)
                        {
                            distance = speed * count;

                            lbOutput.Items.Add("After hour " + count + " The distance traveled is " + distance + " km.");
                            count++;
                        }
                    }

                    else
                    {
                        MessageBox.Show("Invalid input for hours traveled.");
                    }

                }

                else
                {
                    MessageBox.Show("Invalid input for vehicle speed.");
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHoursTraveled.Text = "";
            txtSpeedKmph.Text = "";
            lbOutput.Items.Clear();
            cbYes.Checked = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are about to exit this program.");
            this.Close();
        }
    }
}
