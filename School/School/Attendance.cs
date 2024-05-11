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
    public partial class Attendance : Form
    {
        public Attendance()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(" Data Source=DESKTOP-G3D9FTC; database=SCHOOLDB; integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Table_6", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable Table_6 = new DataTable();
            da.Fill(Table_6);
            dataGridView1.DataSource = Table_6;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string status = "";
            if (radioButton1.Checked)
            {
                status = radioButton1.Text;
            }
            else
            {
                status =    radioButton2.Text;
            }
            SqlConnection con = new SqlConnection(" Data Source=DESKTOP-G3D9FTC; database=SCHOOLDB; integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("update Table_6 set Studentname = @Studentname, Class = @Class where Status = @Status", con);
            cmd.Parameters.AddWithValue("@Aid", Convert.ToInt32(textBox1.Text));
            cmd.Parameters.AddWithValue("@Studentname", textBox2.Text);
            cmd.Parameters.AddWithValue("@Status", status);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Updated Successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(" Data Source=DESKTOP-G3D9FTC; database=SCHOOLDB; integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete Table_6 where Aid = @Aid", con);
            cmd.Parameters.AddWithValue("@Aid", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted Successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
      
   
    }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(" Data Source=DESKTOP-G3D9FTC; database=SCHOOLDB; integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Table_6", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable Table_6 = new DataTable();
            da.Fill(Table_6);
            dataGridView1.DataSource = Table_6;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string status = "";
            if (radioButton1.Checked)
            {
                status = radioButton1.Text;
            }
            else
            {
                status = radioButton2.Text;
            }
            SqlConnection con = new SqlConnection(" Data Source=DESKTOP-G3D9FTC; database=SCHOOLDB; integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Table_6 values(@Aid,@Studentname,@Status )", con);
            cmd.Parameters.AddWithValue("@Aid", Convert.ToInt32(textBox1.Text));
            cmd.Parameters.AddWithValue("@Studentname", textBox2.Text);
            cmd.Parameters.AddWithValue("@Status", status);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Saved Successfully", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
