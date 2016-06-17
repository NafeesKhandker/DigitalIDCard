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
    public partial class Add_Student : Form
    {
        public StudentInformations si = new StudentInformations();

        public Operations op = new Operations();

        public Add_Student()
        {
            InitializeComponent();
            hideValidationMessages();
            rbMale.Checked = true;
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            si.student_id = validateSID(tbStudentId.Text);
            si.student_RFID = validateRFID(tbRfid.Text);
            si.first_name = validateFName(tbFirstName.Text);
            si.last_name = validateLName(tbLastName.Text);
            if (rbMale.Checked)
                si.gender_id = 1;
            else
                si.gender_id = 2;

            si.contact_mobile = tbContact.Text;
            si.email_address = tbEmail.Text;
            si.is_active = true;

            if(valmsgSID.Visible || valmsgRFID.Visible || valmsgFirstName.Visible || valmsgLastName.Visible)
            {
                
            }
            else
            {
                int flag = op.insertStudentInfo(si);
                if (flag > 0)
                {
                    MessageBox.Show("Saved Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetAll();
                }
                else
                    MessageBox.Show("Faild to Save Information", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void ResetAll()
        {
            tbStudentId.Clear();
            tbRfid.Clear();
            tbFirstName.Clear();
            tbLastName.Clear();
            tbContact.Clear();
            tbEmail.Clear();
        }

        private void hideValidationMessages()
        {
            valmsgSID.Visible = false;
            valmsgRFID.Visible = false;
            valmsgFirstName.Visible = false;
            valmsgLastName.Visible = false;
        }

        private string validateSID(string text)
        {
            string result = "";
            if (text == "")
            {
                valmsgSID.Text = "This Field Required";
                valmsgSID.Visible = true;
                return result;
            }
            else
            {
                valmsgSID.Visible = false;
                return result = text;
            }
        }

        private string validateRFID(string text)
        {
            string result = "";
            if (text == "")
            {
                valmsgRFID.Text = "This Field Required";
                valmsgRFID.Visible = true;
                return result;
            }
            else
            {
                valmsgRFID.Visible = false;
                return result = text;
            }
        }

        private string validateFName(string text)
        {
            string result = "";
            if (text == "")
            {
                valmsgFirstName.Text = "This Field Required";
                valmsgFirstName.Visible = true;
                return result;
            }
            else
            {
                valmsgFirstName.Visible = false;
                return result = text;
            }
        }

        private string validateLName(string text)
        {
            string result = "";
            if (text == "")
            {
                valmsgLastName.Text = "This Field Required";
                valmsgLastName.Visible = true;
                return result;
            }
            else
            {
                valmsgLastName.Visible = false;
                return result = text;
            }
        }

        private void tbStudentId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tbStudentId_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Student_Load(object sender, EventArgs e)
        {

        }

        private void tbRfid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
