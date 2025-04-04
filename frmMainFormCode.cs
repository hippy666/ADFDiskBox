using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ADFDiskBox
{
    //[System.ComponentModel.DesignerCategory("code")] 

    public partial class frmMainForm : Form
    {
        public void Tester()
        {
            MessageBox.Show("Fucking thing");
        }

        private void ErrorReporter(string sMessage)
        {
            /* error reporter */

            //string sMessage = error.Message.ToString();

            //ClearlbErrorOutput(); clear the listbox ....

            string report = string.Format("{0}", sMessage);
            txtDiag.Text = report;

            lbErrors.Items.Add("the following event has occured");
            lbErrors.SelectedIndex = lbErrors.Items.Count - 1;

            lbErrors.Items.Add(report);
            lbErrors.SelectedIndex = lbErrors.Items.Count - 1;

            txtDiag.Text = report;

            /* end of error reporter */
        }
        private void ClearlbOutput()
        {
            if (lbOutput.InvokeRequired)
            {
                lbOutput.Invoke((MethodInvoker)delegate
                {
                    // Running on the UI thread
                    lbOutput.Items.Clear();
                });
            }
            else
            {
                lbOutput.Items.Clear();
            }
        }

        private void ClearlbErrorOutput()
        {
            if (lbErrors.InvokeRequired)
            {
                lbErrors.Invoke((MethodInvoker)delegate
                {
                    // Running on the UI thread
                    lbErrors.Items.Clear();
                });
            }
            else
            {
                lbErrors.Items.Clear();
            }
        }

        void process_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
     
            if (null != e.Data)
            {
                UpdatelbOutput(e.Data);
            }
        }

        void process_ErrorDatarecieved(object sender, DataReceivedEventArgs err)
        {
            if (null !=err.Data)
            {
                UpdatelbErrors(err.Data);
            }
        }

        private void UpdatelbOutput(string lineOutput)
        {
            if (lbOutput.InvokeRequired)
            {
                lbOutput.Invoke((MethodInvoker)delegate
                {
                    // Running on the UI thread
                    lbOutputDoUpdate(lineOutput);
                });
            }
            else
            {
                lbOutputDoUpdate(lineOutput);
            }
        }

        private void UpdatelbErrors(string ErrorOutput)
        {
            if(lbErrors.InvokeRequired)
            {
                lbErrors.Invoke((MethodInvoker)delegate
                {
                    // Running on the UI thread
                    lbErrorsDoUpdate(ErrorOutput);
                });
            }
            else
            {
                lbErrorsDoUpdate(ErrorOutput);
            }
        }

        private void lbErrorsDoUpdate(string ErrorOutput)
        {
            lbErrors.Items.Add(ErrorOutput);
            lbErrors.SelectedIndex = lbErrors.Items.Count - 1;

        }

        private void lbOutputDoUpdate(string lineOutput)
        {
            lbOutput.Items.Add(lineOutput);
            lbOutput.SelectedIndex = lbOutput.Items.Count - 1;

            string track;
            int intTrackno = 0;

            if (string.IsNullOrEmpty(lineOutput))
            {
                txtTrackNo.Text = "";
                txtSide.Text = "";
            }
            else
            {
                string[] settings = new string[3]; 
                settings=lineOutput.Split('T', '.', ':','A');

                if (settings.Length > 1)
                {

                    //it exists
                    track = settings[1];

                    bool result = int.TryParse(track, out intTrackno); //intTrackno now an int 
                    if (result == true)
                    {

                        if( intTrackno>=0 && intTrackno<=81)
                        {
                            txtTrackNo.Text = track;

                            string tracknostr = Convert.ToString(intTrackno);
                            txtSide.Text = settings[2];
                            //progress bar stuff
                            prgProgressBar1.PerformStep();
                        }

                    }


                }
            }
        }
       


        delegate void UpdateProgressCallback();

        private void DoUpdate()
        {
            prgProgressBar1.PerformStep();
        }

        private void DoSomethingLengthy(UpdateProgressCallback updateProgress)
        {
            int duration = 82;
            int intervals = 1;
            int updateInterval = duration / intervals;

            for (int i = 0; i <= intervals; i++)
            {
                Thread.Sleep(updateInterval);

                updateProgress();
            }
        }



        private void ADF2DISK()
        {
            openFileDialog1.FileName = "";
            openFileDialog1.InitialDirectory = "c:\\";

            openFileDialog1.Filter = "Amiga ADF only|*.adf";
            // testing.....
            openFileDialog1.ShowReadOnly = true;
            openFileDialog1.ReadOnlyChecked = true;
            //
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                var fileContent = string.Empty;
                var filePath = string.Empty;

                //Get the path of specified file
                filePath = openFileDialog1.FileName;
                lblFileName.Text = filePath;

               

                string diskformat = "";
                int SelectedTracks = cboTrackCombo.SelectedIndex;

                switch (SelectedTracks)
                {
                    case 0:
                        //NoOfTracks = "--tracks=c=0-79:h=0-1 ";
                        diskformat=" --format=amiga.amigados ";
                        break;
                    case 1:
                        //NoOfTracks = "--tracks=c=0-81:h=0-1 ";
                        diskformat = " --format=amiga.amigados.plus ";
                        break;
                    default:
                        //NoOfTracks = "--tracks=c=0-79:h=0-1 ";
                        diskformat = " --format=amiga.amigados ";
                        break;
                }

                string NoOfRetries = "--retries=" + cboRetries.SelectedIndex+" ";

                string driveselect;
                if (cboDriveSelect.SelectedIndex == 0)
                {
                    driveselect = "--drive=A";
                }
                else
                {
                    driveselect = "--drive=B";
                }

                string device;
                device = "--device=" + cboComPort.Text;


                //MessageBox.Show(driveselect);

                string arg = "/K " + "gw write " + device+" "+driveselect+" "+" --diskdefs " + "\"" + StxtDiskdefs + "\"" + diskformat + " " + NoOfRetries +" "+ "\"" + filePath + "\"";

                //MessageBox.Show(arg);

                ClearlbOutput();
                ClearlbErrorOutput();

                var proc = new Process
                {
                    EnableRaisingEvents = true,
                    StartInfo = new ProcessStartInfo
                    {
                        WorkingDirectory = StxtGwtext,
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
            }
            else
            {
                string sMessage = "could not write That adf files no good try again";
                ErrorReporter(sMessage);

                return;
            }
        }


        private void DISK2ADF()
        {
            saveFileDialog1.FileName = "";
            saveFileDialog1.InitialDirectory = "c:\\";
            saveFileDialog1.Filter = "Amiga ADF only|*.adf";
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                var fileContent = string.Empty;
                var filePath = string.Empty;

                //Get the path of specified file
                filePath = saveFileDialog1.FileName;
                lblFileName.Text = filePath;

                
                string diskformat = "";
                //string NoOfTracks = "";
                int SelectedTracks = cboTrackCombo.SelectedIndex;

                switch (SelectedTracks)
                {

                    case 0:
                        //NoOfTracks = "--tracks=c=0-79:h=0-1 ";
                        diskformat = " --format=amiga.amigados ";
                        break;
                    case 1:
                        //NoOfTracks = "--tracks=c=0-81:h=0-1 ";
                        diskformat = " --format=amiga.amigados.plus ";
                        break;
                    default:
                        //NoOfTracks = "--tracks=c=0-79:h=0-1 ";
                        diskformat = " --format=amiga.amigados ";
                        break;
                }

                string NoOfRetries = " --retries=" + cboRetries.SelectedIndex;

                string driveselect;
                if (cboDriveSelect.SelectedIndex == 0)
                {
                    driveselect = "--drive=A";
                }
                else
                {
                    driveselect = "--drive=B";
                }




                string device;
                device = "--device=" + cboComPort.Text;
                
                //MessageBox.Show(driveselect);

                string arg = "/K " + "gw read " + device + " "+driveselect+" --diskdefs " + "\"" + StxtDiskdefs + "\"" + diskformat + " " + NoOfRetries + " " + "\"" + filePath + "\"";


                //MessageBox.Show(arg);
                //startInfo.Arguments = arg;


                ClearlbOutput();
                ClearlbErrorOutput();

                var proc = new Process
                {
                    EnableRaisingEvents = true,
                    StartInfo = new ProcessStartInfo
                    {
                        WorkingDirectory = StxtGwtext,
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


                    proc.BeginErrorReadLine();
                    proc.BeginOutputReadLine();

                    proc.Close();
                }

                catch (Exception error)
                {
                    string sMessage = error.Message.ToString();
                    ErrorReporter(sMessage);
                }
            }

            else
            {
                string sMessage="could not save That adf try again";
                ErrorReporter(sMessage);
            }
        }
                

                
            

        

        private void SCP2DISK()
        {
            openFileDialog1.FileName = "";
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Amiga SCP only|*.scp";
            openFileDialog1.RestoreDirectory = true;
            // testing.....
            openFileDialog1.ShowReadOnly = true;
            openFileDialog1.ReadOnlyChecked = true;
            //
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
               
                var fileContent = string.Empty;
                var filePath = string.Empty;

                //Get the path of specified file
                filePath = openFileDialog1.FileName;
                lblFileName.Text = filePath;

               

                string diskformat = "";
                //string NoOfTracks = "";
                int SelectedTracks = cboTrackCombo.SelectedIndex;

                switch (SelectedTracks)
                {

                    case 0:
                        //NoOfTracks = "--tracks=c=0-79:h=0-1 ";
                        diskformat = " --format=amiga.amigados ";
                        break;
                    case 1:
                        //NoOfTracks = "--tracks=c=0-81:h=0-1 ";
                        diskformat = " --format=amiga.amigados.plus ";
                        break;
                    default:
                        //NoOfTracks = "--tracks=c=0-79:h=0-1 ";
                        diskformat = " --format=amiga.amigados ";
                        break;
                }

                string NoOfRetries = "--retries=" + cboRetries.SelectedIndex;

                string driveselect;
                if (cboDriveSelect.SelectedIndex == 0)
                {
                    driveselect = "--drive=A";
                }
                else
                {
                    driveselect = "--drive=B";
                }

                //MessageBox.Show(driveselect);

                string device;
                device = "--device=" + cboComPort.Text;

                string arg = "/K " + "gw write " +device + " " + driveselect + " --diskdefs " + "\"" + StxtDiskdefs + "\"" + diskformat + " " + NoOfRetries + " " + "\"" + filePath + "\"";



                //if doing scp you will need to add mydisk.scp::disktype=amiga directly

                //startInfo.Arguments = arg;
                //MessageBox.Show(arg);

                ClearlbOutput();
                ClearlbErrorOutput();

                var proc = new Process
                {
                    EnableRaisingEvents = true,
                    StartInfo = new ProcessStartInfo
                    {
                        WorkingDirectory = StxtGwtext,
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


                    proc.BeginErrorReadLine();
                    proc.BeginOutputReadLine();

                    proc.Close();
                }

                catch (Exception error)
                {
                        string sMessage = error.Message.ToString();
                        ErrorReporter(sMessage);
                }
                
            }

            else
            {
                    string sMessage = "could not open That scp file try again";
                    ErrorReporter(sMessage);
            }
        }


        private void RAWSCP2DISK()
        {
            openFileDialog1.FileName = "";
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "SCP only|*.scp";
            openFileDialog1.RestoreDirectory = true;
            // testing.....
            openFileDialog1.ShowReadOnly = true;
            openFileDialog1.ReadOnlyChecked = true;
            //
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var fileContent = string.Empty;
                var filePath = string.Empty;

                //Get the path of specified file
                filePath = openFileDialog1.FileName;
                lblFileName.Text = filePath;

                //MessageBox.Show(filePath + " File selected and opened");

                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.CreateNoWindow = false;
                startInfo.UseShellExecute = false;

                startInfo.FileName = "C:\\WINDOWS\\SYSTEM32\\cmd.exe";
                startInfo.WindowStyle = ProcessWindowStyle.Normal;
                startInfo.WorkingDirectory = StxtGwtext;

                

                string NoOfRetries = "--retries=" + cboRetries.SelectedIndex;

                string driveselect;
                if (cboDriveSelect.SelectedIndex == 0)
                {
                    driveselect = "--drive=A";
                }
                else
                {
                    driveselect = "--drive=B";
                }

                //MessageBox.Show(driveselect);

                // below for raw scp....
                //string arg = "/K " + "gw write " + "\"" + filePath + "::disktype=amiga" + "\"";

                string device;
                device = "--device=" + cboComPort.Text;


                string arg = "/K " + "gw write " + device+" "+ driveselect +" "+"\"" + filePath + "\"";
                //if doing scp you will need to add mydisk.scp::disktype=amiga directly

                startInfo.Arguments = arg;
                //MessageBox.Show(arg);

                ClearlbOutput();
                ClearlbErrorOutput();

                var proc = new Process
                {
                    EnableRaisingEvents = true,
                    StartInfo = new ProcessStartInfo
                    {
                        WorkingDirectory = StxtGwtext,
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

                    proc.BeginErrorReadLine();
                    proc.BeginOutputReadLine();

                    proc.Close();
                }

                catch (Exception error)
                {
                        string sMessage = error.Message.ToString();
                        ErrorReporter(sMessage);
                }
            }

            else
            {
                    string sMessage = "could not open That scp file try again";
                    ErrorReporter(sMessage);
            }
        }

        private void DISK2SCP()
        {
            saveFileDialog1.FileName = "";
            saveFileDialog1.InitialDirectory = "c:\\";
            saveFileDialog1.Filter = "SCP Amiga only|*.scp";
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
                var fileContent = string.Empty;
                var filePath = string.Empty;

                //Get the path of specified file
                filePath = saveFileDialog1.FileName;
                lblFileName.Text = filePath;

                //MessageBox.Show(filePath + " File selected and opened");

                string diskformat = "";
                //string NoOfTracks = "";
                int SelectedTracks = cboTrackCombo.SelectedIndex;

                switch (SelectedTracks)
                {

                    case 0:
                        //NoOfTracks = "--tracks=c=0-79:h=0-1 ";
                        diskformat = " --format=amiga.amigados ";
                        break;
                    case 1:
                        //NoOfTracks = "--tracks=c=0-81:h=0-1 ";
                        diskformat = " --format=amiga.amigados.plus ";
                        break;
                    default:
                        //NoOfTracks = "--tracks=c=0-79:h=0-1 ";
                        diskformat = " --format=amiga.amigados ";
                        break;
                }

                string NoOfRetries = "--retries=" + cboRetries.SelectedIndex;

                string driveselect;
                if (cboDriveSelect.SelectedIndex == 0)
                {
                    driveselect = "--drive=A";
                }
                else
                {
                    driveselect = "--drive=B";
                }

                //MessageBox.Show(driveselect);

                string device;
                device = "--device=" + cboComPort.Text;



                string arg = "/K " + "gw read " + device + " " + driveselect + " --diskdefs " + "\"" + StxtDiskdefs+ "\"" + diskformat + " " + NoOfRetries +" " + "\"" + filePath +"::disktype=amiga" + "\"";

                //MessageBox.Show(arg);

                ClearlbOutput();
                ClearlbErrorOutput();

                var proc = new Process
                {
                    EnableRaisingEvents = true,
                    StartInfo = new ProcessStartInfo
                    {
                        WorkingDirectory = StxtGwtext,
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


                    proc.BeginErrorReadLine();
                    proc.BeginOutputReadLine();

                    proc.Close();
                }

                catch (Exception error)
                {
                    string sMessage = error.Message.ToString();
                    ErrorReporter(sMessage);
                }
  
            }

            else
            {
                    string sMessage = "That scp files no good try again";
                    ErrorReporter(sMessage);
            }
        }

        private void DISK2RAWSCP()
        {
            saveFileDialog1.FileName = "";
            saveFileDialog1.InitialDirectory = "c:\\";
            saveFileDialog1.Filter = "SCP only|*.scp";
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //DISK2ADF GOES HERE
                var fileContent = string.Empty;
                var filePath = string.Empty;

                //Get the path of specified file
                filePath = saveFileDialog1.FileName;
                lblFileName.Text = filePath;

                
                

                string NoOfRetries = "--retries=" + cboRetries.SelectedIndex;

                //if doing scp you will need to add mydisk.scp::disktype=amiga directly
                
                string driveselect;
                if (cboDriveSelect.SelectedIndex == 0)
                {
                    driveselect = "--drive=A";
                }
                else
                {
                    driveselect = "--drive=B";
                }

                //MessageBox.Show(driveselect);
                // below for raw scp....
                string device;
                device = "--device=" + cboComPort.Text;

                //string arg = "/K " + "gw read " + device + " " +driveselect+" "+"\"" + filePath + "::disktype=amiga" + "\"";

                string arg = "/K " + "gw read " + device + " " + driveselect + " " + "\"" + filePath + "\"";

                //startInfo.Arguments = arg;
                //MessageBox.Show(arg);

                ClearlbOutput();
                ClearlbErrorOutput();

                var proc = new Process
                {
                    EnableRaisingEvents = true,
                    StartInfo = new ProcessStartInfo
                    {
                        WorkingDirectory = StxtGwtext,
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


                    proc.BeginErrorReadLine();
                    proc.BeginOutputReadLine();

                    proc.Close();
                }

                catch (Exception error)
                {
                    string sMessage = error.Message.ToString();
                    ErrorReporter(sMessage);
                }

            }

            else
            {
                    string sMessage = "That scp files no good try again";
                    ErrorReporter(sMessage);
            }
        }

        public string Checkexists()
        {
            string ADFDiskBoxINI = "ADFDiskbox.ini";

            string path = Directory.GetCurrentDirectory();
            //MessageBox.Show(string.Format("current directory {0}", path));

            string fullpath = path + "\\" + ADFDiskBoxINI;

            string defs = path + "\\" + "Jdiskdefs.cfg";
            StxtDiskdefs = defs;

            //check adfdiskbox ini exists
            //MessageBox.Show(string.Format(fullpath));

            if (File.Exists(fullpath))
            {
                //MessageBox.Show(string.Format("File {0} at path {1} Exists", fullpath, path));
                txtDiag.Text = string.Format("File {0} at path {1} Exists", fullpath, path);
                SINIPath = fullpath;

                LoadINI(fullpath);
                return fullpath;
            }

            else
            {
                //MessageBox.Show(string.Format("File {0} at path {1} Did Not Exist", fullpath, path));
                string smessage= string.Format("ini File {0} at path {1} Did Not Exist", fullpath, path);

                ErrorReporter(smessage);

                string[] LegalCrap = new string[]
                { "Software License."+"\n\n"+

                "MIT License"+ "\n\n" +

                "Copyright(c) 2025 John Brett" + "\n\n" +

                "Parts from GreasewesalGUI .NET Copyright(c) 2020 Don Mankin"+"\n\n"+

                "Permission is hereby granted, free of charge, to any person obtaining" +"\n"+
                "a copy of this software and associated documentation files"+"\n"+
                "(the "+"\""+"Software"+"\""+"), to deal in the Software without"+"\n"+
                "restriction, including without limitation the rights"+"\n"+
                "to use, copy, modify, merge, publish, distribute, sublicense, and/ or sell"+"\n"+
                "copies of the Software, and to permit persons to whom the Software is"+"\n"+
                "furnished to do so, subject to the following conditions:"+"\n"+

                "\n\n"+
                "The above copyright notice and this permission notice shall be"+"\n"+
                "included in all copies or substantial portions of the Software."+"\n"+
                "\n\n"+

                "THE SOFTWARE IS PROVIDED "+"\""+"AS IS"+"\""+", WITHOUT WARRANTY OF ANY"+"\n"+
                "KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE"+"\n"+
                "WARRANTIES OF MERCHANTABILITY,FITNESS FOR A PARTICULAR"+"\n"+
                "PURPOSE AND NONINFRINGEMENT.IN NO EVENT SHALL THE"+"\n"+
                "\""+"AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,"+"\""+"\n"+
                "DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF"+"\n"+
                "CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN"+"\n"+
                "CONNECTION  WITH THE SOFTWARE OR"+"\n"+
                "THE USE OR OTHER DEALINGS IN THE"+"\""+"SOFTWARE."+"\""
                };


                /* legal shit is for here */
                MessageBox.Show(string.Format("{0}", LegalCrap));


                StxtGwtext = " ";
                SINIPath = fullpath;
                StxtDiskdefs = defs;
                lblFileName.Text = "C:\\temp\\temp.adf";
                cboTrackCombo.Text = "79";
                cboType.Text = "AmigaDos";
                cboRetries.Text = "3";

                cboNumberOfDisks.Text = "5";
                cboDriveSelect.Text = "A";


                FolderBrowserDialog folderDlg = new FolderBrowserDialog();
                folderDlg.ShowNewFolderButton = true;
                folderDlg.ShowNewFolderButton = false;
                folderDlg.Description = "Please Select the greasewesal Folder\nShould Work With Any version\n" +
                "That recognises the diskdefs.cfg file\n";
                // Show the FolderBrowserDialog.  
                DialogResult result = folderDlg.ShowDialog();


                if (result == DialogResult.OK)
                {
                    string exepath = folderDlg.SelectedPath + "\\" + "gw.exe";

                    if (File.Exists(exepath))
                    {
                        StxtGwtext = folderDlg.SelectedPath;
                        Environment.SpecialFolder root = folderDlg.RootFolder;
                        SaveINI(SINIPath);

                        //MessageBox.Show(string.Format("greasewesal software found at {0}", exepath));
                        //txtDiag.Text = string.Format("greasewesal software found at {0}", exepath);
                        ErrorReporter(string.Format("greasewesal software found at {0}", exepath));

                    }

                    else
                    {
                            string sMessage = "That folder does not contain greasewesal software please try again";
                            ErrorReporter(sMessage);
                    }


                }

                else
                {
                        string sMessage = "That folders no good please try again";
                        ErrorReporter(sMessage);
                }

                cboType.Text = "AmigaDos";

                return fullpath;
            }
        }




        public void LoadINI(string path)
        {

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string line = "";
                    //line = sr.ReadLine();

                    line = sr.ReadLine();
                    if (line != null)
                    {
                        string[] settings = line.Split(',');
                        StxtGwtext = settings[0];
                        SINIPath = settings[1];
                        StxtDiskdefs = settings[2];
                        lblFileName.Text = settings[3];
                        cboTrackCombo.Text = settings[4];
                        cboType.Text = settings[5];
                        cboRetries.Text = settings[6];

                        cboNumberOfDisks.Text = settings[7];
                        cboDriveSelect.Text = settings[8];


                        

                        string iniContents = string.Format("loading ini contents {0},{1},{2},{3},{4},{5},{6},{7},{8}", StxtGwtext, SINIPath, StxtDiskdefs, lblFileName.Text, cboTrackCombo.Text, cboType.Text, cboRetries.Text, cboNumberOfDisks.Text, cboDriveSelect.Text);

                        //testing
                        //MessageBox.Show(string.Format(" Load settings {0}", iniContents));
                        string esettings= string.Format(" Loaded settings {0}", iniContents);
                        ErrorReporter(esettings);
                    }
                    sr.Close();
                }
            }

            catch (Exception error)
            {
                string sMessage = error.Message.ToString();
                ErrorReporter(sMessage);
            }
        }

        public void SaveINI(string path)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    //string newline = string.Format("{0},{1},{2},{3},{4}", "greasewesal_path", "tracks_selected", "disk_type", "read_retrys", "last_file");
                    //sw.WriteLine(newline);


                    string settings = string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}", StxtGwtext, SINIPath, StxtDiskdefs, lblFileName.Text, cboTrackCombo.Text, cboType.Text, cboRetries.Text, cboNumberOfDisks.Text, cboDriveSelect.Text, cboComPort.Text);

                    //MessageBox.Show(string.Format(" SaveINI settings {0},{1},{2},{3},{4},{5},{6},{7},{8}", txtGwtext.Text, INIPath.Text, txtDiskdefs.Text, lblFileName.Text, cboTrackCombo.Text, cboType.Text, cboRetries.Text, cboNumberOfDisks.Text, cboDriveSelect.Text));


                    sw.WriteLine(settings);

                    //MessageBox.Show(string.Format(" INI File Saved: {0}", settings));
                    string sMessage=string.Format(" INI File Saved: {0}", settings);

                    ErrorReporter(sMessage);
                    sw.Close();
                }
            }

            catch (Exception error)
            {
                string sMessage = error.Message.ToString();
                ErrorReporter(sMessage);
            }
        }


    }
}
