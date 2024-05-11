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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Data.Common;

namespace School
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

        private void Student_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Gender = "";
            if (radioButton1.Checked)
            {
                Gender = radioButton1.Text;
            }
            else
            {
                Gender = radioButton2.Text;
            }
            SqlConnection con = new SqlConnection(" Data Source=DESKTOP-G3D9FTC; database=SCHOOLDB; integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Table_2 values(@Studentid,@Studentname,@Gender,@Phone,@Livingplace )", con);
            cmd.Parameters.AddWithValue("@Studentid", Convert.ToInt32(textBox1.Text));
            cmd.Parameters.AddWithValue("@Studentname", textBox2.Text);
            cmd.Parameters.AddWithValue("@Gender", Gender);
            cmd.Parameters.AddWithValue("@Phone",Convert.ToInt32(textBox4.Text));
            cmd.Parameters.AddWithValue("@Livingplace", textBox6.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Saved Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(" Data Source=DESKTOP-G3D9FTC; database=SCHOOLDB; integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Table_2", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable Table_2 = new DataTable();
            da.Fill(Table_2);
            dataGridView1.DataSource = Table_2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Gender = "";
            if (radioButton1.Checked)
            {
                Gender = radioButton1.Text;
            }
            else
            {
                Gender = radioButton2.Text;
            }
            SqlConnection con = new SqlConnection(" Data Source=DESKTOP-G3D9FTC; database=SCHOOLDB; integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("update Table_2 set Studentname = @Studentname, Gander = @Gander, Phone = @Phone, Livingplace = @Livingplace where Studentid = @Studentid", con);
            cmd.Parameters.AddWithValue("@Studentid", Convert.ToInt32(textBox1.Text));
            cmd.Parameters.AddWithValue("@Studentname", textBox2.Text);
            cmd.Parameters.AddWithValue("@Gander", Gender);
            cmd.Parameters.AddWithValue("@Phone", Convert.ToInt32 (textBox4.Text));
            cmd.Parameters.AddWithValue("@Livingplace", textBox6.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Updated Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(" Data Source=DESKTOP-G3D9FTC; database=SCHOOLDB; integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete Table_2 where Studentid = @Studentid", con);
            cmd.Parameters.AddWithValue("@Studentid", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted Successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false; ;
            textBox4.Text = "";
            textBox6.Text = "";


        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(" Data Source=DESKTOP-G3D9FTC; database=SCHOOLDB; integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Table_2", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            SqlCommandBuilder x = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds, "Table_2");

            dataGridView1.DataSource = ds.Tables["Table_2"];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}