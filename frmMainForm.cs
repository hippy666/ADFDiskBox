﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
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

namespace ADFDiskBox

{
    public partial class frmMainForm : Form

    {


        public frmMainForm()
        {
            InitializeComponent();

        }



        private void frmMainForm_Load(object sender, EventArgs e)
        {
            INIControl inisettings = new INIControl();

            var INIpath = Checkexists();
            cboNumberOfDisks.SelectedIndex = 1;

            MessageBox.Show("ADF Diskbox version 1.0.0.10" + "\n\n" + "By John Brett"
            + "\n\n" + "this program reads and writes amiga disks"
            + " using the greasewesal v4 hardware and host tools" + "\n\n"
            + "Tested on host tools 1.16.2" + "\n\n"
            + "This is a beta and a work in progress!" + "\n\n");
        }


















        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void readToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selected = cboType.SelectedItem.ToString();
            //MessageBox.Show(selected);
            string tracks = cboTrackCombo.SelectedItem.ToString();

            //MessageBox.Show(tracks);

            switch (selected)
            {
                case "ADF":
                    DISK2ADF();
                    break;
                case "SCP":
                    DISK2SCP();
                    break;
                case "RAWSCP":
                    DISK2RAWSCP();
                    break;
                default:
                    break;
            }


        }

        private void writeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string selected = cboType.SelectedItem.ToString();
            //MessageBox.Show(selected);
            string tracks = cboTrackCombo.SelectedItem.ToString();

            //MessageBox.Show(tracks);

            switch (selected)
            {
                case "ADF":
                    ADF2DISK();
                    break;
                case "SCP":
                    SCP2DISK();
                    break;
                case "RAWSCP":
                    RAWSCP2DISK();
                    break;
                default:
                    break;

            }

            prgProgressBar1.Value = 0;
            cboTrackCombo.SelectedIndex = 0;

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*MessageBox.Show("ADF Diskbox version 1.0.0.12" + "\n\n" + "By John Brett"
            + "\n\n" + "this program reads and writes amiga disks"
            + " using the greasewesal v4 hardware and host tools" + "\n\n"
            + "Tested on host tools 1.16.2" + "\n\n"
            + "This is a beta and a work in progress!" + "\n\n");*/
            string[] helpstring = new string[] {
                "this is a gui frontend for the greasewesal v4 host tools."+ "\n\n"+
                "\n\n" + "this program reads and writes amiga disks" + "\n\n"+
                " using the greasewesal v4 hardware and host tools" + "\n\n"+
                "Tested on host tools 1.16.3" + "\n\n"+
                "should work on any host tools that recongnises the diskdefs file" + "\n\n"+
                "on first load the program will set up its settings." + "\n\n"+
                "you can save and load your settings." + "\n\n"+
                "if the program wont work hit reset settings to factory" + "\n\n"+
                " to sort it out." + "\n\n"+
                "greasewesal info gives info on host tools and greasewesal version" + "\n\n"+
                "change host tool path lets you use a diffrent version of host tools"+
                "than you picked when installing this program." + "\n\n"+
                "you shouldent need reset path to settings"+
                " but i've included it for just in case" + "\n\n"+
                "change diskdefs path lets you use a diffrent diskdefs file."+
                "\n\nIf you want to use your own diskdefs file\n" +
                " please include the following\n\n" +
                "disk amiga.amigados.plus\n" +
                "cyls = 82\n" +
                "    heads = 2\n" +
                "    tracks * amiga.amigados\n" +
                "        secs = 11\n" +
                "    end\n" +
                "end\n\n"+
                "pick your number of tracks then disk type (adf for a plain disk,"+
                "scp for a protected amigados and rawscp for a rearly protected)" + "\n\n"+
                "pick your read retries - for adf files only." + "\n\n"+
                "then hit read from floppy disk or write to floppy disk" + "\n\n"+
                " and follow the instructions." + "\n\n"+
                "\n\nThis is a beta and a work in progress!" + "\n\n"
            };


