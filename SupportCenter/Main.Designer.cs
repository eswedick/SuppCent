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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.mtsView = new System.Windows.Forms.ToolStripMenuItem();
            this.mtsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.itemToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bugToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.timesheetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hotKeysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsBottomStrip = new System.Windows.Forms.ToolStrip();
            this.tsddNewMessage = new System.Windows.Forms.ToolStripDropDownButton();
            this.OpenItems = new System.Windows.Forms.GroupBox();
            this.grdOpenItems = new System.Windows.Forms.DataGridView();
            this.pnlControlPanel = new System.Windows.Forms.Panel();
            this.Menu.SuspendLayout();
            this.tsBottomStrip.SuspendLayout();
            this.OpenItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOpenItems)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mtsView,
            this.maintenanceToolStripMenuItem,
            this.preferenceToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(994, 24);
            this.Menu.TabIndex = 0;
            // 
            // mtsView
            // 
            this.mtsView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mtsMenu,
            this.itemToolStripMenuItem1,
            this.bugToolStripMenuItem1,
            this.timesheetToolStripMenuItem});
            this.mtsView.Name = "mtsView";
            this.mtsView.Size = new System.Drawing.Size(44, 20);
            this.mtsView.Text = "View";
            // 
            // mtsMenu
            // 
            this.mtsMenu.Name = "mtsMenu";
            this.mtsMenu.Size = new System.Drawing.Size(129, 22);
            this.mtsMenu.Text = "Client";
            this.mtsMenu.Click += new System.EventHandler(this.clientToolStripMenuItem1_Click);
            // 
            // itemToolStripMenuItem1
            // 
            this.itemToolStripMenuItem1.Name = "itemToolStripMenuItem1";
            this.itemToolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.itemToolStripMenuItem1.Text = "Item";
            this.itemToolStripMenuItem1.Click += new System.EventHandler(this.itemToolStripMenuItem1_Click);
            // 
            // bugToolStripMenuItem1
            // 
            this.bugToolStripMenuItem1.Name = "bugToolStripMenuItem1";
            this.bugToolStripMenuItem1.Size = new System.Drawing.Size(129, 22);
            this.bugToolStripMenuItem1.Text = "Bug";
            this.bugToolStripMenuItem1.Click += new System.EventHandler(this.bugToolStripMenuItem1_Click);
            // 
            // timesheetToolStripMenuItem
            // 
            this.timesheetToolStripMenuItem.Name = "timesheetToolStripMenuItem";
            this.timesheetToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.timesheetToolStripMenuItem.Text = "Timesheet";
            this.timesheetToolStripMenuItem.Click += new System.EventHandler(this.timesheetToolStripMenuItem_Click);
            // 
            // maintenanceToolStripMenuItem
            // 
            this.maintenanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientToolStripMenuItem,
            this.itemToolStripMenuItem,
            this.bugToolStripMenuItem});
            this.maintenanceToolStripMenuItem.Name = "maintenanceToolStripMenuItem";
            this.maintenanceToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.maintenanceToolStripMenuItem.Text = "Maintenance";
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.clientToolStripMenuItem.Text = "Client";
            // 
            // itemToolStripMenuItem
            // 
            this.itemToolStripMenuItem.Name = "itemToolStripMenuItem";
            this.itemToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.itemToolStripMenuItem.Text = "Item";
            // 
            // bugToolStripMenuItem
            // 
            this.bugToolStripMenuItem.Name = "bugToolStripMenuItem";
            this.bugToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.bugToolStripMenuItem.Text = "Bug";
            // 
            // preferenceToolStripMenuItem
            // 
            this.preferenceToolStripMenuItem.Name = "preferenceToolStripMenuItem";
            this.preferenceToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.preferenceToolStripMenuItem.Text = "Preferences";
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
            // tsBottomStrip
            // 
            this.tsBottomStrip.AllowItemReorder = true;
            this.tsBottomStrip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tsBottomStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.tsBottomStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsddNewMessage});
            this.tsBottomStrip.Location = new System.Drawing.Point(849, 597);
            this.tsBottomStrip.Name = "tsBottomStrip";
            this.tsBottomStrip.Size = new System.Drawing.Size(136, 25);
            this.tsBottomStrip.TabIndex = 1;
            this.tsBottomStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.BottomStrip_ItemClicked);
            this.tsBottomStrip.Click += new System.EventHandler(this.BottomStrip_Click);
            // 
            // tsddNewMessage
            // 
            this.tsddNewMessage.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsddNewMessage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsddNewMessage.Image = ((System.Drawing.Image)(resources.GetObject("tsddNewMessage.Image")));
            this.tsddNewMessage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddNewMessage.Name = "tsddNewMessage";
            this.tsddNewMessage.Size = new System.Drawing.Size(93, 22);
            this.tsddNewMessage.Text = "New Message";
            this.tsddNewMessage.Click += new System.EventHandler(this.tsddNewMessage_Click);
            // 
            // OpenItems
            // 
            this.OpenItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.OpenItems.Controls.Add(this.grdOpenItems);
            this.OpenItems.Location = new System.Drawing.Point(0, 23);
            this.OpenItems.Name = "OpenItems";
            this.OpenItems.Size = new System.Drawing.Size(283, 577);
            this.OpenItems.TabIndex = 2;
            this.OpenItems.TabStop = false;
            this.OpenItems.Text = "Open Items";
            // 
            // grdOpenItems
            // 
            this.grdOpenItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grdOpenItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOpenItems.Location = new System.Drawing.Point(6, 19);
            this.grdOpenItems.Name = "grdOpenItems";
            this.grdOpenItems.Size = new System.Drawing.Size(270, 552);
            this.grdOpenItems.TabIndex = 0;
            // 
            // pnlControlPanel
            // 
            this.pnlControlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlControlPanel.Location = new System.Drawing.Point(282, 27);
            this.pnlControlPanel.Name = "pnlControlPanel";
            this.pnlControlPanel.Size = new System.Drawing.Size(712, 567);
            this.pnlControlPanel.TabIndex = 3;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 628);
            this.Controls.Add(this.pnlControlPanel);
            this.Controls.Add(this.OpenItems);
            this.Controls.Add(this.tsBottomStrip);
            this.Controls.Add(this.Menu);
            this.MainMenuStrip = this.Menu;
            this.Name = "frmMain";
            this.Text = "Support Center";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.tsBottomStrip.ResumeLayout(false);
            this.tsBottomStrip.PerformLayout();
            this.OpenItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdOpenItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem mtsView;
        private System.Windows.Forms.ToolStripMenuItem maintenanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hotKeysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStrip tsBottomStrip;
        private System.Windows.Forms.ToolStripMenuItem mtsMenu;
        private System.Windows.Forms.ToolStripMenuItem itemToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bugToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem timesheetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bugToolStripMenuItem;
        private System.Windows.Forms.GroupBox OpenItems;
        private System.Windows.Forms.DataGridView grdOpenItems;
        private System.Windows.Forms.Panel pnlControlPanel;
        private System.Windows.Forms.ToolStripDropDownButton tsddNewMessage;
    }
}

