
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
            this.btnChange.Location = new System.Drawing.Point(456, 213);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(150, 31);
            this.btnChange.TabIndex = 25;
            this.btnChange.Text = "change Host Tools path";
            this.btnChange.UseVisualStyleBackColor = true;
            // 
            // lblDirectory
            // 
            this.lblDirectory.AutoSize = true;
            this.lblDirectory.Location = new System.Drawing.Point(471, 247);
            this.lblDirectory.Name = "lblDirectory";
            this.lblDirectory.Size = new System.Drawing.Size(121, 13);
            this.lblDirectory.TabIndex = 26;
            this.lblDirectory.Text = "Path To GW Host Tools";
            // 
            // txtGwtext
            // 
            this.txtGwtext.Location = new System.Drawing.Point(456, 266);
            this.txtGwtext.Name = "txtGwtext";
            this.txtGwtext.ReadOnly = true;
            this.txtGwtext.Size = new System.Drawing.Size(151, 20);
            this.txtGwtext.TabIndex = 27;
            this.txtGwtext.Text = "C:\\Greaseweazle";
            // 
            // btnChangeSettings
            // 
            this.btnChangeSettings.Location = new System.Drawing.Point(456, 25);
            this.btnChangeSettings.Name = "btnChangeSettings";
            this.btnChangeSettings.Size = new System.Drawing.Size(100, 37);
            this.btnChangeSettings.TabIndex = 32;
            this.btnChangeSettings.Text = "Reset Path To Settings";
            this.btnChangeSettings.UseVisualStyleBackColor = true;
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
            this.INIPath.Size = new System.Drawing.Size(100, 20);
            this.INIPath.TabIndex = 34;
            // 
            // btnDiskdefs
            // 
            this.btnDiskdefs.Location = new System.Drawing.Point(456, 113);
            this.btnDiskdefs.Name = "btnDiskdefs";
            this.btnDiskdefs.Size = new System.Drawing.Size(142, 55);
            this.btnDiskdefs.TabIndex = 35;
            this.btnDiskdefs.Text = "Change Diskdefs Path";
            this.btnDiskdefs.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(482, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Path To Diskdefs";
            // 
            // txtDiskdefs
            // 
            this.txtDiskdefs.Location = new System.Drawing.Point(456, 187);
            this.txtDiskdefs.Name = "txtDiskdefs";
            this.txtDiskdefs.Size = new System.Drawing.Size(136, 20);
            this.txtDiskdefs.TabIndex = 37;
            // 
            // btnConvert2ADF
            // 
            this.btnConvert2ADF.Location = new System.Drawing.Point(672, 25);
            this.btnConvert2ADF.Name = "btnConvert2ADF";
            this.btnConvert2ADF.Size = new System.Drawing.Size(75, 39);
            this.btnConvert2ADF.TabIndex = 42;
            this.btnConvert2ADF.Text = "Convert scp 2 adf";
            this.btnConvert2ADF.UseVisualStyleBackColor = true;
            // 
            // btnConvert2SCP
            // 
            this.btnConvert2SCP.Location = new System.Drawing.Point(574, 25);
            this.btnConvert2SCP.Name = "btnConvert2SCP";
            this.btnConvert2SCP.Size = new System.Drawing.Size(75, 42);
            this.btnConvert2SCP.TabIndex = 43;
            this.btnConvert2SCP.Text = "Convert adf 2 scp";
            this.btnConvert2SCP.UseVisualStyleBackColor = true;
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
            this.btnUpdate.Location = new System.Drawing.Point(341, 96);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(99, 69);
            this.btnUpdate.TabIndex = 56;
            this.btnUpdate.Text = "Update My Greaseweazle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(222, 96);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(102, 69);
            this.btnReset.TabIndex = 57;
            this.btnReset.Text = "Reset Settings to Factory";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // BtnLoadSettings
            // 
            this.BtnLoadSettings.Location = new System.Drawing.Point(222, 25);
            this.BtnLoadSettings.Name = "BtnLoadSettings";
            this.BtnLoadSettings.Size = new System.Drawing.Size(102, 65);
            this.BtnLoadSettings.TabIndex = 58;
            this.BtnLoadSettings.Text = "Load Saved Settings";
            this.BtnLoadSettings.UseVisualStyleBackColor = true;
            this.BtnLoadSettings.Click += new System.EventHandler(this.BtnLoadSettings_Click);
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Location = new System.Drawing.Point(341, 25);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(99, 65);
            this.btnSaveSettings.TabIndex = 59;
            this.btnSaveSettings.Text = "SaveSettings";
            // 
            // lbOutput
            // 
            this.lbOutput.FormattingEnabled = true;
            this.lbOutput.Location = new System.Drawing.Point(17, 171);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(411, 95);
            this.lbOutput.TabIndex = 60;
            // 
            // lblOutputWIndow
            // 
            this.lblOutputWIndow.AutoSize = true;
            this.lblOutputWIndow.Location = new System.Drawing.Point(14, 155);
            this.lblOutputWIndow.Name = "lblOutputWIndow";
            this.lblOutputWIndow.Size = new System.Drawing.Size(81, 13);
            this.lblOutputWIndow.TabIndex = 61;
            this.lblOutputWIndow.Text = "Output Window";
            // 
            // lblErrorReport
            // 
            this.lblErrorReport.AutoSize = true;
            this.lblErrorReport.Location = new System.Drawing.Point(14, 269);
            this.lblErrorReport.Name = "lblErrorReport";
            this.lblErrorReport.Size = new System.Drawing.Size(63, 13);
            this.lblErrorReport.TabIndex = 62;
            this.lblErrorReport.Text = "Notifcations";
            // 
            // lbErrors
            // 
            this.lbErrors.FormattingEnabled = true;
            this.lbErrors.HorizontalScrollbar = true;
            this.lbErrors.Location = new System.Drawing.Point(17, 285);
            this.lbErrors.Name = "lbErrors";
            this.lbErrors.Size = new System.Drawing.Size(411, 95);
            this.lbErrors.TabIndex = 63;
            // 
            // lblDiag
            // 
            this.lblDiag.AutoSize = true;
            this.lblDiag.Location = new System.Drawing.Point(22, 383);
            this.lblDiag.Name = "lblDiag";
            this.lblDiag.Size = new System.Drawing.Size(73, 13);
            this.lblDiag.TabIndex = 64;
            this.lblDiag.Text = "Last Message";
            // 
            // txtDiag
            // 
            this.txtDiag.Location = new System.Drawing.Point(19, 399);
            this.txtDiag.Name = "txtDiag";
            this.txtDiag.Size = new System.Drawing.Size(409, 20);
            this.txtDiag.TabIndex = 65;
            // 
            // BtnCloseButton
            // 
            this.BtnCloseButton.Location = new System.Drawing.Point(565, 292);
            this.BtnCloseButton.Name = "BtnCloseButton";
            this.BtnCloseButton.Size = new System.Drawing.Size(193, 107);
            this.BtnCloseButton.TabIndex = 66;
            this.BtnCloseButton.Text = "Close Options";
            this.BtnCloseButton.UseVisualStyleBackColor = true;
            this.BtnCloseButton.Click += new System.EventHandler(this.BtnCloseButton_Click);
            // 
            // btnGwinfo
            // 
            this.btnGwinfo.Location = new System.Drawing.Point(19, 96);
            this.btnGwinfo.Name = "btnGwinfo";
            this.btnGwinfo.Size = new System.Drawing.Size(87, 35);
            this.btnGwinfo.TabIndex = 67;
            this.btnGwinfo.Text = "Greaseweazle Info";
            this.btnGwinfo.UseVisualStyleBackColor = true;
            this.btnGwinfo.Click += new System.EventHandler(this.btnGwinfo_Click);
            // 
            // FrmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}