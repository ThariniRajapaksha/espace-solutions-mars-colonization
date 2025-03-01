using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tharini_Rajapaksha_00238334_Database_Design
{
    public partial class UserLogin : Form
    {
        // Connection string for the SQL Server connection
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-E4VLV2RS\SQLEXPRESS; Initial Catalog=E_Space_Solutions; Integrated Security=True; TrustServerCertificate=True;");

        public UserLogin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Handle PictureBox click event (if needed)
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Handle text changed event for TextBox1 (if needed)
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var newForm = new UserRegister();
            newForm.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var newForm = new AdminLogin();
            newForm.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Form Load event (if needed)
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            // Handle Paint event for TableLayoutPanel (if needed)
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Handle Label click event (if needed)
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Handle Label click event (if needed)
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check if both textboxes are filled
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "")
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("INSERT INTO User_Login VALUES(@Username, @Password)", conn);
                    command.Parameters.AddWithValue("@Username", textBox1.Text);
                    command.Parameters.AddWithValue("@Password", textBox2.Text);
                    command.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Login Is Sucessfull");
                    var newForm = new HomePage();
                    newForm.Show();
                    this.Hide();
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
                else
                {
                    MessageBox.Show("Fill in the blanks!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
