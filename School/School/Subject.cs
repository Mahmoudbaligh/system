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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace School
{
    public partial class Subject : Form
    {
        public Subject()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(" Data Source=DESKTOP-G3D9FTC; database=SCHOOLDB; integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete Table_3 where Subjectid = @Subjectid", con);
            cmd.Parameters.AddWithValue("@Subjectid", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted Successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(" Data Source=DESKTOP-G3D9FTC; database=SCHOOLDB; integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("update Table_3 set Subjectname = @Subjectname where Subjectid = @Subjectid", con);
            cmd.Parameters.AddWithValue("@Subjectid", Convert.ToInt32(textBox1.Text));
            cmd.Parameters.AddWithValue("@Subjectname", textBox2.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Updated Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(" Data Source=DESKTOP-G3D9FTC; database=SCHOOLDB; integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Table_3 values(@Subjectid,@Subjectname )", con);
            cmd.Parameters.AddWithValue("@Subjectid", Convert.ToInt32(textBox1.Text));
            cmd.Parameters.AddWithValue("@Subjectname", textBox2.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Saved Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(" Data Source=DESKTOP-G3D9FTC; database=SCHOOLDB; integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Table_3", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable Table_3 = new DataTable();
            da.Fill(Table_3);
            dataGridView1.DataSource = Table_3;
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
            SqlCommand cmd = new SqlCommand("select * from Table_3", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            SqlCommandBuilder f = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds, "Table_3");

            dataGridView1.DataSource = ds.Tables["Table_3"];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
