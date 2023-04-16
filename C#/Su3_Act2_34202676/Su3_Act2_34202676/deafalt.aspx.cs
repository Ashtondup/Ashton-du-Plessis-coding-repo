//Ashton du Plessis 34202676
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Su3_Act2_34202676
{
    public partial class deafalt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnOrder_Click(object sender, EventArgs e)
        {
            string colour;
            double amount, tax, total;
            int num;
            if(int.TryParse(txtAmount.Text, out num))
            {
                lblResult.Text = "Selection made from " + txtName.Text + " " + txtLastName.Text + " --- Colour: " + lbColour.SelectedItem + " - (Amount)" + txtAmount.Text;
                if (lbColour.SelectedIndex != -1)
                {
                    colour = lbColour.SelectedItem.ToString();

                    switch (colour)
                    {
                        case "Rainbow":
                            amount = num * 45.50;
                            tax = amount * 0.15;
                            total = amount + tax;
                            lblAmount.Text = "Total cost, excluding tax = R" + amount;
                            lblTax.Text = "Total amount of tax = R" + tax;
                            lblTotal.Text = "Total cost, including tax = R" + total;
                            break;
                        case "Red":
                            amount = num * 30;
                            tax = amount * 0.15;
                            total = amount + tax;
                            lblAmount.Text = "Total cost, excluding tax = R" + amount;
                            lblTax.Text = "Total amount of tax = R" + tax;
                            lblTotal.Text = "Total cost, including tax = R" + total;
                            break;
                        case "Black":
                            amount = num * 30;
                            tax = amount * 0.15;
                            total = amount + tax;
                            lblAmount.Text = "Total cost, excluding tax = R" + amount;
                            lblTax.Text = "Total amount of tax = R" + tax;
                            lblTotal.Text = "Total cost, including tax = R" + total;
                            break;
                        case "Blue":
                            amount = num * 30;
                            tax = amount * 0.15;
                            total = amount + tax;
                            lblAmount.Text = "Total cost, excluding tax = R" + amount;
                            lblTax.Text = "Total amount of tax = R" + tax;
                            lblTotal.Text = "Total cost, including tax = R" + total;
                            break;
                        case "Green":
                            amount = num * 30;
                            tax = amount * 0.15;
                            total = amount + tax;
                            lblAmount.Text = "Total cost, excluding tax = R" + amount;
                            lblTax.Text = "Total amount of tax = R" + tax;
                            lblTotal.Text = "Total cost, including tax = R" + total;
                            break;
                    }
                }
            }            
        }

        protected void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }
    }
}