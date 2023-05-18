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

namespace Prac7._1_MATH_SQUARES_34202676
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenRand_Click(object sender, EventArgs e)
        {
            int lower;
            int upper;
            int randnumber;
            
            if(int.TryParse(txtLower.Text, out lower) && int.TryParse(txtUpper.Text, out upper))
            {
                if(lower >= 1 || upper <= 50)
                {
                    Random rand = new Random();
                    randnumber = rand.Next(upper) + lower;

                    lblRandom.Text = randnumber.ToString();

                    lblDisplay.Text = "The squares of numbers 1 to " + randnumber.ToString() + " will be displayed.";

                    for (int i = 1; i <= randnumber; i++)
                    {
                        int result = i * i;
                        lstDisplay.Items.Add(i + " x " + i + " = " + result.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid integer between 1-50.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid integer between 1-50.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLower.Text = "";
            txtUpper.Text = "";
            lblRandom.Text = "";
            lblDisplay.Text = "";
            lstDisplay.Items.Clear();
            txtLower.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are about to exit this application.");
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtLower.Focus();
            lblRandom.Text = "";
            lblDisplay.Text = "";
            MessageBox.Show("Welcome to Math Squares!");
        }
    }
}
