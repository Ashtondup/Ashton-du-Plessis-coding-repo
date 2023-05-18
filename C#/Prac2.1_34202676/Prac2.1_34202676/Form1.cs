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

namespace Prac2._1_34202676
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string sName = "";
            string sSurname = "";
            double sSalary;
            double sMedicalAid;
            double sPension;

            sName = txtName.Text;
            sSurname = txtSurname.Text;
            sSalary = double.Parse(txtSalary.Text);
            sMedicalAid = double.Parse(txtMedicalAid.Text);
            sPension = double.Parse(txtPension.Text);

            double resSalary = (sSalary - sMedicalAid - sPension);

            MessageBox.Show("The afterdeductions salary of: " + sName + " " + sSurname + " is R " + resSalary);

            this.Close();
        }
    }
}
