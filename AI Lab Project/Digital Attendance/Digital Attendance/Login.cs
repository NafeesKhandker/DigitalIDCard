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
    public partial class Login : Form
    {
        public UserProfile up = new UserProfile();
        public Operations op = new Operations();

        DataTable dt = new DataTable();

        public Login()
        {
            InitializeComponent();
            valmsgUsername.Visible = false;
            valmsgPassword.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            up.username = ValidateUsername(tbUsername.Text);
            up.password = ValidatePassword(tbPassword.Text);

            dt = op.login(up);

            if(valmsgUsername.Visible || valmsgPassword.Visible)
            {

            }
            else
            {
                if (dt.Rows.Count > 0)
                {
                    AdminPage ap = new AdminPage(up.username);
                    ap.loggedUserName = up.username;
                    ap.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Validation For the Username And Password
        string ValidateUsername(string Username)
        {
            if (Username == "")
            {
                valmsgUsername.Visible = true;
                return Username;
            }
            else
            {
                valmsgUsername.Visible = false;
                return Username;
            }
        }

        string ValidatePassword(string Password)
        {
            if (Password == "")
            {
                valmsgPassword.Visible = true;
                return Password;
            }
            else
            {
                valmsgPassword.Visible = false;
                return Password;
            }
        }
    }
}
