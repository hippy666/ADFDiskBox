namespace ADFDiskBox
{
    partial class frmMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainForm));
            this.prgProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.BtnRead = new System.Windows.Forms.Button();
            this.BtnWrite = new System.Windows.Forms.Button();
            this.BtnQuit = new System.Windows.Forms.Button();
            this.LblPercentComplete = new System.Windows.Forms.Label();
            this.LblFileInUse = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.cboTrackCombo = new System.Windows.Forms.ComboBox();
            this.lblFileName = new System.Windows.Forms.Label();
            this.lblNumberOfTracks = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.writeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.softwareLicenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDiskType = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.btnGwinfo = new System.Windows.Forms.Button();
            this.txtGwtext = new System.Windows.Forms.TextBox();
            this.lblDirectory = new System.Windows.Forms.Label();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.lblRetries = new System.Windows.Forms.Label();
            this.cboRetries = new System.Windows.Forms.ComboBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.INIPath = new System.Windows.Forms.TextBox();
            this.btnDiskdefs = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiskdefs = new System.Windows.Forms.TextBox();
            this.btnLoadSettings = new System.Windows.Forms.Button();
            this.btnChangeSettings = new System.Windows.Forms.Button();
            this.lblSettings = new System.Windows.Forms.Label();
            this.txtTrackNo = new System.Windows.Forms.TextBox();
            this.lblTrackNo = new System.Windows.Forms.Label();
            this.lbOutput = new System.Windows.Forms.ListBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.lblSide = new System.Windows.Forms.Label();
            this.txtSide = new System.Windows.Forms.TextBox();
            this.txtDiag = new System.Windows.Forms.TextBox();
            this.btnConvert2ADF = new System.Windows.Forms.Button();
            this.btnConvert2SCP = new System.Windows.Forms.Button();
            this.lblDiag = new System.Windows.Forms.Label();
            this.lblNoOfDisks = new System.Windows.Forms.Label();
            this.cboNumberOfDisks = new System.Windows.Forms.ComboBox();
            this.lblOutputWIndow = new System.Windows.Forms.Label();
            this.lbErrors = new System.Windows.Forms.ListBox();
            this.lblErrorReport = new System.Windows.Forms.Label();
            this.btnXwrite = new System.Windows.Forms.Button();
            this.lblDriveSelect = new System.Windows.Forms.Label();
            this.cboDriveSelect = new System.Windows.Forms.ComboBox();
            this.cboComPort = new System.Windows.Forms.ComboBox();
            this.lblComPort = new System.Windows.Forms.Label();
            this.btnRescan = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // prgProgressBar1
            // 
            this.prgProgressBar1.Location = new System.Drawing.Point(16, 148);
            this.prgProgressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.prgProgressBar1.Maximum = 162;
            this.prgProgressBar1.Name = "prgProgressBar1";
            this.prgProgressBar1.Size = new System.Drawing.Size(867, 28);
            this.prgProgressBar1.Step = 1;
            this.prgProgressBar1.TabIndex = 0;
            this.prgProgressBar1.Click += new System.EventHandler(this.prgProgressBar1_Click);
            // 
            // BtnRead
            // 
            this.BtnRead.Location = new System.Drawing.Point(672, 465);
            this.BtnRead.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRead.Name = "BtnRead";
            this.BtnRead.Size = new System.Drawing.Size(123, 117);
            this.BtnRead.TabIndex = 4;
            this.BtnRead.Text = "Read from floppy disk";
            this.BtnRead.UseVisualStyleBackColor = true;
            this.BtnRead.Click += new System.EventHandler(this.BtnRead_Click);
            // 
            // BtnWrite
            // 
            this.BtnWrite.Location = new System.Drawing.Point(871, 465);
            this.BtnWrite.Margin = new System.Windows.Forms.Padding(4);
            this.BtnWrite.Name = "BtnWrite";
            this.BtnWrite.Size = new System.Drawing.Size(121, 117);
            this.BtnWrite.TabIndex = 5;
            this.BtnWrite.Text = "Write To Floppy Disk";
            this.BtnWrite.UseVisualStyleBackColor = true;
            this.BtnWrite.Click += new System.EventHandler(this.BtnWrite_Click);
            // 
            // BtnQuit
            // 
            this.BtnQuit.Location = new System.Drawing.Point(1053, 465);
            this.BtnQuit.Margin = new System.Windows.Forms.Padding(4);
            this.BtnQuit.Name = "BtnQuit";
            this.BtnQuit.Size = new System.Drawing.Size(116, 117);
            this.BtnQuit.TabIndex = 6;
            this.BtnQuit.Text = "Quit";
            this.BtnQuit.UseVisualStyleBackColor = true;
            this.BtnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // LblPercentComplete
            // 
            this.LblPercentComplete.AutoSize = true;
            this.LblPercentComplete.Location = new System.Drawing.Point(12, 128);
            this.LblPercentComplete.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPercentComplete.Name = "LblPercentComplete";
            this.LblPercentComplete.Size = new System.Drawing.Size(91, 17);
            this.LblPercentComplete.TabIndex = 7;
            this.LblPercentComplete.Text = "Progress Bar";
            // 
            // LblFileInUse
            // 
            this.LblFileInUse.AutoSize = true;
            this.LblFileInUse.Location = new System.Drawing.Point(632, 204);
            this.LblFileInUse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblFileInUse.Name = "LblFileInUse";
            this.LblFileInUse.Size = new System.Drawing.Size(98, 17);
            this.LblFileInUse.TabIndex = 8;
            this.LblFileInUse.Text = "Last File Used";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cboTrackCombo
            // 
            this.cboTrackCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrackCombo.FormattingEnabled = true;
            this.cboTrackCombo.Items.AddRange(new object[] {
            "79",
            "81"});
            this.cboTrackCombo.Location = new System.Drawing.Point(172, 212);
            this.cboTrackCombo.Margin = new System.Windows.Forms.Padding(4);
            this.cboTrackCombo.MaxDropDownItems = 2;
            this.cboTrackCombo.Name = "cboTrackCombo";
            this.cboTrackCombo.Size = new System.Drawing.Size(59, 24);
            this.cboTrackCombo.Sorted = true;
            this.cboTrackCombo.TabIndex = 9;
            this.cboTrackCombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(632, 233);
            this.lblFileName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(67, 17);
            this.lblFileName.TabIndex = 10;
            this.lblFileName.Text = "Blank.adf";
            // 
            // lblNumberOfTracks
            // 
            this.lblNumberOfTracks.AutoSize = true;
            this.lblNumberOfTracks.Location = new System.Drawing.Point(168, 192);
            this.lblNumberOfTracks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumberOfTracks.Name = "lblNumberOfTracks";
            this.lblNumberOfTracks.Size = new System.Drawing.Size(51, 17);
            this.lblNumberOfTracks.TabIndex = 11;
            this.lblNumberOfTracks.Text = "Tracks";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 648);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1269, 26);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(50, 20);
            this.toolStripStatusLabel1.Text = "Ready";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 28);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1269, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(1269, 28);
            this.menuStrip2.TabIndex = 16;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readToolStripMenuItem,
            this.toolStripSeparator,
            this.writeToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // readToolStripMenuItem
            // 
            this.readToolStripMenuItem.AutoSize = false;
            this.readToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("readToolStripMenuItem.Image")));
            this.readToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.readToolStripMenuItem.Name = "readToolStripMenuItem";
            this.readToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.readToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.readToolStripMenuItem.Text = "&Read";
            this.readToolStripMenuItem.Click += new System.EventHandler(this.readToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(181, 6);
            // 
            // writeToolStripMenuItem
            // 
            this.writeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("writeToolStripMenuItem.Image")));
            this.writeToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.writeToolStripMenuItem.Name = "writeToolStripMenuItem";
            this.writeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.writeToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.writeToolStripMenuItem.Text = "&Write";
            this.writeToolStripMenuItem.Click += new System.EventHandler(this.writeToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(181, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(181, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.customizeToolStripMenuItem.Text = "&Customize";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.softwareLicenceToolStripMenuItem});
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // softwareLicenceToolStripMenuItem
            // 
            this.softwareLicenceToolStripMenuItem.Name = "softwareLicenceToolStripMenuItem";
            this.softwareLicenceToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.softwareLicenceToolStripMenuItem.Text = "Software licence";
            this.softwareLicenceToolStripMenuItem.Click += new System.EventHandler(this.softwareLicenceToolStripMenuItem_Click);
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(147, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // lblDiskType
            // 
            this.lblDiskType.AutoSize = true;
            this.lblDiskType.Location = new System.Drawing.Point(285, 192);
            this.lblDiskType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiskType.Name = "lblDiskType";
            this.lblDiskType.Size = new System.Drawing.Size(67, 17);
            this.lblDiskType.TabIndex = 17;
            this.lblDiskType.Text = "DiskType";
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "ADF",
            "SCP",
            "RAWSCP"});
            this.cboType.Location = new System.Drawing.Point(289, 212);
            this.cboType.Margin = new System.Windows.Forms.Padding(4);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(93, 24);
            this.cboType.TabIndex = 18;
            this.cboType.SelectedIndexChanged += new System.EventHandler(this.cboType_SelectedIndexChanged);
            // 
            // btnGwinfo
            // 
            this.btnGwinfo.Location = new System.Drawing.Point(1053, 252);
            this.btnGwinfo.Margin = new System.Windows.Forms.Padding(4);
            this.btnGwinfo.Name = "btnGwinfo";
            this.btnGwinfo.Size = new System.Drawing.Size(116, 43);
            this.btnGwinfo.TabIndex = 19;
            this.btnGwinfo.Text = "Greasewesal Info";
            this.btnGwinfo.UseVisualStyleBackColor = true;
            this.btnGwinfo.Click += new System.EventHandler(this.btnGwinfo_Click);
            // 
            // txtGwtext
            // 
            this.txtGwtext.Location = new System.Drawing.Point(226, 89);
            this.txtGwtext.Margin = new System.Windows.Forms.Padding(4);
            this.txtGwtext.Name = "txtGwtext";
            this.txtGwtext.ReadOnly = true;
            this.txtGwtext.Size = new System.Drawing.Size(200, 22);
            this.txtGwtext.TabIndex = 20;
            this.txtGwtext.Text = "C:\\Greasewesal";
            // 
            // lblDirectory
            // 
            this.lblDirectory.AutoSize = true;
            this.lblDirectory.Location = new System.Drawing.Point(224, 71);
            this.lblDirectory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDirectory.Name = "lblDirectory";
            this.lblDirectory.Size = new System.Drawing.Size(158, 17);
            this.lblDirectory.TabIndex = 21;
            this.lblDirectory.Text = "Path To GW Host Tools";
            this.lblDirectory.Click += new System.EventHandler(this.lblDirectory_Click);
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Location = new System.Drawing.Point(743, 252);
            this.btnSaveSettings.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(116, 43);
            this.btnSaveSettings.TabIndex = 0;
            this.btnSaveSettings.Text = "SaveSettings";
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // lblRetries
            // 
            this.lblRetries.AutoSize = true;
            this.lblRetries.Location = new System.Drawing.Point(419, 192);
            this.lblRetries.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRetries.Name = "lblRetries";
            this.lblRetries.Size = new System.Drawing.Size(145, 17);
            this.lblRetries.TabIndex = 22;
            this.lblRetries.Text = "read retries (adf only)";
            // 
            // cboRetries
            // 
            this.cboRetries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRetries.FormattingEnabled = true;
            this.cboRetries.IntegralHeight = false;
            this.cboRetries.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59",
            "60",
            "61",
            "62",
            "63",
            "64",
            "65",
            "66",
            "67",
            "68",
            "69",
            "70",
            "71",
            "72",
            "73",
            "74",
            "75",
            "76",
            "77",
            "78",
            "79",
            "80",
            "81",
            "82",
            "83",
            "84",
            "85",
            "86",
            "87",
            "88",
            "89",
            "90",
            "91",
            "92",
            "93",
            "94",
            "95",
            "96",
            "97",
            "98",
            "99"});
            this.cboRetries.Location = new System.Drawing.Point(423, 212);
            this.cboRetries.Margin = new System.Windows.Forms.Padding(4);
            this.cboRetries.MaxDropDownItems = 99;
            this.cboRetries.Name = "cboRetries";
            this.cboRetries.Size = new System.Drawing.Size(73, 24);
            this.cboRetries.TabIndex = 23;
            this.cboRetries.SelectedIndexChanged += new System.EventHandler(this.cboRetries_SelectedIndexChanged);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(226, 28);
            this.btnChange.Margin = new System.Windows.Forms.Padding(4);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(200, 38);
            this.btnChange.TabIndex = 24;
            this.btnChange.Text = "change Host Tools path";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // INIPath
            // 
            this.INIPath.Enabled = false;
            this.INIPath.Location = new System.Drawing.Point(455, 89);
            this.INIPath.Margin = new System.Windows.Forms.Padding(4);
            this.INIPath.Name = "INIPath";
            this.INIPath.ReadOnly = true;
            this.INIPath.Size = new System.Drawing.Size(132, 22);
            this.INIPath.TabIndex = 26;
            // 
            // btnDiskdefs
            // 
            this.btnDiskdefs.Location = new System.Drawing.Point(636, 25);
            this.btnDiskdefs.Margin = new System.Windows.Forms.Padding(4);
            this.btnDiskdefs.Name = "btnDiskdefs";
            this.btnDiskdefs.Size = new System.Drawing.Size(189, 43);
            this.btnDiskdefs.TabIndex = 27;
            this.btnDiskdefs.Text = "Change Diskdefs Path";
            this.btnDiskdefs.UseVisualStyleBackColor = true;
            this.btnDiskdefs.Click += new System.EventHandler(this.btnDiskdefs_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(640, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Path To Diskdefs";
            // 
            // txtDiskdefs
            // 
            this.txtDiskdefs.Location = new System.Drawing.Point(644, 89);
            this.txtDiskdefs.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiskdefs.Name = "txtDiskdefs";
            this.txtDiskdefs.Size = new System.Drawing.Size(180, 22);
            this.txtDiskdefs.TabIndex = 29;
            // 
            // btnLoadSettings
            // 
            this.btnLoadSettings.Location = new System.Drawing.Point(617, 252);
            this.btnLoadSettings.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoadSettings.Name = "btnLoadSettings";
            this.btnLoadSettings.Size = new System.Drawing.Size(100, 43);
            this.btnLoadSettings.TabIndex = 30;
            this.btnLoadSettings.Text = "Load Saved Settings";
            this.btnLoadSettings.UseVisualStyleBackColor = true;
            this.btnLoadSettings.Click += new System.EventHandler(this.btnLoadSettings_Click);
            // 
            // btnChangeSettings
            // 
            this.btnChangeSettings.Location = new System.Drawing.Point(455, 25);
            this.btnChangeSettings.Margin = new System.Windows.Forms.Padding(4);
            this.btnChangeSettings.Name = "btnChangeSettings";
            this.btnChangeSettings.Size = new System.Drawing.Size(133, 46);
            this.btnChangeSettings.TabIndex = 31;
            this.btnChangeSettings.Text = "Reset Path To Settings";
            this.btnChangeSettings.UseVisualStyleBackColor = true;
            this.btnChangeSettings.Click += new System.EventHandler(this.btnChangeSettings_Click);
            // 
            // lblSettings
            // 
            this.lblSettings.AutoSize = true;
            this.lblSettings.Location = new System.Drawing.Point(455, 71);
            this.lblSettings.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(106, 17);
            this.lblSettings.TabIndex = 32;
            this.lblSettings.Text = "Path to settings";
            // 
            // txtTrackNo
            // 
            this.txtTrackNo.Location = new System.Drawing.Point(16, 212);
            this.txtTrackNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTrackNo.Name = "txtTrackNo";
            this.txtTrackNo.Size = new System.Drawing.Size(64, 22);
            this.txtTrackNo.TabIndex = 33;
            // 
            // lblTrackNo
            // 
            this.lblTrackNo.AutoSize = true;
            this.lblTrackNo.Location = new System.Drawing.Point(16, 192);
            this.lblTrackNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrackNo.Name = "lblTrackNo";
            this.lblTrackNo.Size = new System.Drawing.Size(62, 17);
            this.lblTrackNo.TabIndex = 34;
            this.lblTrackNo.Text = "TrackNo";
            // 
            // lbOutput
            // 
            this.lbOutput.FormattingEnabled = true;
            this.lbOutput.ItemHeight = 16;
            this.lbOutput.Location = new System.Drawing.Point(61, 289);
            this.lbOutput.Margin = new System.Windows.Forms.Padding(4);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(547, 116);
            this.lbOutput.TabIndex = 35;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(883, 252);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 63);
            this.btnReset.TabIndex = 36;
            this.btnReset.Text = "Reset Settings to Factory";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnX
            // 
            this.btnX.Location = new System.Drawing.Point(892, 357);
            this.btnX.Margin = new System.Windows.Forms.Padding(4);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(100, 94);
            this.btnX.TabIndex = 37;
            this.btnX.Text = "Xperimental adf batch read";
            this.btnX.UseVisualStyleBackColor = true;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // lblSide
            // 
            this.lblSide.AutoSize = true;
            this.lblSide.Location = new System.Drawing.Point(91, 192);
            this.lblSide.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSide.Name = "lblSide";
            this.lblSide.Size = new System.Drawing.Size(36, 17);
            this.lblSide.TabIndex = 38;
            this.lblSide.Text = "Side";
            // 
            // txtSide
            // 
            this.txtSide.Location = new System.Drawing.Point(95, 212);
            this.txtSide.Margin = new System.Windows.Forms.Padding(4);
            this.txtSide.Name = "txtSide";
            this.txtSide.Size = new System.Drawing.Size(55, 22);
            this.txtSide.TabIndex = 39;
            // 
            // txtDiag
            // 
            this.txtDiag.Location = new System.Drawing.Point(61, 619);
            this.txtDiag.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiag.Name = "txtDiag";
            this.txtDiag.Size = new System.Drawing.Size(544, 22);
            this.txtDiag.TabIndex = 40;
            // 
            // btnConvert2ADF
            // 
            this.btnConvert2ADF.Location = new System.Drawing.Point(912, 20);
            this.btnConvert2ADF.Margin = new System.Windows.Forms.Padding(4);
            this.btnConvert2ADF.Name = "btnConvert2ADF";
            this.btnConvert2ADF.Size = new System.Drawing.Size(100, 48);
            this.btnConvert2ADF.TabIndex = 41;
            this.btnConvert2ADF.Text = "Convert scp 2 adf";
            this.btnConvert2ADF.UseVisualStyleBackColor = true;
            this.btnConvert2ADF.Click += new System.EventHandler(this.btnConvert2ADF_Click);
            // 
            // btnConvert2SCP
            // 
            this.btnConvert2SCP.Location = new System.Drawing.Point(912, 89);
            this.btnConvert2SCP.Margin = new System.Windows.Forms.Padding(4);
            this.btnConvert2SCP.Name = "btnConvert2SCP";
            this.btnConvert2SCP.Size = new System.Drawing.Size(100, 52);
            this.btnConvert2SCP.TabIndex = 42;
            this.btnConvert2SCP.Text = "Convert adf 2 scp";
            this.btnConvert2SCP.UseVisualStyleBackColor = true;
            this.btnConvert2SCP.Click += new System.EventHandler(this.btnConvert2SCP_Click);
            // 
            // lblDiag
            // 
            this.lblDiag.AutoSize = true;
            this.lblDiag.Location = new System.Drawing.Point(57, 599);
            this.lblDiag.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiag.Name = "lblDiag";
            this.lblDiag.Size = new System.Drawing.Size(96, 17);
            this.lblDiag.TabIndex = 43;
            this.lblDiag.Text = "Last Message";
            // 
            // lblNoOfDisks
            // 
            this.lblNoOfDisks.AutoSize = true;
            this.lblNoOfDisks.Location = new System.Drawing.Point(775, 320);
            this.lblNoOfDisks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNoOfDisks.MaximumSize = new System.Drawing.Size(91, 90);
            this.lblNoOfDisks.Name = "lblNoOfDisks";
            this.lblNoOfDisks.Size = new System.Drawing.Size(82, 68);
            this.lblNoOfDisks.TabIndex = 44;
            this.lblNoOfDisks.Text = "Select Number Of Disks for batch mode";
            this.lblNoOfDisks.Click += new System.EventHandler(this.lblNoOfDisks_Click);
            // 
            // cboNumberOfDisks
            // 
            this.cboNumberOfDisks.FormattingEnabled = true;
            this.cboNumberOfDisks.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.cboNumberOfDisks.Location = new System.Drawing.Point(779, 393);
            this.cboNumberOfDisks.Margin = new System.Windows.Forms.Padding(4);
            this.cboNumberOfDisks.Name = "cboNumberOfDisks";
            this.cboNumberOfDisks.Size = new System.Drawing.Size(65, 24);
            this.cboNumberOfDisks.TabIndex = 45;
            // 
            // lblOutputWIndow
            // 
            this.lblOutputWIndow.AutoSize = true;
            this.lblOutputWIndow.Location = new System.Drawing.Point(65, 252);
            this.lblOutputWIndow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOutputWIndow.Name = "lblOutputWIndow";
            this.lblOutputWIndow.Size = new System.Drawing.Size(104, 17);
            this.lblOutputWIndow.TabIndex = 46;
            this.lblOutputWIndow.Text = "Output Window";
            // 
            // lbErrors
            // 
            this.lbErrors.FormattingEnabled = true;
            this.lbErrors.HorizontalScrollbar = true;
            this.lbErrors.ItemHeight = 16;
            this.lbErrors.Location = new System.Drawing.Point(61, 465);
            this.lbErrors.Margin = new System.Windows.Forms.Padding(4);
            this.lbErrors.Name = "lbErrors";
            this.lbErrors.Size = new System.Drawing.Size(547, 116);
            this.lbErrors.TabIndex = 47;
            // 
            // lblErrorReport
            // 
            this.lblErrorReport.AutoSize = true;
            this.lblErrorReport.Location = new System.Drawing.Point(69, 434);
            this.lblErrorReport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErrorReport.Name = "lblErrorReport";
            this.lblErrorReport.Size = new System.Drawing.Size(82, 17);
            this.lblErrorReport.TabIndex = 48;
            this.lblErrorReport.Text = "Notifcations";
            // 
            // btnXwrite
            // 
            this.btnXwrite.Location = new System.Drawing.Point(1067, 357);
            this.btnXwrite.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXwrite.Name = "btnXwrite";
            this.btnXwrite.Size = new System.Drawing.Size(103, 94);
            this.btnXwrite.TabIndex = 49;
            this.btnXwrite.Text = "Xperimental batch write";
            this.btnXwrite.UseVisualStyleBackColor = true;
            this.btnXwrite.Click += new System.EventHandler(this.btnXwrite_Click);
            // 
            // lblDriveSelect
            // 
            this.lblDriveSelect.AutoSize = true;
            this.lblDriveSelect.Location = new System.Drawing.Point(644, 320);
            this.lblDriveSelect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDriveSelect.Name = "lblDriveSelect";
            this.lblDriveSelect.Size = new System.Drawing.Size(84, 17);
            this.lblDriveSelect.TabIndex = 50;
            this.lblDriveSelect.Text = "Select Drive";
            // 
            // cboDriveSelect
            // 
            this.cboDriveSelect.FormattingEnabled = true;
            this.cboDriveSelect.Items.AddRange(new object[] {
            "A",
            "B"});
            this.cboDriveSelect.Location = new System.Drawing.Point(648, 357);
            this.cboDriveSelect.Margin = new System.Windows.Forms.Padding(4);
            this.cboDriveSelect.Name = "cboDriveSelect";
            this.cboDriveSelect.Size = new System.Drawing.Size(81, 24);
            this.cboDriveSelect.TabIndex = 51;
            // 
            // cboComPort
            // 
            this.cboComPort.FormattingEnabled = true;
            this.cboComPort.Location = new System.Drawing.Point(29, 71);
            this.cboComPort.Name = "cboComPort";
            this.cboComPort.Size = new System.Drawing.Size(121, 24);
            this.cboComPort.TabIndex = 52;
            // 
            // lblComPort
            // 
            this.lblComPort.AutoSize = true;
            this.lblComPort.Location = new System.Drawing.Point(16, 49);
            this.lblComPort.Name = "lblComPort";
            this.lblComPort.Size = new System.Drawing.Size(188, 17);
            this.lblComPort.TabIndex = 53;
            this.lblComPort.Text = "Please Select your Com Port";
            this.lblComPort.Click += new System.EventHandler(this.lblComPort_Click);
            // 
            // btnRescan
            // 
            this.btnRescan.Location = new System.Drawing.Point(1094, 43);
            this.btnRescan.Name = "btnRescan";
            this.btnRescan.Size = new System.Drawing.Size(75, 80);
            this.btnRescan.TabIndex = 54;
            this.btnRescan.Text = "Rescan Com Ports";
            this.btnRescan.UseVisualStyleBackColor = true;
            this.btnRescan.Click += new System.EventHandler(this.btnRescan_Click);
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 674);
            this.Controls.Add(this.btnRescan);
            this.Controls.Add(this.lblComPort);
            this.Controls.Add(this.cboComPort);
            this.Controls.Add(this.cboDriveSelect);
            this.Controls.Add(this.lblDriveSelect);
            this.Controls.Add(this.btnXwrite);
            this.Controls.Add(this.lblErrorReport);
            this.Controls.Add(this.lbErrors);
            this.Controls.Add(this.lblOutputWIndow);
            this.Controls.Add(this.cboNumberOfDisks);
            this.Controls.Add(this.lblNoOfDisks);
            this.Controls.Add(this.lblDiag);
            this.Controls.Add(this.btnConvert2SCP);
            this.Controls.Add(this.btnConvert2ADF);
            this.Controls.Add(this.txtDiag);
            this.Controls.Add(this.txtSide);
            this.Controls.Add(this.lblSide);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lbOutput);
            this.Controls.Add(this.lblTrackNo);
            this.Controls.Add(this.txtTrackNo);
            this.Controls.Add(this.lblSettings);
            this.Controls.Add(this.btnChangeSettings);
            this.Controls.Add(this.btnLoadSettings);
            this.Controls.Add(this.txtDiskdefs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDiskdefs);
            this.Controls.Add(this.INIPath);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.cboRetries);
            this.Controls.Add(this.lblRetries);
            this.Controls.Add(this.btnSaveSettings);
            this.Controls.Add(this.lblDirectory);
            this.Controls.Add(this.txtGwtext);
            this.Controls.Add(this.btnGwinfo);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.lblDiskType);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.lblNumberOfTracks);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.cboTrackCombo);
            this.Controls.Add(this.LblFileInUse);
            this.Controls.Add(this.LblPercentComplete);
            this.Controls.Add(this.BtnQuit);
            this.Controls.Add(this.BtnWrite);
            this.Controls.Add(this.BtnRead);
            this.Controls.Add(this.prgProgressBar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMainForm";
            this.Text = "ADFDiskBox";
            this.Load += new System.EventHandler(this.frmMainForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar prgProgressBar1;
        private System.Windows.Forms.Button BtnRead;
        private System.Windows.Forms.Button BtnWrite;
        private System.Windows.Forms.Button BtnQuit;
        private System.Windows.Forms.Label LblPercentComplete;
        private System.Windows.Forms.Label LblFileInUse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ComboBox cboTrackCombo;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label lblNumberOfTracks;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem writeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label lblDiskType;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Button btnGwinfo;
        private System.Windows.Forms.Label lblDirectory;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.Label lblRetries;
        private System.Windows.Forms.ComboBox cboRetries;
        private System.Windows.Forms.Button btnChange;
        public System.Windows.Forms.TextBox txtGwtext;
        private System.Windows.Forms.TextBox INIPath;
        private System.Windows.Forms.Button btnDiskdefs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiskdefs;
        private System.Windows.Forms.Button btnLoadSettings;
        private System.Windows.Forms.Button btnChangeSettings;
        private System.Windows.Forms.Label lblSettings;
        private System.Windows.Forms.ToolStripMenuItem softwareLicenceToolStripMenuItem;
        private System.Windows.Forms.TextBox txtTrackNo;
        private System.Windows.Forms.Label lblTrackNo;
        private System.Windows.Forms.ListBox lbOutput;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Label lblSide;
        private System.Windows.Forms.TextBox txtSide;
        private System.Windows.Forms.TextBox txtDiag;
        private System.Windows.Forms.Button btnConvert2ADF;
        private System.Windows.Forms.Button btnConvert2SCP;
        private System.Windows.Forms.Label lblDiag;
        private System.Windows.Forms.Label lblNoOfDisks;
        private System.Windows.Forms.ComboBox cboNumberOfDisks;
        private System.Windows.Forms.Label lblOutputWIndow;
        private System.Windows.Forms.ListBox lbErrors;
        private System.Windows.Forms.Label lblErrorReport;
        private System.Windows.Forms.Button btnXwrite;
        private System.Windows.Forms.Label lblDriveSelect;
        private System.Windows.Forms.ComboBox cboDriveSelect;
        private System.Windows.Forms.ComboBox cboComPort;
        private System.Windows.Forms.Label lblComPort;
        private System.Windows.Forms.Button btnRescan;
    }
}

