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
            this.TabSync = new System.Windows.Forms.TabPage();
            this.destProviderSettingBox = new System.Windows.Forms.ComboBox();
            this.srcProviderSettingBox = new System.Windows.Forms.ComboBox();
            this.destPathToProviderObject = new System.Windows.Forms.Label();
            this.sourcePathToProviderLbl = new System.Windows.Forms.Label();
            this.syncdestProviderBox = new System.Windows.Forms.ComboBox();
            this.syncdestLbl = new System.Windows.Forms.Label();
            this.syncsourceProviderBox = new System.Windows.Forms.ComboBox();
            this.syncsourceLbl = new System.Windows.Forms.Label();
            this.TabDump = new System.Windows.Forms.TabPage();
            this.dumpSourceFileFolderDialogBtn = new System.Windows.Forms.Button();
            this.dumpsourcePathToPOBox = new System.Windows.Forms.TextBox();
            this.dumpsourceProviderBox = new System.Windows.Forms.ComboBox();
            this.dumpsourceLbl = new System.Windows.Forms.Label();
            this.TabDelete = new System.Windows.Forms.TabPage();
            this.TabGetSystemInfo = new System.Windows.Forms.TabPage();
            this.TabGetDependencies = new System.Windows.Forms.TabPage();
            this.FileSystemTab = new System.Windows.Forms.TabPage();
            this.cellpanelfordesigneroptions = new System.Windows.Forms.Panel();
            this.operationSettingsBox = new System.Windows.Forms.ComboBox();
            this.OperationSettingsLbl = new System.Windows.Forms.Label();
            this.WhatIfChkBox = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabLeftControl.SuspendLayout();
            this.tabHistory.SuspendLayout();
            this.tabProfiles.SuspendLayout();
            this.tabCentralControl.SuspendLayout();
            this.TabSync.SuspendLayout();
            this.TabDump.SuspendLayout();
            this.cellpanelfordesigneroptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.80514F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.19486F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tableLayoutPanel1.Controls.Add(this.console, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.commandBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabLeftControl, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ExecuteBtn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabCentralControl, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cellpanelfordesigneroptions, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1113, 516);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // console
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.console, 3);
            this.console.Dock = System.Windows.Forms.DockStyle.Fill;
            this.console.IsInputEnabled = true;
            this.console.Location = new System.Drawing.Point(4, 301);
            this.console.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.console.Name = "console";
            this.console.SendKeyboardCommandsToProcess = false;
            this.console.ShowDiagnostics = false;
            this.console.Size = new System.Drawing.Size(1105, 211);
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
            this.menuStrip1.Size = new System.Drawing.Size(265, 28);
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
            this.aboutMSDeployGUIToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.aboutMSDeployGUIToolStripMenuItem.Text = "Running as";
            // 
            // aboutMSDeployGUIToolStripMenuItem1
            // 
            this.aboutMSDeployGUIToolStripMenuItem1.Name = "aboutMSDeployGUIToolStripMenuItem1";
            this.aboutMSDeployGUIToolStripMenuItem1.Size = new System.Drawing.Size(219, 6);
            // 
            // aboutMSDeployGUIToolStripMenuItem2
            // 
            this.aboutMSDeployGUIToolStripMenuItem2.Name = "aboutMSDeployGUIToolStripMenuItem2";
            this.aboutMSDeployGUIToolStripMenuItem2.Size = new System.Drawing.Size(222, 26);
            this.aboutMSDeployGUIToolStripMenuItem2.Text = "About MSDeployGUI";
            // 
            // commandBox
            // 
            this.commandBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commandBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commandBox.FormattingEnabled = true;
            this.commandBox.Location = new System.Drawing.Point(268, 3);
            this.commandBox.Name = "commandBox";
            this.commandBox.Size = new System.Drawing.Size(719, 26);
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
            this.tableLayoutPanel1.SetRowSpan(this.tabLeftControl, 2);
            this.tabLeftControl.SelectedIndex = 0;
            this.tabLeftControl.Size = new System.Drawing.Size(259, 258);
            this.tabLeftControl.TabIndex = 3;
            // 
            // tabHistory
            // 
            this.tabHistory.Controls.Add(this.HistoryListBox);
            this.tabHistory.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabHistory.Location = new System.Drawing.Point(4, 27);
            this.tabHistory.Name = "tabHistory";
            this.tabHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabHistory.Size = new System.Drawing.Size(251, 227);
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
            this.HistoryListBox.Size = new System.Drawing.Size(245, 221);
            this.HistoryListBox.TabIndex = 5;
            // 
            // tabProfiles
            // 
            this.tabProfiles.Controls.Add(this.ProfileListBox);
            this.tabProfiles.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabProfiles.Location = new System.Drawing.Point(4, 27);
            this.tabProfiles.Name = "tabProfiles";
            this.tabProfiles.Padding = new System.Windows.Forms.Padding(3);
            this.tabProfiles.Size = new System.Drawing.Size(251, 227);
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
            this.ProfileListBox.Size = new System.Drawing.Size(245, 221);
            this.ProfileListBox.TabIndex = 0;
            this.ProfileListBox.DoubleClick += new System.EventHandler(this.ProfileListBox_DoubleClick);
            // 
            // tabTemplates
            // 
            this.tabTemplates.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabTemplates.Location = new System.Drawing.Point(4, 27);
            this.tabTemplates.Name = "tabTemplates";
            this.tabTemplates.Size = new System.Drawing.Size(251, 227);
            this.tabTemplates.TabIndex = 2;
            this.tabTemplates.Text = "Templates";
            this.tabTemplates.UseVisualStyleBackColor = true;
            // 
            // ExecuteBtn
            // 
            this.ExecuteBtn.Location = new System.Drawing.Point(993, 3);
            this.ExecuteBtn.Name = "ExecuteBtn";
            this.ExecuteBtn.Size = new System.Drawing.Size(90, 27);
            this.ExecuteBtn.TabIndex = 4;
            this.ExecuteBtn.Text = "Execute";
            this.ExecuteBtn.UseVisualStyleBackColor = true;
            // 
            // tabCentralControl
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tabCentralControl, 2);
            this.tabCentralControl.Controls.Add(this.TabSync);
            this.tabCentralControl.Controls.Add(this.TabDump);
            this.tabCentralControl.Controls.Add(this.TabDelete);
            this.tabCentralControl.Controls.Add(this.TabGetSystemInfo);
            this.tabCentralControl.Controls.Add(this.TabGetDependencies);
            this.tabCentralControl.Controls.Add(this.FileSystemTab);
            this.tabCentralControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCentralControl.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCentralControl.Location = new System.Drawing.Point(268, 36);
            this.tabCentralControl.Name = "tabCentralControl";
            this.tabCentralControl.SelectedIndex = 0;
            this.tabCentralControl.Size = new System.Drawing.Size(842, 213);
            this.tabCentralControl.TabIndex = 5;
            this.tabCentralControl.SelectedIndexChanged += new System.EventHandler(this.tabCentralControl_SelectedIndexChanged);
            // 
            // TabSync
            // 
            this.TabSync.Controls.Add(this.destProviderSettingBox);
            this.TabSync.Controls.Add(this.srcProviderSettingBox);
            this.TabSync.Controls.Add(this.destPathToProviderObject);
            this.TabSync.Controls.Add(this.sourcePathToProviderLbl);
            this.TabSync.Controls.Add(this.syncdestProviderBox);
            this.TabSync.Controls.Add(this.syncdestLbl);
            this.TabSync.Controls.Add(this.syncsourceProviderBox);
            this.TabSync.Controls.Add(this.syncsourceLbl);
            this.TabSync.Location = new System.Drawing.Point(4, 27);
            this.TabSync.Name = "TabSync";
            this.TabSync.Padding = new System.Windows.Forms.Padding(3);
            this.TabSync.Size = new System.Drawing.Size(834, 182);
            this.TabSync.TabIndex = 0;
            this.TabSync.Text = "sync";
            this.TabSync.UseVisualStyleBackColor = true;
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
            this.destProviderSettingBox.Location = new System.Drawing.Point(478, 64);
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
            this.srcProviderSettingBox.Location = new System.Drawing.Point(477, 16);
            this.srcProviderSettingBox.Name = "srcProviderSettingBox";
            this.srcProviderSettingBox.Size = new System.Drawing.Size(257, 26);
            this.srcProviderSettingBox.TabIndex = 10;
            // 
            // destPathToProviderObject
            // 
            this.destPathToProviderObject.AutoSize = true;
            this.destPathToProviderObject.Location = new System.Drawing.Point(275, 68);
            this.destPathToProviderObject.Name = "destPathToProviderObject";
            this.destPathToProviderObject.Size = new System.Drawing.Size(176, 18);
            this.destPathToProviderObject.TabIndex = 9;
            this.destPathToProviderObject.Text = "=pathToProviderObject";
            // 
            // sourcePathToProviderLbl
            // 
            this.sourcePathToProviderLbl.AutoSize = true;
            this.sourcePathToProviderLbl.Location = new System.Drawing.Point(275, 19);
            this.sourcePathToProviderLbl.Name = "sourcePathToProviderLbl";
            this.sourcePathToProviderLbl.Size = new System.Drawing.Size(176, 18);
            this.sourcePathToProviderLbl.TabIndex = 8;
            this.sourcePathToProviderLbl.Text = "=pathToProviderObject";
            // 
            // syncdestProviderBox
            // 
            this.syncdestProviderBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.syncdestProviderBox.FormattingEnabled = true;
            this.syncdestProviderBox.Items.AddRange(new object[] {
            "Provider1",
            "Provider2",
            "Provider3"});
            this.syncdestProviderBox.Location = new System.Drawing.Point(89, 64);
            this.syncdestProviderBox.Name = "syncdestProviderBox";
            this.syncdestProviderBox.Size = new System.Drawing.Size(159, 26);
            this.syncdestProviderBox.TabIndex = 6;
            // 
            // syncdestLbl
            // 
            this.syncdestLbl.AutoSize = true;
            this.syncdestLbl.Location = new System.Drawing.Point(11, 68);
            this.syncdestLbl.Name = "syncdestLbl";
            this.syncdestLbl.Size = new System.Drawing.Size(56, 18);
            this.syncdestLbl.TabIndex = 5;
            this.syncdestLbl.Text = "-dest:";
            // 
            // syncsourceProviderBox
            // 
            this.syncsourceProviderBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.syncsourceProviderBox.FormattingEnabled = true;
            this.syncsourceProviderBox.Items.AddRange(new object[] {
            "Provider 1",
            "Provider 2",
            "Provider 3"});
            this.syncsourceProviderBox.Location = new System.Drawing.Point(89, 16);
            this.syncsourceProviderBox.Name = "syncsourceProviderBox";
            this.syncsourceProviderBox.Size = new System.Drawing.Size(159, 26);
            this.syncsourceProviderBox.TabIndex = 4;
            // 
            // syncsourceLbl
            // 
            this.syncsourceLbl.AutoSize = true;
            this.syncsourceLbl.Location = new System.Drawing.Point(11, 19);
            this.syncsourceLbl.Name = "syncsourceLbl";
            this.syncsourceLbl.Size = new System.Drawing.Size(72, 18);
            this.syncsourceLbl.TabIndex = 3;
            this.syncsourceLbl.Text = "-source:";
            // 
            // TabDump
            // 
            this.TabDump.Controls.Add(this.dumpSourceFileFolderDialogBtn);
            this.TabDump.Controls.Add(this.dumpsourcePathToPOBox);
            this.TabDump.Controls.Add(this.dumpsourceProviderBox);
            this.TabDump.Controls.Add(this.dumpsourceLbl);
            this.TabDump.Location = new System.Drawing.Point(4, 27);
            this.TabDump.Name = "TabDump";
            this.TabDump.Padding = new System.Windows.Forms.Padding(3);
            this.TabDump.Size = new System.Drawing.Size(834, 182);
            this.TabDump.TabIndex = 2;
            this.TabDump.Text = "dump";
            this.TabDump.UseVisualStyleBackColor = true;
            // 
            // dumpSourceFileFolderDialogBtn
            // 
            this.dumpSourceFileFolderDialogBtn.Image = global::MSDeployGUI.Properties.Resources.FileSource_16x_32;
            this.dumpSourceFileFolderDialogBtn.Location = new System.Drawing.Point(272, 16);
            this.dumpSourceFileFolderDialogBtn.Name = "dumpSourceFileFolderDialogBtn";
            this.dumpSourceFileFolderDialogBtn.Size = new System.Drawing.Size(29, 26);
            this.dumpSourceFileFolderDialogBtn.TabIndex = 4;
            this.dumpSourceFileFolderDialogBtn.UseVisualStyleBackColor = true;
            this.dumpSourceFileFolderDialogBtn.Click += new System.EventHandler(this.dumpSourceFileFolderDialogBtn_Click);
            // 
            // dumpsourcePathToPOBox
            // 
            this.dumpsourcePathToPOBox.Location = new System.Drawing.Point(307, 17);
            this.dumpsourcePathToPOBox.Name = "dumpsourcePathToPOBox";
            this.dumpsourcePathToPOBox.Size = new System.Drawing.Size(418, 25);
            this.dumpsourcePathToPOBox.TabIndex = 3;
            // 
            // dumpsourceProviderBox
            // 
            this.dumpsourceProviderBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dumpsourceProviderBox.FormattingEnabled = true;
            this.dumpsourceProviderBox.Items.AddRange(new object[] {
            "contentPath",
            "dirPath",
            "filePath",
            "webServer"});
            this.dumpsourceProviderBox.Location = new System.Drawing.Point(89, 16);
            this.dumpsourceProviderBox.Name = "dumpsourceProviderBox";
            this.dumpsourceProviderBox.Size = new System.Drawing.Size(159, 26);
            this.dumpsourceProviderBox.TabIndex = 1;
            this.dumpsourceProviderBox.SelectedIndexChanged += new System.EventHandler(this.dumpsourceProviderBox_SelectedIndexChanged);
            // 
            // dumpsourceLbl
            // 
            this.dumpsourceLbl.AutoSize = true;
            this.dumpsourceLbl.Location = new System.Drawing.Point(11, 19);
            this.dumpsourceLbl.Name = "dumpsourceLbl";
            this.dumpsourceLbl.Size = new System.Drawing.Size(72, 18);
            this.dumpsourceLbl.TabIndex = 0;
            this.dumpsourceLbl.Text = "-source:";
            // 
            // TabDelete
            // 
            this.TabDelete.Location = new System.Drawing.Point(4, 27);
            this.TabDelete.Name = "TabDelete";
            this.TabDelete.Padding = new System.Windows.Forms.Padding(3);
            this.TabDelete.Size = new System.Drawing.Size(834, 182);
            this.TabDelete.TabIndex = 3;
            this.TabDelete.Text = "delete";
            this.TabDelete.UseVisualStyleBackColor = true;
            // 
            // TabGetSystemInfo
            // 
            this.TabGetSystemInfo.Location = new System.Drawing.Point(4, 27);
            this.TabGetSystemInfo.Name = "TabGetSystemInfo";
            this.TabGetSystemInfo.Size = new System.Drawing.Size(834, 182);
            this.TabGetSystemInfo.TabIndex = 4;
            this.TabGetSystemInfo.Text = "getSystemInfo";
            this.TabGetSystemInfo.UseVisualStyleBackColor = true;
            // 
            // TabGetDependencies
            // 
            this.TabGetDependencies.Location = new System.Drawing.Point(4, 27);
            this.TabGetDependencies.Name = "TabGetDependencies";
            this.TabGetDependencies.Size = new System.Drawing.Size(834, 182);
            this.TabGetDependencies.TabIndex = 5;
            this.TabGetDependencies.Text = "getDependencies";
            this.TabGetDependencies.UseVisualStyleBackColor = true;
            // 
            // FileSystemTab
            // 
            this.FileSystemTab.Location = new System.Drawing.Point(4, 27);
            this.FileSystemTab.Name = "FileSystemTab";
            this.FileSystemTab.Padding = new System.Windows.Forms.Padding(3);
            this.FileSystemTab.Size = new System.Drawing.Size(834, 182);
            this.FileSystemTab.TabIndex = 1;
            this.FileSystemTab.Text = "File System";
            this.FileSystemTab.UseVisualStyleBackColor = true;
            // 
            // cellpanelfordesigneroptions
            // 
            this.cellpanelfordesigneroptions.Controls.Add(this.operationSettingsBox);
            this.cellpanelfordesigneroptions.Controls.Add(this.OperationSettingsLbl);
            this.cellpanelfordesigneroptions.Controls.Add(this.WhatIfChkBox);
            this.cellpanelfordesigneroptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cellpanelfordesigneroptions.Location = new System.Drawing.Point(268, 255);
            this.cellpanelfordesigneroptions.Name = "cellpanelfordesigneroptions";
            this.cellpanelfordesigneroptions.Size = new System.Drawing.Size(719, 39);
            this.cellpanelfordesigneroptions.TabIndex = 6;
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
            this.operationSettingsBox.Location = new System.Drawing.Point(337, 9);
            this.operationSettingsBox.Name = "operationSettingsBox";
            this.operationSettingsBox.Size = new System.Drawing.Size(375, 24);
            this.operationSettingsBox.TabIndex = 16;
            // 
            // OperationSettingsLbl
            // 
            this.OperationSettingsLbl.AutoSize = true;
            this.OperationSettingsLbl.Location = new System.Drawing.Point(118, 12);
            this.OperationSettingsLbl.Name = "OperationSettingsLbl";
            this.OperationSettingsLbl.Size = new System.Drawing.Size(191, 17);
            this.OperationSettingsLbl.TabIndex = 15;
            this.OperationSettingsLbl.Text = "-MSDeployOperationSettings";
            // 
            // WhatIfChkBox
            // 
            this.WhatIfChkBox.AutoSize = true;
            this.WhatIfChkBox.Location = new System.Drawing.Point(16, 11);
            this.WhatIfChkBox.Name = "WhatIfChkBox";
            this.WhatIfChkBox.Size = new System.Drawing.Size(71, 21);
            this.WhatIfChkBox.TabIndex = 14;
            this.WhatIfChkBox.Text = "-whatIf";
            this.WhatIfChkBox.UseVisualStyleBackColor = true;
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
            this.TabSync.ResumeLayout(false);
            this.TabSync.PerformLayout();
            this.TabDump.ResumeLayout(false);
            this.TabDump.PerformLayout();
            this.cellpanelfordesigneroptions.ResumeLayout(false);
            this.cellpanelfordesigneroptions.PerformLayout();
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
        private System.Windows.Forms.TabPage TabSync;
        private System.Windows.Forms.TabPage FileSystemTab;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem SaveHistoryToolStripMenuItem;
        private System.Windows.Forms.ListBox ProfileListBox;
        private System.Windows.Forms.ToolStripMenuItem SettingsMenuItem3;
        private System.Windows.Forms.Label syncsourceLbl;
        private System.Windows.Forms.ComboBox syncsourceProviderBox;
        private System.Windows.Forms.Label syncdestLbl;
        private System.Windows.Forms.ComboBox syncdestProviderBox;
        private System.Windows.Forms.Label sourcePathToProviderLbl;
        private System.Windows.Forms.Label destPathToProviderObject;
        private System.Windows.Forms.ComboBox srcProviderSettingBox;
        private System.Windows.Forms.ComboBox destProviderSettingBox;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMSDeployGUIToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator aboutMSDeployGUIToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutMSDeployGUIToolStripMenuItem2;
        private System.Windows.Forms.TabPage TabDump;
        private System.Windows.Forms.TabPage TabDelete;
        private System.Windows.Forms.TabPage TabGetSystemInfo;
        private System.Windows.Forms.Panel cellpanelfordesigneroptions;
        private System.Windows.Forms.CheckBox WhatIfChkBox;
        private System.Windows.Forms.TabPage TabGetDependencies;
        private System.Windows.Forms.ComboBox operationSettingsBox;
        private System.Windows.Forms.Label OperationSettingsLbl;
        private System.Windows.Forms.Label dumpsourceLbl;
        private System.Windows.Forms.ComboBox dumpsourceProviderBox;
        private System.Windows.Forms.TextBox dumpsourcePathToPOBox;
        private System.Windows.Forms.Button dumpSourceFileFolderDialogBtn;
    }
}