using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Timers;
using BOL;

namespace Digital_Attendance
{
    public partial class AppGUI : Form
    {
        SerialPort serialCom = new SerialPort();
        Operations op = new Operations();
        string password = "";
        string runningCourse = "";

        public AppGUI()
        {
            InitializeComponent();
            pictureBoxStatus.Image = Properties.Resources.StopStatus;
            labelStatus.Text = "KUSmartLog is not running...";
            textBoxPortName.Focus();
            
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
        
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Are you sure you want to stop counting?", "KUSmartLog", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                case DialogResult.No:
                    break;
                default:
                    serialCom.Close();
                    labelStatus.Text = "KUSmartLog is not running...";
                    pictureBoxStatus.Image = Properties.Resources.StopStatus;
                    MessageBox.Show("KUSmartLog has stopped counting attendence.", "KUSmartLog Stopped", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Are you sure you want to exit?", "Digital Attendence System", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                case DialogResult.No:
                    break;
                default:
                    serialCom.Close();
                    Application.ExitThread();
                    break;
            }

            //Application.Exit();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            serialCom.BaudRate = 9600;
            serialCom.Parity = Parity.None;
            serialCom.DataBits = 8;
            serialCom.StopBits = StopBits.One;

            try
            {
                serialCom.PortName = textBoxPortName.Text;
                serialCom.Open();
                labelStatus.Text = "KUSmartLog is running...";
                pictureBoxStatus.Image = Properties.Resources.image_997222;
                MessageBox.Show("KUSmartLog attendance counting started!", "KUSmartLog Started", MessageBoxButtons.OK, MessageBoxIcon.Information);
                serialCom.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

            }
            catch (Exception)
            {

                MessageBox.Show("The port name you have entered is not valid! \nTroubleshooting: \n1. Try with different port name such as 'COM5', 'COM6', etc. \n2. Check if the letters are in uppercase. \n3. Check if the hardware is connected to the serial port of the computer.", "Access Denied!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        public void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadLine();

            if (indata.Length == 2)
            {
                //Single digit pressed
                if (indata.Contains('#'))
                {
                    if (op.IsValidPassword(password))
                    {
                        //This password is valid
                        string courseCode = op.GetCourseCodeByPW(password);

                        if (runningCourse.Equals(""))
                        {
                            sp.WriteLine(op.GetCourseNameByPW(password) + " --> Started!");
                            runningCourse = courseCode;
                        }
                        else
                        {
                            if (runningCourse.Equals(courseCode))
                            {
                                sp.WriteLine(op.GetCourseNameByPW(password) + " --> Ended!");
                                runningCourse = "";
                            }
                            else
                            {
                                sp.WriteLine("Sorry! Another  course is running now.#");
                            }
                        }
                    }
                    else
                    {
                        //this password is not valid
                        sp.WriteLine("Invalid password!#");
                    }
                    password = "";
                }
                else
                    password += indata.Substring(0, indata.Length - 1);
            }

            else
            {
                //TagID digit
                indata = indata.Substring(0, indata.Length - 1);

                if (!runningCourse.Equals(""))
                {
                    if (op.IsAssignedToThisCourse(indata, runningCourse))
                    {
                        int flag = op.TakeAttendance(indata, runningCourse);
                        if (flag > 0)
                        {
                            sp.WriteLine("Attandance counted!");

                            this.Invoke((MethodInvoker)delegate
                            {
                                DataTable dtable = op.ViewAttendenceToday();
                                dataGVLog.Rows.Clear();
                                foreach (DataRow item in dtable.Rows)
                                {
                                    int n = dataGVLog.Rows.Add();
                                    dataGVLog.Rows[n].Cells[0].Value = item["student_id"].ToString();
                                    dataGVLog.Rows[n].Cells[1].Value = item["course_code"].ToString();
                                    dataGVLog.Rows[n].Cells[2].Value = item["attendence_date"].ToString();
                                    dataGVLog.Rows[n].Cells[3].Value = item["is_present"].ToString();
                                }
                            });
                        }
                        else
                            sp.WriteLine("Duplicate entry!Attendance already counted!#");
                    }

                    else
                    {
                        sp.WriteLine("Sorry! You are  not assigned to this course!#");
                    }
                }

                else
                {
                    sp.WriteLine("Sorry! No courseis running now!#");
                }

            }

        }


        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            switch (MessageBox.Show("Are you sure you want to exit?", "KUSmartLog", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                default:
                    int flag = op.DeleteAllDynamicCourses();
                    Application.ExitThread();
                    break;
            }
        }

    }
}
