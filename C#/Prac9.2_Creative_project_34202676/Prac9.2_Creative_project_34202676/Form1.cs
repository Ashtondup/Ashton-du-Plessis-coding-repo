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

namespace Prac9._2_Creative_project_34202676
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int firsttest;
        private int secondtest;

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(int.TryParse(txtFirstTest.Text, out firsttest) && int.TryParse(txtLastTest.Text, out secondtest))
            {
                if((firsttest >= 0 && firsttest <=100) && (secondtest >= 0 && secondtest <= 100))
                {
                    StreamWriter outputFile;

                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        FileWite();
                    }
                }
                else
                {
                    MessageBox.Show("The marks for the first test and the second test must be between 0 and 100");
                }
            }
            else
            {
                MessageBox.Show("Enter valid mark for test");
            }
        }

        private void FileWite()
        {
            StreamWriter outputFile;
            outputFile = File.CreateText(saveFileDialog1.FileName);
            outputFile.WriteLine(txtFirstName.Text + " " + txtLastName.Text);
            outputFile.WriteLine("Mark for first test " + firsttest);
            outputFile.WriteLine("Mark for second test " + secondtest);
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtFirstTest.Text, out firsttest) && int.TryParse(txtLastTest.Text, out secondtest))
            {
                if ((firsttest >= 0 && firsttest <= 100) && (secondtest >= 0 && secondtest <= 100))
                {
                    AddItem();
                }
                else
                {
                    MessageBox.Show("The marks for the first test and the second test must be between 0 and 100");
                }
            }
            else
            {
                MessageBox.Show("Enter valid mark for test");
            }
        }
        private void AddItem()
        {
            lstDisplay.Items.Add(txtFirstName.Text + " " + txtLastName.Text);
            lstDisplay.Items.Add("Mark for first test " + firsttest);
            lstDisplay.Items.Add("Mark for second test " + secondtest);
            ShowMax(firsttest, secondtest);
        }
        private void ShowMax(int num1, int num2)
        {
            if (int.TryParse(txtFirstTest.Text, out firsttest) && int.TryParse(txtLastTest.Text, out secondtest))
            {
                if ((firsttest >= 0 && firsttest <= 100) && (secondtest >= 0 && secondtest <= 100))
                {
                    if (firsttest < secondtest)
                    {
                        lstDisplay.Items.Add("Best mark is: " + firsttest);
                    }
                    else if (firsttest > secondtest)
                    {
                        lstDisplay.Items.Add("Best mark is: " + secondtest);
                    }
                    else
                    {
                        lstDisplay.Items.Add("Same mark for both test.");
                    }
                }
                else
                {
                    MessageBox.Show("The marks for the first test and the second test must be between 0 and 100");
                }
            }
            else
            {
                MessageBox.Show("Enter valid mark for test");
            }
        }
    }
}
