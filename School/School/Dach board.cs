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
    public partial class Dach_board : Form
    {
        public Dach_board()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
           
        }
        private void display()
        {
            SqlConnection con = new SqlConnection(" Data Source=DESKTOP-G3D9FTC; database=SCHOOLDB; integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Table_4", con);
            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
            {
                lblCount2.Text = Convert.ToString(count.ToString());
            }
            else
            {
                lblCount2.Text = "0";
            }

            con.Close();
        }

        private void Dach_board_Load(object sender, EventArgs e)
        {
            display();
            display1();
            display2();
            display3();
        }
        private void display1()
        {
            SqlConnection con = new SqlConnection(" Data Source=DESKTOP-G3D9FTC; database=SCHOOLDB; integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Table_2", con);
            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
            {
                lblCount1.Text = Convert.ToString(count.ToString());
            }
            else
            {
                lblCount1.Text = "0";
            }

            con.Close();
        }
        private void display2()
        {
            SqlConnection con = new SqlConnection(" Data Source=DESKTOP-G3D9FTC; database=SCHOOLDB; integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Table_5", con);
            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
            {
                lblCount3.Text = Convert.ToString(count.ToString());
            }
            else
            {
                lblCount3.Text = "0";
            }

            con.Close();
        }
        private void display3()
        {
            SqlConnection con = new SqlConnection(" Data Source=DESKTOP-G3D9FTC; database=SCHOOLDB; integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Table_6", con);
            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
            {
                lblCount4.Text = Convert.ToString(count.ToString());
            }
            else
            {
                lblCount4.Text = "0";
            }

            con.Close();
        }
    }
}
