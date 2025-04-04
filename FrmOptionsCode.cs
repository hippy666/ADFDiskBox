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
                settings = lineOutput.Split('T', '.', ':', 'A');

                if (settings.Length > 1)
                {

                    //it exists
                    track = settings[1];

                    bool result = int.TryParse(track, out intTrackno); //intTrackno now an int 
                    if (result == true)
                    {

                        if (intTrackno >= 0 && intTrackno <= 81)
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

        public string Checkexists()
        {
            string ADFDiskBoxINI = "ADFDiskbox.ini";

            string path = Directory.GetCurrentDirectory();
            //MessageBox.Show(string.Format("current directory {0}", path));

            string fullpath = path + "\\" + ADFDiskBoxINI;

            string defs = path + "\\" + "Jdiskdefs.cfg";
            txtDiskdefs.Text = defs;

            //check adfdiskbox ini exists
            //MessageBox.Show(string.Format(fullpath));

            if (File.Exists(fullpath))
            {
                //MessageBox.Show(string.Format("File {0} at path {1} Exists", fullpath, path));
                txtDiag.Text = string.Format("File {0} at path {1} Exists", fullpath, path);
                INIPath.Text = fullpath;

                LoadINI(fullpath);
                return fullpath;
            }

            else
            {
                //MessageBox.Show(string.Format("File {0} at path {1} Did Not Exist", fullpath, path));
                string smessage = string.Format("ini File {0} at path {1} Did Not Exist", fullpath, path);

                ErrorReporter(smessage);

                string[] LegalCrap = new string[]
                { "Software License."+"\n\n"+

                "MIT License"+ "\n\n" +

                "Copyright(c) 2024 John Brett" + "\n\n" +

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

                INIPath.Text = fullpath;

                txtGwtext.Text = " ";
                INIPath.Text = fullpath;
                txtDiskdefs.Text = defs;
                lblFileName.Text = "last file.adf";
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
                        txtGwtext.Text = folderDlg.SelectedPath;
                        Environment.SpecialFolder root = folderDlg.RootFolder;
                        SaveINI(INIPath.Text);

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
                        txtGwtext.Text = settings[0];
                        INIPath.Text = settings[1];
                        txtDiskdefs.Text = settings[2];
                        lblFileName.Text = settings[3];
                        cboTrackCombo.Text = settings[4];
                        cboType.Text = settings[5];
                        cboRetries.Text = settings[6];

                        cboNumberOfDisks.Text = settings[7];
                        cboDriveSelect.Text = settings[8];




                        string iniContents = string.Format("loading ini contents {0},{1},{2},{3},{4},{5},{6},{7},{8},{9}", txtGwtext.Text, INIPath.Text, txtDiskdefs.Text, lblFileName.Text, cboTrackCombo.Text, cboType.Text, cboRetries.Text, cboNumberOfDisks.Text, cboDriveSelect.Text, cboComPort.Text);

                        //testing
                        //MessageBox.Show(string.Format(" Load settings {0}", iniContents));
                        string esettings = string.Format(" Loaded settings {0}", iniContents);
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


                    string settings = string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}", txtGwtext.Text, INIPath.Text, txtDiskdefs.Text, lblFileName.Text, cboTrackCombo.Text, cboType.Text, cboRetries.Text, cboNumberOfDisks.Text, cboDriveSelect.Text, cboComPort.Text);
                    //frmMainForm.frmMain.StxtDiskdefs = "trash";
                    //MessageBox.Show(string.Format(" SaveINI settings {0},{1},{2},{3},{4},{5},{6},{7},{8}", txtGwtext.Text, INIPath.Text, txtDiskdefs.Text, lblFileName.Text, cboTrackCombo.Text, cboType.Text, cboRetries.Text, cboNumberOfDisks.Text, cboDriveSelect.Text));

                    frmMainForm.frmMain.StxtGwtext = txtGwtext.Text;
                    frmMainForm.frmMain.SINIPath = INIPath.Text;
                    frmMainForm.frmMain.StxtDiskdefs = txtDiskdefs.Text;
                    frmMainForm.frmMain.lblFileName.Text = lblFileName.Text;
                    frmMainForm.frmMain.cboTrackCombo.Text = cboTrackCombo.Text;
                    frmMainForm.frmMain.cboType.Text = cboType.Text;
                    frmMainForm.frmMain.cboRetries.Text = cboRetries.Text;
                    frmMainForm.frmMain.cboNumberOfDisks.Text = cboNumberOfDisks.Text;
                    frmMainForm.frmMain.cboDriveSelect.Text = cboDriveSelect.Text;

                    sw.WriteLine(settings);

                    //MessageBox.Show(string.Format(" INI File Saved: {0}", settings));
                    string sMessage = string.Format(" INI File Saved: {0}", settings);

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

    }
}
