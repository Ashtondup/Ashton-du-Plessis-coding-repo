//Ashton du Plessis 34202676
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SU3_Act8
{
	public partial class Info : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			HttpCookie cName = Request.Cookies["name"];
			HttpCookie cUni = Request.Cookies["Uni"];
			HttpCookie cEmail = Request.Cookies["email"];

			if ((cName != null) && (cUni != null) && (cEmail != null))
			{
				String sName = cName["name"];
				String sEmail = cEmail["email"];
				String sUni = cUni["Uni"];
				DateTime openDate = new DateTime(2022, 2, 3);

				if (sUni == "North-West University")
				{
					openDate = new DateTime(2021, 2, 3);
					cldOut.SelectedDate = openDate;
				}
				else if (sUni == "University of Johannesburg")
				{
					openDate = new DateTime(2021, 2, 10);
					cldOut.SelectedDate = openDate;
				}
				else if (sUni == "University of Capetown")
				{
					openDate = new DateTime(2021, 2, 5);
					cldOut.SelectedDate = openDate;
				}
				else if (sUni == "University of Pretoria")
				{
					openDate = new DateTime(2021, 2, 17);
					cldOut.SelectedDate = openDate;
				}
				else if (sUni == "University of Free State")
				{
					openDate = new DateTime(2021, 2, 3);
					cldOut.SelectedDate = openDate;
				}
				else
				{
					openDate = new DateTime(2021, 2, 3);
					cldOut.SelectedDate = openDate;
				}

				lblName.Text = "Welcome " + sName + ", the " + sUni + " Starts at " + openDate.ToString("dddddd, yyyy/MM/dd");
				lblEmail.Text = "We will send you a reminder to: " + sEmail;

				cName.Expires = DateTime.Now.AddSeconds(10);
				cUni.Expires = DateTime.Now.AddSeconds(10);
				cEmail.Expires = DateTime.Now.AddSeconds(10);
			}
			else
			{
				lblInfo.Text = "Please vist front page first!";
				lblName.Visible = false;
				lblEmail.Visible = false;
				cldOut.Visible = false;
			}
		}
	}
}