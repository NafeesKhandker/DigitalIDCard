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
    public partial class AdminProfile : Form
    {
        string loggedUsername;
        Operations op = new Operations();
        UserProfile up = new UserProfile();

        public AdminProfile(string username)
        {
            InitializeComponent();
            loggedUsername = username;
            loadData();
            ReadOnlyBoxes();
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            if(btnEditProfile.Text != "Update")
            {
                btnEditProfile.Text = "Update";
                giveBackControls();
            }
            else
            {
                MessageBox.Show("Update Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                btnEditProfile.Text = "Edit Profile";
                this.Close();
            }
                      

        }

        void loadData()
        {
            op.setUserName(loggedUsername);
            DataTable dt = new DataTable();
            dt = op.ViewUserProfile(up);

            if (dt.Rows.Count > 0)
            {
                tbFirstName.Text = dt.Rows[0]["first_name"].ToString();
                tbLastName.Text = dt.Rows[0]["last_name"].ToString();
                tbUserName.Text = dt.Rows[0]["user_name"].ToString();
                tbPassword.Text = dt.Rows[0]["password"].ToString();
                rtUserDetails.Text = dt.Rows[0]["user_details"].ToString();
                tbEmail.Text = dt.Rows[0]["email_address"].ToString();
                tbPhone.Text = dt.Rows[0]["contact_phone"].ToString();
                tbMobile.Text = dt.Rows[0]["contact_mobile"].ToString();
                bool status = Convert.ToBoolean(dt.Rows[0]["is_active"]);
                if (status == true)
                    checkIsActive.Checked = true;
                else
                    checkIsActive.Checked = false;

            }
        }

        void ReadOnlyBoxes()
        {
            tbFirstName.ReadOnly = true;
            tbFirstName.BackColor = Color.Lavender;

            tbLastName.ReadOnly = true;
            tbLastName.BackColor = Color.Lavender;

            tbUserName.ReadOnly = true;
            tbUserName.BackColor = Color.Lavender;

            tbPassword.ReadOnly = true;
            tbPassword.BackColor = Color.Lavender;

            rtUserDetails.ReadOnly = true;
            rtUserDetails.BackColor = Color.Lavender;

            tbEmail.ReadOnly = true;
            tbEmail.BackColor = Color.Lavender;

            tbPhone.ReadOnly = true;
            tbPhone.BackColor = Color.Lavender;

            tbMobile.ReadOnly = true;
            tbMobile.BackColor = Color.Lavender;

            checkIsActive.Enabled = false;
        }

        void giveBackControls()
        {
            tbFirstName.ReadOnly = false;
            tbFirstName.BackColor = Color.White;

            tbLastName.ReadOnly = false;
            tbLastName.BackColor = Color.White;

            tbUserName.ReadOnly = false;
            tbUserName.BackColor = Color.White;

            tbPassword.ReadOnly = false;
            tbPassword.BackColor = Color.White;

            rtUserDetails.ReadOnly = false;
            rtUserDetails.BackColor = Color.White;

            tbEmail.ReadOnly = false;
            tbEmail.BackColor = Color.White;

            tbPhone.ReadOnly = false;
            tbPhone.BackColor = Color.White;

            tbMobile.ReadOnly = false;
            tbMobile.BackColor = Color.White;

            checkIsActive.Enabled = true;
        }
    }
}
