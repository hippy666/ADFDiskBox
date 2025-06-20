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
        public static FrmOptions frmOpt;
        //public string INIpath;

        public FrmOptions()
        {
            InitializeComponent();
            frmOpt = this;
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
            Checkexists();
            LoadINI(INIPath.Text);

            //frmMainForm.tester
        }

        private void btnGwinfo_Click(object sender, EventArgs e)
        {
            string device;
            device = "--device=" + cboComPort.Text;

            string arg = "/C gw info " + device;

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

       
       

        private void lblSide_Click(object sender, EventArgs e)
        {

        }

        
        private void FrmOptions_Load(object sender, EventArgs e)
        {
            INIControl inisettings = new INIControl();


            INIPath.Text = Checkexists();


            /*
            MessageBox.Show("ADF Diskbox version 2.0" + "\n\n" + "By John Brett"
            + "\n\n" + "this program reads and writes amiga disks"
            + " using the greasewesal v4 hardware and host tools" + "\n\n"
            + "Tested on host tools 1.16.2 and up" + "\n\n"
            + "This is a beta and a work in progress!" + "\n\n");
            */

            // Get a list of serial port names.
            string[] ports = SerialPort.GetPortNames();

            MessageBox.Show("The following serial ports were found:");

            // Display each port name

            cboComPort.Items.Clear();

            if (null == ports | ports.Length == 0)
            {
                MessageBox.Show("No Com ports Detected. please replugin and press rescan ports!");
                cboComPort.Items.Add("Rescan");
                cboComPort.SelectedIndex = cboComPort.Items.Count - 1;

            }
            else
            {
                foreach (string port in ports)
                {

                    MessageBox.Show(port);
                    cboComPort.Items.Add(port);
                    cboComPort.SelectedIndex = cboComPort.Items.Count - 1;
                }

                string device;
                device = "--device=" + cboComPort.Text;
                frmMainForm.frmMain.cboComPort.Text = cboComPort.Text;

                string arg = "/C gw info " + device;

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

            }


            CboRevs.Text = frmMainForm.frmMain.CboRevs.Text;
                
            
            /////////////////////////////////////////////////////////////////////////////////////////////////////

            

            
            // Load HxC File and path here..
            // load hxc folders


            /*string file, dir;
            file = LoadHxCpath();
            dir = LoadHxCFolder();

            TxtHxCFolder.Text = dir;
            TxtHxCPath.Text = file;

            frmMainForm.frmMain.StxtHxCFolder = dir;
            frmMainForm.frmMain.StxtHxCFile = file;
            */

            // Load HxC File and path here..
            // load hxc folders
 

            //lbErrors.Items.Add(report);
            //lbErrors.SelectedIndex = lbErrors.Items.Count - 1;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string device;
            device = "--device=" + cboComPort.Text;

            string arg = "/C gw update " + device;

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

        private void btnChange_Click(object sender, EventArgs e)
        {

            //frmMainForm.StxtGwtext;

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

        private void btnChangeSettings_Click(object sender, EventArgs e)
        {

            string FilePath = INIPath.Text;
            string DirectoryName;

            DirectoryName = Path.GetDirectoryName(FilePath);

            MessageBox.Show("Directory " + DirectoryName);

            saveFileDialog1.FileName = FilePath;
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

        private void btnDiskdefs_Click(object sender, EventArgs e)
        {
            string[] defsstring = new string[]{
                    "If you want to use your own diskdefs file\n"+
                    " please include the following\n\n"+
                    "\n\n"+
                "disk amiga.amigados\n"+
                "cyls = 80\n"+
                "    heads = 2\n"+
                "    tracks * amiga.amigados\n"+
                "        secs = 11\n"+
                "    end\n"+
                "end\n"+
                "\n"+
                "\n"+
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
                saveFileDialog1.Filter = "SCP only|*.scp";
                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    //Get the path of specified file
                    filePathout = saveFileDialog1.FileName;

                    // insert process stuff

                    string arg = "/C " + "gw convert " + " --diskdefs " + "\"" + txtDiskdefs.Text + "\"" + " " + "\"" + filePathin + "\"" + " " + "\"" + filePathout + "\"";

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
                    ErrorReporter("could not save that file");
                    /*
                    MessageBox.Show("could not save that file");
                    txtDiag.Text = "could not save that file";*/
                }
            }

            else
            {
                ErrorReporter("could not open this file");

                /* MessageBox.Show("could not open this file");*/
            }
        }

        private void btnConvert2ADF_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePathin = string.Empty;
            var filePathout = string.Empty;

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

                    string arg = "/C " + "gw convert " + " --diskdefs " + "\"" + txtDiskdefs.Text + "\"" + " " + "\"" + filePathin + "\"" + " " + "\"" + filePathout + "\"";

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
                    ErrorReporter("Could Not save that file");
                    /*
                    MessageBox.Show("Could Not save that file");
                    txtDiag.Text = "Could Not save that file";*/
                }
            }

            else
            {
                ErrorReporter("could not open that file");
                /*
                MessageBox.Show("could not open that file");
                txtDiag.Text = "could not open that file";*/

            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            string ADFDiskBoxINI = "ADFDiskbox.ini";

            string path = Directory.GetCurrentDirectory();
            //MessageBox.Show(string.Format("current directory {0}", path));

            string fullpath = path + "\\" + ADFDiskBoxINI;

            string defs = path + "\\" + "Jdiskdefs.cfg";


            txtGwtext.Text = " ";
            INIPath.Text = fullpath;
            txtDiskdefs.Text = defs;
            lblFileName.Text = "last file.adf";
            cboTrackCombo.Text = "79";
            cboType.Text = "AmigaDos";
            cboRetries.Text = "3";

            cboNumberOfDisks.Text = "2";
            cboDriveSelect.Text = "A";
            CboRevs.Text = "5";


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

            //stuff to fix later on
            FolderBrowserDialog folderDlg1 = new FolderBrowserDialog();
            folderDlg1.ShowNewFolderButton = true;
            folderDlg1.ShowNewFolderButton = false;
            folderDlg1.SelectedPath = "C:\\";
            folderDlg1.Description = "Please Select the HxC Software Folder";
            // Show the FolderBrowserDialog.  
            DialogResult result2 = folderDlg1.ShowDialog();
            if (result2 == DialogResult.OK)
            {
                //Environment.SpecialFolder root = folderDlg.RootFolder;

                string exepath = folderDlg1.SelectedPath + "\\" + "HxCFloppyEmulator.exe";


                if (File.Exists(exepath))
                {
                    TxtHxCFolder.Text = folderDlg1.SelectedPath;
                    TxtHxCPath.Text = exepath;

                    frmMainForm.frmMain.StxtHxCFolder = TxtHxCFolder.Text;
                    frmMainForm.frmMain.StxtHxCFile = TxtHxCPath.Text;
                    SaveINI(INIPath.Text);

                    string sMessage = string.Format("HxC software found at {0}", exepath);
                    ErrorReporter(sMessage);
                }

                else
                {
                    string sMessage = "folder does not contain HxC software please try again";
                    ErrorReporter(sMessage);
                }
            }

            else
            {
                string sMessage = "Invalid Folder please try again";
                ErrorReporter(sMessage);
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

        private void button1_Click(object sender, EventArgs e)
        {
            
            frmMainForm.frmMain.StxtGwtext = "string working";
            //frmMainForm.frmMain.ini
            MessageBox.Show("value of StxtGwtext: " + frmMainForm.frmMain.StxtGwtext);
            //frmMainForm myClass = new frmMainForm();
            //myClass.StxtGwtext = "shit";

            //MessageBox.Show(myClass.StxtGwtext);
            //string stxtgwtext=frmMainForm.
            //StxtGwtext
            //frmMainForm.txt
            //txtGwtext.Text

        }

        private void BtnHxCPath_Click(object sender, EventArgs e)
        {


            openFileDialog1.FileName = "HxCFloppyEmulator.exe";
            openFileDialog1.InitialDirectory = "c:\\";

            
            openFileDialog1.Filter = "path to hxc exe | HxCFloppyEmulator.exe";
            // testing.....
            openFileDialog1.ShowReadOnly = true;
            openFileDialog1.ReadOnlyChecked = true;
            //

            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                TxtHxCPath.Text = openFileDialog1.FileName;
                frmMainForm.frmMain.StxtHxCFile = TxtHxCPath.Text;
            }

            else
            {
                string sMessage = "could not find the program";
                ErrorReporter(sMessage);

                return;
            }
        }

        private void btnHxCFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            folderDlg.ShowNewFolderButton = false;
            folderDlg.SelectedPath = "C:\\";
            folderDlg.Description = "Please Select the HxC Software Folder";
            // Show the FolderBrowserDialog.  
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                //Environment.SpecialFolder root = folderDlg.RootFolder;

                string exepath= folderDlg.SelectedPath + "\\" + "HxCFloppyEmulator.exe";


                if (File.Exists(exepath))
                {
                    TxtHxCFolder.Text = folderDlg.SelectedPath;
                    TxtHxCPath.Text = exepath;

                    frmMainForm.frmMain.StxtHxCFolder = TxtHxCFolder.Text;
                    frmMainForm.frmMain.StxtHxCFile = TxtHxCPath.Text;
                    SaveINI(INIPath.Text);
                    
                    string sMessage = string.Format("HxC software found at {0}", exepath);
                    ErrorReporter(sMessage);
                }

                else
                {
                    string sMessage = "folder does not contain HxC software please try again";
                    ErrorReporter(sMessage);
                }
            }

            else
            {
                string sMessage = "Invalid Folder please try again";
                ErrorReporter(sMessage);
            }
        }

        public string LoadHxCFolder()
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            folderDlg.ShowNewFolderButton = false;
            folderDlg.SelectedPath = "C:\\";
            folderDlg.Description = "Please Select the HxC Software Folder";
            // Show the FolderBrowserDialog.  
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                //Environment.SpecialFolder root = folderDlg.RootFolder;

                string exepath = folderDlg.SelectedPath + "\\" + "HxCFloppyEmulator.exe";

                if (File.Exists(exepath))
                {

                    frmMainForm.frmMain.StxtHxCFolder = folderDlg.SelectedPath;
                    SaveINI(INIPath.Text);

                    string sMessage = string.Format("HxC software found at {0}", exepath);
                    ErrorReporter(sMessage);
                    return (exepath);
                }

                else
                {
                    string sMessage = "folder does not contain HxC software please try again";
                    ErrorReporter(sMessage);
                    return ("Blank");
                }
            }

            else
            {
                string sMessage = "Invalid Folder please try again";
                ErrorReporter(sMessage);
                return ("blank");
            }
        }

        public string LoadHxCpath()
        {
            openFileDialog1.FileName = "HxCFloppyEmulator.exe";
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Title = "Please Select The HxC Software";

            openFileDialog1.Filter = "path to hxc exe | HxCFloppyEmulator.exe";
            // testing.....
            openFileDialog1.ShowReadOnly = true;
            openFileDialog1.ReadOnlyChecked = true;
            //

            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //StxtHxCFile = openFileDialog1.FileName;
                return (openFileDialog1.FileName);
            }

            else
            {
                string sMessage = "could not find the program";
                ErrorReporter(sMessage);

                return ("blank");
            }
        }

        private void BtnEmergency_Click(object sender, EventArgs e)
        {
            Process[] GWprocess = Process.GetProcessesByName("gw");
            foreach (Process GWP in GWprocess)
            {
                GWP.Kill();
                GWP.WaitForExit();
                GWP.Dispose();
            }
        }

        private void BtnHxCTest_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Pick a file to load";
            openFileDialog1.FileName = lblFileName.Text;


            string path = Directory.GetCurrentDirectory();

            openFileDialog1.InitialDirectory = path;

            //openFileDialog1.Filter = "pick file |*.adf;*.scp";
            openFileDialog1.Filter = "Pick An Image adf or scp|*.adf;*.scp;";

            // testing.....
            openFileDialog1.ShowReadOnly = true;
            openFileDialog1.ReadOnlyChecked = true;
            //


            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //string arg = "\"" + openFileDialog1.FileName + "\"";
                string arg = "/C " + frmMainForm.frmMain.StxtHxCFolder + " \"" + openFileDialog1.FileName + "\"";
                //string programCall = "HxCFloppyEmulator.exe";

                //MessageBox.Show(arg);

                ClearlbOutput();
                ClearlbErrorOutput();

                //MessageBox.Show(string.Format("file {0} " + StxtHxCFile));
                //MessageBox.Show(string.Format("folder {0} " +  StxtHxCFolder));

                var proc = new Process
                {
                    EnableRaisingEvents = true,
                    StartInfo = new ProcessStartInfo
                    {
                        
                        WorkingDirectory = frmMainForm.frmMain.StxtHxCFolder,
                        Arguments = arg,

                        //FileName = frmMainForm.frmMain.StxtHxCFile,
                        FileName="C:\\WINDOWS\\SYSTEM32\\cmd.exe",

                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        CreateNoWindow = true


                    }
                };

                //prgProgressBar1.Value = 0;

                proc.ErrorDataReceived += new DataReceivedEventHandler(process_OutputDataReceived);
                proc.OutputDataReceived += new DataReceivedEventHandler(process_OutputDataReceived);

                try
                {
                    proc.Start();

                    //ChooserForm.m_ProcessId = proc.Id;
                    //SendKeys.Send("%(H)");
                    //SendKeys.SendWait("%H");

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
                string sMessage = "could not load the program";
                ErrorReporter(sMessage);

                return;
            }
        }
    }
}
