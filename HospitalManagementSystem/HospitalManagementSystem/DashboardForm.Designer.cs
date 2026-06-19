namespace HospitalManagementSystem
{
    partial class DashboardForm
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

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblBedsHeader;
        private System.Windows.Forms.Label lblBedsValue;
        private System.Windows.Forms.Button btnAdmit;
        private System.Windows.Forms.Button btnDischarge;
        private System.Windows.Forms.Label lblEmergencyHeader;
        private System.Windows.Forms.Label lblEmergencyValue;
        private System.Windows.Forms.Button btnToggleEmergency;
        private System.Windows.Forms.Label lblConnectionStatus;

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblBedsHeader = new System.Windows.Forms.Label();
            this.lblBedsValue = new System.Windows.Forms.Label();
            this.btnAdmit = new System.Windows.Forms.Button();
            this.btnDischarge = new System.Windows.Forms.Button();
            this.lblEmergencyHeader = new System.Windows.Forms.Label();
            this.lblEmergencyValue = new System.Windows.Forms.Label();
            this.btnToggleEmergency = new System.Windows.Forms.Button();
            this.lblConnectionStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(250, 30);
            this.lblTitle.Text = "Hospital Dashboard";

            // lblBedsHeader
            this.lblBedsHeader.AutoSize = true;
            this.lblBedsHeader.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblBedsHeader.Location = new System.Drawing.Point(20, 80);
            this.lblBedsHeader.Name = "lblBedsHeader";
            this.lblBedsHeader.Size = new System.Drawing.Size(120, 20);
            this.lblBedsHeader.Text = "Bed Availability";

            // lblBedsValue
            this.lblBedsValue.AutoSize = true;
            this.lblBedsValue.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblBedsValue.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblBedsValue.Location = new System.Drawing.Point(20, 105);
            this.lblBedsValue.Name = "lblBedsValue";
            this.lblBedsValue.Size = new System.Drawing.Size(150, 25);
            this.lblBedsValue.Text = "20 / 20 available";

            // btnAdmit
            this.btnAdmit.Location = new System.Drawing.Point(20, 140);
            this.btnAdmit.Name = "btnAdmit";
            this.btnAdmit.Size = new System.Drawing.Size(140, 30);
            this.btnAdmit.Text = "Admit Patient";
            this.btnAdmit.UseVisualStyleBackColor = true;
            this.btnAdmit.Click += new System.EventHandler(this.btnAdmit_Click);

            // btnDischarge
            this.btnDischarge.Location = new System.Drawing.Point(170, 140);
            this.btnDischarge.Name = "btnDischarge";
            this.btnDischarge.Size = new System.Drawing.Size(140, 30);
            this.btnDischarge.Text = "Discharge Patient";
            this.btnDischarge.UseVisualStyleBackColor = true;
            this.btnDischarge.Click += new System.EventHandler(this.btnDischarge_Click);

            // lblEmergencyHeader
            this.lblEmergencyHeader.AutoSize = true;
            this.lblEmergencyHeader.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblEmergencyHeader.Location = new System.Drawing.Point(20, 200);
            this.lblEmergencyHeader.Name = "lblEmergencyHeader";
            this.lblEmergencyHeader.Size = new System.Drawing.Size(140, 20);
            this.lblEmergencyHeader.Text = "Emergency Status";

            // lblEmergencyValue
            this.lblEmergencyValue.AutoSize = true;
            this.lblEmergencyValue.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblEmergencyValue.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblEmergencyValue.Location = new System.Drawing.Point(20, 225);
            this.lblEmergencyValue.Name = "lblEmergencyValue";
            this.lblEmergencyValue.Size = new System.Drawing.Size(150, 25);
            this.lblEmergencyValue.Text = "Normal";

            // btnToggleEmergency
            this.btnToggleEmergency.Location = new System.Drawing.Point(20, 260);
            this.btnToggleEmergency.Name = "btnToggleEmergency";
            this.btnToggleEmergency.Size = new System.Drawing.Size(290, 30);
            this.btnToggleEmergency.Text = "Toggle Emergency Status";
            this.btnToggleEmergency.UseVisualStyleBackColor = true;
            this.btnToggleEmergency.Click += new System.EventHandler(this.btnToggleEmergency_Click);

            // lblConnectionStatus
            this.lblConnectionStatus.AutoSize = true;
            this.lblConnectionStatus.ForeColor = System.Drawing.Color.Red;
            this.lblConnectionStatus.Location = new System.Drawing.Point(20, 320);
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            this.lblConnectionStatus.Size = new System.Drawing.Size(150, 13);
            this.lblConnectionStatus.Text = "SignalR: Disconnected";

            // DashboardForm
            this.ClientSize = new System.Drawing.Size(340, 360);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblBedsHeader);
            this.Controls.Add(this.lblBedsValue);
            this.Controls.Add(this.btnAdmit);
            this.Controls.Add(this.btnDischarge);
            this.Controls.Add(this.lblEmergencyHeader);
            this.Controls.Add(this.lblEmergencyValue);
            this.Controls.Add(this.btnToggleEmergency);
            this.Controls.Add(this.lblConnectionStatus);
            this.Name = "DashboardForm";
            this.Text = "Hospital Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
