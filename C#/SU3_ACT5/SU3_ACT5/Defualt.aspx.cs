using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SU3_ACT5
{
    public partial class Defualt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Calendar.SelectedDate = DateTime.Today.Date;

        }

        protected void cal_SelectionChanged(object sender, EventArgs e)
        {
            DateTime theDate  = Calendar.SelectedDate;

            int fri = 5 - (int)(theDate.DayOfWeek);
            int sat = 6 - (int)(theDate.DayOfWeek);
            int sun = 7 - (int)(theDate.DayOfWeek);
            
            

            if ((int)(theDate.DayOfWeek) == 5)
            {
                lblOut.Text = theDate.AddDays(3).ToLongDateString();
            }
           else if ((int)(theDate.DayOfWeek) == 6)
            {
                lblOut.Text = theDate.AddDays(3).ToLongDateString();
            }
            else if ((int)(theDate.DayOfWeek) == 7)
            {
                lblOut.Text = theDate.AddDays(3).ToLongDateString();
            }
            else 
            {
                lblOut.Text = theDate.AddDays(2).ToLongDateString();
            }


        }
    }
}