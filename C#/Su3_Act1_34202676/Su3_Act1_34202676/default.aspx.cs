//Ashton du Plessis 34202676
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Su3_Act1_34202676
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            lbGrosoryList.Items.Add(txtItem.Text);
            //lbGrosoryList.Items.Remove(lbGrosoryList.SelectedItem);
            lblMessage.Text = txtName.Text + ", " + lbGrosoryList.SelectedItem + " removed from the list.";
            lbGrosoryList.Items.Remove(lbGrosoryList.SelectedItem);
        }
    }
}