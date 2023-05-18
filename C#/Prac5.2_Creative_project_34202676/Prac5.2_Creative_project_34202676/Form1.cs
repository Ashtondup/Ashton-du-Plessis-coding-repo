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

namespace Prac5._2_Creative_project_34202676
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int points = 15;
        private int exp;
        private int enemies;
        private int result;
        private int experions;

        private void btnProcess_Click(object sender, EventArgs e)
        {
            string weapon;
            int.TryParse(txtExp.Text, out exp);
            int.TryParse(txtEnemiesKilled.Text, out enemies);

            if (lbWeapons.SelectedIndex != -1)
            {
                weapon = lbWeapons.SelectedItem.ToString();

                switch (weapon)
                {
                    case "Axe":
                        if (rbMage.Checked && cbDubExp.Checked)
                        {
                            experions = (points * enemies) * 2;
                            result = (exp + experions);
                            lbOutput.Items.Add("You are a Mage that earned " + experions.ToString() + " experions from killing " + enemies.ToString() + " enimies with an Axe. Total experions is: " + result.ToString());
                        }
                        else if (rbMage.Checked && !cbDubExp.Checked)
                        {
                            experions = (points * enemies);
                            result = (exp + experions);
                            lbOutput.Items.Add("You are a Mage that earned " + experions.ToString() + " experions from killing " + enemies.ToString() + " enimies with an Axe. Total experions is: " + result.ToString());
                        }
                        else if(rbRoge.Checked && cbDubExp.Checked)
                        {
                            experions = (points * enemies) * 2;
                            result = (exp + experions);
                            lbOutput.Items.Add("You are a Roge that earned " + experions.ToString() + " experions from killing " + enemies.ToString() + " enimies with an Axe. Total experions is: " + result.ToString());
                        }
                        else if (rbRoge.Checked && !cbDubExp.Checked)
                        {
                            experions = (points * enemies);
                            result = (exp + experions);
                            lbOutput.Items.Add("You are a Roge that earned " + experions.ToString() + " experions from killing " + enemies.ToString() + " enimies with an Axe. Total experions is: " + result.ToString());
                        }
                        else if (rbThief.Checked && cbDubExp.Checked)
                        {
                            experions = (points * enemies) * 2;
                            result = (exp + experions);
                            lbOutput.Items.Add("You are a Thief that earned " + experions.ToString() + " experions from killing " + enemies.ToString() + " enimies with an Axe. Total experions is: " + result.ToString());
                        }
                        else if (rbThief.Checked && !cbDubExp.Checked)
                        {
                            experions = (points * enemies);
                            result = (exp + experions);
                            lbOutput.Items.Add("You are a Thief that earned " + experions.ToString() + " experions from killing " + enemies.ToString() + " enimies with an Axe. Total experions is: " + result.ToString());
                        }
                        else if (rbWarrior.Checked && cbDubExp.Checked)
                        {
                            experions = (points * enemies) * 2;
                            result = (exp + experions);
                            lbOutput.Items.Add("You are a Warrior that earned " + experions.ToString() + " experions from killing " + enemies.ToString() + " enimies with an Axe. Total experions is: " + result.ToString());
                        }
                        else if (rbWarrior.Checked && !cbDubExp.Checked)
                        {
                            experions = (points * enemies);
                            result = (exp + experions);
                            lbOutput.Items.Add("You are a Warrior that earned " + experions.ToString() + " experions from killing " + enemies.ToString() + " enimies with an Axe. Total experions is: " + result.ToString());
                        }
                        break;

                    case "Mace":
                        if (rbMage.Checked && cbDubExp.Checked)
                        {
                            experions = (points * enemies) * 2;
                            result = (exp + experions);
                            lbOutput.Items.Add("You are a Mage that earned " + experions.ToString() + " experions from killing " + enemies.ToString() + " enimies with an Mace. Total experions is: " + result.ToString());
                        }
                        else if (rbMage.Checked && !cbDubExp.Checked)
                        {
                            experions = (points * enemies);
                            result = (exp + experions);
                            lbOutput.Items.Add("You are a Mage that earned " + experions.ToString() + " experions from killing " + enemies.ToString() + " enimies with an Mace. Total experions is: " + result.ToString());
                        }
                        else if (rbRoge.Checked && cbDubExp.Checked)
                        {
                            experions = (points * enemies) * 2;
                            result = (exp + experions);
                            lbOutput.Items.Add("You are a Roge that earned " + experions.ToString() + " experions from killing " + enemies.ToString() + " enimies with an Mace. Total experions is: " + result.ToString());
                        }
                        else if (rbRoge.Checked && !cbDubExp.Checked)
                        {
                            experions = (points * enemies);
                            result = (exp + experions);
                            lbOutput.Items.Add("You are a Roge that earned " + experions.ToString() + " experions from killing " + enemies.ToString() + " enimies with an Mace. Total experions is: " + result.ToString());
                        }
                        else if (rbThief.Checked && cbDubExp.Checked)
                        {
                            experions = (points * enemies) * 2;
                            result = (exp + experions);
                            lbOutput.Items.Add("You are a Thief that earned " + experions.ToString() + " experions from killing " + enemies.ToString() + " enimies with an Mace. Total experions is: " + result.ToString());
                        }
                        else if (rbThief.Checked && !cbDubExp.Checked)
                        {
                            experions = (points * enemies);
                            result = (exp + experions);
                            lbOutput.Items.Add("You are a Thief that earned " + experions.ToString() + " experions from killing " + enemies.ToString() + " enimies with an Mace. Total experions is: " + result.ToString());
                        }
                        else if (rbWarrior.Checked && cbDubExp.Checked)
                        {
                            experions = (points * enemies) * 2;
                            result = (exp + experions);
                            lbOutput.Items.Add("You are a Warrior that earned " + experions.ToString() + " experions from killing " + enemies.ToString() + " enimies with an Mace. Total experions is: " + result.ToString());
                        }
                        else if (rbWarrior.Checked && !cbDubExp.Checked)
                        {
                            experions = (points * enemies);
                            result = (exp + experions);
                            lbOutput.Items.Add("You are a Warrior that earned " + experions.ToString() + " experions from killing " + enemies.ToString() + " enimies with an Mace. Total experions is: " + result.ToString());
                        }
                        break;

                    case "Sword":
                        if (rbMage.Checked && cbDubExp.Checked)
                        {
                            experions = (points * enemies) * 2;
                            result = (exp + experions);
                            lbOutput.Items.Add("You are a Mage that earned " + experions.ToString() + " experions from killing " + enemies.ToString() + " enimies with an Sword. Total experions is: " + result.ToString());
                        }
                        else if (rbMage.Checked && !cbDubExp.Checked)
                        {
                            experions = (points * enemies);
                            result = (exp + experions);
                            lbOutput.Items.Add("You are a Mage that earned " + experions.ToString() + " experions from killing " + enemies.ToString() + " enimies with an Sword. Total experions is: " + result.ToString());
                        }
                        else if (rbRoge.Checked && cbDubExp.Checked)
                        {
                            experions = (points * enemies) * 2;
                            result = (exp + experions);
                            lbOutput.Items.Add("You are a Roge that earned " + experions.ToString() + " experions from killing " + enemies.ToString() + " enimies with an Sword. Total experions is: " + result.ToString());
                        }
                        else if (rbRoge.Checked && !cbDubExp.Checked)
                        {
                            experions = (points * enemies);
                            result = (exp + experions);
                            lbOutput.Items.Add("You are a Roge that earned " + experions.ToString() + " experions from killing " + enemies.ToString() + " enimies with an Sword. Total experions is: " + result.ToString());
                        }
                        else if (rbThief.Checked && cbDubExp.Checked)
                        {
                            experions = (points * enemies) * 2;
                            result = (exp + experions);
                            lbOutput.Items.Add("You are a Thief that earned " + experions.ToString() + " experions from killing " + enemies.ToString() + " enimies with an Sword. Total experions is: " + result.ToString());
                        }
                        else if (rbThief.Checked && !cbDubExp.Checked)
                        {
                            experions = (points * enemies);
                            result = (exp + experions);
                            lbOutput.Items.Add("You are a Thief that earned " + experions.ToString() + " experions from killing " + enemies.ToString() + " enimies with an Sword. Total experions is: " + result.ToString());
                        }
                        else if (rbWarrior.Checked && cbDubExp.Checked)
                        {
                            experions = (points * enemies) * 2;
                            result = (exp + experions);
                            lbOutput.Items.Add("You are a Warrior that earned " + experions.ToString() + " experions from killing " + enemies.ToString() + " enimies with an Sword. Total experions is: " + result.ToString());
                        }
                        else if (rbWarrior.Checked && !cbDubExp.Checked)
                        {
                            experions = (points * enemies);
                            result = (exp + experions);
                            lbOutput.Items.Add("You are a Warrior that earned " + experions.ToString() + " experions from killing " + enemies.ToString() + " enimies with an Sword. Total experions is: " + result.ToString());
                        }
                        break;

                    case "Bow":
                        if (rbMage.Checked && cbDubExp.Checked)
                        {
                            experions = (points * enemies) * 2;
                            result = (exp + experions);
                            lbOutput.Items.Add("You are a Mage that earned " + experions.ToString() + " experions from killing " + enemies.ToString() + " enimies with an Bow. Total experions is: " + result.ToString());
                        }
                        else if (rbMage.Checked && !cbDubExp.Checked)
                        {
                            experions = (points * enemies);
                            result = (exp + experions);
                            lbOutput.Items.Add("You are a Mage that earned " + experions.ToString() + " experions from killing " + enemies.ToString() + " enimies with an Bow. Total experions is: " + result.ToString());
                        }
                        else if (rbRoge.Checked && cbDubExp.Checked)
                        {
                            experions = (points * enemies) * 2;
                            result = (exp + experions);
                            lbOutput.Items.Add("You are a Roge that earned " + experions.ToString() + " experions from killing " + enemies.ToString() + " enimies with an Bow. Total experions is: " + result.ToString());
                        }
                        else if (rbRoge.Checked && !cbDubExp.Checked)
                        {
                            experions = (points * enemies);
                            result = (exp + experions);
                            lbOutput.Items.Add("You are a Roge that earned " + experions.ToString() + " experions from killing " + enemies.ToString() + " enimies with an Bow. Total experions is: " + result.ToString());
                        }
                        else if (rbThief.Checked && cbDubExp.Checked)
                        {
                            experions = (points * enemies) * 2;
                            result = (exp + experions);
                            lbOutput.Items.Add("You are a Thief that earned " + experions.ToString() + " experions from killing " + enemies.ToString() + " enimies with an Bow. Total experions is: " + result.ToString());
                        }
                        else if (rbThief.Checked && !cbDubExp.Checked)
                        {
                            experions = (points * enemies);
                            result = (exp + experions);
                            lbOutput.Items.Add("You are a Thief that earned " + experions.ToString() + " experions from killing " + enemies.ToString() + " enimies with an Bow. Total experions is: " + result.ToString());
                        }
                        else if (rbWarrior.Checked && cbDubExp.Checked)
                        {
                            experions = (points * enemies) * 2;
                            result = (exp + experions);
                            lbOutput.Items.Add("You are a Warrior that earned " + experions.ToString() + " experions from killing " + enemies.ToString() + " enimies with an Bow. Total experions is: " + result.ToString());
                        }
                        else if (rbWarrior.Checked && !cbDubExp.Checked)
                        {
                            experions = (points * enemies);
                            result = (exp + experions);
                            lbOutput.Items.Add("You are a Warrior that earned " + experions.ToString() + " experions from killing " + enemies.ToString() + " enimies with an Bow. Total experions is: " + result.ToString());
                        }
                        break;

                    case "Staff":
                        if (rbMage.Checked && cbDubExp.Checked)
                        {
                            experions = (points * enemies) * 2;
                            result = (exp + experions);
                            lbOutput.Items.Add("You are a Mage that earned " + experions.ToString() + " experions from killing " + enemies.ToString() + " enimies with an Staff. Total experions is: " + result.ToString());
                        }
                        else if (rbMage.Checked && !cbDubExp.Checked)
                        {
                            experions = (points * enemies);
                            result = (exp + experions);
                            lbOutput.Items.Add("You are a Mage that earned " + experions.ToString() + " experions from killing " + enemies.ToString() + " enimies with an Staff. Total experions is: " + result.ToString());
                        }
                        else if (rbRoge.Checked && cbDubExp.Checked)
                        {
                            experions = (points * enemies) * 2;
                            result = (exp + experions);
                            lbOutput.Items.Add("You are a Roge that earned " + experions.ToString() + " experions from killing " + enemies.ToString() + " enimies with an Staff. Total experions is: " + result.ToString());
                        }
                        else if (rbRoge.Checked && !cbDubExp.Checked)
                        {
                            experions = (points * enemies);
                            result = (exp + experions);
                            lbOutput.Items.Add("You are a Roge that earned " + experions.ToString() + " experions from killing " + enemies.ToString() + " enimies with an Staff. Total experions is: " + result.ToString());
                        }
                        else if (rbThief.Checked && cbDubExp.Checked)
                        {
                            experions = (points * enemies) * 2;
                            result = (exp + experions);
                            lbOutput.Items.Add("You are a Thief that earned " + experions.ToString() + " experions from killing " + enemies.ToString() + " enimies with an Staff. Total experions is: " + result.ToString());
                        }
                        else if (rbThief.Checked && !cbDubExp.Checked)
                        {
                            experions = (points * enemies);
                            result = (exp + experions);
                            lbOutput.Items.Add("You are a Thief that earned " + experions.ToString() + " experions from killing " + enemies.ToString() + " enimies with an Staff. Total experions is: " + result.ToString());
                        }
                        else if (rbWarrior.Checked && cbDubExp.Checked)
                        {
                            experions = (points * enemies) * 2;
                            result = (exp + experions);
                            lbOutput.Items.Add("You are a Warrior that earned " + experions.ToString() + " experions from killing " + enemies.ToString() + " enimies with an Staff. Total experions is: " + result.ToString());
                        }
                        else if (rbWarrior.Checked && !cbDubExp.Checked)
                        {
                            experions = (points * enemies);
                            result = (exp + experions);
                            lbOutput.Items.Add("You are a Warrior that earned " + experions.ToString() + " experions from killing " + enemies.ToString() + " enimies with an Staff. Total experions is: " + result.ToString());
                        }
                        break;

                    default:
                        lbOutput.Items.Add("Pick a weapon.");
                        break;
                }
            }
            else
                lbOutput.Text = "Pick a weapon";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbOutput.Items.Clear();
            txtEnemiesKilled.Text = "";
            txtExp.Text = "";
            rbMage.Checked = false;
            rbRoge.Checked = false;
            rbThief.Checked = false;
            rbWarrior.Checked = false;
            cbDubExp.Checked = false;
            lbWeapons.ClearSelected();
        }
    }
}
