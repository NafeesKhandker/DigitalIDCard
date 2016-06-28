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
using BOL;

namespace Digital_Attendance
{
    public partial class AssignCourse : Form
    {
        Operations oper = new Operations();
        string comboIDValue = "";
        string comboCourseValue = "";

        public AssignCourse()
        {
            InitializeComponent();
            valmsgStdID.Visible = false;
            valmsgCourseCode.Visible = false;

            SqlDataReader DRStudentID = oper.GetStudentID();
            while (DRStudentID.Read())
            {
                comboBoxStdID.Items.Add(DRStudentID[0]);
            }
            DRStudentID.Close();

            SqlDataReader DRCourses = oper.GetCourses();
            while (DRCourses.Read())
            {
                comboBoxCourseName.Items.Add(DRCourses[0]);
            }
            DRCourses.Close();
        }


        private void AssignCourse_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxStdID_SelectedValueChanged(object sender, EventArgs e)
        {
            comboIDValue = ((sender as ComboBox).SelectedItem as string);
            valmsgStdID.Visible = false;
        }

        private void comboBoxCourseName_SelectedValueChanged(object sender, EventArgs e)
        {
            comboCourseValue = ((sender as ComboBox).SelectedItem as string);
            valmsgCourseCode.Visible = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboIDValue == "")
            {
                valmsgStdID.Visible = true;
            }
            else
            {
                valmsgStdID.Visible = false;
            }
            if (comboCourseValue == "")
            {
                valmsgCourseCode.Visible = true;
            }
            else
            {
                valmsgCourseCode.Visible = false;
            }
            if ((comboIDValue != "") && (comboCourseValue != ""))
            {
                if (oper.HasCourseAssigned(comboIDValue, comboCourseValue))
                {
                    MessageBox.Show("This Course is Already Recorded!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int flag = oper.AssaignCourse(comboIDValue, comboCourseValue);
                    if (flag > 0)
                    {
                        MessageBox.Show("Course Assigned Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Faild to Assign Course!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            ShowAssignedCourses showgui = new ShowAssignedCourses();
            showgui.ShowDialog();
        }
    }
}