            string s = string.Join(",", helpstring);
            MessageBox.Show(s);


        }

        #region LaunchPython
        private void LaunchPython(string commandline)
        {
            /*// only allow one instance at a time
            if (ChooserForm.existsGWProcess())
                return;
            */

            // create the command console
            //frmForm1.createCmdConsole("/K "+"echo hello");
            //frmForm1.createCmdConsole("/K " + "\"" + commandline + "\"");
            //frmForm1.createCmdConsole("/K " + "\"" + txtInfoCommandLine.Text + "\"");
        }
        #endregion

        #region createCmdConsole
        public static void createCmdConsole(string args)
        {
            /*// hide main form
            if (frmForm1.Visible == true)
                frmForm1m.Hide();
            */

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = false;
            startInfo.UseShellExecute = false;


            //startInfo.WorkingDirectory = Gwtext

            string text = startInfo.WorkingDirectory.ToString();
            MessageBox.Show(text);

            startInfo.FileName = "C:\\WINDOWS\\SYSTEM32\\cmd.exe";
            startInfo.WindowStyle = ProcessWindowStyle.Normal;
            startInfo.Arguments = args;
            try
            {
                Process exeProcess = Process.Start(startInfo);
                /* ChooserForm.m_ProcessId = exeProcess.Id; */
            }
            catch (Exception e)
            {
                string sMessage = e.Message.ToString();
                MessageBox.Show("An error has occured\n" + sMessage, "Oops!");
            }
        }
        #endregion



        private void cboRetries_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGwinfo_Click(object sender, EventArgs e)
        {
            string arg = "/K " + "gw info";
            //if doing scp you will need to add mydisk.scp::disktype=amiga directly

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

        private void BtnRead_Click(object sender, EventArgs e)
        {
            string selected = cboType.SelectedItem.ToString();
            //MessageBox.Show(selected);
            string tracks = cboTrackCombo.SelectedItem.ToString();

            //MessageBox.Show(tracks);

            switch (selected)
            {
                case "ADF":
                    DISK2ADF();
                    break;
                case "SCP":
                    DISK2SCP();
                    break;
                case "RAWSCP":
                    DISK2RAWSCP();
                    break;
                default:
                    break;
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            folderDlg.ShowNewFolderButton = false;
            folderDlg.SelectedPath = txtGwtext.Text;
            folderDlg.Description = "Please Select the greasewesal Folder";
            // Show the FolderBrowserDialog.  
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                //Environment.SpecialFolder root = folderDlg.RootFolder;


                string exepath = folderDlg.SelectedPath + "\\" + "gw.exe";

                if (File.Exists(exepath))
                {
                    txtGwtext.Text = folderDlg.SelectedPath;
                    SaveINI(INIPath.Text);

                    string sMessage = string.Format("greasewesal software found at {0}", exepath);
                    ErrorReporter(sMessage);
                }

                else
                {
                    string sMessage = "folder does not contain greasewesal software please try again";
                    ErrorReporter(sMessage);
                }
            }

            else
            {
                string sMessage = "Invalid Folder please try again";
                ErrorReporter(sMessage);
            }
        }


        private void BtnWrite_Click(object sender, EventArgs e)
        {
            string selected = cboType.SelectedItem.ToString();
            //MessageBox.Show(selected);
            string tracks = cboTrackCombo.SelectedItem.ToString();

            //MessageBox.Show(tracks);


            switch (selected)
            {
                case "ADF":
                    ADF2DISK();
                    break;
                case "SCP":
                    SCP2DISK();
                    break;
                case "RAWSCP":
                    RAWSCP2DISK();
                    break;
                default:
                    break;
            }
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)

        {
            string fullpath = INIPath.Text;

            //(!File.Exists(path))

            if (!File.Exists(fullpath))
            {

                //do everything below!!

                FolderBrowserDialog folderDlg = new FolderBrowserDialog();
                folderDlg.ShowNewFolderButton = true;
                folderDlg.ShowNewFolderButton = false;
                folderDlg.Description = "Please Select the path to this program";
                // Show the FolderBrowserDialog.  
                DialogResult result = folderDlg.ShowDialog();
                if (result == DialogResult.OK)
                {
                    INIPath.Text = folderDlg.SelectedPath;
                    Environment.SpecialFolder root = folderDlg.RootFolder;

                    fullpath = INIPath.Text + "\\" + "ADFDiskBox.ini";
                    INIPath.Text = fullpath;
                }


            }

            else
            {
                txtDiag.Text = string.Format("File INIpath {0} Exists", fullpath);
            }

            SaveINI(fullpath);
        }

        private void lblPPath_Click(object sender, EventArgs e)
        {

        }

        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void btnDiskdefs_Click(object sender, EventArgs e)
        {
            string[] defsstring = new string[]{
                    "If you want to use your own diskdefs file\n"+
                    " please include the following\n\n"+
                            "disk amiga.amigados.plus\n"+
                            "cyls = 82\n"+
                                "    heads = 2\n"+
                                "    tracks * amiga.amigados\n"+
                                "        secs = 11\n"+
                                "    end\n"+
                             "end\n"
            };

            string s = string.Join(",", defsstring);
            MessageBox.Show(s);

            string FilePath = txtDiskdefs.Text;

            string DirectoryName;

            DirectoryName = Path.GetDirectoryName(FilePath);

            MessageBox.Show("Directory " + DirectoryName);

            openFileDialog1.FileName = txtDiskdefs.Text;
            openFileDialog1.Filter = "Diskdefs File Location|*.cfg";
            openFileDialog1.InitialDirectory = DirectoryName;
            openFileDialog1.RestoreDirectory = true;


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                var fileContent = string.Empty;
                var filePath = string.Empty;

                //Get the path of specified file
                filePath = openFileDialog1.FileName;

                txtDiskdefs.Text = filePath;

                SaveINI(INIPath.Text);
            }

            else
            {
                MessageBox.Show("could not open That diskdefs file please try again");
                txtDiag.Text = "could not open That diskdefs file please try again";

            }
        }



        private void btnLoadSettings_Click(object sender, EventArgs e)
        {
            Checkexists();
            LoadINI(INIPath.Text);
        }

        private void btnChangeSettings_Click(object sender, EventArgs e)
        {

            string FilePath = INIPath.Text;
            string DirectoryName;

            DirectoryName = Path.GetDirectoryName(FilePath);

            MessageBox.Show("Directory " + DirectoryName);

            saveFileDialog1.FileName = INIPath.Text;
            saveFileDialog1.Filter = "Settings File Location|" + "ADFDiskbox.ini";

            saveFileDialog1.InitialDirectory = DirectoryName;



            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                var fileContent = string.Empty;
                var filePath = string.Empty;

                //Get the path of specified file
                filePath = saveFileDialog1.FileName;

                INIPath.Text = filePath;

                SaveINI(INIPath.Text);
            }

            else
            {
                MessageBox.Show("Cant save ini file");
                txtDiag.Text = "Cant save ini file";
            }
        }

        private void softwareLicenceToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

            /* display legal shit here */
            MessageBox.Show(string.Format("{0}", LegalCrap));
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            string ADFDiskBoxINI = "ADFDiskbox.ini";

            string path = Directory.GetCurrentDirectory();
            //MessageBox.Show(string.Format("current directory {0}", path));

            string fullpath = path + "\\" + ADFDiskBoxINI;

            string defs = path + "\\" + "Jdiskdefs.cfg";
            txtDiskdefs.Text = defs;

            INIPath.Text = fullpath;

            txtGwtext.Text = " ";
            INIPath.Text = fullpath;
            txtDiskdefs.Text = defs;
            lblFileName.Text = "last file.adf";
            cboTrackCombo.Text = "79";
            cboType.Text = "ADF";
            cboRetries.Text = "3";


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

                    MessageBox.Show(string.Format("greasewesal software found at {0}", exepath));

                }

                else
                {
                    MessageBox.Show("That folder does not contain greasewesal software please try again");
                }

            }

            else
            {
                MessageBox.Show("Cant open that config file");
                txtDiag.Text = "Cant open that config file";
            }
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            //pick directory

            string selectedfolder = "c:\\";

            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            //folderDlg.ShowNewFolderButton = false;
            folderDlg.Description = "Please Select the folder for this batch";
            // Show the FolderBrowserDialog.  
            DialogResult result = folderDlg.ShowDialog();
            if (result != DialogResult.OK)
            {
                string sMessage = "that folders no good please try again";

                string report = string.Format("{0}", sMessage);
                txtDiag.Text = report;

                lbErrors.Items.Add("An error");
                lbErrors.SelectedIndex = lbErrors.Items.Count - 1;

                lbErrors.Items.Add(report);
                lbErrors.SelectedIndex = lbErrors.Items.Count - 1;

                lbErrors.Items.Add("has occured");
                lbErrors.SelectedIndex = lbErrors.Items.Count - 1;

                /* end of error reporter */
            }

            else
            {


                selectedfolder = folderDlg.SelectedPath;
                Environment.SpecialFolder root = folderDlg.RootFolder;

                saveFileDialog1.FileName = "";
                saveFileDialog1.Title = "Please Select the filename for this batch (!dont add file extension)";
                saveFileDialog1.InitialDirectory = selectedfolder;
                //saveFileDialog1.Filter = "Amiga ADF only|*.adf";
                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() != DialogResult.OK)
                {
                    /* error reporter */

                    string report = string.Format("that files no good please try again");
                    txtDiag.Text = report;

                    lbErrors.Items.Add("An error");
                    lbErrors.SelectedIndex = lbErrors.Items.Count - 1;

                    lbErrors.Items.Add(report);
                    lbErrors.SelectedIndex = lbErrors.Items.Count - 1;

                    lbErrors.Items.Add("has occured");
                    lbErrors.SelectedIndex = lbErrors.Items.Count - 1;

                    /* end of error reporter */
                }

                else
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

                    /////////////////////////////////////////////////////////////////////
                    // insert while here

                    int NoDisks = cboNumberOfDisks.SelectedIndex + 1;

                    string NumberOfDisks = NoDisks.ToString();

                    int i = 1;

                    MessageBox.Show(string.Format(" number of disks {0}", NumberOfDisks));





                    while (i <= NoDisks)
                    {


                        MessageBox.Show(string.Format("Please Insert disk {0}", i));

                        // original
                        //string arg = "/K " + "gw read " + " --diskdefs " + "\"" + txtDiskdefs.Text + "\"" + diskformat + " " + NoOfRetries + " " + "\"" + filePath + "\"";


                        string arg = "/K " + "gw read " + " --diskdefs " + "\"" + txtDiskdefs.Text + "\"" + diskformat + " " + NoOfRetries + " " + "\"" + filePath + " Disk " + i + " .adf" + "\"";


                        //startInfo.Arguments = arg;


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

                        proc.OutputDataReceived += new DataReceivedEventHandler(process_OutputDataReceived);
                        proc.ErrorDataReceived += new DataReceivedEventHandler(process_OutputDataReceived);

                        //proc.ErrorDataReceived += new DataReceivedEventHandler(process_OutputDataReceived);

                        try
                        {
                            proc.Start();

                            proc.BeginOutputReadLine();
                            proc.BeginErrorReadLine();


                            proc.Close();
                        }

                        catch (Exception error)
                        {
                            /* error reporter */

                            string sMessage = error.Message.ToString();

                            string report = string.Format("{0}", sMessage);
                            txtDiag.Text = report;

                            lbErrors.Items.Add("An error");
                            lbErrors.SelectedIndex = lbErrors.Items.Count - 1;

                            lbErrors.Items.Add(report);
                            lbErrors.SelectedIndex = lbErrors.Items.Count - 1;

                            lbErrors.Items.Add("has occured");
                            lbErrors.SelectedIndex = lbErrors.Items.Count - 1;

                            /* end of error reporter */
                        }

                        // end of while i think
                        i++;

                    }

                }


            }
        }

        private void prgProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void btnConvert2ADF_Click(object sender, EventArgs e)
        {

            var fileContent = string.Empty;
            var filePathin = string.Empty;
            var filePathout = string.Empty;

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

                //Get the path of specified file
                filePathin = openFileDialog1.FileName;

                saveFileDialog1.FileName = "";
                saveFileDialog1.InitialDirectory = "c:\\";
                saveFileDialog1.Filter = "ADF Amiga only|*.adf";
                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    //Get the path of specified file
                    filePathout = saveFileDialog1.FileName;

                    // insert process stuff

                    string arg = "/K " + "gw convert " + " --diskdefs " + "\"" + txtDiskdefs.Text + "\"" + " " + "\"" + filePathin + "\"" + " " + "\"" + filePathout + "\"";

                    txtDiag.Text = arg;

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

                    proc.Start();

                    proc.BeginErrorReadLine();
                    proc.BeginOutputReadLine();

                    proc.Close();
                }

                else
                {
                    MessageBox.Show("Could Not save that file");
                    txtDiag.Text = "Could Not save that file";
                }
            }

            else
            {
                MessageBox.Show("could not open that file");
                txtDiag.Text = "could not open that file";
            }
        }


        private void btnConvert2SCP_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePathin = string.Empty;
            var filePathout = string.Empty;

            openFileDialog1.FileName = "";
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Amiga ADF only|*.adf";
            openFileDialog1.RestoreDirectory = true;
            // testing.....
            openFileDialog1.ShowReadOnly = true;
            openFileDialog1.ReadOnlyChecked = true;
            //
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                filePathin = openFileDialog1.FileName;

                saveFileDialog1.FileName = "";
                saveFileDialog1.InitialDirectory = "c:\\";
                saveFileDialog1.Filter = "SCP Amiga only|*.scp";
                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    //Get the path of specified file
                    filePathout = saveFileDialog1.FileName;

                    // insert process stuff

                    string arg = "/K " + "gw convert " + " --diskdefs " + "\"" + txtDiskdefs.Text + "\"" + " " + "\"" + filePathin + "\"" + " " + "\"" + filePathout + "\"";

                    //MessageBox.Show(arg);
                    txtDiag.Text = arg;

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

                    proc.Start();

                    proc.BeginErrorReadLine();
                    proc.BeginOutputReadLine();

                    proc.Close();
                }

                else
                {
                    MessageBox.Show("could not save that file");
                    txtDiag.Text = "could not save that file";
                }
            }

            else
            {
                MessageBox.Show("could not open this file");
            }
        }

        private void lblNoOfDisks_Click(object sender, EventArgs e)
        {

        }

        private void btnXwrite_Click(object sender, EventArgs e)
        {
            //pick directory

            string selectedfolder = "c:\\";

            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            //folderDlg.ShowNewFolderButton = true;
            folderDlg.ShowNewFolderButton = false;
            folderDlg.Description = "Please Select the folder for this batch";
            // Show the FolderBrowserDialog.  
            DialogResult result = folderDlg.ShowDialog();
            if (result != DialogResult.OK)
            {
                string sMessage = "that folders no good please try again";

                string report = string.Format("{0}", sMessage);
                txtDiag.Text = report;

                lbErrors.Items.Add("An error");
                lbErrors.SelectedIndex = lbErrors.Items.Count - 1;

                lbErrors.Items.Add(report);
                lbErrors.SelectedIndex = lbErrors.Items.Count - 1;

                lbErrors.Items.Add("has occured");
                lbErrors.SelectedIndex = lbErrors.Items.Count - 1;

                /* end of error reporter */
            }

            else
            {


                selectedfolder = folderDlg.SelectedPath;
                Environment.SpecialFolder root = folderDlg.RootFolder;

                


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

                    /////////////////////////////////////////////////////////////////////
                    // insert while here

                    int NoDisks = cboNumberOfDisks.SelectedIndex + 1;

                    string NumberOfDisks = NoDisks.ToString();

                    int i = 1;

                    MessageBox.Show(string.Format(" number of disks {0}", NumberOfDisks));


                    bool quitwhile = false;


                    while (i <= NoDisks && quitwhile==false)
                    {

                        MessageBox.Show(string.Format("Please Insert disk {0}", i));

                        openFileDialog1.FileName = "";
                        openFileDialog1.InitialDirectory = selectedfolder;
                        openFileDialog1.Title = "Pick the next adf disk to write";

                        openFileDialog1.Filter = "Amiga ADF only|*.adf";
                        // testing.....
                        openFileDialog1.ShowReadOnly = true;
                        openFileDialog1.ReadOnlyChecked = true;
                        //
                        openFileDialog1.RestoreDirectory = true;
                        if (openFileDialog1.ShowDialog() != DialogResult.OK)
                        {
                            /* error reporter */

                            string report = string.Format("that files no good please try again");
                            txtDiag.Text = report;

                            lbErrors.Items.Add("An error");
                            lbErrors.SelectedIndex = lbErrors.Items.Count - 1;

                            lbErrors.Items.Add(report);
                            lbErrors.SelectedIndex = lbErrors.Items.Count - 1;

                            lbErrors.Items.Add("has occured");
                            lbErrors.SelectedIndex = lbErrors.Items.Count - 1;

                        /* end of error reporter */
                        quitwhile = true;
                        }

                        else
                        {
                            var fileContent = string.Empty;
                            var filePath = string.Empty;

                            //Get the path of specified file
                            filePath = openFileDialog1.FileName;
                            lblFileName.Text = filePath;


                        

                            // original
                            //string arg = "/K " + "gw read " + " --diskdefs " + "\"" + txtDiskdefs.Text + "\"" + diskformat + " " + NoOfRetries + " " + "\"" + filePath + "\"";


                            string arg = "/K " + "gw write " + " --diskdefs " + "\"" + txtDiskdefs.Text + "\"" + diskformat + " " + NoOfRetries + " " + "\"" + filePath + "\"";


                            //startInfo.Arguments = arg;


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

                            proc.OutputDataReceived += new DataReceivedEventHandler(process_OutputDataReceived);
                            proc.ErrorDataReceived += new DataReceivedEventHandler(process_OutputDataReceived);

                            //proc.ErrorDataReceived += new DataReceivedEventHandler(process_OutputDataReceived);

                            try
                            {
                                proc.Start();

                                proc.BeginOutputReadLine();
                                proc.BeginErrorReadLine();


                                proc.Close();
                            }

                            catch (Exception error)
                            {
                                /* error reporter */

                                string sMessage = error.Message.ToString();

                                string report = string.Format("{0}", sMessage);
                                txtDiag.Text = report;

                                lbErrors.Items.Add("An error");
                                lbErrors.SelectedIndex = lbErrors.Items.Count - 1;

                                lbErrors.Items.Add(report);
                                lbErrors.SelectedIndex = lbErrors.Items.Count - 1;

                                lbErrors.Items.Add("has occured");
                                lbErrors.SelectedIndex = lbErrors.Items.Count - 1;

                                /* end of error reporter */
                            }

                            // end of while i think
                            i++;

                    }

                }


            }
        }
    }
    
}

        