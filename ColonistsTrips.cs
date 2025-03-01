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
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tharini_Rajapaksha_00238334_Database_Design
{
    public partial class ColonistsTrips : Form
    {
        private string connectionString = @"Data Source=LAPTOP-E4VLV2RS\SQLEXPRESS; Initial Catalog=E_Space_Solutions; Integrated Security=True; TrustServerCertificate=True;";
        public ColonistsTrips()
        {
            InitializeComponent();
            LoadUsers();
        }
        private void LoadUsers()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM ColonistTrip", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO ColonistTrip (Colonization_ID, Trip_ID) VALUES (@Colonization_ID, @Trip_ID)", conn);
                cmd.Parameters.AddWithValue("@Colonization_ID", textBox1.Text);
                cmd.Parameters.AddWithValue("@Trip_ID", textBox2.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data added successfully.");
                LoadUsers(); // Refresh the data grid view
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    // Get Colonization_ID from the selected row in DataGridView
                    int Colonization_ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Colonization_ID"].Value);

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        // Debugging: Check if the Colonization_ID is retrieved correctly
                        Console.WriteLine("Deleting Colonization_ID: " + Colonization_ID);

                        SqlCommand cmd = new SqlCommand("DELETE FROM ColonistTrip WHERE Colonization_ID = @Colonization_ID", conn);
                        cmd.Parameters.AddWithValue("@Colonization_ID", Colonization_ID);

                        int rowsAffected = cmd.ExecuteNonQuery(); // Execute the query and get affected rows count

                        // Check if the row was deleted
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data deleted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Colonist not found or could not be deleted.");
                        }

                        // Refresh the DataGridView
                        LoadUsers();
                    }
                }
                catch (Exception ex)
                {
                    // Show any error that occurs during the deletion process
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a Colonist ID to delete.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newForm = new InforForReports();
            newForm.Show();
            this.Hide();
        }

        private void ColonistsTrips_Load(object sender, EventArgs e)
        {

        }
    }
}
