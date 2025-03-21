
namespace ADFDiskBox
{
    partial class FrmOptions
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
            this.lblComPort = new System.Windows.Forms.Label();
            this.cboComPort = new System.Windows.Forms.ComboBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.lblDirectory = new System.Windows.Forms.Label();
            this.txtGwtext = new System.Windows.Forms.TextBox();
            this.btnChangeSettings = new System.Windows.Forms.Button();
            this.lblSettings = new System.Windows.Forms.Label();
            this.INIPath = new System.Windows.Forms.TextBox();
            this.btnDiskdefs = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiskdefs = new System.Windows.Forms.TextBox();
            this.btnConvert2ADF = new System.Windows.Forms.Button();
            this.btnConvert2SCP = new System.Windows.Forms.Button();
            this.btnRescan = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.BtnLoadSettings = new System.Windows.Forms.Button();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.lbOutput = new System.Windows.Forms.ListBox();
            this.lblOutputWIndow = new System.Windows.Forms.Label();
            this.lblErrorReport = new System.Windows.Forms.Label();
            this.lbErrors = new System.Windows.Forms.ListBox();
            this.lblDiag = new System.Windows.Forms.Label();
            this.txtDiag = new System.Windows.Forms.TextBox();
            this.BtnCloseButton = new System.Windows.Forms.Button();
            this.btnGwinfo = new System.Windows.Forms.Button();
            this.LblPercentComplete = new System.Windows.Forms.Label();
            this.prgProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblTrackNo = new System.Windows.Forms.Label();
            this.txtTrackNo = new System.Windows.Forms.TextBox();
            this.lblSide = new System.Windows.Forms.Label();
            this.txtSide = new System.Windows.Forms.TextBox();
            this.lblNumberOfTracks = new System.Windows.Forms.Label();
            this.cboTrackCombo = new System.Windows.Forms.ComboBox();
            this.lblDiskType = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.lblRetries = new System.Windows.Forms.Label();
            this.cboRetries = new System.Windows.Forms.ComboBox();
            this.lblDriveSelect = new System.Windows.Forms.Label();
            this.cboDriveSelect = new System.Windows.Forms.ComboBox();
            this.lblNoOfDisks = new System.Windows.Forms.Label();
            this.cboNumberOfDisks = new System.Windows.Forms.ComboBox();
            this.LblFileInUse = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BtnTestbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblComPort
            // 
            this.lblComPort.AutoSize = true;
            this.lblComPort.Location = new System.Drawing.Point(0, 32);
            this.lblComPort.Name = "lblComPort";
            this.lblComPort.Size = new System.Drawing.Size(132, 13);
            this.lblComPort.TabIndex = 1;
            this.lblComPort.Text = "Please Select your Device";
            // 
            // cboComPort
            // 
            this.cboComPort.FormattingEnabled = true;
            this.cboComPort.Location = new System.Drawing.Point(3, 48);
            this.cboComPort.Name = "cboComPort";
            this.cboComPort.Size = new System.Drawing.Size(121, 21);
            this.cboComPort.TabIndex = 2;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(457, 107);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(150, 31);
            this.btnChange.TabIndex = 25;
            this.btnChange.Text = "change Host Tools path";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // lblDirectory
            // 
            this.lblDirectory.AutoSize = true;
            this.lblDirectory.Location = new System.Drawing.Point(461, 141);
            this.lblDirectory.Name = "lblDirectory";
            this.lblDirectory.Size = new System.Drawing.Size(121, 13);
            this.lblDirectory.TabIndex = 26;
            this.lblDirectory.Text = "Path To GW Host Tools";
            // 
            // txtGwtext
            // 
            this.txtGwtext.Location = new System.Drawing.Point(457, 157);
            this.txtGwtext.Name = "txtGwtext";
            this.txtGwtext.ReadOnly = true;
            this.txtGwtext.Size = new System.Drawing.Size(344, 20);
            this.txtGwtext.TabIndex = 27;
            this.txtGwtext.Text = "C:\\Greaseweazle";
            // 
            // btnChangeSettings
            // 
            this.btnChangeSettings.Location = new System.Drawing.Point(456, 25);
            this.btnChangeSettings.Name = "btnChangeSettings";
            this.btnChangeSettings.Size = new System.Drawing.Size(178, 37);
            this.btnChangeSettings.TabIndex = 32;
            this.btnChangeSettings.Text = "Reset Path To Settings";
            this.btnChangeSettings.UseVisualStyleBackColor = true;
            this.btnChangeSettings.Click += new System.EventHandler(this.btnChangeSettings_Click);
            // 
            // lblSettings
            // 
            this.lblSettings.AutoSize = true;
            this.lblSettings.Location = new System.Drawing.Point(461, 65);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(80, 13);
            this.lblSettings.TabIndex = 33;
            this.lblSettings.Text = "Path to settings";
            // 
            // INIPath
            // 
            this.INIPath.Enabled = false;
            this.INIPath.Location = new System.Drawing.Point(456, 81);
            this.INIPath.Name = "INIPath";
            this.INIPath.ReadOnly = true;
            this.INIPath.Size = new System.Drawing.Size(345, 20);
            this.INIPath.TabIndex = 34;
            this.INIPath.Text = "C:\\greasewezel";
            // 
            // btnDiskdefs
            // 
            this.btnDiskdefs.Location = new System.Drawing.Point(59, 229);
            this.btnDiskdefs.Name = "btnDiskdefs";
            this.btnDiskdefs.Size = new System.Drawing.Size(142, 55);
            this.btnDiskdefs.TabIndex = 35;
            this.btnDiskdefs.Text = "Change Diskdefs Path";
            this.btnDiskdefs.UseVisualStyleBackColor = true;
            this.btnDiskdefs.Click += new System.EventHandler(this.btnDiskdefs_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Path To Diskdefs";
            // 
            // txtDiskdefs
            // 
            this.txtDiskdefs.Location = new System.Drawing.Point(29, 310);
            this.txtDiskdefs.Name = "txtDiskdefs";
            this.txtDiskdefs.Size = new System.Drawing.Size(419, 20);
            this.txtDiskdefs.TabIndex = 37;
            // 
            // btnConvert2ADF
            // 
            this.btnConvert2ADF.Location = new System.Drawing.Point(726, 24);
            this.btnConvert2ADF.Name = "btnConvert2ADF";
            this.btnConvert2ADF.Size = new System.Drawing.Size(75, 39);
            this.btnConvert2ADF.TabIndex = 42;
            this.btnConvert2ADF.Text = "Convert scp 2 adf";
            this.btnConvert2ADF.UseVisualStyleBackColor = true;
            this.btnConvert2ADF.Click += new System.EventHandler(this.btnConvert2ADF_Click);
            // 
            // btnConvert2SCP
            // 
            this.btnConvert2SCP.Location = new System.Drawing.Point(645, 22);
            this.btnConvert2SCP.Name = "btnConvert2SCP";
            this.btnConvert2SCP.Size = new System.Drawing.Size(75, 42);
            this.btnConvert2SCP.TabIndex = 43;
            this.btnConvert2SCP.Text = "Convert adf 2 scp";
            this.btnConvert2SCP.UseVisualStyleBackColor = true;
            this.btnConvert2SCP.Click += new System.EventHandler(this.btnConvert2SCP_Click);
            // 
            // btnRescan
            // 
            this.btnRescan.Location = new System.Drawing.Point(146, 25);
            this.btnRescan.Margin = new System.Windows.Forms.Padding(2);
            this.btnRescan.Name = "btnRescan";
            this.btnRescan.Size = new System.Drawing.Size(56, 65);
            this.btnRescan.TabIndex = 55;
            this.btnRescan.Text = "Rescan Com Ports";
            this.btnRescan.UseVisualStyleBackColor = true;
            this.btnRescan.Click += new System.EventHandler(this.btnRescan_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(338, 24);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(99, 69);
            this.btnUpdate.TabIndex = 56;
            this.btnUpdate.Text = "Update My Greaseweazle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(560, 550);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(102, 69);
            this.btnReset.TabIndex = 57;
            this.btnReset.Text = "Reset Settings to Factory";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // BtnLoadSettings
            // 
            this.BtnLoadSettings.Location = new System.Drawing.Point(560, 466);
            this.BtnLoadSettings.Name = "BtnLoadSettings";
            this.BtnLoadSettings.Size = new System.Drawing.Size(102, 65);
            this.BtnLoadSettings.TabIndex = 58;
            this.BtnLoadSettings.Text = "Load Saved Settings";
            this.BtnLoadSettings.UseVisualStyleBackColor = true;
            this.BtnLoadSettings.Click += new System.EventHandler(this.BtnLoadSettings_Click);
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Location = new System.Drawing.Point(683, 466);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(99, 65);
            this.btnSaveSettings.TabIndex = 59;
            this.btnSaveSettings.Text = "SaveSettings";
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // lbOutput
            // 
            this.lbOutput.FormattingEnabled = true;
            this.lbOutput.Location = new System.Drawing.Point(26, 368);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(411, 95);
            this.lbOutput.TabIndex = 60;
            // 
            // lblOutputWIndow
            // 
            this.lblOutputWIndow.AutoSize = true;
            this.lblOutputWIndow.Location = new System.Drawing.Point(26, 352);
            this.lblOutputWIndow.Name = "lblOutputWIndow";
            this.lblOutputWIndow.Size = new System.Drawing.Size(81, 13);
            this.lblOutputWIndow.TabIndex = 61;
            this.lblOutputWIndow.Text = "Output Window";
            // 
            // lblErrorReport
            // 
            this.lblErrorReport.AutoSize = true;
            this.lblErrorReport.Location = new System.Drawing.Point(26, 466);
            this.lblErrorReport.Name = "lblErrorReport";
            this.lblErrorReport.Size = new System.Drawing.Size(63, 13);
            this.lblErrorReport.TabIndex = 62;
            this.lblErrorReport.Text = "Notifcations";
            // 
            // lbErrors
            // 
            this.lbErrors.FormattingEnabled = true;
            this.lbErrors.HorizontalScrollbar = true;
            this.lbErrors.Location = new System.Drawing.Point(26, 485);
            this.lbErrors.Name = "lbErrors";
            this.lbErrors.Size = new System.Drawing.Size(411, 95);
            this.lbErrors.TabIndex = 63;
            // 
            // lblDiag
            // 
            this.lblDiag.AutoSize = true;
            this.lblDiag.Location = new System.Drawing.Point(23, 583);
            this.lblDiag.Name = "lblDiag";
            this.lblDiag.Size = new System.Drawing.Size(73, 13);
            this.lblDiag.TabIndex = 64;
            this.lblDiag.Text = "Last Message";
            // 
            // txtDiag
            // 
            this.txtDiag.Location = new System.Drawing.Point(26, 601);
            this.txtDiag.Name = "txtDiag";
            this.txtDiag.Size = new System.Drawing.Size(409, 20);
            this.txtDiag.TabIndex = 65;
            // 
            // BtnCloseButton
            // 
            this.BtnCloseButton.Location = new System.Drawing.Point(683, 550);
            this.BtnCloseButton.Name = "BtnCloseButton";
            this.BtnCloseButton.Size = new System.Drawing.Size(131, 71);
            this.BtnCloseButton.TabIndex = 66;
            this.BtnCloseButton.Text = "Close Options";
            this.BtnCloseButton.UseVisualStyleBackColor = true;
            this.BtnCloseButton.Click += new System.EventHandler(this.BtnCloseButton_Click);
            // 
            // btnGwinfo
            // 
            this.btnGwinfo.Location = new System.Drawing.Point(222, 29);
            this.btnGwinfo.Name = "btnGwinfo";
            this.btnGwinfo.Size = new System.Drawing.Size(87, 61);
            this.btnGwinfo.TabIndex = 67;
            this.btnGwinfo.Text = "Greaseweazle Info";
            this.btnGwinfo.UseVisualStyleBackColor = true;
            this.btnGwinfo.Click += new System.EventHandler(this.btnGwinfo_Click);
            // 
            // LblPercentComplete
            // 
            this.LblPercentComplete.AutoSize = true;
            this.LblPercentComplete.Location = new System.Drawing.Point(143, 164);
            this.LblPercentComplete.Name = "LblPercentComplete";
            this.LblPercentComplete.Size = new System.Drawing.Size(67, 13);
            this.LblPercentComplete.TabIndex = 68;
            this.LblPercentComplete.Text = "Progress Bar";
            // 
            // prgProgressBar1
            // 
            this.prgProgressBar1.Location = new System.Drawing.Point(59, 183);
            this.prgProgressBar1.Maximum = 162;
            this.prgProgressBar1.Name = "prgProgressBar1";
            this.prgProgressBar1.Size = new System.Drawing.Size(650, 23);
            this.prgProgressBar1.Step = 1;
            this.prgProgressBar1.TabIndex = 69;
            // 
            // lblTrackNo
            // 
            this.lblTrackNo.AutoSize = true;
            this.lblTrackNo.Location = new System.Drawing.Point(0, 100);
            this.lblTrackNo.Name = "lblTrackNo";
            this.lblTrackNo.Size = new System.Drawing.Size(49, 13);
            this.lblTrackNo.TabIndex = 70;
            this.lblTrackNo.Text = "TrackNo";
            // 
            // txtTrackNo
            // 
            this.txtTrackNo.Location = new System.Drawing.Point(0, 117);
            this.txtTrackNo.Name = "txtTrackNo";
            this.txtTrackNo.Size = new System.Drawing.Size(49, 20);
            this.txtTrackNo.TabIndex = 71;
            // 
            // lblSide
            // 
            this.lblSide.AutoSize = true;
            this.lblSide.Location = new System.Drawing.Point(76, 100);
            this.lblSide.Name = "lblSide";
            this.lblSide.Size = new System.Drawing.Size(28, 13);
            this.lblSide.TabIndex = 72;
            this.lblSide.Text = "Side";
            this.lblSide.Click += new System.EventHandler(this.lblSide_Click);
            // 
            // txtSide
            // 
            this.txtSide.Location = new System.Drawing.Point(79, 116);
            this.txtSide.Name = "txtSide";
            this.txtSide.Size = new System.Drawing.Size(42, 20);
            this.txtSide.TabIndex = 73;
            // 
            // lblNumberOfTracks
            // 
            this.lblNumberOfTracks.AutoSize = true;
            this.lblNumberOfTracks.Location = new System.Drawing.Point(143, 100);
            this.lblNumberOfTracks.Name = "lblNumberOfTracks";
            this.lblNumberOfTracks.Size = new System.Drawing.Size(40, 13);
            this.lblNumberOfTracks.TabIndex = 74;
            this.lblNumberOfTracks.Text = "Tracks";
            // 
            // cboTrackCombo
            // 
            this.cboTrackCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrackCombo.FormattingEnabled = true;
            this.cboTrackCombo.Items.AddRange(new object[] {
            "79",
            "81"});
            this.cboTrackCombo.Location = new System.Drawing.Point(146, 117);
            this.cboTrackCombo.MaxDropDownItems = 2;
            this.cboTrackCombo.Name = "cboTrackCombo";
            this.cboTrackCombo.Size = new System.Drawing.Size(45, 21);
            this.cboTrackCombo.Sorted = true;
            this.cboTrackCombo.TabIndex = 75;
            // 
            // lblDiskType
            // 
            this.lblDiskType.AutoSize = true;
            this.lblDiskType.Location = new System.Drawing.Point(205, 102);
            this.lblDiskType.Name = "lblDiskType";
            this.lblDiskType.Size = new System.Drawing.Size(52, 13);
            this.lblDiskType.TabIndex = 76;
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
            this.cboType.Location = new System.Drawing.Point(208, 118);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(71, 21);
            this.cboType.TabIndex = 77;
            // 
            // lblRetries
            // 
            this.lblRetries.AutoSize = true;
            this.lblRetries.Location = new System.Drawing.Point(301, 107);
            this.lblRetries.Name = "lblRetries";
            this.lblRetries.Size = new System.Drawing.Size(105, 13);
            this.lblRetries.TabIndex = 78;
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
            this.cboRetries.Location = new System.Drawing.Point(304, 123);
            this.cboRetries.MaxDropDownItems = 99;
            this.cboRetries.Name = "cboRetries";
            this.cboRetries.Size = new System.Drawing.Size(56, 21);
            this.cboRetries.TabIndex = 79;
            // 
            // lblDriveSelect
            // 
            this.lblDriveSelect.AutoSize = true;
            this.lblDriveSelect.Location = new System.Drawing.Point(454, 229);
            this.lblDriveSelect.Name = "lblDriveSelect";
            this.lblDriveSelect.Size = new System.Drawing.Size(65, 13);
            this.lblDriveSelect.TabIndex = 80;
            this.lblDriveSelect.Text = "Select Drive";
            // 
            // cboDriveSelect
            // 
            this.cboDriveSelect.FormattingEnabled = true;
            this.cboDriveSelect.Items.AddRange(new object[] {
            "A",
            "B"});
            this.cboDriveSelect.Location = new System.Drawing.Point(456, 245);
            this.cboDriveSelect.Name = "cboDriveSelect";
            this.cboDriveSelect.Size = new System.Drawing.Size(62, 21);
            this.cboDriveSelect.TabIndex = 81;
            // 
            // lblNoOfDisks
            // 
            this.lblNoOfDisks.AutoSize = true;
            this.lblNoOfDisks.Location = new System.Drawing.Point(544, 229);
            this.lblNoOfDisks.MaximumSize = new System.Drawing.Size(68, 73);
            this.lblNoOfDisks.Name = "lblNoOfDisks";
            this.lblNoOfDisks.Size = new System.Drawing.Size(63, 52);
            this.lblNoOfDisks.TabIndex = 82;
            this.lblNoOfDisks.Text = "Select Number Of Disks for batch mode";
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
            this.cboNumberOfDisks.Location = new System.Drawing.Point(547, 284);
            this.cboNumberOfDisks.Name = "cboNumberOfDisks";
            this.cboNumberOfDisks.Size = new System.Drawing.Size(50, 21);
            this.cboNumberOfDisks.TabIndex = 83;
            // 
            // LblFileInUse
            // 
            this.LblFileInUse.AutoSize = true;
            this.LblFileInUse.Location = new System.Drawing.Point(490, 313);
            this.LblFileInUse.Name = "LblFileInUse";
            this.LblFileInUse.Size = new System.Drawing.Size(74, 13);
            this.LblFileInUse.TabIndex = 84;
            this.LblFileInUse.Text = "Last File Used";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(490, 338);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(52, 13);
            this.lblFileName.TabIndex = 85;
            this.lblFileName.Text = "Blank.adf";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BtnTestbutton
            // 
            this.BtnTestbutton.Location = new System.Drawing.Point(816, 245);
            this.BtnTestbutton.Name = "BtnTestbutton";
            this.BtnTestbutton.Size = new System.Drawing.Size(75, 23);
            this.BtnTestbutton.TabIndex = 86;
            this.BtnTestbutton.Text = "testbutton";
            this.BtnTestbutton.UseVisualStyleBackColor = true;
            this.BtnTestbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 749);
            this.Controls.Add(this.BtnTestbutton);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.LblFileInUse);
            this.Controls.Add(this.cboNumberOfDisks);
            this.Controls.Add(this.lblNoOfDisks);
            this.Controls.Add(this.cboDriveSelect);
            this.Controls.Add(this.lblDriveSelect);
            this.Controls.Add(this.cboRetries);
            this.Controls.Add(this.lblRetries);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.lblDiskType);
            this.Controls.Add(this.cboTrackCombo);
            this.Controls.Add(this.lblNumberOfTracks);
            this.Controls.Add(this.txtSide);
            this.Controls.Add(this.lblSide);
            this.Controls.Add(this.txtTrackNo);
            this.Controls.Add(this.lblTrackNo);
            this.Controls.Add(this.prgProgressBar1);
            this.Controls.Add(this.LblPercentComplete);
            this.Controls.Add(this.btnGwinfo);
            this.Controls.Add(this.BtnCloseButton);
            this.Controls.Add(this.txtDiag);
            this.Controls.Add(this.lblDiag);
            this.Controls.Add(this.lbErrors);
            this.Controls.Add(this.lblErrorReport);
            this.Controls.Add(this.lblOutputWIndow);
            this.Controls.Add(this.lbOutput);
            this.Controls.Add(this.btnSaveSettings);
            this.Controls.Add(this.BtnLoadSettings);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRescan);
            this.Controls.Add(this.btnConvert2SCP);
            this.Controls.Add(this.btnConvert2ADF);
            this.Controls.Add(this.txtDiskdefs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDiskdefs);
            this.Controls.Add(this.INIPath);
            this.Controls.Add(this.lblSettings);
            this.Controls.Add(this.btnChangeSettings);
            this.Controls.Add(this.txtGwtext);
            this.Controls.Add(this.lblDirectory);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.cboComPort);
            this.Controls.Add(this.lblComPort);
            this.Name = "FrmOptions";
            this.Text = "Options";
            this.Load += new System.EventHandler(this.FrmOptions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblComPort;
        private System.Windows.Forms.ComboBox cboComPort;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Label lblDirectory;
        public System.Windows.Forms.TextBox txtGwtext;
        private System.Windows.Forms.Button btnChangeSettings;
        private System.Windows.Forms.Label lblSettings;
        private System.Windows.Forms.TextBox INIPath;
        private System.Windows.Forms.Button btnDiskdefs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiskdefs;
        private System.Windows.Forms.Button btnConvert2ADF;
        private System.Windows.Forms.Button btnConvert2SCP;
        private System.Windows.Forms.Button btnRescan;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button BtnLoadSettings;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.ListBox lbOutput;
        private System.Windows.Forms.Label lblOutputWIndow;
        private System.Windows.Forms.Label lblErrorReport;
        private System.Windows.Forms.ListBox lbErrors;
        private System.Windows.Forms.Label lblDiag;
        private System.Windows.Forms.TextBox txtDiag;
        private System.Windows.Forms.Button BtnCloseButton;
        private System.Windows.Forms.Button btnGwinfo;
        private System.Windows.Forms.Label LblPercentComplete;
        private System.Windows.Forms.ProgressBar prgProgressBar1;
        private System.Windows.Forms.Label lblTrackNo;
        private System.Windows.Forms.TextBox txtTrackNo;
        private System.Windows.Forms.Label lblSide;
        private System.Windows.Forms.TextBox txtSide;
        private System.Windows.Forms.Label lblNumberOfTracks;
        private System.Windows.Forms.ComboBox cboTrackCombo;
        private System.Windows.Forms.Label lblDiskType;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label lblRetries;
        private System.Windows.Forms.ComboBox cboRetries;
        private System.Windows.Forms.Label lblDriveSelect;
        private System.Windows.Forms.ComboBox cboDriveSelect;
        private System.Windows.Forms.Label lblNoOfDisks;
        private System.Windows.Forms.ComboBox cboNumberOfDisks;
        private System.Windows.Forms.Label LblFileInUse;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button BtnTestbutton;
    }
}