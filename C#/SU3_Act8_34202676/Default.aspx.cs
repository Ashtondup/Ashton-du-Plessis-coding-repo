//Ashton du Plessis 34202676
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SU3_Act8
{
	public partial class Default : System.Web.UI.Page
	{
		public String sName;
		public String sEmail;
		public String sUni;
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void btnSubmit_Click(object sender, EventArgs e)
		{
			HttpCookie cName = new HttpCookie("name");
			HttpCookie cUni = new HttpCookie("Uni");
			HttpCookie cEmail = new HttpCookie("email");

			if ((sName != null) && (sUni != null) && (sEmail != null))
			{
				cName["name"] = sName;
				cName.Expires = DateTime.Now.AddSeconds(10);
				Response.Cookies.Add(cName);

				cEmail["email"] = sEmail;
				cUni.Expires = DateTime.Now.AddSeconds(10);
				Response.Cookies.Add(cEmail);

				cUni["Uni"] = sUni;
				cEmail.Expires = DateTime.Now.AddSeconds(10);
				Response.Cookies.Add(cUni);
				
				Response.Redirect("Info.aspx");

			}
			else
			{
				lblDeets.Text = "PLease make sure to enter all your details:";
			}
		}

		protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
		{
			sUni = RadioButtonList1.SelectedValue.ToString();
		}

		protected void txtName_TextChanged(object sender, EventArgs e)
		{
			sName = txtName.Text;
		}

		protected void txtEmail_TextChanged(object sender, EventArgs e)
		{
			sEmail = txtEmail.Text;
		}
	}
}