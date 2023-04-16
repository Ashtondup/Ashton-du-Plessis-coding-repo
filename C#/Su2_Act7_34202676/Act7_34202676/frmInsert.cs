using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Act7_34202676
{
    public partial class frmInsert : Form
    {

        public String fName;
        public String fDirector;
        public int fRateing;
        public int fYear;

        public frmInsert()
        {
            InitializeComponent();
        }

        private void frmInsert_Load(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int result1;
            int result2;
            fName = txtName.Text;
            fDirector = txtDirector.Text;
            if (int.TryParse(txtRaring.Text, out result1) && result1 >0)
            {
                if (int.TryParse(txtYear.Text, out result2) && result2 >= 1990 && result2 <=2019)
                {
                    //fName = txtName.Text;
                    //fDirector = txtDirector.Text;
                    fRateing = result1;
                    fYear = result2;
                }
                else
                {
                    errorProvider1.SetError(txtYear, "Year must be numeric and between 1990 and 2019.");
                }
            }
            else
            {
                errorProvider2.SetError(txtRaring, "Value must be numeric.");
            }
            this.Close();
        }
    }
}
