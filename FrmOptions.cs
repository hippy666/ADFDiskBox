using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Management;
using System.Management.Instrumentation;
using System.Collections;

namespace ADFDiskBox
{
    public partial class FrmOptions : Form
    {
        public FrmOptions()
        {
            InitializeComponent();
        }

        private void btnRescan_Click(object sender, EventArgs e)
        {
            // Get a list of serial port names.
            string[] ports = SerialPort.GetPortNames();

            MessageBox.Show("The following serial ports were found:");

            // Display each port name

            cboComPort.Items.Clear();

            if (ports.Length != 0)
            {
                foreach (string port in ports)
                {

                    MessageBox.Show(port);
                    cboComPort.Items.Add(port);
                    cboComPort.SelectedIndex = cboComPort.Items.Count - 1;
                }
            }
        }

        private void BtnCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLoadSettings_Click(object sender, EventArgs e)
        {
            //frmMainForm.tester
            //Checkexists();
            //LoadINI(INIPath.Text);
        }

        private void btnGwinfo_Click(object sender, EventArgs e)
        {
            string device;
            device = "--device=" + cboComPort.Text;

            string arg = "/K gw info " + device;

            //////////////////////////////////////////////////////////////////////////////////////////////////////

            ClearlbOutput();
            ClearlbErrorOutput();

            var proc = new Process
            {
                EnableRaisingEvents = true,
                StartInfo = new ProcessStartInfo
                {
                    WorkingDirectory = txtGwtext.Text,
                    Arguments = arg,
                    FileName = "C:\\WINDOWS\\SYSTEM32\\cmd.exe",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true
                }
            };

            prgProgressBar1.Value = 0;

            proc.ErrorDataReceived += new DataReceivedEventHandler(process_OutputDataReceived);
            proc.OutputDataReceived += new DataReceivedEventHandler(process_OutputDataReceived);

            try
            {
                proc.Start();
                //ChooserForm.m_ProcessId = proc.Id;


                proc.BeginErrorReadLine();
                proc.BeginOutputReadLine();

                //proc.WaitForExit();
                proc.Close();
            }

            catch (Exception error)
            {
                string sMessage = error.Message.ToString();

                ErrorReporter(sMessage);


            }
            /////////////////////////////////////////////////////////////////////////////////////////////////////

        }
    }
}
