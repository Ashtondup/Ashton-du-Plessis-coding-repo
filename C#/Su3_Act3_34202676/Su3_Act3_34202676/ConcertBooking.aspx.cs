//Ashton du Plessis 34202676
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Su3_Act3_34202676
{
    public partial class ConcertBooking : System.Web.UI.Page
    {
        int ticket;

        protected void Page_Load(object sender, EventArgs e)
        {
            if(Page.IsPostBack)
            {
                ticket = 0;
                cookies.Visible = false;
            }
        }

        protected void rb1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void btn11oclock_Click(object sender, EventArgs e)
        {
            cookies.Text = ("11:00");
        }

        public int Tickets()
        {

            if (rb1.Checked)
                ticket = 1;
            else if (rb2.Checked)
                ticket = 2;
            else if (rb3.Checked)
                ticket = 3;
            return ticket;
        }

        protected void btnBook_Click(object sender, EventArgs e)
        {
            Tickets();
            lblDisplay.Text = (txtName_Surname.Text + " you have successfully booked the show for " + ticket + " " + cookies.Text);
        }

        protected void btn2oclock_Click(object sender, EventArgs e)
        {
            cookies.Text = ("14:00");
        }

        protected void btn5oclock_Click(object sender, EventArgs e)
        {
            cookies.Text = ("17:00");
        }
    }
}