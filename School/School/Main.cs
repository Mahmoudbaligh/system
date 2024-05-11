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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Class Class = new Class();
            Class.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Subject subject = new Subject();
            subject.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher(); 
            teacher.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Attendance attendance = new Attendance();
            attendance.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Dach_board duty = new Dach_board();
            duty.Show();    
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Logout logout = new Logout();
            logout.Show(); 
        }
    }
}
