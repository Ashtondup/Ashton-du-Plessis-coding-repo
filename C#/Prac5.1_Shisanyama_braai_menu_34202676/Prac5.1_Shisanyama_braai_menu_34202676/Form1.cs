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

namespace Prac5._1_Shisanyama_braai_menu_34202676
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int quantity;

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtQuantity.Text, out quantity))
            {
                if (rbPapWors.Checked)
                {
                    MessageBox.Show(quantity + " Delicious Pap and wors - Comeing up.");
                }

                else if (rbFilletVeg.Checked)
                {
                    MessageBox.Show(quantity + " Delicious Fillet steak and vegetables - Comeing up.");
                }

                else if (rbChickenChip.Checked)
                {
                    MessageBox.Show(quantity + " Delicious Chicken and chips - Comeing up.");
                }

                else
                {
                    MessageBox.Show("Pick a dishe.");
                }
            }

            else
            {
                MessageBox.Show("Invalid input. Please enter an integer.");
            }
        }

        private void rbFilletVeg_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFilletVeg.Checked)
            {
                this.BackColor = Color.Green;
            }
        }

        private void rbPapWors_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPapWors.Checked)
            {
                this.BackColor = SystemColors.Control;
            }
        }

        private void rbChickenChip_CheckedChanged(object sender, EventArgs e)
        {
            if (rbChickenChip.Checked)
            {
                this.BackColor = SystemColors.Control;
            }
        }
    }
}
