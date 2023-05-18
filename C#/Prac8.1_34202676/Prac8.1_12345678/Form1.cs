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

namespace Prac8._1_12345678
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            int randnum;

            Random rand = new Random();
            randnum = rand.Next(999999) + 100000;

            StreamWriter outputFile;

            try
            {

                outputFile = File.AppendText("Output.txt");

                outputFile.WriteLine("The learner: " + txtName.Text);
                outputFile.WriteLine("With surname: " + txtSurname.Text);
                outputFile.WriteLine("And ID number" + txtIdNum.Text);
                outputFile.WriteLine("Is noted to be from Pre school: " + txtPreSchool.Text);
                outputFile.WriteLine("And is currently: " + txtAge.Text + " years of age");
                outputFile.WriteLine("Learner number is: " + randnum);
                outputFile.WriteLine("");

                outputFile.Close();

                MessageBox.Show("Learner was successfully added.");
            }
            catch(IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnRetrieve_Click(object sender, EventArgs e)
        {
            StreamReader readFile;

            readFile = File.OpenText("Output.txt");

            while(!readFile.EndOfStream)
            {
                lstRetrieve.Items.Add(readFile.ReadLine());
            }

            readFile.Close();
        }
    }
}
