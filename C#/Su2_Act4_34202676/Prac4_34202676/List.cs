//Ashton du Plessis 34202676
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Prac4_34202676
{
    public partial class List : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Companies;Integrated Security=True");
        SqlDataAdapter adapter;
        DataSet ds;

        public List()
        {
            InitializeComponent();
        }

        private void List_Load(object sender, EventArgs e)
        {
            
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand sqlcommand = new SqlCommand(@"SELECT * FROM Companies", con);
                adapter= new SqlDataAdapter();
                ds = new DataSet();

                adapter.SelectCommand = sqlcommand;
                adapter.Fill(ds, "Companies");

                dtgListData.DataSource = ds;
                dtgListData.DataMember = "Companies";
                con.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand sqlcmd = new SqlCommand($"SELECT * FROM Companies WHERE Slogan LIKE '%{txtSearchPhrase.Text}%'", con);
                adapter = new SqlDataAdapter();
                ds = new DataSet();

                adapter.SelectCommand = sqlcmd;
                adapter.Fill(ds, "Companies");

                dtgListData.DataSource = ds;
                dtgListData.DataMember = "Companies";
                con.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand sqlcmd = new SqlCommand($"SELECT * FROM Companies WHERE Rating = {txtFindRating.Text}", con);
                adapter = new SqlDataAdapter();
                ds = new DataSet();

                adapter.SelectCommand = sqlcmd;
                adapter.Fill(ds, "Companies");

                dtgListData.DataSource = ds;
                dtgListData.DataMember = "Companies";
                con.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
