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

namespace Prac6._1_Interest_calculator_34202676
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double amount = 0.0, rate = 0.0, final_amount = 0.0, result = 0.0;
        private int year, counter = 1;

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            amount = double.Parse(txtAmountInvested.Text);
            rate = double.Parse(txtRate.Text);
            year = int.Parse(txtYears.Text);

            while (counter <= year)
            {
                final_amount = 0;
                final_amount = amount * (1 + (rate / 100));
                result = Math.Pow(final_amount, counter);

                lbOutput.Items.Add("After " + counter.ToString() + " years the amount is: R" + result.ToString(""));
                
                counter++;
            }
        }
    }
}
