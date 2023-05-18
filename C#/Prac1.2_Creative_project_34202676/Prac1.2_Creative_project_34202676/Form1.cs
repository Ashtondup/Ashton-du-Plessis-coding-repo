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

namespace Prac1._2_Creative_project_34202676
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public double temp;
        public string day = "Friday";

        private void btnResult_Click(object sender, EventArgs e)
        {
            temp = double.Parse(txtTemp.Text);

            try
            {
                if (temp > 20 && temp < 30)
                {
                    if (txtDayofWeek.Text == day)
                    {
                        MessageBox.Show ("Good day to braai.");
                    }
                    else
                    {
                        MessageBox.Show ("It is a good day.");
                    }
                }
                else
                {
                    MessageBox.Show ("It is not a good day, but make the best of it.");
                }
            }

            catch
            {
                MessageBox.Show ("Invalid input.");
            }
        }
    }
}
