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

namespace Prac2._2_34202676
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double dLenght;
            double dWidht;

            dLenght = double.Parse(txtLenght.Text);
            dWidht = double.Parse(txtWidght.Text);

            double perimeter = (dLenght * 2) + (dWidht * 2);

            double layers_required = ((double)perimeter / (double)dWidht);

            MessageBox.Show("The amount of brick layers required: " + layers_required.ToString("n0"));
            this.Close();
        }
    }
}
