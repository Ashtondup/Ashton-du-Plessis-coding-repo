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
using System.IO;

namespace Test2_34202676
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnSave.Visible = false;
            btnView.Visible = false;
            lstViewRecords.Visible = false;
        }

        private void btnCreateOpen_Click(object sender, EventArgs e)
        {
            btnSave.Visible = true;
            btnView.Visible = true;
            lstViewRecords.Visible = true;

            MessageBox.Show("File created/opened successfully.");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            decimal earnd = 0.0m;
            int hours;
            int rate;
            int randnum1;
            int randnum2;
            int randnum3;

            if (int.TryParse(txtTotHours.Text, out hours) && int.TryParse(txtRatePHour.Text, out rate))
            {
                StreamWriter outputFile;

                Random rand = new Random();

                randnum1 = rand.Next(10);
                randnum2 = rand.Next(10);
                randnum3 = rand.Next(10);

                string name = txtName.Text;

                earnd = hours * rate;

                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    outputFile = File.AppendText(saveFile.FileName);

                    outputFile.WriteLine(name + randnum1 + randnum2 + randnum3 + " earnd " + earnd);
                }

                MessageBox.Show("Record saved successfully");

                txtName.Text = "";
                txtRatePHour.Text = "";
                txtTotHours.Text = "";
                txtName.Focus();

            }
            else
            {
                MessageBox.Show("Invalid Total hours or Rate per hour.");
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            StreamReader readFile;

            readFile = File.OpenText(saveFile.FileName);

            while (!readFile.EndOfStream)
            {
                lstViewRecords.Items.Add(readFile.ReadLine());
            }

            readFile.Close();
        }
    }
}
