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
        bool isKeypressed = false;
        bool isHashPressed = false;
        string password = "";
        System.Timers.Timer myTimer;

        public AppGUI()
        {
            InitializeComponent();
            pictureBoxStatus.Image = Properties.Resources.StopStatus;
            labelStatus.Text = "KUSmartLog is not running...";
            textBoxPortName.Focus();
        }

        private void labelAppName_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Are you sure you want to stop counting?", "Digital Attendence System", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                case DialogResult.No:
                    break;
                default:
                    serialCom.Close();
                    labelStatus.Text = "KUSmartLog is not running...";
                    pictureBoxStatus.Image = Properties.Resources.StopStatus;
                    MessageBox.Show("KUSmartLog Stopped counting attendence.");                   
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
            serialCom.BaudRate = 115200;
            serialCom.Parity = Parity.None;
            serialCom.DataBits = 8;
            serialCom.StopBits = StopBits.One;

            try
            {
                serialCom.PortName = textBoxPortName.Text;
                serialCom.Open();
                serialCom.WriteLine("");
                labelStatus.Text = "KUSmartLog is running...";
                pictureBoxStatus.Image = Properties.Resources.image_997222;
                MessageBox.Show("KUSmartLog attendance counting started!");
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
                if (isKeypressed == false)
                {
                    InitTimer();
                    isKeypressed = true;
                }

                if (indata.Contains('#'))
                {
                    myTimer.Stop();
                    MessageBox.Show(password);
                    isKeypressed = false;
                    password = "";
                    isHashPressed = true; 
                }

                password += indata.Substring(0, indata.Length - 1);
            }

            else
            {
                //TagID digit
            }
           // indata = indata.Substring(0, indata.Length - 1);
            
            //check if password
            //if (indata.Contains('#'))
            //{
            //    String password = indata.Substring(0, indata.Length - 1);

            //    if (op.IsValidPassword(password))
            //    {
            //        //This password is valid
            //        MessageBox.Show("Found");
            //    }

            //    else
            //    {
            //        //This password is not valid
            //        sp.WriteLine("Invalid Password!");

            //    }
                     
            //}

            //else
            //{
            //    MessageBox.Show("Not a Password");
                
            //}


            this.Invoke((MethodInvoker)delegate
            {
                textBoxEntry.AppendText("Data Received.\n");
                textBoxEntry.AppendText(indata + "\n");
            });


            if (String.Equals(indata, "160975869190"))
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    textBoxEntry.AppendText("Matched! \n");
                }));
                sp.WriteLine("Matched");


            }
            else
            {
                sp.WriteLine("");
            }

        }

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

        public void InitTimer()
        {
            myTimer = new System.Timers.Timer();
            // Tell the timer what to do when it elapses
            myTimer.Elapsed += new ElapsedEventHandler(myEvent);
            // Set it to go off every five seconds
            myTimer.Interval = 10000;
            // And start it        
            myTimer.Enabled = true;
        }

        private void myEvent(object source, ElapsedEventArgs e)
        {
            if (isHashPressed == false)
            {
                System.Timers.Timer mTimer = (System.Timers.Timer)source;
                mTimer.Close();
                MessageBox.Show("Timedout");
                password = "";
                serialCom.WriteLine("Session Timedout!");
            }
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
