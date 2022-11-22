namespace ElvUIUpdater {
	partial class MainForm {
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.updatesLeftTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.installButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.logListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.versionsListView = new System.Windows.Forms.ListView();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.updatesResetLabel = new System.Windows.Forms.Label();
            this.checkForUpdatesButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.updatesLeftLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.gameLocationLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.gameLocationTextBox = new System.Windows.Forms.TextBox();
            this.gameLocationButton = new System.Windows.Forms.Button();
            this.elvuiVersionLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesOnProgramStartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.installLatestVersionOnProgramStartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.checkForNewElvUIUpdaterOnProgramStartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForNewElvUIUpdaterVersionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel7, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1, 165);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(798, 284);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.installButton, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.logListView, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(399, 1);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(398, 282);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // installButton
            // 
            this.installButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.installButton.AutoSize = true;
            this.installButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.installButton.Enabled = false;
            this.installButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.installButton.Location = new System.Drawing.Point(111, 10);
            this.installButton.Margin = new System.Windows.Forms.Padding(10);
            this.installButton.Name = "installButton";
            this.installButton.Size = new System.Drawing.Size(176, 31);
            this.installButton.TabIndex = 0;
            this.installButton.Text = "Install selected version";
            this.installButton.UseVisualStyleBackColor = true;
            this.installButton.Click += new System.EventHandler(this.installButton_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Log:";
            // 
            // logListView
            // 
            this.logListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.logListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.logListView.HideSelection = true;
            this.logListView.LabelWrap = false;
            this.logListView.Location = new System.Drawing.Point(0, 66);
            this.logListView.Margin = new System.Windows.Forms.Padding(0);
            this.logListView.MultiSelect = false;
            this.logListView.Name = "logListView";
            this.logListView.ShowGroups = false;
            this.logListView.Size = new System.Drawing.Size(398, 216);
            this.logListView.TabIndex = 3;
            this.logListView.UseCompatibleStateImageBehavior = false;
            this.logListView.View = System.Windows.Forms.View.Details;
            this.logListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.logListView_ItemSelectionChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 25;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.AutoSize = true;
            this.tableLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.versionsListView, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.checkForUpdatesButton, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(1, 1);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 4;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(397, 282);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // versionsListView
            // 
            this.versionsListView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.versionsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.versionsListView.FullRowSelect = true;
            this.versionsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.versionsListView.Location = new System.Drawing.Point(123, 103);
            this.versionsListView.Margin = new System.Windows.Forms.Padding(10);
            this.versionsListView.MultiSelect = false;
            this.versionsListView.Name = "versionsListView";
            this.versionsListView.Size = new System.Drawing.Size(150, 169);
            this.versionsListView.TabIndex = 3;
            this.versionsListView.UseCompatibleStateImageBehavior = false;
            this.versionsListView.View = System.Windows.Forms.View.Details;
            this.versionsListView.SelectedIndexChanged += new System.EventHandler(this.versionsListView_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 125;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.updatesResetLabel, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(151, 72);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(94, 21);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Resets at:";
            // 
            // updatesResetLabel
            // 
            this.updatesResetLabel.AutoSize = true;
            this.updatesResetLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updatesResetLabel.Location = new System.Drawing.Point(75, 0);
            this.updatesResetLabel.Margin = new System.Windows.Forms.Padding(0);
            this.updatesResetLabel.Name = "updatesResetLabel";
            this.updatesResetLabel.Size = new System.Drawing.Size(19, 21);
            this.updatesResetLabel.TabIndex = 1;
            this.updatesResetLabel.Text = "0";
            // 
            // checkForUpdatesButton
            // 
            this.checkForUpdatesButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkForUpdatesButton.AutoSize = true;
            this.checkForUpdatesButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.checkForUpdatesButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkForUpdatesButton.Location = new System.Drawing.Point(126, 10);
            this.checkForUpdatesButton.Margin = new System.Windows.Forms.Padding(10);
            this.checkForUpdatesButton.Name = "checkForUpdatesButton";
            this.checkForUpdatesButton.Size = new System.Drawing.Size(145, 31);
            this.checkForUpdatesButton.TabIndex = 0;
            this.checkForUpdatesButton.Text = "Check for updates";
            this.checkForUpdatesButton.UseVisualStyleBackColor = true;
            this.checkForUpdatesButton.Click += new System.EventHandler(this.checkForUpdatesButton_Click);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel6.AutoSize = true;
            this.tableLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.Controls.Add(this.updatesLeftLabel, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(103, 51);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.Size = new System.Drawing.Size(190, 21);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // updatesLeftLabel
            // 
            this.updatesLeftLabel.AutoSize = true;
            this.updatesLeftLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updatesLeftLabel.Location = new System.Drawing.Point(171, 0);
            this.updatesLeftLabel.Margin = new System.Windows.Forms.Padding(0);
            this.updatesLeftLabel.Name = "updatesLeftLabel";
            this.updatesLeftLabel.Size = new System.Drawing.Size(19, 21);
            this.updatesLeftLabel.TabIndex = 1;
            this.updatesLeftLabel.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Checks for updates left:";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.AutoSize = true;
            this.tableLayoutPanel7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.gameLocationLabel, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel8, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.elvuiVersionLabel, 0, 2);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(1, 26);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 3;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.Size = new System.Drawing.Size(798, 138);
            this.tableLayoutPanel7.TabIndex = 2;
            // 
            // gameLocationLabel
            // 
            this.gameLocationLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gameLocationLabel.AutoSize = true;
            this.gameLocationLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gameLocationLabel.ForeColor = System.Drawing.Color.Red;
            this.gameLocationLabel.Location = new System.Drawing.Point(111, 10);
            this.gameLocationLabel.Margin = new System.Windows.Forms.Padding(10);
            this.gameLocationLabel.Name = "gameLocationLabel";
            this.gameLocationLabel.Size = new System.Drawing.Size(576, 42);
            this.gameLocationLabel.TabIndex = 0;
            this.gameLocationLabel.Text = "WoW addon directory not found\r\nThis is usually C:\\Program Files (x86)\\World of Wa" +
    "rcraft\\_retail_\\Interface\\AddOns";
            this.gameLocationLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel8.AutoSize = true;
            this.tableLayoutPanel8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel8.Controls.Add(this.gameLocationTextBox, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.gameLocationButton, 1, 0);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(78, 62);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel8.Size = new System.Drawing.Size(641, 35);
            this.tableLayoutPanel8.TabIndex = 1;
            // 
            // gameLocationTextBox
            // 
            this.gameLocationTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gameLocationTextBox.Enabled = false;
            this.gameLocationTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gameLocationTextBox.Location = new System.Drawing.Point(3, 3);
            this.gameLocationTextBox.Name = "gameLocationTextBox";
            this.gameLocationTextBox.Size = new System.Drawing.Size(600, 29);
            this.gameLocationTextBox.TabIndex = 0;
            // 
            // gameLocationButton
            // 
            this.gameLocationButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gameLocationButton.AutoSize = true;
            this.gameLocationButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gameLocationButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gameLocationButton.Location = new System.Drawing.Point(606, 2);
            this.gameLocationButton.Margin = new System.Windows.Forms.Padding(0);
            this.gameLocationButton.Name = "gameLocationButton";
            this.gameLocationButton.Size = new System.Drawing.Size(35, 31);
            this.gameLocationButton.TabIndex = 1;
            this.gameLocationButton.Text = "⋯";
            this.gameLocationButton.UseVisualStyleBackColor = true;
            this.gameLocationButton.Click += new System.EventHandler(this.gameLocationButton_Click);
            // 
            // elvuiVersionLabel
            // 
            this.elvuiVersionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.elvuiVersionLabel.AutoSize = true;
            this.elvuiVersionLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.elvuiVersionLabel.Location = new System.Drawing.Point(275, 107);
            this.elvuiVersionLabel.Margin = new System.Windows.Forms.Padding(10);
            this.elvuiVersionLabel.Name = "elvuiVersionLabel";
            this.elvuiVersionLabel.Size = new System.Drawing.Size(248, 21);
            this.elvuiVersionLabel.TabIndex = 2;
            this.elvuiVersionLabel.Text = "ElvUI not found in addon directory";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.checkForNewElvUIUpdaterVersionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(1, 1);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(798, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkForUpdatesOnProgramStartToolStripMenuItem,
            this.installLatestVersionOnProgramStartToolStripMenuItem,
            this.toolStripSeparator1,
            this.checkForNewElvUIUpdaterOnProgramStartToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // checkForUpdatesOnProgramStartToolStripMenuItem
            // 
            this.checkForUpdatesOnProgramStartToolStripMenuItem.CheckOnClick = true;
            this.checkForUpdatesOnProgramStartToolStripMenuItem.Name = "checkForUpdatesOnProgramStartToolStripMenuItem";
            this.checkForUpdatesOnProgramStartToolStripMenuItem.Size = new System.Drawing.Size(316, 22);
            this.checkForUpdatesOnProgramStartToolStripMenuItem.Text = "Check for updates on program start";
            this.checkForUpdatesOnProgramStartToolStripMenuItem.CheckedChanged += new System.EventHandler(this.checkForUpdatesOnProgramStartToolStripMenuItem_CheckedChanged);
            // 
            // installLatestVersionOnProgramStartToolStripMenuItem
            // 
            this.installLatestVersionOnProgramStartToolStripMenuItem.CheckOnClick = true;
            this.installLatestVersionOnProgramStartToolStripMenuItem.Enabled = false;
            this.installLatestVersionOnProgramStartToolStripMenuItem.Name = "installLatestVersionOnProgramStartToolStripMenuItem";
            this.installLatestVersionOnProgramStartToolStripMenuItem.Size = new System.Drawing.Size(316, 22);
            this.installLatestVersionOnProgramStartToolStripMenuItem.Text = "Install latest version on program start";
            this.installLatestVersionOnProgramStartToolStripMenuItem.CheckedChanged += new System.EventHandler(this.installLatestVersionOnProgramStartToolStripMenuItem_CheckedChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(313, 6);
            // 
            // checkForNewElvUIUpdaterOnProgramStartToolStripMenuItem
            // 
            this.checkForNewElvUIUpdaterOnProgramStartToolStripMenuItem.Checked = true;
            this.checkForNewElvUIUpdaterOnProgramStartToolStripMenuItem.CheckOnClick = true;
            this.checkForNewElvUIUpdaterOnProgramStartToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkForNewElvUIUpdaterOnProgramStartToolStripMenuItem.Name = "checkForNewElvUIUpdaterOnProgramStartToolStripMenuItem";
            this.checkForNewElvUIUpdaterOnProgramStartToolStripMenuItem.Size = new System.Drawing.Size(316, 22);
            this.checkForNewElvUIUpdaterOnProgramStartToolStripMenuItem.Text = "Check for new ElvUI Updater on program start";
            this.checkForNewElvUIUpdaterOnProgramStartToolStripMenuItem.CheckedChanged += new System.EventHandler(this.checkForNewElvUIUpdaterOnProgramStartToolStripMenuItem_CheckedChanged);
            // 
            // checkForNewElvUIUpdaterVersionToolStripMenuItem
            // 
            this.checkForNewElvUIUpdaterVersionToolStripMenuItem.Name = "checkForNewElvUIUpdaterVersionToolStripMenuItem";
            this.checkForNewElvUIUpdaterVersionToolStripMenuItem.Size = new System.Drawing.Size(210, 20);
            this.checkForNewElvUIUpdaterVersionToolStripMenuItem.Text = "Check for new ElvUI Updater version";
            this.checkForNewElvUIUpdaterVersionToolStripMenuItem.Click += new System.EventHandler(this.checkForNewElvUIUpdaterVersionToolStripMenuItem_Click);
            // 
            // gameFolderBrowserDialog
            // 
            this.gameFolderBrowserDialog.AddToRecent = false;
            this.gameFolderBrowserDialog.Description = "Select the World of Warcraft game directory";
            this.gameFolderBrowserDialog.UseDescriptionForTitle = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "ElvUI Updater";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private ToolTip updatesLeftTooltip;
		private TableLayoutPanel tableLayoutPanel1;
		private TableLayoutPanel tableLayoutPanel2;
		private TableLayoutPanel tableLayoutPanel3;
		private TableLayoutPanel tableLayoutPanel5;
		private TableLayoutPanel tableLayoutPanel4;
		private Label label2;
		private Label updatesResetLabel;
		private Button checkForUpdatesButton;
		private TableLayoutPanel tableLayoutPanel6;
		private Label updatesLeftLabel;
		private Label label1;
		private TableLayoutPanel tableLayoutPanel7;
		private Label gameLocationLabel;
		private TableLayoutPanel tableLayoutPanel8;
		private TextBox gameLocationTextBox;
		private Button gameLocationButton;
		private FolderBrowserDialog gameFolderBrowserDialog;
		private Label elvuiVersionLabel;
		private Button installButton;
		private Label label3;
		private MenuStrip menuStrip1;
		private ToolStripMenuItem settingsToolStripMenuItem;
		private ToolStripMenuItem checkForUpdatesOnProgramStartToolStripMenuItem;
		private ToolStripMenuItem installLatestVersionOnProgramStartToolStripMenuItem;
		private ListView versionsListView;
		private ListView logListView;
		private ColumnHeader columnHeader1;
		private ColumnHeader columnHeader2;
		private ToolStripMenuItem checkForNewElvUIUpdaterVersionToolStripMenuItem;
		private ToolStripSeparator toolStripSeparator1;
		private ToolStripMenuItem checkForNewElvUIUpdaterOnProgramStartToolStripMenuItem;
	}
}