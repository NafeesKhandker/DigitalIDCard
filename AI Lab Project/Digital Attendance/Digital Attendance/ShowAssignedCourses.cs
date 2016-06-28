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
using System.Data.SqlClient;

namespace Digital_Attendance
{
    public partial class ShowAssignedCourses : Form
    {
        Operations op = new Operations();
        string comboIDValue = "";

        public ShowAssignedCourses()
        {
            InitializeComponent();
            DataTable dtable = op.ViewAllAssignedCourses();
            UpdateGridView(dtable);

            SqlDataReader DRStudentID = op.GetStudentID();
            while (DRStudentID.Read())
            {
                cmbBoxStdID.Items.Add(DRStudentID[0]);
            }
            DRStudentID.Close();

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dbGridAssignedCrs.Rows)
            {
                if (bool.Parse(item.Cells[0].Value.ToString()))
                {
                    int flag = op.DeleteAssignedCourses(item.Cells[1].Value.ToString(), item.Cells[2].Value.ToString());
                    if (flag > 0)
                    {
                        MessageBox.Show("Successfully Deleted!");
                        DataTable Dtable = op.ViewByIDAssignedCourses(comboIDValue);
                        UpdateGridView(Dtable);
                    }
                    else
                    {
                        MessageBox.Show("Could Not Delete!");
                    }
                }
            }

        }

        private void cmbBoxStdID_SelectedValueChanged(object sender, EventArgs e)
        {
            comboIDValue = ((sender as ComboBox).SelectedItem as string);

            if (comboIDValue != "")
            {
                DataTable Dtable = op.ViewByIDAssignedCourses(comboIDValue);
                UpdateGridView(Dtable);
            }
        }

        private void UpdateGridView(DataTable dt)
        {
            dbGridAssignedCrs.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dbGridAssignedCrs.Rows.Add();
                dbGridAssignedCrs.Rows[n].Cells[0].Value = false;
                dbGridAssignedCrs.Rows[n].Cells[1].Value = item["student_id"].ToString();
                dbGridAssignedCrs.Rows[n].Cells[2].Value = item["course_id"].ToString();
            }
        }

    }
}
