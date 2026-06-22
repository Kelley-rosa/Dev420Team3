namespace HospitalManagementSystem
{
    partial class ChatForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private System.Windows.Forms.ListBox lstMessages;
        private System.Windows.Forms.TextBox txtSenderName;
        private System.Windows.Forms.Label lblSenderName;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblConnectionStatus;

        private void InitializeComponent()
        {
            this.lstMessages = new System.Windows.Forms.ListBox();
            this.txtSenderName = new System.Windows.Forms.TextBox();
            this.lblSenderName = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblConnectionStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // lblSenderName
            this.lblSenderName.AutoSize = true;
            this.lblSenderName.Location = new System.Drawing.Point(12, 15);
            this.lblSenderName.Name = "lblSenderName";
            this.lblSenderName.Size = new System.Drawing.Size(75, 13);
            this.lblSenderName.Text = "Your Name:";

            // txtSenderName
            this.txtSenderName.Location = new System.Drawing.Point(95, 12);
            this.txtSenderName.Name = "txtSenderName";
            this.txtSenderName.Size = new System.Drawing.Size(180, 20);

            // lblConnectionStatus
            this.lblConnectionStatus.AutoSize = true;
            this.lblConnectionStatus.ForeColor = System.Drawing.Color.Red;
            this.lblConnectionStatus.Location = new System.Drawing.Point(290, 15);
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            this.lblConnectionStatus.Size = new System.Drawing.Size(130, 13);
            this.lblConnectionStatus.Text = "SignalR: Disconnected";

            // lstMessages
            this.lstMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstMessages.FormattingEnabled = true;
            this.lstMessages.IntegralHeight = false;
            this.lstMessages.Location = new System.Drawing.Point(12, 45);
            this.lstMessages.Name = "lstMessages";
            this.lstMessages.Size = new System.Drawing.Size(460, 280);

            // txtMessage
            this.txtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessage.Location = new System.Drawing.Point(12, 335);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(360, 20);
            this.txtMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMessage_KeyDown);

            // btnSend
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Location = new System.Drawing.Point(378, 333);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(94, 25);
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);

            // ChatForm
            this.ClientSize = new System.Drawing.Size(484, 370);
            this.Controls.Add(this.lblSenderName);
            this.Controls.Add(this.txtSenderName);
            this.Controls.Add(this.lblConnectionStatus);
            this.Controls.Add(this.lstMessages);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnSend);
            this.Name = "ChatForm";
            this.Text = "Staff / Patient Chat";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
