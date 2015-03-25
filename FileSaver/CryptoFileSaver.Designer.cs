namespace FileSaver
{
    partial class CryptoFileSaver
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
            this.registryFileBrowser = new System.Windows.Forms.OpenFileDialog();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.mainTab = new System.Windows.Forms.TabPage();
            this.loadLocationOfEncryptedFiles = new System.Windows.Forms.Button();
            this.currentLocationEncrptedFiles = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.loadDestinationLocationBtn = new System.Windows.Forms.Button();
            this.targetDir = new System.Windows.Forms.TextBox();
            this.destinationLocation = new System.Windows.Forms.Label();
            this.copySafe = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.orignalDriveLetter = new System.Windows.Forms.ComboBox();
            this.loadFormattedRegistryFileBtn = new System.Windows.Forms.Button();
            this.formattedFile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.processRegistryFile = new System.Windows.Forms.Button();
            this.loadRegistryFileBtn = new System.Windows.Forms.Button();
            this.registryFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.exclusionsTab = new System.Windows.Forms.TabPage();
            this.removeFromExclusion = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.excludeFileBtn = new System.Windows.Forms.Button();
            this.excludeFile = new System.Windows.Forms.TextBox();
            this.exclusionList = new System.Windows.Forms.ListBox();
            this.formattedRegBrowser = new System.Windows.Forms.OpenFileDialog();
            this.saveFormattedRegFileLocation = new System.Windows.Forms.FolderBrowserDialog();
            this.currentLocationOfFiles = new System.Windows.Forms.FolderBrowserDialog();
            this.targetLocationBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1.SuspendLayout();
            this.mainTab.SuspendLayout();
            this.exclusionsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // registryFileBrowser
            // 
            this.registryFileBrowser.FileName = "*.reg";
            this.registryFileBrowser.FileOk += new System.ComponentModel.CancelEventHandler(this.registryFileBrowser_FileOk);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 552);
            this.splitter1.TabIndex = 10;
            this.splitter1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.mainTab);
            this.tabControl1.Controls.Add(this.exclusionsTab);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(891, 552);
            this.tabControl1.TabIndex = 11;
            // 
            // mainTab
            // 
            this.mainTab.Controls.Add(this.loadLocationOfEncryptedFiles);
            this.mainTab.Controls.Add(this.currentLocationEncrptedFiles);
            this.mainTab.Controls.Add(this.label5);
            this.mainTab.Controls.Add(this.loadDestinationLocationBtn);
            this.mainTab.Controls.Add(this.targetDir);
            this.mainTab.Controls.Add(this.destinationLocation);
            this.mainTab.Controls.Add(this.copySafe);
            this.mainTab.Controls.Add(this.label3);
            this.mainTab.Controls.Add(this.orignalDriveLetter);
            this.mainTab.Controls.Add(this.loadFormattedRegistryFileBtn);
            this.mainTab.Controls.Add(this.formattedFile);
            this.mainTab.Controls.Add(this.label2);
            this.mainTab.Controls.Add(this.processRegistryFile);
            this.mainTab.Controls.Add(this.loadRegistryFileBtn);
            this.mainTab.Controls.Add(this.registryFile);
            this.mainTab.Controls.Add(this.label1);
            this.mainTab.Location = new System.Drawing.Point(4, 22);
            this.mainTab.Name = "mainTab";
            this.mainTab.Padding = new System.Windows.Forms.Padding(3);
            this.mainTab.Size = new System.Drawing.Size(883, 526);
            this.mainTab.TabIndex = 0;
            this.mainTab.Text = "Main";
            this.mainTab.UseVisualStyleBackColor = true;
            // 
            // loadLocationOfEncryptedFiles
            // 
            this.loadLocationOfEncryptedFiles.Location = new System.Drawing.Point(634, 354);
            this.loadLocationOfEncryptedFiles.Name = "loadLocationOfEncryptedFiles";
            this.loadLocationOfEncryptedFiles.Size = new System.Drawing.Size(75, 23);
            this.loadLocationOfEncryptedFiles.TabIndex = 34;
            this.loadLocationOfEncryptedFiles.Text = "Browse...";
            this.loadLocationOfEncryptedFiles.UseVisualStyleBackColor = true;
            this.loadLocationOfEncryptedFiles.Click += new System.EventHandler(this.loadLocationOfEncryptedFiles_Click);
            // 
            // currentLocationEncrptedFiles
            // 
            this.currentLocationEncrptedFiles.Location = new System.Drawing.Point(324, 357);
            this.currentLocationEncrptedFiles.Name = "currentLocationEncrptedFiles";
            this.currentLocationEncrptedFiles.Size = new System.Drawing.Size(304, 20);
            this.currentLocationEncrptedFiles.TabIndex = 33;
            this.currentLocationEncrptedFiles.Text = "G:\\CryptoWallEncryptedFiles";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(321, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Current Location";
            // 
            // loadDestinationLocationBtn
            // 
            this.loadDestinationLocationBtn.Location = new System.Drawing.Point(634, 411);
            this.loadDestinationLocationBtn.Name = "loadDestinationLocationBtn";
            this.loadDestinationLocationBtn.Size = new System.Drawing.Size(75, 23);
            this.loadDestinationLocationBtn.TabIndex = 31;
            this.loadDestinationLocationBtn.Text = "Browse...";
            this.loadDestinationLocationBtn.UseVisualStyleBackColor = true;
            this.loadDestinationLocationBtn.Click += new System.EventHandler(this.loadDestinationLocationBtn_Click);
            // 
            // targetDir
            // 
            this.targetDir.Location = new System.Drawing.Point(176, 413);
            this.targetDir.Name = "targetDir";
            this.targetDir.Size = new System.Drawing.Size(452, 20);
            this.targetDir.TabIndex = 30;
            this.targetDir.Text = "C:\\CryptoSafe\\";
            // 
            // destinationLocation
            // 
            this.destinationLocation.AutoSize = true;
            this.destinationLocation.Location = new System.Drawing.Point(173, 397);
            this.destinationLocation.Name = "destinationLocation";
            this.destinationLocation.Size = new System.Drawing.Size(60, 13);
            this.destinationLocation.TabIndex = 29;
            this.destinationLocation.Text = "Destination";
            // 
            // copySafe
            // 
            this.copySafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copySafe.Location = new System.Drawing.Point(176, 439);
            this.copySafe.Name = "copySafe";
            this.copySafe.Size = new System.Drawing.Size(193, 31);
            this.copySafe.TabIndex = 28;
            this.copySafe.Text = "Copy Safe Files";
            this.copySafe.UseVisualStyleBackColor = true;
            this.copySafe.Click += new System.EventHandler(this.copySafe_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(173, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Original Drive Letter";
            // 
            // orignalDriveLetter
            // 
            this.orignalDriveLetter.FormattingEnabled = true;
            this.orignalDriveLetter.Items.AddRange(new object[] {
            "C:",
            "D:",
            "E:",
            "F:",
            "G:",
            "H:",
            "I:",
            "J:",
            "K:",
            "L:",
            "M:",
            "N:",
            "O:",
            "P:",
            "Q:",
            "R:",
            "S:",
            "T:",
            "U:",
            "V:",
            "W:",
            "X:",
            "Y:",
            "Z:"});
            this.orignalDriveLetter.Location = new System.Drawing.Point(176, 356);
            this.orignalDriveLetter.Name = "orignalDriveLetter";
            this.orignalDriveLetter.Size = new System.Drawing.Size(121, 21);
            this.orignalDriveLetter.TabIndex = 26;
            this.orignalDriveLetter.Text = "C:";
            // 
            // loadFormattedRegistryFileBtn
            // 
            this.loadFormattedRegistryFileBtn.Location = new System.Drawing.Point(634, 285);
            this.loadFormattedRegistryFileBtn.Name = "loadFormattedRegistryFileBtn";
            this.loadFormattedRegistryFileBtn.Size = new System.Drawing.Size(75, 23);
            this.loadFormattedRegistryFileBtn.TabIndex = 25;
            this.loadFormattedRegistryFileBtn.Text = "Browse...";
            this.loadFormattedRegistryFileBtn.UseVisualStyleBackColor = true;
            this.loadFormattedRegistryFileBtn.Click += new System.EventHandler(this.loadFormattedRegistryFileBtn_Click);
            // 
            // formattedFile
            // 
            this.formattedFile.Location = new System.Drawing.Point(176, 287);
            this.formattedFile.Name = "formattedFile";
            this.formattedFile.Size = new System.Drawing.Size(452, 20);
            this.formattedFile.TabIndex = 24;
            this.formattedFile.Text = "C:\\Users\\kamal\\Desktop\\FormattedReg.txt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Text (.txt) file containing formatted registry entries";
            // 
            // processRegistryFile
            // 
            this.processRegistryFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processRegistryFile.Location = new System.Drawing.Point(176, 100);
            this.processRegistryFile.Name = "processRegistryFile";
            this.processRegistryFile.Size = new System.Drawing.Size(193, 31);
            this.processRegistryFile.TabIndex = 22;
            this.processRegistryFile.Text = "Process Registry File";
            this.processRegistryFile.UseVisualStyleBackColor = true;
            // 
            // loadRegistryFileBtn
            // 
            this.loadRegistryFileBtn.Location = new System.Drawing.Point(634, 72);
            this.loadRegistryFileBtn.Name = "loadRegistryFileBtn";
            this.loadRegistryFileBtn.Size = new System.Drawing.Size(75, 23);
            this.loadRegistryFileBtn.TabIndex = 21;
            this.loadRegistryFileBtn.Text = "Browse...";
            this.loadRegistryFileBtn.UseVisualStyleBackColor = true;
            this.loadRegistryFileBtn.Click += new System.EventHandler(this.loadRegistryFileBtn_Click);
            // 
            // registryFile
            // 
            this.registryFile.Location = new System.Drawing.Point(176, 74);
            this.registryFile.Name = "registryFile";
            this.registryFile.Size = new System.Drawing.Size(452, 20);
            this.registryFile.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Regsitry file to process";
            // 
            // exclusionsTab
            // 
            this.exclusionsTab.Controls.Add(this.removeFromExclusion);
            this.exclusionsTab.Controls.Add(this.label6);
            this.exclusionsTab.Controls.Add(this.excludeFileBtn);
            this.exclusionsTab.Controls.Add(this.excludeFile);
            this.exclusionsTab.Controls.Add(this.exclusionList);
            this.exclusionsTab.Location = new System.Drawing.Point(4, 22);
            this.exclusionsTab.Name = "exclusionsTab";
            this.exclusionsTab.Padding = new System.Windows.Forms.Padding(3);
            this.exclusionsTab.Size = new System.Drawing.Size(883, 526);
            this.exclusionsTab.TabIndex = 1;
            this.exclusionsTab.Text = "Exclusions";
            this.exclusionsTab.UseVisualStyleBackColor = true;
            // 
            // removeFromExclusion
            // 
            this.removeFromExclusion.Location = new System.Drawing.Point(565, 481);
            this.removeFromExclusion.Name = "removeFromExclusion";
            this.removeFromExclusion.Size = new System.Drawing.Size(151, 23);
            this.removeFromExclusion.TabIndex = 5;
            this.removeFromExclusion.Text = "Remove from exclusion";
            this.removeFromExclusion.UseVisualStyleBackColor = true;
            this.removeFromExclusion.Click += new System.EventHandler(this.removeFromExclusion_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Exclusions";
            // 
            // excludeFileBtn
            // 
            this.excludeFileBtn.Location = new System.Drawing.Point(442, 44);
            this.excludeFileBtn.Name = "excludeFileBtn";
            this.excludeFileBtn.Size = new System.Drawing.Size(116, 23);
            this.excludeFileBtn.TabIndex = 2;
            this.excludeFileBtn.Text = "Add Exclusion...";
            this.excludeFileBtn.UseVisualStyleBackColor = true;
            this.excludeFileBtn.Click += new System.EventHandler(this.excludeFileBtn_Click);
            // 
            // excludeFile
            // 
            this.excludeFile.Location = new System.Drawing.Point(26, 46);
            this.excludeFile.Name = "excludeFile";
            this.excludeFile.Size = new System.Drawing.Size(410, 20);
            this.excludeFile.TabIndex = 1;
            // 
            // exclusionList
            // 
            this.exclusionList.FormattingEnabled = true;
            this.exclusionList.Items.AddRange(new object[] {
            "HELP_DECRYPT.HTML",
            "HELP_DECRYPT.TXT",
            "HELP_DECRYPT.PNG",
            "HELP_DECRYPT.URL"});
            this.exclusionList.Location = new System.Drawing.Point(26, 72);
            this.exclusionList.Name = "exclusionList";
            this.exclusionList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.exclusionList.Size = new System.Drawing.Size(532, 433);
            this.exclusionList.TabIndex = 0;
            // 
            // formattedRegBrowser
            // 
            this.formattedRegBrowser.FileName = "*.txt";
            this.formattedRegBrowser.FileOk += new System.ComponentModel.CancelEventHandler(this.formattedRegBrowser_FileOk);
            // 
            // currentLocationOfFiles
            // 
            this.currentLocationOfFiles.SelectedPath = "%USERPROFILE%\\Desktop";
            // 
            // CryptoFileSaver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 552);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.splitter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CryptoFileSaver";
            this.Text = "Crypto File Saver";
            this.tabControl1.ResumeLayout(false);
            this.mainTab.ResumeLayout(false);
            this.mainTab.PerformLayout();
            this.exclusionsTab.ResumeLayout(false);
            this.exclusionsTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog registryFileBrowser;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage mainTab;
        private System.Windows.Forms.Button loadLocationOfEncryptedFiles;
        private System.Windows.Forms.TextBox currentLocationEncrptedFiles;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button loadDestinationLocationBtn;
        private System.Windows.Forms.TextBox targetDir;
        private System.Windows.Forms.Label destinationLocation;
        private System.Windows.Forms.Button copySafe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox orignalDriveLetter;
        private System.Windows.Forms.Button loadFormattedRegistryFileBtn;
        private System.Windows.Forms.TextBox formattedFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button processRegistryFile;
        private System.Windows.Forms.Button loadRegistryFileBtn;
        private System.Windows.Forms.TextBox registryFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage exclusionsTab;
        private System.Windows.Forms.Button excludeFileBtn;
        private System.Windows.Forms.TextBox excludeFile;
        private System.Windows.Forms.ListBox exclusionList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.OpenFileDialog formattedRegBrowser;
        private System.Windows.Forms.Button removeFromExclusion;
        private System.Windows.Forms.FolderBrowserDialog saveFormattedRegFileLocation;
        private System.Windows.Forms.FolderBrowserDialog currentLocationOfFiles;
        private System.Windows.Forms.FolderBrowserDialog targetLocationBrowser;
    }
}

