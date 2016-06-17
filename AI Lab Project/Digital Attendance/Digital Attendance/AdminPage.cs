using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BOL;
using Entity;

namespace Digital_Attendance
{
    public partial class AdminPage : Form
    {
        public string loggedUserName;

        public AdminPage(string username)
        {
            InitializeComponent();    
            loggedUserName = username;
            lblAdmin.Text = "Welcome " + loggedUserName;
            lblAdmin.Visible = true;
        }

        private void btnAdminProfile_Click(object sender, EventArgs e)
        {
            AdminProfile ap = new AdminProfile(loggedUserName);
            ap.ShowDialog();
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            AssignCourse ac = new AssignCourse();
            ac.ShowDialog();
        }

        private void btnShowStudents_Click(object sender, EventArgs e)
        {
            Student_List sl = new Student_List();
            sl.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add_Student addStu = new Add_Student();
            addStu.ShowDialog();
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            Attendance att = new Attendance();
            att.ShowDialog();
        }

        // This Section is for handling close evend with custom message
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            switch (MessageBox.Show("Are you sure you want to exit?", "Digital Attendence System", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                default:
                    Application.ExitThread();
                    break;
            }
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            Add_Course addCo = new Add_Course();
            addCo.ShowDialog();
        }
    }
}
