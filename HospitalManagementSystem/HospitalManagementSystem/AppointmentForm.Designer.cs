namespace HospitalManagementSystem
{
    partial class AppointmentForm
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

        private System.Windows.Forms.DataGridView dgvAppointments;
        private System.Windows.Forms.Label lblPatientID;
        private System.Windows.Forms.TextBox txtPatientID;
        private System.Windows.Forms.Label lblDoctorName;
        private System.Windows.Forms.TextBox txtDoctorName;
        private System.Windows.Forms.Label lblAppointmentDate;
        private System.Windows.Forms.DateTimePicker dtpAppointmentDate;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblConnectionStatus;

        private void InitializeComponent()
        {
            this.dgvAppointments = new System.Windows.Forms.DataGridView();
            this.lblPatientID = new System.Windows.Forms.Label();
            this.txtPatientID = new System.Windows.Forms.TextBox();
            this.lblDoctorName = new System.Windows.Forms.Label();
            this.txtDoctorName = new System.Windows.Forms.TextBox();
            this.lblAppointmentDate = new System.Windows.Forms.Label();
            this.dtpAppointmentDate = new System.Windows.Forms.DateTimePicker();
            this.lblReason = new System.Windows.Forms.Label();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblConnectionStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
            this.SuspendLayout();

            // lblPatientID
            this.lblPatientID.AutoSize = true;
            this.lblPatientID.Location = new System.Drawing.Point(12, 15);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(60, 13);
            this.lblPatientID.Text = "Patient ID:";

            // txtPatientID
            this.txtPatientID.Location = new System.Drawing.Point(90, 12);
            this.txtPatientID.Name = "txtPatientID";
            this.txtPatientID.Size = new System.Drawing.Size(80, 20);

            // lblDoctorName
            this.lblDoctorName.AutoSize = true;
            this.lblDoctorName.Location = new System.Drawing.Point(190, 15);
            this.lblDoctorName.Name = "lblDoctorName";
            this.lblDoctorName.Size = new System.Drawing.Size(75, 13);
            this.lblDoctorName.Text = "Doctor Name:";

            // txtDoctorName
            this.txtDoctorName.Location = new System.Drawing.Point(280, 12);
            this.txtDoctorName.Name = "txtDoctorName";
            this.txtDoctorName.Size = new System.Drawing.Size(150, 20);

            // lblAppointmentDate
            this.lblAppointmentDate.AutoSize = true;
            this.lblAppointmentDate.Location = new System.Drawing.Point(12, 48);
            this.lblAppointmentDate.Name = "lblAppointmentDate";
            this.lblAppointmentDate.Size = new System.Drawing.Size(75, 13);
            this.lblAppointmentDate.Text = "Date / Time:";

            // dtpAppointmentDate
            this.dtpAppointmentDate.CustomFormat = "MM/dd/yyyy HH:mm";
            this.dtpAppointmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAppointmentDate.Location = new System.Drawing.Point(90, 45);
            this.dtpAppointmentDate.Name = "dtpAppointmentDate";
            this.dtpAppointmentDate.Size = new System.Drawing.Size(150, 20);

            // lblReason
            this.lblReason.AutoSize = true;
            this.lblReason.Location = new System.Drawing.Point(260, 48);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(45, 13);
            this.lblReason.Text = "Reason:";

            // txtReason
            this.txtReason.Location = new System.Drawing.Point(310, 45);
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(220, 20);

            // btnAdd
            this.btnAdd.Location = new System.Drawing.Point(12, 80);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 30);
            this.btnAdd.Text = "Add Appointment";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // btnCancel
            this.btnCancel.Location = new System.Drawing.Point(140, 80);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 30);
            this.btnCancel.Text = "Cancel Selected";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // btnRefresh
            this.btnRefresh.Location = new System.Drawing.Point(268, 80);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 30);
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            // lblConnectionStatus
            this.lblConnectionStatus.AutoSize = true;
            this.lblConnectionStatus.ForeColor = System.Drawing.Color.Red;
            this.lblConnectionStatus.Location = new System.Drawing.Point(400, 88);
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            this.lblConnectionStatus.Size = new System.Drawing.Size(130, 13);
            this.lblConnectionStatus.Text = "SignalR: Disconnected";

            // dgvAppointments
            this.dgvAppointments.AllowUserToAddRows = false;
            this.dgvAppointments.AllowUserToDeleteRows = false;
            this.dgvAppointments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAppointments.Location = new System.Drawing.Point(12, 120);
            this.dgvAppointments.MultiSelect = false;
            this.dgvAppointments.Name = "dgvAppointments";
            this.dgvAppointments.ReadOnly = true;
            this.dgvAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAppointments.Size = new System.Drawing.Size(580, 320);

            // AppointmentForm
            this.ClientSize = new System.Drawing.Size(610, 460);
            this.Controls.Add(this.lblPatientID);
            this.Controls.Add(this.txtPatientID);
            this.Controls.Add(this.lblDoctorName);
            this.Controls.Add(this.txtDoctorName);
            this.Controls.Add(this.lblAppointmentDate);
            this.Controls.Add(this.dtpAppointmentDate);
            this.Controls.Add(this.lblReason);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblConnectionStatus);
            this.Controls.Add(this.dgvAppointments);
            this.Name = "AppointmentForm";
            this.Text = "Appointment Scheduling";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
