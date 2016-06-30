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
    public partial class Add_Course : Form
    {
        public Courses c = new Courses();

        public Operations op = new Operations();

        public Add_Course()
        {
            InitializeComponent();
            hideValidationMessages();
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            c.course_name = validateC_NAME(tbCourseName.Text);
            c.course_code = validateC_CODE(tbCourseCode.Text);
            c.password = validateC_Password(tbPassword.Text);

            if (valmsgC_Name.Visible || valmsgC_Code.Visible)
            {

            }
            else
            {
                int flag = op.insertCourse(c);
                if (flag > 0)
                    MessageBox.Show("Saved Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if(flag == -1)
                    MessageBox.Show("The course is already enlisted or the password is already assigned for another course!", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Failed to Save Information!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string validateC_NAME(string text)
        {
            string result = "";
            if (text == "")
            {
                valmsgC_Name.Text = "This Field is Required";
                valmsgC_Name.Visible = true;
                return result;
            }
            else
            {
                valmsgC_Name.Visible = false;
                return result = text;
            }
        }

        private string validateC_CODE(string text)
        {
            if (text == "")
            {
                valmsgC_Code.Text = "This Field is Required";
                valmsgC_Code.Visible = true;
                return text;
            }
            else
            {
                valmsgC_Code.Visible = false;
                return text;
            }
        }

        private string validateC_Password(string text)
        {
            if(text=="")
            {
                valmsgC_Password.Visible = true;
                return text;
            }
            else
            {
                valmsgC_Password.Visible = false;
                return text;
            }
        }

        private void hideValidationMessages()
        {
            valmsgC_Name.Visible = false;
            valmsgC_Code.Visible = false;
            valmsgC_Password.Visible = false;
        }

        private void combocourseType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void isoptional_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
