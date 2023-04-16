//Ashton du Plessis 34202676
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace SU3_Act_6_34202676
{
    public partial class Default : System.Web.UI.Page
    {
        public string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ashto\Desktop\CMPG\2022\CMPG212\Prakties\Su3_Act6_34202676\SU3_Act_6_34202676\App_Data\PetKettel.mdf;Integrated Security=True";
        public SqlConnection con;
        public SqlCommand cmd;
        public DataSet ds;
        public SqlDataAdapter adap;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnShowAll_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(constr);
                con.Open();
                string sql = "SELECT HouseId, PetName, PetType FROM PetTable";

                ds = new DataSet();
                adap = new SqlDataAdapter();
                cmd = new SqlCommand(sql, con);
                adap.SelectCommand = cmd;
                adap.Fill(ds);

                gvPet.DataSource = ds;
                gvPet.DataBind();
                con.Close();
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
            
        }

        protected void btnShowLarge_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(constr);
                con.Open();
                string sql = "SELECT HouseId, PetName FROM PetTable WHERE PetSize = 'Large'";

                ds = new DataSet();
                adap = new SqlDataAdapter();
                cmd = new SqlCommand(sql, con);
                adap.SelectCommand = cmd;
                adap.Fill(ds);

                gvPet.DataSource = ds;
                gvPet.DataBind();
                con.Close();
            }
            catch(Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }
    }
}