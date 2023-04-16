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

namespace Prac6_34202676
{
    public partial class frmTheaters : Form
    {
        public frmTheaters()
        {
            InitializeComponent();
        }

        String conStr = @"Data Source=.;Initial Catalog=Theatredb;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adap;
        SqlDataReader theReader;
        DataSet ds;

        private void btnView_Click(object sender, EventArgs e)
        {
            loadAll();
        }

        private void loadAll()
        {
            try
            {
                con = new SqlConnection(conStr);

                con.Open();
                adap = new SqlDataAdapter();
                ds = new DataSet();

                string sql = "SELECT * FROM Theatre";
                cmd = new SqlCommand(sql, con);
                adap.SelectCommand = cmd;
                adap.Fill(ds, "SourceTable");

                dgvViewData.DataSource = ds;
                dgvViewData.DataMember = "SourceTable";

                con.Close();
            }
            catch (SqlException erros)
            {
                MessageBox.Show(erros.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add myform = new Add();
            myform.ShowDialog();

            try
            {
                con = new SqlConnection(conStr);

                con.Open();
                adap = new SqlDataAdapter();

                cmd = new SqlCommand($"INSERT INTO Theatre(TheatreNumber,TotalSeats,OpenSeats,TheatreSize) VALUES ({myform.fNum},{myform.fTotal},{myform.fOpen},'{myform.fSize}')", con);
                adap.InsertCommand = cmd;
                adap.InsertCommand.ExecuteNonQuery();

                con.Close();
                loadAll();
                cbTheterNum.Items.Clear();
                populate();
            }
            catch(SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void frmTheaters_Load(object sender, EventArgs e)
        {

            populate();


            MessageBox.Show("Database Connected successful");
        }

        private void populate()
        {
            con = new SqlConnection(conStr);

            con.Open();
            string sql = "SELECT DISTINCT TheatreNumber FROM Theatre";
            cmd = new SqlCommand(sql, con);

            theReader = cmd.ExecuteReader();

            while (theReader.Read())
            {
                cbTheterNum.Items.Add(theReader.GetValue(0));
            }
            con.Close();
        }

        private void btnSmallTheaters_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(conStr);

                con.Open();
                adap = new SqlDataAdapter();
                ds = new DataSet();

                string sql = "SELECT * FROM Theatre WHERE OpenSeats < 50";
                cmd = new SqlCommand(sql, con);
                adap.SelectCommand = cmd;
                adap.Fill(ds, "SourceTable");

                dgvViewData.DataSource = ds;
                dgvViewData.DataMember = "SourceTable";

                con.Close();
            }
            catch (SqlException erros)
            {
                MessageBox.Show(erros.Message);
            }
        }

        private void btnMediumandLargeTheaters_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(conStr);

                con.Open();
                adap = new SqlDataAdapter();
                ds = new DataSet();

                string sql = "SELECT * FROM Theatre WHERE TotalSeats >= 120 AND TotalSeats <= 260";
                cmd = new SqlCommand(sql, con);
                adap.SelectCommand = cmd;
                adap.Fill(ds, "SourceTable");

                dgvViewData.DataSource = ds;
                dgvViewData.DataMember = "SourceTable";

                con.Close();
            }
            catch (SqlException erros)
            {
                MessageBox.Show(erros.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string sql = "DELETE FROM Theatre WHERE TheatreNumber = @num";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@num", cbTheterNum.SelectedItem);
                cmd.ExecuteNonQuery();
                con.Close();

                loadAll();
                MessageBox.Show("Successfully deleted");

                cbTheterNum.Items.Clear();
                populate();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
