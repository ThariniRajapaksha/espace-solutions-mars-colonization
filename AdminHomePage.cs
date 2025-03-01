using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace Tharini_Rajapaksha_00238334_Database_Design
{
    public partial class AdminHomePage : Form
    {
        public AdminHomePage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var newForm = new list1();
            newForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var newForm = new list2();
            newForm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var newForm = new list3();
            newForm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var newForm = new list4();
            newForm.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var newForm = new list5();
            newForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var newForm = new list6();
            newForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Close the current form (Admin Homepage)
            MessageBox.Show("Your Logout is sucessful...!");
            this.Close(); // This will close the current form
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var newForm = new UserManage();
            newForm.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var newForm = new PilotsManage();
            newForm.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var newForm = new InforForReports();
            newForm.Show();
            this.Hide();
        }
    }
}
