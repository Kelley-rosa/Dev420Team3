namespace HospitalManagementSystem
{
    partial class MainForm
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

        private void InitializeComponent()
        {
            this.label_title = new System.Windows.Forms.Label();
            this.label_loggedInUser = new System.Windows.Forms.Label();
            this.button_login = new System.Windows.Forms.Button();
            this.button_register = new System.Windows.Forms.Button();
            this.button_patientManagement = new System.Windows.Forms.Button();
            this.button_analytics = new System.Windows.Forms.Button();
            this.button_appointments = new System.Windows.Forms.Button();
            this.button_dashboard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label_title.Location = new System.Drawing.Point(22, 9);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(330, 26);
            this.label_title.TabIndex = 6;
            this.label_title.Text = "Hospital Management System";
            // 
            // label_loggedInUser
            // 
            this.label_loggedInUser.AutoSize = true;
            this.label_loggedInUser.Location = new System.Drawing.Point(24, 35);
            this.label_loggedInUser.Name = "label_loggedInUser";
            this.label_loggedInUser.Size = new System.Drawing.Size(70, 13);
            this.label_loggedInUser.TabIndex = 7;
            this.label_loggedInUser.Text = "Not logged in";
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(45, 74);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(120, 23);
            this.button_login.TabIndex = 0;
            this.button_login.Text = "Login";
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // button_register
            // 
            this.button_register.Location = new System.Drawing.Point(211, 74);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(120, 23);
            this.button_register.TabIndex = 1;
            this.button_register.Text = "Register";
            this.button_register.Click += new System.EventHandler(this.button_register_Click);
            // 
            // button_patientManagement
            // 
            this.button_patientManagement.Location = new System.Drawing.Point(45, 114);
            this.button_patientManagement.Name = "button_patientManagement";
            this.button_patientManagement.Size = new System.Drawing.Size(120, 23);
            this.button_patientManagement.TabIndex = 2;
            this.button_patientManagement.Text = "Patient Management";
            this.button_patientManagement.Click += new System.EventHandler(this.button_patientManagement_Click);
            // 
            // button_analytics
            // 
            this.button_analytics.Location = new System.Drawing.Point(211, 114);
            this.button_analytics.Name = "button_analytics";
            this.button_analytics.Size = new System.Drawing.Size(120, 23);
            this.button_analytics.TabIndex = 3;
            this.button_analytics.Text = "Analytics";
            this.button_analytics.Click += new System.EventHandler(this.button_analytics_Click);
            // 
            // button_appointments
            // 
            this.button_appointments.Location = new System.Drawing.Point(45, 154);
            this.button_appointments.Name = "button_appointments";
            this.button_appointments.Size = new System.Drawing.Size(120, 23);
            this.button_appointments.TabIndex = 4;
            this.button_appointments.Text = "Appointments";
            this.button_appointments.Click += new System.EventHandler(this.button_appointments_Click);
            // 
            // button_dashboard
            // 
            this.button_dashboard.Location = new System.Drawing.Point(211, 154);
            this.button_dashboard.Name = "button_dashboard";
            this.button_dashboard.Size = new System.Drawing.Size(120, 23);
            this.button_dashboard.TabIndex = 5;
            this.button_dashboard.Text = "Dashboard";
            this.button_dashboard.Click += new System.EventHandler(this.button_dashboard_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 202);
            this.Controls.Add(this.button_dashboard);
            this.Controls.Add(this.button_appointments);
            this.Controls.Add(this.button_analytics);
            this.Controls.Add(this.button_patientManagement);
            this.Controls.Add(this.button_register);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.label_loggedInUser);
            this.Controls.Add(this.label_title);
            this.Name = "MainForm";
            this.Text = "Hospital Management System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_loggedInUser;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Button button_register;
        private System.Windows.Forms.Button button_patientManagement;
        private System.Windows.Forms.Button button_analytics;
        private System.Windows.Forms.Button button_appointments;
        private System.Windows.Forms.Button button_dashboard;
    }
}