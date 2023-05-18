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

namespace Prac3._2_Creative_project_34202676
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double TAX = 0.15;
        private double price1;
        private double price2;
        private double price;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnAmountBothItemsTax_Click(object sender, EventArgs e)
        {
            try
            {
                price1 = double.Parse(txtPrice1.Text);
                price2 = double.Parse(txtPrice2.Text);

                price = ((price1 + price2) * TAX ) + (price1 +price2);

                lblPrice.Text = "The amount of " + txtName1.Text + " and " + txtName2.Text + " with tax is: R" + price.ToString("n2");
            }

            catch
            {
                MessageBox.Show ("Input string was not in a correct format.");
            }
        }

        private void btnHightestitem_Click(object sender, EventArgs e)
        {
            try
            {
                price1 = double.Parse(txtPrice1.Text);
                price2 = double.Parse(txtPrice2.Text);

                price = Math.Max(price1, price2);

                if(price == price1)
                {
                    gbItem1.BackColor = Color.Red;
                    gbItem2.BackColor = Color.Green;
                }
                else if(price == price2)
                {
                    gbItem1.BackColor = Color.Green;
                    gbItem2.BackColor = Color.Red;
                }
            }

            catch
            {
                MessageBox.Show("Input string was not in a correct format.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName1.Text = "";
            txtName2.Text = "";
            txtPrice1.Text = "";
            txtPrice2.Text = "";
            lblPrice.Text = "";
            gbItem1.BackColor = Color.Transparent;
            gbItem2.BackColor = Color.Transparent;

            txtName1.Focus();
        }
    }
}
