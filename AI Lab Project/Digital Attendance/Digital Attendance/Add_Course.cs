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
            combocourseType.Items.Add("Theory");
            combocourseType.Items.Add("Lab");
            hideValidationMessages();
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            c.course_name = validateC_NAME(tbCourseName.Text);
            c.course_code = validateC_CODE(tbCourseCode.Text);
            c.course_type_id = validateC_TYPE(combocourseType.Text);
            c.is_optional = IsOption();
            c.is_active = true;

            if (valmsgC_Name.Visible || valmsgC_Code.Visible)
            {

            }
            else
            {
                int flag = op.insertCourse(c);
                if (flag > 0)
                {
                    MessageBox.Show("Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Faild to Save Information", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string validateC_NAME(string text)
        {
            string result = "";
            if (text == "")
            {
                valmsgC_Name.Text = "This Field Required";
                valmsgC_Name.Visible = true;
                return result;
            }
            else
            {
                valmsgC_Name.Visible = false;
                return result = text;
            }
        }

        private int validateC_CODE(string text)
        {
            int code = 0;
            if (text == "")
            {
                valmsgC_Code.Text = "This Field Required";
                valmsgC_Code.Visible = true;
                return code;
            }
            else
            {
                valmsgC_Code.Visible = false;
                return code = Convert.ToInt32(text);
            }
        }

        private int validateC_TYPE(string text)
        {
            int code = 0;
            if (text == "")
            {
                valmsgC_Type.Text = "This Field Required";
                valmsgC_Type.Visible = true;
                return code;
            }
            else
            {
                valmsgC_Type.Visible = false;
                if (text == "Lab")
                    return code = 2;
                else
                    return code = 1;
            }
        }

        private bool IsOption()
        {
            if (isoptional.CheckState.ToString() == "Unchecked")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void hideValidationMessages()
        {
            valmsgC_Name.Visible = false;
            valmsgC_Code.Visible = false;
            valmsgC_Type.Visible = false;
        }

        private void combocourseType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void isoptional_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
