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

namespace Test3Paving_34202676
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Aqua;
        }

        private double CalcDays(double breadth, double length, int num = 7)
        {
            return (breadth * length) / num;
        }

        private void DisplayScale()
        {
            double breadth;
            double length;

            if (double.TryParse(txtBreadth.Text, out breadth) && double.TryParse(txtLength.Text, out length))
            {
                if (CalcDays(breadth, length) <= 1 || CalcDays(breadth, length) >= 8)
                {
                    lstDisplay.Items.Add("A project that last " + CalcDays(breadth, length).ToString("n2") + " days is small scale.");
                }
                else if (CalcDays(breadth, length) <= 9 || CalcDays(breadth, length) >= 10)
                {
                    lstDisplay.Items.Add("A project that last " + CalcDays(breadth, length).ToString("n2") + " days is semi-large scale.");
                }
                else if (CalcDays(breadth, length) >= 11)
                {
                    lstDisplay.Items.Add("A project that last " + CalcDays(breadth, length).ToString("n2") + " days is large scale.");
                }
            }
            else
            {
                MessageBox.Show("The input was invalid, bothe inputs must be double inputs.");
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            double breadth;
            double length;
            lstDisplay.Items.Clear();

            if (double.TryParse(txtBreadth.Text, out breadth) && double.TryParse(txtLength.Text, out length))
            {
                
                lstDisplay.Items.Add("It wil take " + CalcDays(breadth, length).ToString("n2") + " days to install this paving.");
                DisplayScale();
            }
            else
            {
                MessageBox.Show("The input was invalid, bothe inputs must be double inputs.");
            }
        }
    }
}
