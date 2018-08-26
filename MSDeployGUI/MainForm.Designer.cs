namespace MSDeployGUI
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.console = new ConsoleControl.ConsoleControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.addProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.SettingsMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMSDeployGUIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMSDeployGUIToolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutMSDeployGUIToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.commandBox = new System.Windows.Forms.ComboBox();
            this.tabLeftControl = new System.Windows.Forms.TabControl();
            this.tabHistory = new System.Windows.Forms.TabPage();
            this.HistoryListBox = new System.Windows.Forms.ListBox();
            this.tabProfiles = new System.Windows.Forms.TabPage();
            this.ProfileListBox = new System.Windows.Forms.ListBox();
            this.tabTemplates = new System.Windows.Forms.TabPage();
            this.ExecuteBtn = new System.Windows.Forms.Button();
            this.tabCentralControl = new System.Windows.Forms.TabControl();
            this.DesignerTab = new System.Windows.Forms.TabPage();
            this.operationSettingsBox = new System.Windows.Forms.ComboBox();
            this.destProviderSettingBox = new System.Windows.Forms.ComboBox();
            this.srcProviderSettingBox = new System.Windows.Forms.ComboBox();
            this.destPathToProviderObject = new System.Windows.Forms.Label();
            this.sourcePathToProviderLbl = new System.Windows.Forms.Label();
            this.OperationSettingsLbl = new System.Windows.Forms.Label();
            this.destProviderBox = new System.Windows.Forms.ComboBox();
            this.destLbl = new System.Windows.Forms.Label();
            this.sourceProviderBox = new System.Windows.Forms.ComboBox();
            this.sourceLbl = new System.Windows.Forms.Label();
            this.VerbLbl = new System.Windows.Forms.Label();
            this.VerbBox = new System.Windows.Forms.ComboBox();
            this.WhatIfChkBox = new System.Windows.Forms.CheckBox();
            this.FileSystemTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabLeftControl.SuspendLayout();
            this.tabHistory.SuspendLayout();
            this.tabProfiles.SuspendLayout();
            this.tabCentralControl.SuspendLayout();
            this.DesignerTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.80514F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.19485F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableLayoutPanel1.Controls.Add(this.console, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.commandBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabLeftControl, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ExecuteBtn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabCentralControl, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1113, 516);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // console
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.console, 3);
            this.console.Dock = System.Windows.Forms.DockStyle.Fill;
            this.console.IsInputEnabled = true;
            this.console.Location = new System.Drawing.Point(4, 278);
            this.console.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.console.Name = "console";
            this.console.SendKeyboardCommandsToProcess = false;
            this.console.ShowDiagnostics = false;
            this.console.Size = new System.Drawing.Size(1105, 234);
            this.console.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(271, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClearHistoryToolStripMenuItem,
            this.SaveHistoryToolStripMenuItem,
            this.toolStripSeparator1,
            this.addProfileToolStripMenuItem,
            this.toolStripMenuItem1,
            this.SettingsMenuItem3,
            this.quitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // ClearHistoryToolStripMenuItem
            // 
            this.ClearHistoryToolStripMenuItem.Name = "ClearHistoryToolStripMenuItem";
            this.ClearHistoryToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.ClearHistoryToolStripMenuItem.Text = "Clear History";
            // 
            // SaveHistoryToolStripMenuItem
            // 
            this.SaveHistoryToolStripMenuItem.Name = "SaveHistoryToolStripMenuItem";
            this.SaveHistoryToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.SaveHistoryToolStripMenuItem.Text = "Save History";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(166, 6);
            // 
            // addProfileToolStripMenuItem
            // 
            this.addProfileToolStripMenuItem.Name = "addProfileToolStripMenuItem";
            this.addProfileToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.addProfileToolStripMenuItem.Text = "Add Profile...";
            this.addProfileToolStripMenuItem.Click += new System.EventHandler(this.addProfileToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(166, 6);
            // 
            // SettingsMenuItem3
            // 
            this.SettingsMenuItem3.Name = "SettingsMenuItem3";
            this.SettingsMenuItem3.Size = new System.Drawing.Size(169, 26);
            this.SettingsMenuItem3.Text = "Settings...";
            this.SettingsMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // quitToolStripMenuItem1
            // 
            this.quitToolStripMenuItem1.Name = "quitToolStripMenuItem1";
            this.quitToolStripMenuItem1.Size = new System.Drawing.Size(169, 26);
            this.quitToolStripMenuItem1.Text = "Quit";
            this.quitToolStripMenuItem1.Click += new System.EventHandler(this.quitToolStripMenuItem1_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMSDeployGUIToolStripMenuItem,
            this.aboutMSDeployGUIToolStripMenuItem1,
            this.aboutMSDeployGUIToolStripMenuItem2});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutMSDeployGUIToolStripMenuItem
            // 
            this.aboutMSDeployGUIToolStripMenuItem.Name = "aboutMSDeployGUIToolStripMenuItem";
            this.aboutMSDeployGUIToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.aboutMSDeployGUIToolStripMenuItem.Text = "Running as Administrator";
            // 
            // aboutMSDeployGUIToolStripMenuItem1
            // 
            this.aboutMSDeployGUIToolStripMenuItem1.Name = "aboutMSDeployGUIToolStripMenuItem1";
            this.aboutMSDeployGUIToolStripMenuItem1.Size = new System.Drawing.Size(248, 6);
            // 
            // aboutMSDeployGUIToolStripMenuItem2
            // 
            this.aboutMSDeployGUIToolStripMenuItem2.Name = "aboutMSDeployGUIToolStripMenuItem2";
            this.aboutMSDeployGUIToolStripMenuItem2.Size = new System.Drawing.Size(251, 26);
            this.aboutMSDeployGUIToolStripMenuItem2.Text = "About MSDeployGUI";
            // 
            // commandBox
            // 
            this.commandBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commandBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commandBox.FormattingEnabled = true;
            this.commandBox.Location = new System.Drawing.Point(274, 3);
            this.commandBox.Name = "commandBox";
            this.commandBox.Size = new System.Drawing.Size(734, 26);
            this.commandBox.TabIndex = 2;
            // 
            // tabLeftControl
            // 
            this.tabLeftControl.Controls.Add(this.tabHistory);
            this.tabLeftControl.Controls.Add(this.tabProfiles);
            this.tabLeftControl.Controls.Add(this.tabTemplates);
            this.tabLeftControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabLeftControl.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabLeftControl.Location = new System.Drawing.Point(3, 36);
            this.tabLeftControl.Name = "tabLeftControl";
            this.tabLeftControl.SelectedIndex = 0;
            this.tabLeftControl.Size = new System.Drawing.Size(265, 235);
            this.tabLeftControl.TabIndex = 3;
            // 
            // tabHistory
            // 
            this.tabHistory.Controls.Add(this.HistoryListBox);
            this.tabHistory.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabHistory.Location = new System.Drawing.Point(4, 27);
            this.tabHistory.Name = "tabHistory";
            this.tabHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabHistory.Size = new System.Drawing.Size(257, 204);
            this.tabHistory.TabIndex = 0;
            this.tabHistory.Text = "History";
            this.tabHistory.UseVisualStyleBackColor = true;
            // 
            // HistoryListBox
            // 
            this.HistoryListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HistoryListBox.FormattingEnabled = true;
            this.HistoryListBox.ItemHeight = 20;
            this.HistoryListBox.Items.AddRange(new object[] {
            "Item 1",
            "Item 2",
            "Item 3"});
            this.HistoryListBox.Location = new System.Drawing.Point(3, 3);
            this.HistoryListBox.Name = "HistoryListBox";
            this.HistoryListBox.Size = new System.Drawing.Size(251, 198);
            this.HistoryListBox.TabIndex = 5;
            // 
            // tabProfiles
            // 
            this.tabProfiles.Controls.Add(this.ProfileListBox);
            this.tabProfiles.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabProfiles.Location = new System.Drawing.Point(4, 27);
            this.tabProfiles.Name = "tabProfiles";
            this.tabProfiles.Padding = new System.Windows.Forms.Padding(3);
            this.tabProfiles.Size = new System.Drawing.Size(257, 204);
            this.tabProfiles.TabIndex = 1;
            this.tabProfiles.Text = "Profiles";
            this.tabProfiles.UseVisualStyleBackColor = true;
            // 
            // ProfileListBox
            // 
            this.ProfileListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProfileListBox.FormattingEnabled = true;
            this.ProfileListBox.ItemHeight = 20;
            this.ProfileListBox.Location = new System.Drawing.Point(3, 3);
            this.ProfileListBox.Name = "ProfileListBox";
            this.ProfileListBox.Size = new System.Drawing.Size(251, 198);
            this.ProfileListBox.TabIndex = 0;
            this.ProfileListBox.DoubleClick += new System.EventHandler(this.ProfileListBox_DoubleClick);
            // 
            // tabTemplates
            // 
            this.tabTemplates.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabTemplates.Location = new System.Drawing.Point(4, 27);
            this.tabTemplates.Name = "tabTemplates";
            this.tabTemplates.Size = new System.Drawing.Size(257, 204);
            this.tabTemplates.TabIndex = 2;
            this.tabTemplates.Text = "Templates";
            this.tabTemplates.UseVisualStyleBackColor = true;
            // 
            // ExecuteBtn
            // 
            this.ExecuteBtn.Location = new System.Drawing.Point(1014, 3);
            this.ExecuteBtn.Name = "ExecuteBtn";
            this.ExecuteBtn.Size = new System.Drawing.Size(90, 27);
            this.ExecuteBtn.TabIndex = 4;
            this.ExecuteBtn.Text = "Execute";
            this.ExecuteBtn.UseVisualStyleBackColor = true;
            // 
            // tabCentralControl
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tabCentralControl, 2);
            this.tabCentralControl.Controls.Add(this.DesignerTab);
            this.tabCentralControl.Controls.Add(this.FileSystemTab);
            this.tabCentralControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCentralControl.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCentralControl.Location = new System.Drawing.Point(274, 36);
            this.tabCentralControl.Name = "tabCentralControl";
            this.tabCentralControl.SelectedIndex = 0;
            this.tabCentralControl.Size = new System.Drawing.Size(836, 235);
            this.tabCentralControl.TabIndex = 5;
            // 
            // DesignerTab
            // 
            this.DesignerTab.Controls.Add(this.operationSettingsBox);
            this.DesignerTab.Controls.Add(this.destProviderSettingBox);
            this.DesignerTab.Controls.Add(this.srcProviderSettingBox);
            this.DesignerTab.Controls.Add(this.destPathToProviderObject);
            this.DesignerTab.Controls.Add(this.sourcePathToProviderLbl);
            this.DesignerTab.Controls.Add(this.OperationSettingsLbl);
            this.DesignerTab.Controls.Add(this.destProviderBox);
            this.DesignerTab.Controls.Add(this.destLbl);
            this.DesignerTab.Controls.Add(this.sourceProviderBox);
            this.DesignerTab.Controls.Add(this.sourceLbl);
            this.DesignerTab.Controls.Add(this.VerbLbl);
            this.DesignerTab.Controls.Add(this.VerbBox);
            this.DesignerTab.Controls.Add(this.WhatIfChkBox);
            this.DesignerTab.Location = new System.Drawing.Point(4, 27);
            this.DesignerTab.Name = "DesignerTab";
            this.DesignerTab.Padding = new System.Windows.Forms.Padding(3);
            this.DesignerTab.Size = new System.Drawing.Size(828, 204);
            this.DesignerTab.TabIndex = 0;
            this.DesignerTab.Text = "Designer";
            this.DesignerTab.UseVisualStyleBackColor = true;
            // 
            // operationSettingsBox
            // 
            this.operationSettingsBox.FormattingEnabled = true;
            this.operationSettingsBox.Items.AddRange(new object[] {
            "allowUntrusted",
            "appHostConfigDir",
            "declareParam",
            "declareParamFile",
            "dest",
            "disableLink",
            "disableRule",
            "disableSkipDirective",
            "enableLink",
            "enableRule",
            "enableSkipDirective",
            "postSync",
            "preSync",
            "removeParam",
            "replace",
            "retryAttempts",
            "retryInterval",
            "setParam",
            "setParamFile",
            "showSecure",
            "skip",
            "source",
            "unicode",
            "useCheckSum",
            "verb",
            "verbose",
            "webServerDir",
            "xml",
            "xpath"});
            this.operationSettingsBox.Location = new System.Drawing.Point(270, 167);
            this.operationSettingsBox.Name = "operationSettingsBox";
            this.operationSettingsBox.Size = new System.Drawing.Size(464, 26);
            this.operationSettingsBox.TabIndex = 12;
            // 
            // destProviderSettingBox
            // 
            this.destProviderSettingBox.FormattingEnabled = true;
            this.destProviderSettingBox.Items.AddRange(new object[] {
            "authType",
            "computerName",
            "encryptPassword",
            "getCredentials",
            "ignoreErrors",
            "includeAcls",
            "password",
            "storeCredentials",
            "tempAgent",
            "userName",
            "wmsvc"});
            this.destProviderSettingBox.Location = new System.Drawing.Point(478, 116);
            this.destProviderSettingBox.Name = "destProviderSettingBox";
            this.destProviderSettingBox.Size = new System.Drawing.Size(257, 26);
            this.destProviderSettingBox.TabIndex = 11;
            // 
            // srcProviderSettingBox
            // 
            this.srcProviderSettingBox.FormattingEnabled = true;
            this.srcProviderSettingBox.Items.AddRange(new object[] {
            "authType",
            "computerName",
            "encryptPassword",
            "getCredentials",
            "ignoreErrors",
            "includeAcls",
            "password",
            "storeCredentials",
            "tempAgent",
            "userName",
            "wmsvc"});
            this.srcProviderSettingBox.Location = new System.Drawing.Point(477, 68);
            this.srcProviderSettingBox.Name = "srcProviderSettingBox";
            this.srcProviderSettingBox.Size = new System.Drawing.Size(257, 26);
            this.srcProviderSettingBox.TabIndex = 10;
            // 
            // destPathToProviderObject
            // 
            this.destPathToProviderObject.AutoSize = true;
            this.destPathToProviderObject.Location = new System.Drawing.Point(275, 120);
            this.destPathToProviderObject.Name = "destPathToProviderObject";
            this.destPathToProviderObject.Size = new System.Drawing.Size(176, 18);
            this.destPathToProviderObject.TabIndex = 9;
            this.destPathToProviderObject.Text = "=pathToProviderObject";
            // 
            // sourcePathToProviderLbl
            // 
            this.sourcePathToProviderLbl.AutoSize = true;
            this.sourcePathToProviderLbl.Location = new System.Drawing.Point(275, 71);
            this.sourcePathToProviderLbl.Name = "sourcePathToProviderLbl";
            this.sourcePathToProviderLbl.Size = new System.Drawing.Size(176, 18);
            this.sourcePathToProviderLbl.TabIndex = 8;
            this.sourcePathToProviderLbl.Text = "=pathToProviderObject";
            // 
            // OperationSettingsLbl
            // 
            this.OperationSettingsLbl.AutoSize = true;
            this.OperationSettingsLbl.Location = new System.Drawing.Point(11, 170);
            this.OperationSettingsLbl.Name = "OperationSettingsLbl";
            this.OperationSettingsLbl.Size = new System.Drawing.Size(216, 18);
            this.OperationSettingsLbl.TabIndex = 7;
            this.OperationSettingsLbl.Text = "-MSDeployOperationSettings";
            // 
            // destProviderBox
            // 
            this.destProviderBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.destProviderBox.FormattingEnabled = true;
            this.destProviderBox.Items.AddRange(new object[] {
            "Provider1",
            "Provider2",
            "Provider3"});
            this.destProviderBox.Location = new System.Drawing.Point(89, 116);
            this.destProviderBox.Name = "destProviderBox";
            this.destProviderBox.Size = new System.Drawing.Size(159, 26);
            this.destProviderBox.TabIndex = 6;
            this.destProviderBox.SelectedIndexChanged += new System.EventHandler(this.destProviderBox_SelectedIndexChanged);
            // 
            // destLbl
            // 
            this.destLbl.AutoSize = true;
            this.destLbl.Location = new System.Drawing.Point(11, 120);
            this.destLbl.Name = "destLbl";
            this.destLbl.Size = new System.Drawing.Size(56, 18);
            this.destLbl.TabIndex = 5;
            this.destLbl.Text = "-dest:";
            // 
            // sourceProviderBox
            // 
            this.sourceProviderBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sourceProviderBox.FormattingEnabled = true;
            this.sourceProviderBox.Items.AddRange(new object[] {
            "Provider 1",
            "Provider 2",
            "Provider 3"});
            this.sourceProviderBox.Location = new System.Drawing.Point(89, 68);
            this.sourceProviderBox.Name = "sourceProviderBox";
            this.sourceProviderBox.Size = new System.Drawing.Size(159, 26);
            this.sourceProviderBox.TabIndex = 4;
            this.sourceProviderBox.SelectedIndexChanged += new System.EventHandler(this.sourceProviderBox_SelectedIndexChanged);
            // 
            // sourceLbl
            // 
            this.sourceLbl.AutoSize = true;
            this.sourceLbl.Location = new System.Drawing.Point(11, 71);
            this.sourceLbl.Name = "sourceLbl";
            this.sourceLbl.Size = new System.Drawing.Size(72, 18);
            this.sourceLbl.TabIndex = 3;
            this.sourceLbl.Text = "-source:";
            // 
            // VerbLbl
            // 
            this.VerbLbl.AutoSize = true;
            this.VerbLbl.Location = new System.Drawing.Point(11, 25);
            this.VerbLbl.Name = "VerbLbl";
            this.VerbLbl.Size = new System.Drawing.Size(56, 18);
            this.VerbLbl.TabIndex = 2;
            this.VerbLbl.Text = "-verb:";
            // 
            // VerbBox
            // 
            this.VerbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VerbBox.FormattingEnabled = true;
            this.VerbBox.Items.AddRange(new object[] {
            "delete",
            "dump",
            "getDependencies",
            "getSystemInfo",
            "sync"});
            this.VerbBox.Location = new System.Drawing.Point(89, 21);
            this.VerbBox.Name = "VerbBox";
            this.VerbBox.Size = new System.Drawing.Size(159, 26);
            this.VerbBox.TabIndex = 1;
            this.VerbBox.SelectedIndexChanged += new System.EventHandler(this.VerbBox_SelectedIndexChanged);
            // 
            // WhatIfChkBox
            // 
            this.WhatIfChkBox.AutoSize = true;
            this.WhatIfChkBox.Location = new System.Drawing.Point(731, 21);
            this.WhatIfChkBox.Name = "WhatIfChkBox";
            this.WhatIfChkBox.Size = new System.Drawing.Size(86, 22);
            this.WhatIfChkBox.TabIndex = 0;
            this.WhatIfChkBox.Text = "-whatif";
            this.WhatIfChkBox.UseVisualStyleBackColor = true;
            this.WhatIfChkBox.CheckedChanged += new System.EventHandler(this.WhatIfChkBox_CheckedChanged);
            // 
            // FileSystemTab
            // 
            this.FileSystemTab.Location = new System.Drawing.Point(4, 27);
            this.FileSystemTab.Name = "FileSystemTab";
            this.FileSystemTab.Padding = new System.Windows.Forms.Padding(3);
            this.FileSystemTab.Size = new System.Drawing.Size(828, 204);
            this.FileSystemTab.TabIndex = 1;
            this.FileSystemTab.Text = "File System";
            this.FileSystemTab.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 516);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "MSDeployGUI";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabLeftControl.ResumeLayout(false);
            this.tabHistory.ResumeLayout(false);
            this.tabProfiles.ResumeLayout(false);
            this.tabCentralControl.ResumeLayout(false);
            this.DesignerTab.ResumeLayout(false);
            this.DesignerTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ConsoleControl.ConsoleControl console;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClearHistoryToolStripMenuItem;
        private System.Windows.Forms.ComboBox commandBox;
        private System.Windows.Forms.TabControl tabLeftControl;
        private System.Windows.Forms.TabPage tabHistory;
        private System.Windows.Forms.TabPage tabProfiles;
        private System.Windows.Forms.Button ExecuteBtn;
        private System.Windows.Forms.TabPage tabTemplates;
        private System.Windows.Forms.ToolStripMenuItem addProfileToolStripMenuItem;
        private System.Windows.Forms.ListBox HistoryListBox;
        private System.Windows.Forms.TabControl tabCentralControl;
        private System.Windows.Forms.TabPage DesignerTab;
        private System.Windows.Forms.TabPage FileSystemTab;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem SaveHistoryToolStripMenuItem;
        private System.Windows.Forms.ListBox ProfileListBox;
        private System.Windows.Forms.ToolStripMenuItem SettingsMenuItem3;
        private System.Windows.Forms.CheckBox WhatIfChkBox;
        private System.Windows.Forms.ComboBox VerbBox;
        private System.Windows.Forms.Label VerbLbl;
        private System.Windows.Forms.Label sourceLbl;
        private System.Windows.Forms.ComboBox sourceProviderBox;
        private System.Windows.Forms.Label destLbl;
        private System.Windows.Forms.ComboBox destProviderBox;
        private System.Windows.Forms.Label OperationSettingsLbl;
        private System.Windows.Forms.Label sourcePathToProviderLbl;
        private System.Windows.Forms.Label destPathToProviderObject;
        private System.Windows.Forms.ComboBox srcProviderSettingBox;
        private System.Windows.Forms.ComboBox destProviderSettingBox;
        private System.Windows.Forms.ComboBox operationSettingsBox;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMSDeployGUIToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator aboutMSDeployGUIToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutMSDeployGUIToolStripMenuItem2;
    }
}