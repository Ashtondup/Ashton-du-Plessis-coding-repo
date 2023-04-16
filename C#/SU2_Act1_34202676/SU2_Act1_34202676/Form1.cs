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

namespace SU2_Act1_34202676
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string conStr = @"Data Source=.;Initial Catalog=ClientList;Integrated Security=True";
        SqlConnection conn;
        SqlCommand comm;
        SqlDataAdapter adap;
        DataSet ds;
        SqlDataReader theReader;

        private void btnConnect_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(conStr); ;

            conn.Open();
            conn.Close();

            MessageBox.Show("Connected Successfully");

            btnDisplay.Show();
        }
        
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            conn.Open();
            adap = new SqlDataAdapter();
            ds = new DataSet();

            string sql = "SELECT * FROM ClientList";

            comm = new SqlCommand(sql, conn);
            adap.SelectCommand = comm;
            adap.Fill(ds, "SourceTable");

            dbView.DataSource = ds;
            dbView.DataMember = "SourceTable";

            conn.Close();

            btnMoveData.Show();
        }

        private void btnMoveData_Click(object sender, EventArgs e)
        {
            conn.Open();
            string sql = "SELECT * FROM ClientList";

            comm = new SqlCommand(sql, conn);
            theReader = comm.ExecuteReader();

            while(theReader.Read())
            {
                lbData.Items.Add(theReader.GetValue(0) + "\t" + theReader.GetValue(1) + "\t" + theReader.GetValue(2) + "\t" + theReader.GetValue(3));
            }

            conn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnDisplay.Hide();
            btnMoveData.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
