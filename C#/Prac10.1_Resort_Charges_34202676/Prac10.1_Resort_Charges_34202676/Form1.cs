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

namespace Prac10._1_Resort_Charges_34202676
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int CalcStayCharges(int num1, int price = 850)
        {
            return num1 * price;
        }

        private decimal CalcMiscCharges(decimal num1, decimal num2, decimal num3, int num4, int safari = 350)
        {
            return num1 + num2 + num3 + num4 * safari;
        }

        private decimal CalcTotalCharges(int num1, decimal num2)
        {
            return num1 + num2;
        }

        private void btnCalculateTot_Click(object sender, EventArgs e)
        {
            int daysstayed;
            decimal minibar;
            decimal spaandhealthe;
            decimal carrental;
            int safaridrives;
            int basecharge;
            decimal misccharge = 0m;
            

            if ((int.TryParse(txtDaysStayed.Text, out daysstayed)) && (int.TryParse(txtSafariDrives.Text, out safaridrives)))
            {
                if ((decimal.TryParse(txtMiniBar.Text, out minibar)) && (decimal.TryParse(txtSpaAndHealth.Text, out spaandhealthe)) && (decimal.TryParse(txtCarRental.Text, out carrental)))
                {
                    basecharge = CalcStayCharges(daysstayed);

                    misccharge = CalcMiscCharges(minibar, spaandhealthe, carrental, safaridrives);

                    MessageBox.Show("Total Bill: R" + CalcTotalCharges(basecharge, misccharge));
                }
                else
                {
                    MessageBox.Show("Invalid input.");
                }
            }
            else
            {
                MessageBox.Show("Invalid input for No. of Days Stayed oor Number of safari drives.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
