namespace RTDataInjector
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.grpErrors = new System.Windows.Forms.GroupBox();
            this.txbOutput = new System.Windows.Forms.TextBox();
            this.grpImport = new System.Windows.Forms.GroupBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.prgBar = new System.Windows.Forms.ProgressBar();
            this.lblUtvecklare = new System.Windows.Forms.Label();
            this.grpFiles = new System.Windows.Forms.GroupBox();
            this.lblIdentifiedFolders = new System.Windows.Forms.Label();
            this.lblDICOMFiles = new System.Windows.Forms.Label();
            this.lblIdentifiedDICOMFiles = new System.Windows.Forms.Label();
            this.lblpatientFolders = new System.Windows.Forms.Label();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.lblFolder = new System.Windows.Forms.Label();
            this.grpSettings = new System.Windows.Forms.GroupBox();
            this.btnTestConnection = new System.Windows.Forms.Button();
            this.daemonGroupBox = new System.Windows.Forms.GroupBox();
            this.editDaemonButton = new System.Windows.Forms.Button();
            this.lblDaemonAE = new System.Windows.Forms.Label();
            this.lblDaemonAEResult = new System.Windows.Forms.Label();
            this.lblDaemonIP = new System.Windows.Forms.Label();
            this.lblDaemonIPResult = new System.Windows.Forms.Label();
            this.lblDaemonPort = new System.Windows.Forms.Label();
            this.lblDaemonPortResult = new System.Windows.Forms.Label();
            this.localGroupBox = new System.Windows.Forms.GroupBox();
            this.editLocalButton = new System.Windows.Forms.Button();
            this.lblLocalPortResult = new System.Windows.Forms.Label();
            this.lblLocalAE = new System.Windows.Forms.Label();
            this.lblLocalPort = new System.Windows.Forms.Label();
            this.lblLocalAEResult = new System.Windows.Forms.Label();
            this.lblLocalIPResult = new System.Windows.Forms.Label();
            this.lblLocalIP = new System.Windows.Forms.Label();
            this.toolTipInjection = new System.Windows.Forms.ToolTip(this.components);
            this.grpErrors.SuspendLayout();
            this.grpImport.SuspendLayout();
            this.grpFiles.SuspendLayout();
            this.grpSettings.SuspendLayout();
            this.daemonGroupBox.SuspendLayout();
            this.localGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpErrors
            // 
            this.grpErrors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpErrors.Controls.Add(this.txbOutput);
            this.grpErrors.Location = new System.Drawing.Point(13, 164);
            this.grpErrors.Name = "grpErrors";
            this.grpErrors.Size = new System.Drawing.Size(458, 341);
            this.grpErrors.TabIndex = 11;
            this.grpErrors.TabStop = false;
            // 
            // txbOutput
            // 
            this.txbOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txbOutput.BackColor = System.Drawing.SystemColors.Control;
            this.txbOutput.Location = new System.Drawing.Point(9, 19);
            this.txbOutput.Multiline = true;
            this.txbOutput.Name = "txbOutput";
            this.txbOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbOutput.Size = new System.Drawing.Size(442, 316);
            this.txbOutput.TabIndex = 5;
            // 
            // grpImport
            // 
            this.grpImport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpImport.Controls.Add(this.btnStart);
            this.grpImport.Controls.Add(this.prgBar);
            this.grpImport.Location = new System.Drawing.Point(13, 99);
            this.grpImport.Name = "grpImport";
            this.grpImport.Size = new System.Drawing.Size(458, 59);
            this.grpImport.TabIndex = 10;
            this.grpImport.TabStop = false;
            this.grpImport.Text = "Injection";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(9, 22);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(93, 23);
            this.btnStart.TabIndex = 15;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // prgBar
            // 
            this.prgBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prgBar.Location = new System.Drawing.Point(108, 23);
            this.prgBar.Name = "prgBar";
            this.prgBar.Size = new System.Drawing.Size(343, 21);
            this.prgBar.TabIndex = 3;
            // 
            // lblUtvecklare
            // 
            this.lblUtvecklare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUtvecklare.AutoSize = true;
            this.lblUtvecklare.Location = new System.Drawing.Point(336, 631);
            this.lblUtvecklare.Name = "lblUtvecklare";
            this.lblUtvecklare.Size = new System.Drawing.Size(139, 13);
            this.lblUtvecklare.TabIndex = 9;
            this.lblUtvecklare.Text = "Developed by Louise Mövik";
            this.lblUtvecklare.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpFiles
            // 
            this.grpFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpFiles.Controls.Add(this.lblIdentifiedFolders);
            this.grpFiles.Controls.Add(this.lblDICOMFiles);
            this.grpFiles.Controls.Add(this.lblIdentifiedDICOMFiles);
            this.grpFiles.Controls.Add(this.lblpatientFolders);
            this.grpFiles.Controls.Add(this.btnSelectFolder);
            this.grpFiles.Controls.Add(this.txtPath);
            this.grpFiles.Controls.Add(this.lblFolder);
            this.grpFiles.Location = new System.Drawing.Point(13, 11);
            this.grpFiles.Name = "grpFiles";
            this.grpFiles.Size = new System.Drawing.Size(458, 82);
            this.grpFiles.TabIndex = 8;
            this.grpFiles.TabStop = false;
            this.grpFiles.Text = "DICOM files to inject";
            // 
            // lblIdentifiedFolders
            // 
            this.lblIdentifiedFolders.AutoSize = true;
            this.lblIdentifiedFolders.Location = new System.Drawing.Point(137, 60);
            this.lblIdentifiedFolders.Name = "lblIdentifiedFolders";
            this.lblIdentifiedFolders.Size = new System.Drawing.Size(10, 13);
            this.lblIdentifiedFolders.TabIndex = 6;
            this.lblIdentifiedFolders.Text = "-";
            this.lblIdentifiedFolders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDICOMFiles
            // 
            this.lblDICOMFiles.AutoSize = true;
            this.lblDICOMFiles.Location = new System.Drawing.Point(236, 60);
            this.lblDICOMFiles.Name = "lblDICOMFiles";
            this.lblDICOMFiles.Size = new System.Drawing.Size(115, 13);
            this.lblDICOMFiles.TabIndex = 5;
            this.lblDICOMFiles.Text = "Identified DICOM files: ";
            // 
            // lblIdentifiedDICOMFiles
            // 
            this.lblIdentifiedDICOMFiles.AutoSize = true;
            this.lblIdentifiedDICOMFiles.Location = new System.Drawing.Point(357, 60);
            this.lblIdentifiedDICOMFiles.Name = "lblIdentifiedDICOMFiles";
            this.lblIdentifiedDICOMFiles.Size = new System.Drawing.Size(10, 13);
            this.lblIdentifiedDICOMFiles.TabIndex = 4;
            this.lblIdentifiedDICOMFiles.Text = "-";
            this.lblIdentifiedDICOMFiles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblpatientFolders
            // 
            this.lblpatientFolders.AutoSize = true;
            this.lblpatientFolders.Location = new System.Drawing.Point(6, 60);
            this.lblpatientFolders.Name = "lblpatientFolders";
            this.lblpatientFolders.Size = new System.Drawing.Size(125, 13);
            this.lblpatientFolders.TabIndex = 3;
            this.lblpatientFolders.Text = "Identified patient folders: ";
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectFolder.Location = new System.Drawing.Point(427, 34);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(24, 22);
            this.btnSelectFolder.TabIndex = 2;
            this.btnSelectFolder.Text = "...";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // txtPath
            // 
            this.txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPath.Location = new System.Drawing.Point(9, 35);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(413, 20);
            this.txtPath.TabIndex = 1;
            this.txtPath.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPath_KeyDown);
            this.txtPath.Leave += new System.EventHandler(this.txtPath_Leave);
            // 
            // lblFolder
            // 
            this.lblFolder.AutoSize = true;
            this.lblFolder.Location = new System.Drawing.Point(6, 19);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(36, 13);
            this.lblFolder.TabIndex = 0;
            this.lblFolder.Text = "Folder";
            // 
            // grpSettings
            // 
            this.grpSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSettings.Controls.Add(this.btnTestConnection);
            this.grpSettings.Controls.Add(this.daemonGroupBox);
            this.grpSettings.Controls.Add(this.localGroupBox);
            this.grpSettings.Location = new System.Drawing.Point(13, 511);
            this.grpSettings.Name = "grpSettings";
            this.grpSettings.Size = new System.Drawing.Size(458, 113);
            this.grpSettings.TabIndex = 7;
            this.grpSettings.TabStop = false;
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTestConnection.Location = new System.Drawing.Point(8, -1);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(131, 24);
            this.btnTestConnection.TabIndex = 14;
            this.btnTestConnection.Text = "Test DICOM Connection";
            this.btnTestConnection.UseVisualStyleBackColor = true;
            this.btnTestConnection.Click += new System.EventHandler(this.btnTestConnection_Click);
            // 
            // daemonGroupBox
            // 
            this.daemonGroupBox.Controls.Add(this.editDaemonButton);
            this.daemonGroupBox.Controls.Add(this.lblDaemonAE);
            this.daemonGroupBox.Controls.Add(this.lblDaemonAEResult);
            this.daemonGroupBox.Controls.Add(this.lblDaemonIP);
            this.daemonGroupBox.Controls.Add(this.lblDaemonIPResult);
            this.daemonGroupBox.Controls.Add(this.lblDaemonPort);
            this.daemonGroupBox.Controls.Add(this.lblDaemonPortResult);
            this.daemonGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daemonGroupBox.Location = new System.Drawing.Point(9, 28);
            this.daemonGroupBox.Name = "daemonGroupBox";
            this.daemonGroupBox.Size = new System.Drawing.Size(219, 78);
            this.daemonGroupBox.TabIndex = 16;
            this.daemonGroupBox.TabStop = false;
            this.daemonGroupBox.Text = "Daemon";
            // 
            // editDaemonButton
            // 
            this.editDaemonButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editDaemonButton.Location = new System.Drawing.Point(167, 50);
            this.editDaemonButton.Name = "editDaemonButton";
            this.editDaemonButton.Size = new System.Drawing.Size(46, 23);
            this.editDaemonButton.TabIndex = 15;
            this.editDaemonButton.Text = "Edit";
            this.editDaemonButton.UseVisualStyleBackColor = true;
            this.editDaemonButton.Click += new System.EventHandler(this.editDaemonButton_Click);
            // 
            // lblDaemonAE
            // 
            this.lblDaemonAE.AutoSize = true;
            this.lblDaemonAE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaemonAE.Location = new System.Drawing.Point(6, 17);
            this.lblDaemonAE.Name = "lblDaemonAE";
            this.lblDaemonAE.Size = new System.Drawing.Size(47, 13);
            this.lblDaemonAE.TabIndex = 1;
            this.lblDaemonAE.Text = "AE Title:";
            // 
            // lblDaemonAEResult
            // 
            this.lblDaemonAEResult.AutoSize = true;
            this.lblDaemonAEResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaemonAEResult.Location = new System.Drawing.Point(82, 17);
            this.lblDaemonAEResult.Name = "lblDaemonAEResult";
            this.lblDaemonAEResult.Size = new System.Drawing.Size(10, 13);
            this.lblDaemonAEResult.TabIndex = 2;
            this.lblDaemonAEResult.Text = "-";
            // 
            // lblDaemonIP
            // 
            this.lblDaemonIP.AutoSize = true;
            this.lblDaemonIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaemonIP.Location = new System.Drawing.Point(6, 32);
            this.lblDaemonIP.Name = "lblDaemonIP";
            this.lblDaemonIP.Size = new System.Drawing.Size(60, 13);
            this.lblDaemonIP.TabIndex = 3;
            this.lblDaemonIP.Text = "IP address:";
            // 
            // lblDaemonIPResult
            // 
            this.lblDaemonIPResult.AutoSize = true;
            this.lblDaemonIPResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaemonIPResult.Location = new System.Drawing.Point(82, 32);
            this.lblDaemonIPResult.Name = "lblDaemonIPResult";
            this.lblDaemonIPResult.Size = new System.Drawing.Size(10, 13);
            this.lblDaemonIPResult.TabIndex = 4;
            this.lblDaemonIPResult.Text = "-";
            // 
            // lblDaemonPort
            // 
            this.lblDaemonPort.AutoSize = true;
            this.lblDaemonPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaemonPort.Location = new System.Drawing.Point(6, 47);
            this.lblDaemonPort.Name = "lblDaemonPort";
            this.lblDaemonPort.Size = new System.Drawing.Size(29, 13);
            this.lblDaemonPort.TabIndex = 5;
            this.lblDaemonPort.Text = "Port:";
            // 
            // lblDaemonPortResult
            // 
            this.lblDaemonPortResult.AutoSize = true;
            this.lblDaemonPortResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaemonPortResult.Location = new System.Drawing.Point(82, 47);
            this.lblDaemonPortResult.Name = "lblDaemonPortResult";
            this.lblDaemonPortResult.Size = new System.Drawing.Size(10, 13);
            this.lblDaemonPortResult.TabIndex = 6;
            this.lblDaemonPortResult.Text = "-";
            // 
            // localGroupBox
            // 
            this.localGroupBox.Controls.Add(this.editLocalButton);
            this.localGroupBox.Controls.Add(this.lblLocalPortResult);
            this.localGroupBox.Controls.Add(this.lblLocalAE);
            this.localGroupBox.Controls.Add(this.lblLocalPort);
            this.localGroupBox.Controls.Add(this.lblLocalAEResult);
            this.localGroupBox.Controls.Add(this.lblLocalIPResult);
            this.localGroupBox.Controls.Add(this.lblLocalIP);
            this.localGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.localGroupBox.Location = new System.Drawing.Point(232, 28);
            this.localGroupBox.Name = "localGroupBox";
            this.localGroupBox.Size = new System.Drawing.Size(219, 78);
            this.localGroupBox.TabIndex = 17;
            this.localGroupBox.TabStop = false;
            this.localGroupBox.Text = "Local";
            // 
            // editLocalButton
            // 
            this.editLocalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editLocalButton.Location = new System.Drawing.Point(167, 50);
            this.editLocalButton.Name = "editLocalButton";
            this.editLocalButton.Size = new System.Drawing.Size(46, 23);
            this.editLocalButton.TabIndex = 15;
            this.editLocalButton.Text = "Edit";
            this.editLocalButton.UseVisualStyleBackColor = true;
            this.editLocalButton.Click += new System.EventHandler(this.editLocalButton_Click);
            // 
            // lblLocalPortResult
            // 
            this.lblLocalPortResult.AutoSize = true;
            this.lblLocalPortResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalPortResult.Location = new System.Drawing.Point(82, 46);
            this.lblLocalPortResult.Name = "lblLocalPortResult";
            this.lblLocalPortResult.Size = new System.Drawing.Size(10, 13);
            this.lblLocalPortResult.TabIndex = 13;
            this.lblLocalPortResult.Text = "-";
            // 
            // lblLocalAE
            // 
            this.lblLocalAE.AutoSize = true;
            this.lblLocalAE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalAE.Location = new System.Drawing.Point(6, 16);
            this.lblLocalAE.Name = "lblLocalAE";
            this.lblLocalAE.Size = new System.Drawing.Size(47, 13);
            this.lblLocalAE.TabIndex = 8;
            this.lblLocalAE.Text = "AE Title:";
            // 
            // lblLocalPort
            // 
            this.lblLocalPort.AutoSize = true;
            this.lblLocalPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalPort.Location = new System.Drawing.Point(6, 46);
            this.lblLocalPort.Name = "lblLocalPort";
            this.lblLocalPort.Size = new System.Drawing.Size(29, 13);
            this.lblLocalPort.TabIndex = 12;
            this.lblLocalPort.Text = "Port:";
            // 
            // lblLocalAEResult
            // 
            this.lblLocalAEResult.AutoSize = true;
            this.lblLocalAEResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalAEResult.Location = new System.Drawing.Point(82, 16);
            this.lblLocalAEResult.Name = "lblLocalAEResult";
            this.lblLocalAEResult.Size = new System.Drawing.Size(10, 13);
            this.lblLocalAEResult.TabIndex = 9;
            this.lblLocalAEResult.Text = "-";
            // 
            // lblLocalIPResult
            // 
            this.lblLocalIPResult.AutoSize = true;
            this.lblLocalIPResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalIPResult.Location = new System.Drawing.Point(82, 31);
            this.lblLocalIPResult.Name = "lblLocalIPResult";
            this.lblLocalIPResult.Size = new System.Drawing.Size(10, 13);
            this.lblLocalIPResult.TabIndex = 11;
            this.lblLocalIPResult.Text = "-";
            // 
            // lblLocalIP
            // 
            this.lblLocalIP.AutoSize = true;
            this.lblLocalIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalIP.Location = new System.Drawing.Point(6, 31);
            this.lblLocalIP.Name = "lblLocalIP";
            this.lblLocalIP.Size = new System.Drawing.Size(60, 13);
            this.lblLocalIP.TabIndex = 10;
            this.lblLocalIP.Text = "IP address:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 654);
            this.Controls.Add(this.grpErrors);
            this.Controls.Add(this.grpImport);
            this.Controls.Add(this.lblUtvecklare);
            this.Controls.Add(this.grpFiles);
            this.Controls.Add(this.grpSettings);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "RT Data Injector (Version 2.0)";
            this.grpErrors.ResumeLayout(false);
            this.grpErrors.PerformLayout();
            this.grpImport.ResumeLayout(false);
            this.grpFiles.ResumeLayout(false);
            this.grpFiles.PerformLayout();
            this.grpSettings.ResumeLayout(false);
            this.daemonGroupBox.ResumeLayout(false);
            this.daemonGroupBox.PerformLayout();
            this.localGroupBox.ResumeLayout(false);
            this.localGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpErrors;
        private System.Windows.Forms.TextBox txbOutput;
        private System.Windows.Forms.GroupBox grpImport;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ProgressBar prgBar;
        private System.Windows.Forms.Label lblUtvecklare;
        private System.Windows.Forms.GroupBox grpFiles;
        private System.Windows.Forms.Label lblIdentifiedFolders;
        private System.Windows.Forms.Label lblDICOMFiles;
        private System.Windows.Forms.Label lblIdentifiedDICOMFiles;
        private System.Windows.Forms.Label lblpatientFolders;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label lblFolder;
        private System.Windows.Forms.GroupBox grpSettings;
        private System.Windows.Forms.Button btnTestConnection;
        private System.Windows.Forms.Label lblLocalPortResult;
        private System.Windows.Forms.Label lblLocalPort;
        private System.Windows.Forms.Label lblLocalIPResult;
        private System.Windows.Forms.Label lblLocalIP;
        private System.Windows.Forms.Label lblLocalAEResult;
        private System.Windows.Forms.Label lblLocalAE;
        private System.Windows.Forms.Label lblDaemonPortResult;
        private System.Windows.Forms.Label lblDaemonPort;
        private System.Windows.Forms.Label lblDaemonIPResult;
        private System.Windows.Forms.Label lblDaemonIP;
        private System.Windows.Forms.Label lblDaemonAEResult;
        private System.Windows.Forms.Label lblDaemonAE;
        private System.Windows.Forms.ToolTip toolTipInjection;
        private System.Windows.Forms.Button editDaemonButton;
        private System.Windows.Forms.GroupBox daemonGroupBox;
        private System.Windows.Forms.GroupBox localGroupBox;
        private System.Windows.Forms.Button editLocalButton;
    }
}

