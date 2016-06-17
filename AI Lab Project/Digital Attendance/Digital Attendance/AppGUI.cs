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

namespace Digital_Attendance
{
    public partial class AppGUI : Form
    {
        SerialPort serialCom = new SerialPort();
        public AppGUI()
        {
            InitializeComponent();
            pictureBoxStatus.Image = Properties.Resources.StopStatus;
            labelStatus.Text = "KUSmartLog is not running...";
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
                labelStatus.Text = "KUSmartLog is running...";
                pictureBoxStatus.Image = Properties.Resources.image_997222;
                MessageBox.Show("KUSmartLog attendance counting started!");
                
            }
            catch (Exception)
            {

                MessageBox.Show("The port name you have entered is not valid! \nTroubleshooting: \n1. Try with different port name such as 'COM5', 'COM6', etc. \n2. Check if the letters are in uppercase. \n3. The hardware is connected to the serial port of the computer.", "Access Denied!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            serialCom.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
        }

        public void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadLine();

            indata = indata.Substring(0, indata.Length - 1);

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
    }
}
