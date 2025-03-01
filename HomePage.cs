using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tharini_Rajapaksha_00238334_Database_Design
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Close the current form (User Homepage)
            MessageBox.Show("Thank You so much for Join with us, Your Logout is sucessful...!");
            this.Close(); // This will close the current form
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var newForm = new ColonistsRegistration();
            newForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var newForm = new DependentsRegistration();
            newForm.Show();
            this.Hide();
        }
    }
}
