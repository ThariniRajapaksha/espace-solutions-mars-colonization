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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Tharini_Rajapaksha_00238334_Database_Design
{
    public partial class ColonistsRegistration : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-E4VLV2RS\SQLEXPRESS; Initial Catalog=E_Space_Solutions; Integrated Security=True; TrustServerCertificate=True;");
        public ColonistsRegistration()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void ColonistsRegistration_Load(object sender, EventArgs e)
        {

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
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
                {
                    conn.Open();
                    string query = "INSERT INTO Colonists (Colonization_ID, First_Name, Middle_Name, Surname, DateOfBirth, Qualification, Age, EarthAddress, Gender, Contact, CivilStatus, FamilyMembers) " +
                                   "VALUES (@ColonizationID, @FirstName, @MiddleName, @Surname, @DateOfBirth, @Qualification, @Age, @EarthAddress, @Gender, @Contact, @CivilStatus, @FamilyMembers)";

                    SqlCommand command = new SqlCommand(query, conn);

                    command.Parameters.AddWithValue("@ColonizationID", textBox1.Text);
                    command.Parameters.AddWithValue("@FirstName", textBox2.Text);
                    command.Parameters.AddWithValue("@MiddleName", textBox3.Text);
                    command.Parameters.AddWithValue("@Surname", textBox4.Text);
                    command.Parameters.AddWithValue("@DateOfBirth", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@Qualification", textBox6.Text);
                    command.Parameters.AddWithValue("@Age", textBox9.Text);
                    command.Parameters.AddWithValue("@EarthAddress", textBox8.Text);
                    command.Parameters.AddWithValue("@Gender", comboBox1.Text);
                    command.Parameters.AddWithValue("@Contact", textBox7.Text);
                    command.Parameters.AddWithValue("@CivilStatus", comboBox2.Text);
                    command.Parameters.AddWithValue("@FamilyMembers", textBox10.Text);

                    command.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Colonists Registration Successful");
                    var newForm = new HomePage();
                    newForm.Show();
                    this.Hide();
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
