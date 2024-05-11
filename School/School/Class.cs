using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School
{
    public partial class Class : Form
    {
        public Class()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(" Data Source=DESKTOP-G3D9FTC; database=SCHOOLDB; integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Table_5 values(@Classid,@Studentname,@Class )", con);
            cmd.Parameters.AddWithValue("@Classid", Convert.ToInt32(textBox1.Text));
            cmd.Parameters.AddWithValue("@Studentname", textBox2.Text);
            cmd.Parameters.AddWithValue("@Class", textBox3.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Saved Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(" Data Source=DESKTOP-G3D9FTC; database=SCHOOLDB; integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Table_5", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable Table_5 = new DataTable();
            da.Fill(Table_5);
            dataGridView1.DataSource = Table_5;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(" Data Source=DESKTOP-G3D9FTC; database=SCHOOLDB; integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("update Table_5 set Studentname = @Studentname, Class = @Class where Classid = @Classid", con);
            cmd.Parameters.AddWithValue("@Classid", Convert.ToInt32(textBox1.Text));
            cmd.Parameters.AddWithValue("@Studentname", textBox2.Text);
            cmd.Parameters.AddWithValue("@Class", textBox3.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Updated Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(" Data Source=DESKTOP-G3D9FTC; database=SCHOOLDB; integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete Table_5 where Classid = @Classid", con);
            cmd.Parameters.AddWithValue("@Classid", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted Successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(" Data Source=DESKTOP-G3D9FTC; database=SCHOOLDB; integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Table_5", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable Table_5 = new DataTable();
            da.Fill(Table_5);
            dataGridView1.DataSource = Table_5;
        }
    }
}
