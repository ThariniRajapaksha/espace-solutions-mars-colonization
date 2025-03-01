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

namespace Tharini_Rajapaksha_00238334_Database_Design
{
    public partial class UserManage : Form
    {
        private string connectionString = @"Data Source=LAPTOP-E4VLV2RS\SQLEXPRESS; Initial Catalog=E_Space_Solutions; Integrated Security=True; TrustServerCertificate=True;";
        public UserManage()
        {
            InitializeComponent();
            LoadUsers();
        }
        // Load users from the database
        private void LoadUsers()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM User_Registration", conn);
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
                SqlCommand cmd = new SqlCommand("INSERT INTO User_Registration (Name, Contact, Username, Password) VALUES (@Name, @Contact, @Username, @Password)", conn);
                cmd.Parameters.AddWithValue("@Name", textBox1.Text);
                cmd.Parameters.AddWithValue("@Contact", textBox2.Text);
                cmd.Parameters.AddWithValue("@Username", textBox3.Text);
                cmd.Parameters.AddWithValue("@Password", textBox4.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User added successfully.");
                LoadUsers(); // Refresh the data grid view
            }
        }



        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    // Get UserID from the selected row in DataGridView
                    int UserID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["UserID"].Value);

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        // Debugging: Check if the UserID is retrieved correctly
                        Console.WriteLine("Deleting UserID: " + UserID);

                        SqlCommand cmd = new SqlCommand("DELETE FROM User_Registration WHERE UserID = @UserID", conn);
                        cmd.Parameters.AddWithValue("@UserID", UserID);

                        int rowsAffected = cmd.ExecuteNonQuery(); // Execute the query and get affected rows count

                        // Check if the row was deleted
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User deleted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("User not found or could not be deleted.");
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
                MessageBox.Show("Please select a user to delete.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newForm = new AdminHomePage();
            newForm.Show();
            this.Hide();
        }

        private void UserManage_Load(object sender, EventArgs e)
        {

        }
    }
}
