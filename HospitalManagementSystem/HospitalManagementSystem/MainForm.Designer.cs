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
            this.button_inventory = new System.Windows.Forms.Button();
            this.button_chat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label_title.Location = new System.Drawing.Point(29, 11);
            this.label_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(401, 31);
            this.label_title.TabIndex = 6;
            this.label_title.Text = "Hospital Management System";
            // 
            // label_loggedInUser
            // 
            this.label_loggedInUser.AutoSize = true;
            this.label_loggedInUser.Location = new System.Drawing.Point(32, 43);
            this.label_loggedInUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_loggedInUser.Name = "label_loggedInUser";
            this.label_loggedInUser.Size = new System.Drawing.Size(87, 16);
            this.label_loggedInUser.TabIndex = 7;
            this.label_loggedInUser.Text = "Not logged in";
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(60, 91);
            this.button_login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(160, 28);
            this.button_login.TabIndex = 0;
            this.button_login.Text = "Login";
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // button_register
            // 
            this.button_register.Location = new System.Drawing.Point(281, 91);
            this.button_register.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(160, 28);
            this.button_register.TabIndex = 1;
            this.button_register.Text = "Register";
            this.button_register.Click += new System.EventHandler(this.button_register_Click);
            // 
            // button_patientManagement
            // 
            this.button_patientManagement.Location = new System.Drawing.Point(60, 140);
            this.button_patientManagement.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_patientManagement.Name = "button_patientManagement";
            this.button_patientManagement.Size = new System.Drawing.Size(160, 28);
            this.button_patientManagement.TabIndex = 2;
            this.button_patientManagement.Text = "Patient Management";
            this.button_patientManagement.Click += new System.EventHandler(this.button_patientManagement_Click);
            // 
            // button_analytics
            // 
            this.button_analytics.Location = new System.Drawing.Point(281, 140);
            this.button_analytics.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_analytics.Name = "button_analytics";
            this.button_analytics.Size = new System.Drawing.Size(160, 28);
            this.button_analytics.TabIndex = 3;
            this.button_analytics.Text = "Analytics";
            this.button_analytics.Click += new System.EventHandler(this.button_analytics_Click);
            // 
            // button_appointments
            // 
            this.button_appointments.Location = new System.Drawing.Point(60, 190);
            this.button_appointments.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_appointments.Name = "button_appointments";
            this.button_appointments.Size = new System.Drawing.Size(160, 28);
            this.button_appointments.TabIndex = 4;
            this.button_appointments.Text = "Appointments";
            this.button_appointments.Click += new System.EventHandler(this.button_appointments_Click);
            // 
            // button_dashboard
            // 
            this.button_dashboard.Location = new System.Drawing.Point(281, 190);
            this.button_dashboard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_dashboard.Name = "button_dashboard";
            this.button_dashboard.Size = new System.Drawing.Size(160, 28);
            this.button_dashboard.TabIndex = 5;
            this.button_dashboard.Text = "Dashboard";
            this.button_dashboard.Click += new System.EventHandler(this.button_dashboard_Click);
            // 
            // button_inventory
            // 
            this.button_inventory.Location = new System.Drawing.Point(60, 234);
            this.button_inventory.Name = "button_inventory";
            this.button_inventory.Size = new System.Drawing.Size(160, 23);
            this.button_inventory.TabIndex = 8;
            this.button_inventory.Text = "Inventory";
            this.button_inventory.UseVisualStyleBackColor = true;
            this.button_inventory.Click += new System.EventHandler(this.button_inventory_Click);
            // 
            // button_chat
            // 
            this.button_chat.Location = new System.Drawing.Point(281, 234);
            this.button_chat.Name = "button_chat";
            this.button_chat.Size = new System.Drawing.Size(160, 23);
            this.button_chat.TabIndex = 9;
            this.button_chat.Text = "Chat";
            this.button_chat.UseVisualStyleBackColor = true;
            this.button_chat.Click += new System.EventHandler(this.button_chat_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 292);
            this.Controls.Add(this.button_chat);
            this.Controls.Add(this.button_inventory);
            this.Controls.Add(this.button_dashboard);
            this.Controls.Add(this.button_appointments);
            this.Controls.Add(this.button_analytics);
            this.Controls.Add(this.button_patientManagement);
            this.Controls.Add(this.button_register);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.label_loggedInUser);
            this.Controls.Add(this.label_title);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button button_inventory;
        private System.Windows.Forms.Button button_chat;
    }
}