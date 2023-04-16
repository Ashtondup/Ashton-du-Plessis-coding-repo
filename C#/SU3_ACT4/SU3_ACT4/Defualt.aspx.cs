using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SU3_ACT4
{
    public partial class Defualt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Calendar.SelectedDate = DateTime.Today.Date;
        }

        protected void cal_SelectionChanged(object sender, EventArgs e)
        {
            DateTime theDate = Calendar.SelectedDate;

            int error = (int)theDate.DayOfWeek; 

            if (Calendar.SelectedDate < DateTime.Today.Date )
            {
                lblOut.Text = "Please select an upcomming date - in the future ";
            }
            else 
            {
                lbDisplay.Items.Add(txtModule.Text + theDate.ToString(" - dddd, yyyy/MM/dd"));
            }

        }

        protected void txtModule_TextChanged(object sender, EventArgs e)
        {

        }
    }
}