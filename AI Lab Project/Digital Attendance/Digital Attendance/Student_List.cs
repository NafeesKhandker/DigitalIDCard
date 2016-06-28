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
    public partial class Student_List : Form
    {
        public Operations op = new Operations();
        public StudentInformations sf = new StudentInformations();
        public Student_List()
        {
            InitializeComponent();
        }

        private void Student_List_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = op.ViewStudents(sf);
            studentsData.DataSource = dt;
        }
    }
}
