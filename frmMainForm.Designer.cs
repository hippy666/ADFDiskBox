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
            this.lblRetries = new System.Windows.Forms.Label();
            this.cboRetries = new System.Windows.Forms.ComboBox();
            this.txtTrackNo = new System.Windows.Forms.TextBox();
            this.lblTrackNo = new System.Windows.Forms.Label();
            this.lbOutput = new System.Windows.Forms.ListBox();
            this.btnX = new System.Windows.Forms.Button();
            this.lblSide = new System.Windows.Forms.Label();
            this.txtSide = new System.Windows.Forms.TextBox();
            this.txtDiag = new System.Windows.Forms.TextBox();
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
            this.BtnLoadButton = new System.Windows.Forms.Button();
            this.btnRescan = new System.Windows.Forms.Button();
            this.BtnLoadHxC = new System.Windows.Forms.Button();
            this.BtnHxC2 = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // prgProgressBar1
            // 
            this.prgProgressBar1.Location = new System.Drawing.Point(12, 120);
            this.prgProgressBar1.Maximum = 162;
            this.prgProgressBar1.Name = "prgProgressBar1";
            this.prgProgressBar1.Size = new System.Drawing.Size(650, 23);
            this.prgProgressBar1.Step = 1;
            this.prgProgressBar1.TabIndex = 0;
            this.prgProgressBar1.Click += new System.EventHandler(this.prgProgressBar1_Click);
            // 
            // BtnRead
            // 
            this.BtnRead.Location = new System.Drawing.Point(504, 378);
            this.BtnRead.Name = "BtnRead";
            this.BtnRead.Size = new System.Drawing.Size(92, 95);
            this.BtnRead.TabIndex = 4;
            this.BtnRead.Text = "Read from floppy disk";
            this.BtnRead.UseVisualStyleBackColor = true;
            this.BtnRead.Click += new System.EventHandler(this.BtnRead_Click);
            // 
            // BtnWrite
            // 
            this.BtnWrite.Location = new System.Drawing.Point(653, 378);
            this.BtnWrite.Name = "BtnWrite";
            this.BtnWrite.Size = new System.Drawing.Size(91, 95);
            this.BtnWrite.TabIndex = 5;
            this.BtnWrite.Text = "Write To Floppy Disk";
            this.BtnWrite.UseVisualStyleBackColor = true;
            this.BtnWrite.Click += new System.EventHandler(this.BtnWrite_Click);
            // 
            // BtnQuit
            // 
            this.BtnQuit.Location = new System.Drawing.Point(790, 378);
            this.BtnQuit.Name = "BtnQuit";
            this.BtnQuit.Size = new System.Drawing.Size(87, 95);
            this.BtnQuit.TabIndex = 6;
            this.BtnQuit.Text = "Quit";
            this.BtnQuit.UseVisualStyleBackColor = true;
            this.BtnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // LblPercentComplete
            // 
            this.LblPercentComplete.AutoSize = true;
            this.LblPercentComplete.Location = new System.Drawing.Point(9, 104);
            this.LblPercentComplete.Name = "LblPercentComplete";
            this.LblPercentComplete.Size = new System.Drawing.Size(67, 13);
            this.LblPercentComplete.TabIndex = 7;
            this.LblPercentComplete.Text = "Progress Bar";
            // 
            // LblFileInUse
            // 
            this.LblFileInUse.AutoSize = true;
            this.LblFileInUse.Location = new System.Drawing.Point(186, 156);
            this.LblFileInUse.Name = "LblFileInUse";
            this.LblFileInUse.Size = new System.Drawing.Size(74, 13);
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
            this.cboTrackCombo.Location = new System.Drawing.Point(129, 172);
            this.cboTrackCombo.MaxDropDownItems = 2;
            this.cboTrackCombo.Name = "cboTrackCombo";
            this.cboTrackCombo.Size = new System.Drawing.Size(45, 21);
            this.cboTrackCombo.Sorted = true;
            this.cboTrackCombo.TabIndex = 9;
            this.cboTrackCombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(197, 180);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(63, 13);
            this.lblFileName.TabIndex = 10;
            this.lblFileName.Text = "C:\\temp.adf";
            // 
            // lblNumberOfTracks
            // 
            this.lblNumberOfTracks.AutoSize = true;
            this.lblNumberOfTracks.Location = new System.Drawing.Point(126, 156);
            this.lblNumberOfTracks.Name = "lblNumberOfTracks";
            this.lblNumberOfTracks.Size = new System.Drawing.Size(40, 13);
            this.lblNumberOfTracks.TabIndex = 11;
            this.lblNumberOfTracks.Text = "Tracks";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 547);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(938, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Ready";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(938, 24);
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
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(938, 24);
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
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
            this.toolStripSeparator.Size = new System.Drawing.Size(144, 6);
            // 
            // writeToolStripMenuItem
            // 
            this.writeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("writeToolStripMenuItem.Image")));
            this.writeToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.writeToolStripMenuItem.Name = "writeToolStripMenuItem";
            this.writeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.writeToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.writeToolStripMenuItem.Text = "&Write";
            this.writeToolStripMenuItem.Click += new System.EventHandler(this.writeToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(144, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(144, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
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
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.softwareLicenceToolStripMenuItem});
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // softwareLicenceToolStripMenuItem
            // 
            this.softwareLicenceToolStripMenuItem.Name = "softwareLicenceToolStripMenuItem";
            this.softwareLicenceToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.softwareLicenceToolStripMenuItem.Text = "Software licence";
            this.softwareLicenceToolStripMenuItem.Click += new System.EventHandler(this.softwareLicenceToolStripMenuItem_Click);
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(119, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // lblDiskType
            // 
            this.lblDiskType.AutoSize = true;
            this.lblDiskType.Location = new System.Drawing.Point(244, 40);
            this.lblDiskType.Name = "lblDiskType";
            this.lblDiskType.Size = new System.Drawing.Size(52, 13);
            this.lblDiskType.TabIndex = 17;
            this.lblDiskType.Text = "DiskType";
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "AmigaDos",
            "AmigaDosSCP",
            "SCP"});
            this.cboType.Location = new System.Drawing.Point(236, 71);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(105, 21);
            this.cboType.TabIndex = 18;
            this.cboType.SelectedIndexChanged += new System.EventHandler(this.cboType_SelectedIndexChanged);
            // 
            // btnGwinfo
            // 
            this.btnGwinfo.Location = new System.Drawing.Point(699, 63);
            this.btnGwinfo.Name = "btnGwinfo";
            this.btnGwinfo.Size = new System.Drawing.Size(87, 35);
            this.btnGwinfo.TabIndex = 19;
            this.btnGwinfo.Text = "Greaseweazle Info";
            this.btnGwinfo.UseVisualStyleBackColor = true;
            this.btnGwinfo.Click += new System.EventHandler(this.btnGwinfo_Click);
            // 
            // lblRetries
            // 
            this.lblRetries.AutoSize = true;
            this.lblRetries.Location = new System.Drawing.Point(346, 40);
            this.lblRetries.Name = "lblRetries";
            this.lblRetries.Size = new System.Drawing.Size(105, 13);
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
            this.cboRetries.Location = new System.Drawing.Point(370, 71);
            this.cboRetries.MaxDropDownItems = 99;
            this.cboRetries.Name = "cboRetries";
            this.cboRetries.Size = new System.Drawing.Size(56, 21);
            this.cboRetries.TabIndex = 23;
            this.cboRetries.SelectedIndexChanged += new System.EventHandler(this.cboRetries_SelectedIndexChanged);
            // 
            // txtTrackNo
            // 
            this.txtTrackNo.Location = new System.Drawing.Point(12, 172);
            this.txtTrackNo.Name = "txtTrackNo";
            this.txtTrackNo.Size = new System.Drawing.Size(49, 20);
            this.txtTrackNo.TabIndex = 33;
            // 
            // lblTrackNo
            // 
            this.lblTrackNo.AutoSize = true;
            this.lblTrackNo.Location = new System.Drawing.Point(12, 156);
            this.lblTrackNo.Name = "lblTrackNo";
            this.lblTrackNo.Size = new System.Drawing.Size(49, 13);
            this.lblTrackNo.TabIndex = 34;
            this.lblTrackNo.Text = "TrackNo";
            // 
            // lbOutput
            // 
            this.lbOutput.FormattingEnabled = true;
            this.lbOutput.Location = new System.Drawing.Point(46, 235);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(411, 95);
            this.lbOutput.TabIndex = 35;
            // 
            // btnX
            // 
            this.btnX.Location = new System.Drawing.Point(504, 235);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(75, 76);
            this.btnX.TabIndex = 37;
            this.btnX.Text = "batch read";
            this.btnX.UseVisualStyleBackColor = true;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // lblSide
            // 
            this.lblSide.AutoSize = true;
            this.lblSide.Location = new System.Drawing.Point(68, 156);
            this.lblSide.Name = "lblSide";
            this.lblSide.Size = new System.Drawing.Size(28, 13);
            this.lblSide.TabIndex = 38;
            this.lblSide.Text = "Side";
            // 
            // txtSide
            // 
            this.txtSide.Location = new System.Drawing.Point(71, 172);
            this.txtSide.Name = "txtSide";
            this.txtSide.Size = new System.Drawing.Size(42, 20);
            this.txtSide.TabIndex = 39;
            // 
            // txtDiag
            // 
            this.txtDiag.Location = new System.Drawing.Point(46, 503);
            this.txtDiag.Name = "txtDiag";
            this.txtDiag.Size = new System.Drawing.Size(409, 20);
            this.txtDiag.TabIndex = 40;
            // 
            // lblDiag
            // 
            this.lblDiag.AutoSize = true;
            this.lblDiag.Location = new System.Drawing.Point(43, 487);
            this.lblDiag.Name = "lblDiag";
            this.lblDiag.Size = new System.Drawing.Size(73, 13);
            this.lblDiag.TabIndex = 43;
            this.lblDiag.Text = "Last Message";
            // 
            // lblNoOfDisks
            // 
            this.lblNoOfDisks.AutoSize = true;
            this.lblNoOfDisks.Location = new System.Drawing.Point(562, 46);
            this.lblNoOfDisks.MaximumSize = new System.Drawing.Size(68, 73);
            this.lblNoOfDisks.Name = "lblNoOfDisks";
            this.lblNoOfDisks.Size = new System.Drawing.Size(63, 52);
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
            this.cboNumberOfDisks.Location = new System.Drawing.Point(631, 71);
            this.cboNumberOfDisks.Name = "cboNumberOfDisks";
            this.cboNumberOfDisks.Size = new System.Drawing.Size(50, 21);
            this.cboNumberOfDisks.TabIndex = 45;
            // 
            // lblOutputWIndow
            // 
            this.lblOutputWIndow.AutoSize = true;
            this.lblOutputWIndow.Location = new System.Drawing.Point(49, 205);
            this.lblOutputWIndow.Name = "lblOutputWIndow";
            this.lblOutputWIndow.Size = new System.Drawing.Size(81, 13);
            this.lblOutputWIndow.TabIndex = 46;
            this.lblOutputWIndow.Text = "Output Window";
            // 
            // lbErrors
            // 
            this.lbErrors.FormattingEnabled = true;
            this.lbErrors.HorizontalScrollbar = true;
            this.lbErrors.Location = new System.Drawing.Point(46, 378);
            this.lbErrors.Name = "lbErrors";
            this.lbErrors.Size = new System.Drawing.Size(411, 95);
            this.lbErrors.TabIndex = 47;
            // 
            // lblErrorReport
            // 
            this.lblErrorReport.AutoSize = true;
            this.lblErrorReport.Location = new System.Drawing.Point(52, 353);
            this.lblErrorReport.Name = "lblErrorReport";
            this.lblErrorReport.Size = new System.Drawing.Size(63, 13);
            this.lblErrorReport.TabIndex = 48;
            this.lblErrorReport.Text = "Notifcations";
            // 
            // btnXwrite
            // 
            this.btnXwrite.Location = new System.Drawing.Point(604, 235);
            this.btnXwrite.Margin = new System.Windows.Forms.Padding(2);
            this.btnXwrite.Name = "btnXwrite";
            this.btnXwrite.Size = new System.Drawing.Size(77, 76);
            this.btnXwrite.TabIndex = 49;
            this.btnXwrite.Text = "batch write";
            this.btnXwrite.UseVisualStyleBackColor = true;
            this.btnXwrite.Click += new System.EventHandler(this.btnXwrite_Click);
            // 
            // lblDriveSelect
            // 
            this.lblDriveSelect.AutoSize = true;
            this.lblDriveSelect.Location = new System.Drawing.Point(466, 40);
            this.lblDriveSelect.Name = "lblDriveSelect";
            this.lblDriveSelect.Size = new System.Drawing.Size(65, 13);
            this.lblDriveSelect.TabIndex = 50;
            this.lblDriveSelect.Text = "Select Drive";
            // 
            // cboDriveSelect
            // 
            this.cboDriveSelect.FormattingEnabled = true;
            this.cboDriveSelect.Items.AddRange(new object[] {
            "A",
            "B"});
            this.cboDriveSelect.Location = new System.Drawing.Point(469, 71);
            this.cboDriveSelect.Name = "cboDriveSelect";
            this.cboDriveSelect.Size = new System.Drawing.Size(62, 21);
            this.cboDriveSelect.TabIndex = 51;
            // 
            // cboComPort
            // 
            this.cboComPort.FormattingEnabled = true;
            this.cboComPort.Location = new System.Drawing.Point(15, 71);
            this.cboComPort.Margin = new System.Windows.Forms.Padding(2);
            this.cboComPort.Name = "cboComPort";
            this.cboComPort.Size = new System.Drawing.Size(92, 21);
            this.cboComPort.TabIndex = 52;
            // 
            // lblComPort
            // 
            this.lblComPort.AutoSize = true;
            this.lblComPort.Location = new System.Drawing.Point(12, 40);
            this.lblComPort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblComPort.Name = "lblComPort";
            this.lblComPort.Size = new System.Drawing.Size(132, 13);
            this.lblComPort.TabIndex = 53;
            this.lblComPort.Text = "Please Select your Device";
            this.lblComPort.Click += new System.EventHandler(this.lblComPort_Click);
            // 
            // BtnLoadButton
            // 
            this.BtnLoadButton.Location = new System.Drawing.Point(730, 241);
            this.BtnLoadButton.Name = "BtnLoadButton";
            this.BtnLoadButton.Size = new System.Drawing.Size(75, 70);
            this.BtnLoadButton.TabIndex = 56;
            this.BtnLoadButton.Text = "Load Options";
            this.BtnLoadButton.UseVisualStyleBackColor = true;
            this.BtnLoadButton.Click += new System.EventHandler(this.BtnLoadButton_Click);
            // 
            // btnRescan
            // 
            this.btnRescan.Location = new System.Drawing.Point(157, 33);
            this.btnRescan.Margin = new System.Windows.Forms.Padding(2);
            this.btnRescan.Name = "btnRescan";
            this.btnRescan.Size = new System.Drawing.Size(56, 65);
            this.btnRescan.TabIndex = 57;
            this.btnRescan.Text = "Rescan Com Ports";
            this.btnRescan.UseVisualStyleBackColor = true;
            this.btnRescan.Click += new System.EventHandler(this.btnRescan_Click_1);
            // 
            // BtnLoadHxC
            // 
            this.BtnLoadHxC.Location = new System.Drawing.Point(699, 120);
            this.BtnLoadHxC.Name = "BtnLoadHxC";
            this.BtnLoadHxC.Size = new System.Drawing.Size(87, 72);
            this.BtnLoadHxC.TabIndex = 58;
            this.BtnLoadHxC.Text = "LoadHxC Lastfile";
            this.BtnLoadHxC.UseVisualStyleBackColor = true;
            this.BtnLoadHxC.Click += new System.EventHandler(this.BtnLoadHxC_Click);
            // 
            // BtnHxC2
            // 
            this.BtnHxC2.Location = new System.Drawing.Point(822, 120);
            this.BtnHxC2.Name = "BtnHxC2";
            this.BtnHxC2.Size = new System.Drawing.Size(88, 72);
            this.BtnHxC2.TabIndex = 59;
            this.BtnHxC2.Text = "Alt Load HxC";
            this.BtnHxC2.UseVisualStyleBackColor = true;
            this.BtnHxC2.Click += new System.EventHandler(this.BtnHxC2_Click);
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 569);
            this.Controls.Add(this.BtnHxC2);
            this.Controls.Add(this.BtnLoadHxC);
            this.Controls.Add(this.btnRescan);
            this.Controls.Add(this.BtnLoadButton);
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
            this.Controls.Add(this.txtDiag);
            this.Controls.Add(this.txtSide);
            this.Controls.Add(this.lblSide);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.lbOutput);
            this.Controls.Add(this.lblTrackNo);
            this.Controls.Add(this.txtTrackNo);
            this.Controls.Add(this.cboRetries);
            this.Controls.Add(this.lblRetries);
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
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label lblDiskType;
        private System.Windows.Forms.Button btnGwinfo;
        private System.Windows.Forms.Label lblRetries;
        private System.Windows.Forms.ToolStripMenuItem softwareLicenceToolStripMenuItem;
        private System.Windows.Forms.TextBox txtTrackNo;
        private System.Windows.Forms.Label lblTrackNo;
        private System.Windows.Forms.ListBox lbOutput;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Label lblSide;
        private System.Windows.Forms.TextBox txtSide;
        private System.Windows.Forms.TextBox txtDiag;
        private System.Windows.Forms.Label lblDiag;
        private System.Windows.Forms.Label lblNoOfDisks;
        private System.Windows.Forms.Label lblOutputWIndow;
        private System.Windows.Forms.ListBox lbErrors;
        private System.Windows.Forms.Label lblErrorReport;
        private System.Windows.Forms.Button btnXwrite;
        private System.Windows.Forms.Label lblDriveSelect;
        private System.Windows.Forms.Label lblComPort;
        public System.Windows.Forms.ComboBox cboComPort;
        private System.Windows.Forms.Button BtnLoadButton;
        public System.Windows.Forms.ComboBox cboType;
        public System.Windows.Forms.ComboBox cboRetries;
        public System.Windows.Forms.ComboBox cboTrackCombo;
        public System.Windows.Forms.Label lblFileName;
        public System.Windows.Forms.ComboBox cboNumberOfDisks;
        public System.Windows.Forms.ComboBox cboDriveSelect;
        private System.Windows.Forms.Button btnRescan;
        private System.Windows.Forms.Button BtnLoadHxC;
        private System.Windows.Forms.Button BtnHxC2;
    }
}

