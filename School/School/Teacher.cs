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
    public partial class Teacher : Form
    {
        public Teacher()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(" Data Source=DESKTOP-G3D9FTC; database=SCHOOLDB; integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Table_4 values(@Teacherid,@Teachername )", con);
            cmd.Parameters.AddWithValue("@Teacherid", Convert.ToInt32(textBox1.Text));
            cmd.Parameters.AddWithValue("@Teachername", textBox2.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Saved Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(" Data Source=DESKTOP-G3D9FTC; database=SCHOOLDB; integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Table_4", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable Table_4 = new DataTable();
            da.Fill(Table_4);
            dataGridView1.DataSource = Table_4;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(" Data Source=DESKTOP-G3D9FTC; database=SCHOOLDB; integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("update Table_4 set Teachername = @Teachername where Teacherid = @Teacherid", con);
            cmd.Parameters.AddWithValue("@Teacherid", Convert.ToInt32(textBox1.Text));
            cmd.Parameters.AddWithValue("@Teachername", textBox2.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Updated Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(" Data Source=DESKTOP-G3D9FTC; database=SCHOOLDB; integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete Table_4 where Teacherid = @Teacherid", con);
            cmd.Parameters.AddWithValue("@Teacherid", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted Successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(" Data Source=DESKTOP-G3D9FTC; database=SCHOOLDB; integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Table_4", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            SqlCommandBuilder f = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds, "Table_4");

            dataGridView1.DataSource = ds.Tables["Table_4"];
        }
    }
}
