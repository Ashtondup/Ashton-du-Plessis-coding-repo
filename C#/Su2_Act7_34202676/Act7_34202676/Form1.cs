using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Act7_34202676
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String conStr = @"Data Source=.;Initial Catalog=Act7;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        SqlDataReader reader;
        DataSet ds;


        private void tabPage1_Click(object sender, EventArgs e)
        {
            LoadAll();
            MessageBox.Show("Connection succesfully");
        }

        private void LoadAll()
        {
            try
            {
                con = new SqlConnection(conStr);

                con.Open();
                adapter = new SqlDataAdapter();
                ds = new DataSet();

                string sql = "SELECT * FROM Movies";
                cmd = new SqlCommand(sql, con);
                adapter.SelectCommand = cmd;
                adapter.Fill(ds, "Movies");

                dgvMovies.DataSource = ds;
                dgvMovies.DataMember = "Movies";

                con.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void populate()
        {
            con = new SqlConnection(conStr);

            con.Open();
            string sql = "SELECT DISTINCT Moviename FROM Movies";
            cmd = new SqlCommand(sql, con);

            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                cbMovieName.Items.Add(reader.GetValue(0));
            }
            con.Close();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(conStr);

                con.Open();
                string sql = "SELECT * FROM Movies";
                cmd = new SqlCommand(sql, con);

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lstResults.Items.Add(reader.GetValue(0) + "\t" + reader.GetValue(1) + "\t" + reader.GetValue(2) + "\t" + reader.GetValue(3));
                }
                con.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string sql = "DELETE FROM Movies WHERE Moviename = @name";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@name", cbMovieName.SelectedItem);
                cmd.ExecuteNonQuery();
                con.Close();

                LoadAll();
                MessageBox.Show("Successfully deleted");

                cbMovieName.Items.Clear();
                populate();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmInsert myform = new frmInsert();
            myform.ShowDialog();

            try
            {
                con = new SqlConnection(conStr);

                con.Open();
                adapter = new SqlDataAdapter();

                cmd = new SqlCommand($"INSERT INTO Movies(Moviename,MovieDirector,MovieRating,MovieYear) VALUE ('{myform.fName}','{myform.fDirector}',{myform.fRateing},{myform.fYear})", con);
                adapter.InsertCommand = cmd;
                adapter.InsertCommand.ExecuteNonQuery();

                con.Close();
                LoadAll();
                cbMovieName.Items.Clear();
                populate();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void txtNameSearch_TextChanged(object sender, EventArgs e)
        {
            lstResults.Items.Clear();
            try
            { 
                con = new SqlConnection(conStr);
                
                con.Open();
                string sql = $"SELECT * FROM Movies WHERE Moviename LIKE '%{txtNameSearch.Text}%'";
                cmd = new SqlCommand(sql, con);

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lstResults.Items.Add(reader.GetValue(0) + "\t" + reader.GetValue(1) + "\t" + reader.GetValue(2) + "\t" + reader.GetValue(3));
                }
                con.Close();
            }
        
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void sbYearSearch_Scroll(object sender, ScrollEventArgs e)
        {
            lstResults.Items.Clear();
            lblScroll.Text = sbYearSearch.Value.ToString();
            try
            {
                con = new SqlConnection(conStr);

                con.Open();
                string sql = $"SELECT * FROM Movies WHERE MovieYear = {sbYearSearch.Value}";
                cmd = new SqlCommand(sql, con);

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lstResults.Items.Add(reader.GetValue(0) + "\t" + reader.GetValue(1) + "\t" + reader.GetValue(2) + "\t" + reader.GetValue(3));
                }
                con.Close();
            }

            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void cbRatingSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstResults.Items.Clear();
            try
            {
                con = new SqlConnection(conStr);

                con.Open();
                string sql = $"SELECT * FROM Movies WHERE MovieRating = {cbRatingSearch.SelectedItem}";
                cmd = new SqlCommand(sql, con);

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lstResults.Items.Add(reader.GetValue(0) + "\t" + reader.GetValue(1) + "\t" + reader.GetValue(2) + "\t" + reader.GetValue(3));
                }
                con.Close();
            }

            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void lstResults_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbMovieName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
