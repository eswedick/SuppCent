namespace SupportCenter
{
    partial class ctlClient
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtClientCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.cboTC = new System.Windows.Forms.ComboBox();
            this.cboCRM = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlConnection = new System.Windows.Forms.Panel();
            this.cboPrimaryUser = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnWebConnection = new System.Windows.Forms.Button();
            this.btnRemoteDesktop = new System.Windows.Forms.Button();
            this.grdUsers = new System.Windows.Forms.DataGridView();
            this.pnlConnectionInfo = new System.Windows.Forms.Panel();
            this.rbtnOtherInfo = new System.Windows.Forms.RadioButton();
            this.rbtnSettings = new System.Windows.Forms.RadioButton();
            this.rtxtInfo = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnViewItems = new System.Windows.Forms.Button();
            this.cboClient = new System.Windows.Forms.ComboBox();
            this.InfoPanel.SuspendLayout();
            this.pnlConnection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsers)).BeginInit();
            this.pnlConnectionInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtClientCode
            // 
            this.txtClientCode.Location = new System.Drawing.Point(38, 0);
            this.txtClientCode.Name = "txtClientCode";
            this.txtClientCode.Size = new System.Drawing.Size(70, 20);
            this.txtClientCode.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Client";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(536, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "CRM";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(546, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "TC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Current Version";
            // 
            // txtVersion
            // 
            this.txtVersion.Location = new System.Drawing.Point(88, 26);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(62, 20);
            this.txtVersion.TabIndex = 9;
            // 
            // InfoPanel
            // 
            this.InfoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoPanel.Controls.Add(this.cboClient);
            this.InfoPanel.Controls.Add(this.cboTC);
            this.InfoPanel.Controls.Add(this.cboCRM);
            this.InfoPanel.Controls.Add(this.panel1);
            this.InfoPanel.Controls.Add(this.label1);
            this.InfoPanel.Controls.Add(this.label5);
            this.InfoPanel.Controls.Add(this.txtVersion);
            this.InfoPanel.Controls.Add(this.txtClientCode);
            this.InfoPanel.Controls.Add(this.label3);
            this.InfoPanel.Controls.Add(this.label4);
            this.InfoPanel.Controls.Add(this.label2);
            this.InfoPanel.Location = new System.Drawing.Point(3, 3);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(706, 52);
            this.InfoPanel.TabIndex = 10;
            // 
            // cboTC
            // 
            this.cboTC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTC.FormattingEnabled = true;
            this.cboTC.Location = new System.Drawing.Point(573, 25);
            this.cboTC.Name = "cboTC";
            this.cboTC.Size = new System.Drawing.Size(130, 21);
            this.cboTC.TabIndex = 13;
            // 
            // cboCRM
            // 
            this.cboCRM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCRM.FormattingEnabled = true;
            this.cboCRM.Location = new System.Drawing.Point(573, 0);
            this.cboCRM.Name = "cboCRM";
            this.cboCRM.Size = new System.Drawing.Size(130, 21);
            this.cboCRM.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 84);
            this.panel1.TabIndex = 11;
            // 
            // pnlConnection
            // 
            this.pnlConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlConnection.Controls.Add(this.btnViewItems);
            this.pnlConnection.Controls.Add(this.btnSave);
            this.pnlConnection.Controls.Add(this.rbtnSettings);
            this.pnlConnection.Controls.Add(this.rbtnOtherInfo);
            this.pnlConnection.Controls.Add(this.pnlConnectionInfo);
            this.pnlConnection.Controls.Add(this.cboPrimaryUser);
            this.pnlConnection.Controls.Add(this.label6);
            this.pnlConnection.Controls.Add(this.btnWebConnection);
            this.pnlConnection.Controls.Add(this.btnRemoteDesktop);
            this.pnlConnection.Location = new System.Drawing.Point(3, 55);
            this.pnlConnection.Name = "pnlConnection";
            this.pnlConnection.Size = new System.Drawing.Size(706, 188);
            this.pnlConnection.TabIndex = 11;
            // 
            // cboPrimaryUser
            // 
            this.cboPrimaryUser.FormattingEnabled = true;
            this.cboPrimaryUser.Location = new System.Drawing.Point(7, 155);
            this.cboPrimaryUser.Name = "cboPrimaryUser";
            this.cboPrimaryUser.Size = new System.Drawing.Size(143, 21);
            this.cboPrimaryUser.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Primary User";
            // 
            // btnWebConnection
            // 
            this.btnWebConnection.Location = new System.Drawing.Point(6, 90);
            this.btnWebConnection.Name = "btnWebConnection";
            this.btnWebConnection.Size = new System.Drawing.Size(119, 23);
            this.btnWebConnection.TabIndex = 2;
            this.btnWebConnection.Text = "Web Connection";
            this.btnWebConnection.UseVisualStyleBackColor = true;
            // 
            // btnRemoteDesktop
            // 
            this.btnRemoteDesktop.Location = new System.Drawing.Point(7, 58);
            this.btnRemoteDesktop.Name = "btnRemoteDesktop";
            this.btnRemoteDesktop.Size = new System.Drawing.Size(119, 23);
            this.btnRemoteDesktop.TabIndex = 1;
            this.btnRemoteDesktop.Text = "Remote Desktop";
            this.btnRemoteDesktop.UseVisualStyleBackColor = true;
            // 
            // grdUsers
            // 
            this.grdUsers.AllowUserToOrderColumns = true;
            this.grdUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUsers.Location = new System.Drawing.Point(3, 249);
            this.grdUsers.Name = "grdUsers";
            this.grdUsers.Size = new System.Drawing.Size(706, 321);
            this.grdUsers.TabIndex = 12;
            // 
            // pnlConnectionInfo
            // 
            this.pnlConnectionInfo.Controls.Add(this.rtxtInfo);
            this.pnlConnectionInfo.Location = new System.Drawing.Point(176, 26);
            this.pnlConnectionInfo.Name = "pnlConnectionInfo";
            this.pnlConnectionInfo.Size = new System.Drawing.Size(527, 159);
            this.pnlConnectionInfo.TabIndex = 11;
            // 
            // rbtnOtherInfo
            // 
            this.rbtnOtherInfo.AutoSize = true;
            this.rbtnOtherInfo.Checked = true;
            this.rbtnOtherInfo.Location = new System.Drawing.Point(188, 6);
            this.rbtnOtherInfo.Name = "rbtnOtherInfo";
            this.rbtnOtherInfo.Size = new System.Drawing.Size(72, 17);
            this.rbtnOtherInfo.TabIndex = 12;
            this.rbtnOtherInfo.TabStop = true;
            this.rbtnOtherInfo.Text = "Other Info";
            this.rbtnOtherInfo.UseVisualStyleBackColor = true;
            this.rbtnOtherInfo.CheckedChanged += new System.EventHandler(this.rbtnOtherInfo_CheckedChanged);
            // 
            // rbtnSettings
            // 
            this.rbtnSettings.AutoSize = true;
            this.rbtnSettings.Location = new System.Drawing.Point(266, 6);
            this.rbtnSettings.Name = "rbtnSettings";
            this.rbtnSettings.Size = new System.Drawing.Size(63, 17);
            this.rbtnSettings.TabIndex = 13;
            this.rbtnSettings.Text = "Settings";
            this.rbtnSettings.UseVisualStyleBackColor = true;
            this.rbtnSettings.CheckedChanged += new System.EventHandler(this.rbtnSettings_CheckedChanged);
            // 
            // rtxtInfo
            // 
            this.rtxtInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtInfo.Location = new System.Drawing.Point(3, 3);
            this.rtxtInfo.Name = "rtxtInfo";
            this.rtxtInfo.Size = new System.Drawing.Size(521, 153);
            this.rtxtInfo.TabIndex = 0;
            this.rtxtInfo.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(573, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(127, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnViewItems
            // 
            this.btnViewItems.Location = new System.Drawing.Point(7, 26);
            this.btnViewItems.Name = "btnViewItems";
            this.btnViewItems.Size = new System.Drawing.Size(119, 23);
            this.btnViewItems.TabIndex = 15;
            this.btnViewItems.Text = "View Items/Bugs";
            this.btnViewItems.UseVisualStyleBackColor = true;
            this.btnViewItems.Click += new System.EventHandler(this.btnViewItems_Click);
            // 
            // cboClient
            // 
            this.cboClient.FormattingEnabled = true;
            this.cboClient.Location = new System.Drawing.Point(153, 0);
            this.cboClient.Name = "cboClient";
            this.cboClient.Size = new System.Drawing.Size(176, 21);
            this.cboClient.TabIndex = 14;
            // 
            // ctlClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grdUsers);
            this.Controls.Add(this.pnlConnection);
            this.Controls.Add(this.InfoPanel);
            this.Name = "ctlClient";
            this.Size = new System.Drawing.Size(712, 573);
            this.Load += new System.EventHandler(this.ctlClient_Load);
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            this.pnlConnection.ResumeLayout(false);
            this.pnlConnection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsers)).EndInit();
            this.pnlConnectionInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtClientCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtVersion;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.Panel pnlConnection;
        private System.Windows.Forms.ComboBox cboPrimaryUser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnWebConnection;
        private System.Windows.Forms.Button btnRemoteDesktop;
        private System.Windows.Forms.DataGridView grdUsers;
        private System.Windows.Forms.ComboBox cboTC;
        private System.Windows.Forms.ComboBox cboCRM;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtnSettings;
        private System.Windows.Forms.RadioButton rbtnOtherInfo;
        private System.Windows.Forms.Panel pnlConnectionInfo;
        private System.Windows.Forms.RichTextBox rtxtInfo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnViewItems;
        private System.Windows.Forms.ComboBox cboClient;
    }
}
