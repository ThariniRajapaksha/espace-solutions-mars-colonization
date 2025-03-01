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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Tharini_Rajapaksha_00238334_Database_Design
{
    public partial class DependentsRegistration : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-E4VLV2RS\SQLEXPRESS; Initial Catalog=E_Space_Solutions; Integrated Security=True; TrustServerCertificate=True;");
        public DependentsRegistration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newForm = new HomePage();
            newForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && dateTimePicker1.Text != "" && textBox2.Text != "" && comboBox1.Text != "" && richTextBox1.Text != "" && textBox3.Text != "")
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("INSERT INTO Colonists_Dependents VALUES(@Name, @Dob, @Age, @Gender, @RWC, @Colonization)", conn);
                    command.Parameters.AddWithValue("@Name", textBox1.Text);
                    command.Parameters.AddWithValue("@Dob", dateTimePicker1.Text);
                    command.Parameters.AddWithValue("@Age", textBox2.Text);
                    command.Parameters.AddWithValue("@Gender", comboBox1.Text);
                    command.Parameters.AddWithValue("@RWC", richTextBox1.Text);
                    command.Parameters.AddWithValue("@Colonization", textBox3.Text);
                    command.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Dependents Form Is Submit Sucessfully");
                    var newForm = new HomePage();
                    newForm.Show();
                    this.Hide();
                    textBox1.Text = "";
                    dateTimePicker1.Text = "";
                    textBox2.Text = "";
                    comboBox1.Text = "";
                    richTextBox1.Text = "";
                    textBox3.Text = "";
                }
                else
                {
                    MessageBox.Show("Fill In the Blanks...!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
