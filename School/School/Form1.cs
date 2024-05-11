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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace School
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        SqlDataAdapter da = new SqlDataAdapter();
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(" Data Source=DESKTOP-G3D9FTC; database=SCHOOLDB; integrated Security=True");
            if (Username.Text == "" || Password.Text == "")
            {
                MessageBox.Show("Please Enter Username and Password", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string selectQuery = "SELECT * FROM Table_1 WHERE Username='" + Username.Text + "' AND Password='" + Password.Text + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, con);
                DataTable table = new DataTable();
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                {
                    Main main = new Main();
                    main.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password", "Wrong Information", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Username.Text = "";
            Password.Text = "";
        }
    }
}
        