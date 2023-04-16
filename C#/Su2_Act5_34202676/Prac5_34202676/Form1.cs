//Ashtom du Plessis 34202676
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

namespace Prac5_34202676
{
    public partial class frmVehicles : Form
    {
        public frmVehicles()
        {
            InitializeComponent();
        }

        String conStr = @"Data Source=.;Initial Catalog=Vehiclesdb;Integrated Security=True";
        SqlConnection conn;
        SqlCommand comm;
        SqlDataAdapter adap;
        DataSet ds;

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                SqlCommand comm = new SqlCommand($"SELECT * FROM Vehicles WHERE vin_number LIKE '%{txtSearch.Text}%'", conn);

                adap = new SqlDataAdapter();
                ds = new DataSet();

                adap.SelectCommand = comm;
                adap.Fill(ds, "Vehicles ");

                dgvVehicles.DataSource = ds;
                dgvVehicles.DataMember = "Vehicles ";


                conn.Close();

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void frmVehicles_Load(object sender, EventArgs e)
        {
            loadAll();
            MessageBox.Show("Connected successful");
        }

        private void loadAll()
        {
            try
            {
                conn = new SqlConnection(conStr);

                conn.Open();
                adap = new SqlDataAdapter();
                ds = new DataSet();

                string sql = "SELECT * FROM Vehicles";
                comm = new SqlCommand(sql, conn);
                adap.SelectCommand = comm;
                adap.Fill(ds, "Vehicles");

                dgvVehicles.DataSource = ds;
                dgvVehicles.DataMember = "Vehicles";

                conn.Close();

                
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            frmDelete myform = new frmDelete();
            myform.ShowDialog();

            try
            {
                conn.Open();
                string sql = "DELETE FROM Vehicles WHERE model = @model";
                comm = new SqlCommand(sql, conn);
                comm.Parameters.AddWithValue("@model", myform.txtVehicleModel.Text);
                comm.ExecuteNonQuery();
                conn.Close();

                loadAll();
                MessageBox.Show("Successfully deleted");
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sql = "INSERT INTO Vehicles(vin_number, brand, model, year, type) VALUES(@num, @brand, @model, @year, @type)";
                comm = new SqlCommand(sql, conn);
                comm.Parameters.AddWithValue("@num", txtVinNum.Text);
                comm.Parameters.AddWithValue("@brand", txtBrand.Text);
                comm.Parameters.AddWithValue("@model", txtModel.Text);
                comm.Parameters.AddWithValue("@year", txtYear.Text);
                comm.Parameters.AddWithValue("@type", cbType.SelectedItem);
                comm.ExecuteNonQuery();

                conn.Close();
                loadAll();

                MessageBox.Show("Data successfully inserted");
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand sqlCommand = new SqlCommand($"SELECT * FROM Vehicles WHERE vin_number LIKE '%{txtSearch.Text}%'", conn);

            adap = new SqlDataAdapter();
            ds = new DataSet();

            adap.SelectCommand = sqlCommand;
            adap.Fill(ds, "Vehicles");

            dgvVehicles.DataSource = ds;
            dgvVehicles.DataMember = "Vehicles";

            conn.Close();
        }
    }
}
