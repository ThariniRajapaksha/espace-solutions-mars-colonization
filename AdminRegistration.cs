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

namespace Tharini_Rajapaksha_00238334_Database_Design
{
    public partial class AdminRegistration : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-E4VLV2RS\SQLEXPRESS; Initial Catalog=E_Space_Solutions; Integrated Security=True; TrustServerCertificate=True;");
        public AdminRegistration()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "" && comboBox1.Text !="" && textBox3.Text != "" && textBox4.Text != "")
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("INSERT INTO Admin_Registration VALUES(@Name, @Contact, @Position, @Username, @Password)", conn);
                    command.Parameters.AddWithValue("@Name", textBox1.Text);
                    command.Parameters.AddWithValue("@Contact", textBox2.Text);
                    command.Parameters.AddWithValue("@Position", comboBox1.Text);
                    command.Parameters.AddWithValue("@Username", textBox3.Text);
                    command.Parameters.AddWithValue("@Password", textBox4.Text);
                    command.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Registration Is Sucessfull");
                    var newForm = new AdminLogin();
                    newForm.Show();
                    this.Hide();
                    textBox1.Text = "";
                    textBox2.Text = "";
                    comboBox1.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                }
                else
                {
                    MessageBox.Show("Fill In the Blanks...!");
                }
            }
            catch (SqlException sqlEx)
            {
                // Display different error messages based on SQL error number
                switch (sqlEx.Number)
                {
                    case 2627:  // Unique constraint error (e.g., duplicate key)
                        MessageBox.Show("This username already exists. Please choose another.");
                        break;
                    case 547:  // Foreign key constraint error
                        MessageBox.Show("There is a problem with the foreign key relationships. Please ensure the data is valid.");
                        break;
                    case 2601:  // Duplicate key error
                        MessageBox.Show("Duplicate key error: This data already exists.");
                        break;
                    default:
                        // For other SQL errors, show a generic message along with the error details
                        MessageBox.Show("A database error occurred: " + sqlEx.Message);
                        break;
                }
            }
            catch (Exception ex)
            {
                // Handle any other general exceptions
                MessageBox.Show("An unexpected error occurred: " + ex.Message);
            }
            finally
            {
                // Ensure the connection is closed even if an error occurs
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var newForm = new AdminLogin();
            newForm.Show();
            this.Hide();
        }
    }
}
