namespace SupportCenter
{
    partial class frmMain
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
            this.MenuBar = new System.Windows.Forms.MenuStrip();
            this.maintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMaintenanceMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bugMaintenanceMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientMaintenanceMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mtsView = new System.Windows.Forms.ToolStripMenuItem();
            this.clientViewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemViewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bugViewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timesheetViewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devDocViewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activitySummaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billingSheetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showCurrentMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllOpenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllClientIssuesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hotKeysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenItems = new System.Windows.Forms.GroupBox();
            this.grdOpenItems = new System.Windows.Forms.DataGridView();
            this.pnlControlPanel = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblCurrentClient = new System.Windows.Forms.Label();
            this.btnConnectChat = new System.Windows.Forms.Button();
            this.lblChatConnection = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.MenuBar.SuspendLayout();
            this.OpenItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOpenItems)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuBar
            // 
            this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maintenanceToolStripMenuItem,
            this.mtsView,
            this.toolsToolStripMenuItem,
            this.preferenceToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(994, 24);
            this.MenuBar.TabIndex = 0;
            // 
            // maintenanceToolStripMenuItem
            // 
            this.maintenanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemMaintenanceMenuItem,
            this.bugMaintenanceMenuItem,
            this.clientMaintenanceMenuItem});
            this.maintenanceToolStripMenuItem.Name = "maintenanceToolStripMenuItem";
            this.maintenanceToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.maintenanceToolStripMenuItem.Text = "New";
            // 
            // itemMaintenanceMenuItem
            // 
            this.itemMaintenanceMenuItem.Name = "itemMaintenanceMenuItem";
            this.itemMaintenanceMenuItem.Size = new System.Drawing.Size(105, 22);
            this.itemMaintenanceMenuItem.Text = "Item";
            // 
            // bugMaintenanceMenuItem
            // 
            this.bugMaintenanceMenuItem.Name = "bugMaintenanceMenuItem";
            this.bugMaintenanceMenuItem.Size = new System.Drawing.Size(105, 22);
            this.bugMaintenanceMenuItem.Text = "Bug";
            // 
            // clientMaintenanceMenuItem
            // 
            this.clientMaintenanceMenuItem.Name = "clientMaintenanceMenuItem";
            this.clientMaintenanceMenuItem.Size = new System.Drawing.Size(105, 22);
            this.clientMaintenanceMenuItem.Text = "Client";
            // 
            // mtsView
            // 
            this.mtsView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientViewMenuItem,
            this.itemViewMenuItem,
            this.bugViewMenuItem,
            this.timesheetViewMenuItem,
            this.devDocViewMenuItem});
            this.mtsView.Name = "mtsView";
            this.mtsView.Size = new System.Drawing.Size(44, 20);
            this.mtsView.Text = "View";
            // 
            // clientViewMenuItem
            // 
            this.clientViewMenuItem.Name = "clientViewMenuItem";
            this.clientViewMenuItem.Size = new System.Drawing.Size(129, 22);
            this.clientViewMenuItem.Text = "Clients";
            this.clientViewMenuItem.Click += new System.EventHandler(this.clientToolStripMenuItem1_Click);
            // 
            // itemViewMenuItem
            // 
            this.itemViewMenuItem.Name = "itemViewMenuItem";
            this.itemViewMenuItem.Size = new System.Drawing.Size(129, 22);
            this.itemViewMenuItem.Text = "Items";
            this.itemViewMenuItem.Click += new System.EventHandler(this.itemToolStripMenuItem1_Click);
            // 
            // bugViewMenuItem
            // 
            this.bugViewMenuItem.Name = "bugViewMenuItem";
            this.bugViewMenuItem.Size = new System.Drawing.Size(129, 22);
            this.bugViewMenuItem.Text = "Bugs";
            this.bugViewMenuItem.Click += new System.EventHandler(this.bugToolStripMenuItem1_Click);
            // 
            // timesheetViewMenuItem
            // 
            this.timesheetViewMenuItem.Name = "timesheetViewMenuItem";
            this.timesheetViewMenuItem.Size = new System.Drawing.Size(129, 22);
            this.timesheetViewMenuItem.Text = "Timesheet";
            this.timesheetViewMenuItem.Click += new System.EventHandler(this.timesheetToolStripMenuItem_Click);
            // 
            // devDocViewMenuItem
            // 
            this.devDocViewMenuItem.Name = "devDocViewMenuItem";
            this.devDocViewMenuItem.Size = new System.Drawing.Size(129, 22);
            this.devDocViewMenuItem.Text = "Dev Docs";
            this.devDocViewMenuItem.Click += new System.EventHandler(this.devDocViewMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.activitySummaryToolStripMenuItem,
            this.billingSheetsToolStripMenuItem,
            this.clientListToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // activitySummaryToolStripMenuItem
            // 
            this.activitySummaryToolStripMenuItem.Name = "activitySummaryToolStripMenuItem";
            this.activitySummaryToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.activitySummaryToolStripMenuItem.Text = "Activity Summary";
            // 
            // billingSheetsToolStripMenuItem
            // 
            this.billingSheetsToolStripMenuItem.Name = "billingSheetsToolStripMenuItem";
            this.billingSheetsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.billingSheetsToolStripMenuItem.Text = "Billing Sheets";
            // 
            // clientListToolStripMenuItem
            // 
            this.clientListToolStripMenuItem.Name = "clientListToolStripMenuItem";
            this.clientListToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.clientListToolStripMenuItem.Text = "Client List";
            // 
            // preferenceToolStripMenuItem
            // 
            this.preferenceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openItemsToolStripMenuItem});
            this.preferenceToolStripMenuItem.Name = "preferenceToolStripMenuItem";
            this.preferenceToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.preferenceToolStripMenuItem.Text = "Preferences";
            // 
            // openItemsToolStripMenuItem
            // 
            this.openItemsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showCurrentMenuItem,
            this.showAllOpenMenuItem,
            this.showAllClientIssuesMenuItem});
            this.openItemsToolStripMenuItem.Name = "openItemsToolStripMenuItem";
            this.openItemsToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.openItemsToolStripMenuItem.Text = "Open Items";
            // 
            // showCurrentMenuItem
            // 
            this.showCurrentMenuItem.Name = "showCurrentMenuItem";
            this.showCurrentMenuItem.Size = new System.Drawing.Size(188, 22);
            this.showCurrentMenuItem.Text = "Show Current";
            this.showCurrentMenuItem.Click += new System.EventHandler(this.showCurrentMenuItem_Click);
            // 
            // showAllOpenMenuItem
            // 
            this.showAllOpenMenuItem.Name = "showAllOpenMenuItem";
            this.showAllOpenMenuItem.Size = new System.Drawing.Size(188, 22);
            this.showAllOpenMenuItem.Text = "Show All Assigned";
            this.showAllOpenMenuItem.Click += new System.EventHandler(this.showAllOpenMenuItem_Click);
            // 
            // showAllClientIssuesMenuItem
            // 
            this.showAllClientIssuesMenuItem.Name = "showAllClientIssuesMenuItem";
            this.showAllClientIssuesMenuItem.Size = new System.Drawing.Size(188, 22);
            this.showAllClientIssuesMenuItem.Text = "Show All Client Issues";
            this.showAllClientIssuesMenuItem.Click += new System.EventHandler(this.showAllClientIssuesMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hotKeysToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // hotKeysToolStripMenuItem
            // 
            this.hotKeysToolStripMenuItem.Name = "hotKeysToolStripMenuItem";
            this.hotKeysToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.hotKeysToolStripMenuItem.Text = "Hot Keys";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // OpenItems
            // 
            this.OpenItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.OpenItems.Controls.Add(this.grdOpenItems);
            this.OpenItems.Location = new System.Drawing.Point(0, 23);
            this.OpenItems.Name = "OpenItems";
            this.OpenItems.Size = new System.Drawing.Size(283, 615);
            this.OpenItems.TabIndex = 2;
            this.OpenItems.TabStop = false;
            this.OpenItems.Text = "Open Items";
            // 
            // grdOpenItems
            // 
            this.grdOpenItems.AllowUserToAddRows = false;
            this.grdOpenItems.AllowUserToDeleteRows = false;
            this.grdOpenItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grdOpenItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOpenItems.Location = new System.Drawing.Point(6, 19);
            this.grdOpenItems.MultiSelect = false;
            this.grdOpenItems.Name = "grdOpenItems";
            this.grdOpenItems.Size = new System.Drawing.Size(270, 590);
            this.grdOpenItems.TabIndex = 0;
            this.grdOpenItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdOpenItems_CellContentClick);
            this.grdOpenItems.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdOpenItems_CellContentDoubleClick);
            // 
            // pnlControlPanel
            // 
            this.pnlControlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlControlPanel.Location = new System.Drawing.Point(282, 27);
            this.pnlControlPanel.Name = "pnlControlPanel";
            this.pnlControlPanel.Size = new System.Drawing.Size(712, 605);
            this.pnlControlPanel.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(683, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(169, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // lblCurrentClient
            // 
            this.lblCurrentClient.AutoSize = true;
            this.lblCurrentClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentClient.Location = new System.Drawing.Point(583, 1);
            this.lblCurrentClient.Name = "lblCurrentClient";
            this.lblCurrentClient.Size = new System.Drawing.Size(94, 17);
            this.lblCurrentClient.TabIndex = 5;
            this.lblCurrentClient.Text = "Current Client";
            this.lblCurrentClient.Click += new System.EventHandler(this.lblCurrentClient_Click);
            // 
            // btnConnectChat
            // 
            this.btnConnectChat.Location = new System.Drawing.Point(878, 638);
            this.btnConnectChat.Name = "btnConnectChat";
            this.btnConnectChat.Size = new System.Drawing.Size(75, 23);
            this.btnConnectChat.TabIndex = 6;
            this.btnConnectChat.Text = "Connect";
            this.btnConnectChat.UseVisualStyleBackColor = true;
            this.btnConnectChat.Click += new System.EventHandler(this.btnConnectChat_Click);
            // 
            // lblChatConnection
            // 
            this.lblChatConnection.AutoSize = true;
            this.lblChatConnection.Location = new System.Drawing.Point(959, 643);
            this.lblChatConnection.Name = "lblChatConnection";
            this.lblChatConnection.Size = new System.Drawing.Size(0, 13);
            this.lblChatConnection.TabIndex = 7;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(797, 638);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 8;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 666);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lblChatConnection);
            this.Controls.Add(this.btnConnectChat);
            this.Controls.Add(this.lblCurrentClient);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pnlControlPanel);
            this.Controls.Add(this.OpenItems);
            this.Controls.Add(this.MenuBar);
            this.MainMenuStrip = this.MenuBar;
            this.Name = "frmMain";
            this.Text = "Support Center";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            this.OpenItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdOpenItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuBar;
        private System.Windows.Forms.ToolStripMenuItem mtsView;
        private System.Windows.Forms.ToolStripMenuItem maintenanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hotKeysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientViewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemViewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bugViewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timesheetViewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientMaintenanceMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemMaintenanceMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bugMaintenanceMenuItem;
        private System.Windows.Forms.GroupBox OpenItems;
        private System.Windows.Forms.DataGridView grdOpenItems;
        private System.Windows.Forms.Panel pnlControlPanel;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activitySummaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billingSheetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devDocViewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllOpenMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showCurrentMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllClientIssuesMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblCurrentClient;
        private System.Windows.Forms.Button btnConnectChat;
        private System.Windows.Forms.Label lblChatConnection;
        private System.Windows.Forms.Button btnSend;
    }
}

