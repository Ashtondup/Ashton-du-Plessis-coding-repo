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
            if (!IsPostBack)
            {
                Session["name"] = null;
                Session["Ticket"] = null;
                Session["Time"] = null;
            }
        }

        protected void rb1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void btn11oclock_Click(object sender, EventArgs e)
        {
            Session["Time"] = "11:00";
        }

        /*public int Tickets()
        {

            if (rb1.Checked)
                ticket = 1;
            else if (rb2.Checked)
                ticket = 2;
            else if (rb3.Checked)
                ticket = 3;
            return ticket;
        }*/

        protected void btnBook_Click(object sender, EventArgs e)
        {
            Session["name"] = txtName_Surname.Text;
            if (this.rb1.Checked)
            {
                Session["Ticket"] = 1;
            }

            else if (this.rb2.Checked)
            {
                Session["Ticket"] = 2;
            }

            else if (this.rb3.Checked)
            {
                Session["Ticket"] = 3;
            }
            if(Session["name"].ToString() != "" && Session["Ticket"] != null && Session["Time"] != null)
            {
                lblDisplay.Text = $"{Session["name"]} you have succesfully booked the show for {Session["Ticket"]} people at {Session["Time"]}";
            }
            else
            {
                lblDisplay.Text = "Error";
            }
        }

        protected void btn2oclock_Click(object sender, EventArgs e)
        {
            Session["Time"] = "14:00";
        }

        protected void btn5oclock_Click(object sender, EventArgs e)
        {
            Session["Time"] = "17:00";
        }
    }
}