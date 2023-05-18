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

namespace Prac7._2_Creative_project_34202676
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to FizzBuzz.");
            lblDisplay.Text = "";
            txtUpper.Focus();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            int fizz;
            int buzz;
            int number;
            int upper;

            if(int.TryParse(txtUpper.Text, out upper))
            {
                if(upper >=1 && upper <= 50)
                {
                    if(int.TryParse(txtFizz.Text, out fizz) && int.TryParse(txtBuzz.Text, out buzz))
                    {
                        Random rand = new Random();
                        number = rand.Next(upper) + 1;
                        lblDisplay.Text = "Will count to " + number;

                        for(int i = 1; i < number; i++)
                        {
                            if ((i % fizz == 0) && (i % buzz == 0))
                            {
                                lstOutput.Items.Add("FizzBuzz");
                            }
                            else if(i % buzz == 0)
                            {
                                lstOutput.Items.Add("Buzz");
                            }
                            else if (i % fizz == 0)
                            {
                                lstOutput.Items.Add("Fizz");
                            }
                            else
                            {
                                lstOutput.Items.Add(i);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter an integer.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter an valid integer between 1-50");
                }
            }
            else
            {
                MessageBox.Show("Please enter an integer.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstOutput.Items.Clear();
            lblDisplay.Text = "";
            txtBuzz.Text = "";
            txtFizz.Text = "";
            txtUpper.Text = "";
            txtUpper.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are about to exit.");
            this.Close();
        }
    }
}
