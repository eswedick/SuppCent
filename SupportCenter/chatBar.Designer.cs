namespace SupportCenter
{
    partial class chatBar
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnConnectChat = new System.Windows.Forms.Button();
            this.chatStrip = new System.Windows.Forms.ToolStrip();
            this.txtChatLog = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(586, 638);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(205, 20);
            this.txtInput.TabIndex = 9;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(797, 638);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 8;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // btnConnectChat
            // 
            this.btnConnectChat.Location = new System.Drawing.Point(878, 638);
            this.btnConnectChat.Name = "btnConnectChat";
            this.btnConnectChat.Size = new System.Drawing.Size(75, 23);
            this.btnConnectChat.TabIndex = 6;
            this.btnConnectChat.Text = "Connect";
            this.btnConnectChat.UseVisualStyleBackColor = true;
            // 
            // chatStrip
            // 
            this.chatStrip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chatStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.chatStrip.Location = new System.Drawing.Point(0, 0);
            this.chatStrip.Name = "chatStrip";
            this.chatStrip.Size = new System.Drawing.Size(100, 25);
            this.chatStrip.TabIndex = 0;
            // 
            // txtChatLog
            // 
            this.txtChatLog.Location = new System.Drawing.Point(0, 0);
            this.txtChatLog.Name = "txtChatLog";
            this.txtChatLog.Size = new System.Drawing.Size(100, 96);
            this.txtChatLog.TabIndex = 0;
            this.txtChatLog.Text = "";
            // 
            // chatBar
            // 
            this.Name = "chatBar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnConnectChat;
        private System.Windows.Forms.ToolStrip chatStrip;
        private System.Windows.Forms.RichTextBox txtChatLog;

    }
}
