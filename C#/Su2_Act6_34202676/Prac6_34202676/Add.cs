using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prac6_34202676
{
    public partial class Add : Form
    {
        public int fNum;
        public int fTotal;
        public int fOpen;
        public String fSize;

        public Add()
        {
            InitializeComponent();
        }

        private void Add_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            fNum = Convert.ToInt32(txtTheatreNum.Text);
            fTotal = Convert.ToInt32(txtTotSeats.Text);
            fOpen = Convert.ToInt32(txtOpenSeats.Text);
            fSize = txtTheatreSize.Text;

            this.Close();
        }
    }
}
