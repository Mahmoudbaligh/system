using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School
{
    public partial class Logout : Form
    {
        public Logout()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure! Are you going to logout?", "logout",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK) {
                Form1 form1 = new Form1();
                form1.Show();
                this.Close();
            }
            else

            {
                MessageBox.Show("Welcome Back <3", "Welcome", MessageBoxButtons.OK);
            }

        }
    }
}
