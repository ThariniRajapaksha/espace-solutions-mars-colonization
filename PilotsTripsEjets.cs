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
    public partial class PilotsTripsEjets : Form
    {
        private string connectionString = @"Data Source=LAPTOP-E4VLV2RS\SQLEXPRESS; Initial Catalog=E_Space_Solutions; Integrated Security=True; TrustServerCertificate=True;";
        public PilotsTripsEjets()
        {
            InitializeComponent();
            LoadUsers();
        }
        private void LoadUsers()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM JetAssignment", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO JetAssignment (Pilot_ID, Trip_ID, JetUniqueCode) VALUES (@Pilot_ID, @Trip_ID, @JetUniqueCode)", conn);
                cmd.Parameters.AddWithValue("@Pilot_ID", textBox1.Text);
                cmd.Parameters.AddWithValue("@Trip_ID", textBox2.Text);
                cmd.Parameters.AddWithValue("@JetUniqueCode", textBox3.Text);
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
                    // Get Pilot_ID from the selected row in DataGridView
                    int Pilot_ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Pilot_ID"].Value);

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        // Debugging: Check if the Pilot_ID is retrieved correctly
                        Console.WriteLine("Deleting Pilot_ID: " + Pilot_ID);

                        using (SqlCommand cmd = new SqlCommand("DELETE FROM JetAssignment WHERE Pilot_ID = @Pilot_ID", conn))
                        {
                            cmd.Parameters.AddWithValue("@Pilot_ID", Pilot_ID);

                            int rowsAffected = cmd.ExecuteNonQuery(); // Execute the query and get affected rows count

                            // Check if the row was deleted
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Data deleted successfully.");
                            }
                            else
                            {
                                MessageBox.Show("Data not found or could not be deleted.");
                            }

                            // Refresh the DataGridView
                            LoadUsers();
                        }
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
                MessageBox.Show("Please select a data to delete.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newForm = new InforForReports();
            newForm.Show();
            this.Hide();
        }
    }
}
