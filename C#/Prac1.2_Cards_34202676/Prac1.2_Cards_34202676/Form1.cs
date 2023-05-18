using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prac1._2_Cards_34202676
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pb8Diamond_Click(object sender, EventArgs e)
        {
            lbl8ofDiamonds.Show();
            lbl2ofClubs.Hide();
            lblKofSpades.Hide();
            lblAofSpaides.Hide();
            lblJokerBlack.Hide();
        }

        private void pb2Clubs_Click(object sender, EventArgs e)
        {
            lbl8ofDiamonds.Hide();
            lbl2ofClubs.Show();
            lblKofSpades.Hide();
            lblAofSpaides.Hide();
            lblJokerBlack.Hide();
        }

        private void pbKSpades_Click(object sender, EventArgs e)
        {
            lbl8ofDiamonds.Hide();
            lbl2ofClubs.Hide();
            lblKofSpades.Show();
            lblAofSpaides.Hide();
            lblJokerBlack.Hide();
        }

        private void pbASpades_Click(object sender, EventArgs e)
        {
            lbl8ofDiamonds.Hide();
            lbl2ofClubs.Hide();
            lblKofSpades.Hide();
            lblAofSpaides.Show();
            lblJokerBlack.Hide();
        }

        private void pbJokerBlacek_Click(object sender, EventArgs e)
        {
            lbl8ofDiamonds.Hide();
            lbl2ofClubs.Hide();
            lblKofSpades.Hide();
            lblAofSpaides.Hide();
            lblJokerBlack.Show();
        }
    }
}
