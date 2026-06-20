namespace HospitalManagementSystem
{
    partial class AnalyticsForm
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
            this.button_patientVisits = new System.Windows.Forms.Button();
            this.button_commonAilments = new System.Windows.Forms.Button();
            this.button_appointmentStatus = new System.Windows.Forms.Button();
            this.button_doctorWorkload = new System.Windows.Forms.Button();
            this.dataGridView_results = new System.Windows.Forms.DataGridView();
            this.label_reportTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_results)).BeginInit();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label_title.Location = new System.Drawing.Point(103, 9);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(140, 24);
            this.label_title.TabIndex = 5;
            this.label_title.Text = "Data Analytics";
            // 
            // button_patientVisits
            // 
            this.button_patientVisits.Location = new System.Drawing.Point(12, 58);
            this.button_patientVisits.Name = "button_patientVisits";
            this.button_patientVisits.Size = new System.Drawing.Size(154, 23);
            this.button_patientVisits.TabIndex = 0;
            this.button_patientVisits.Text = "Patient Visits by Month";
            this.button_patientVisits.Click += new System.EventHandler(this.button_patientVisits_Click);
            // 
            // button_commonAilments
            // 
            this.button_commonAilments.Location = new System.Drawing.Point(12, 96);
            this.button_commonAilments.Name = "button_commonAilments";
            this.button_commonAilments.Size = new System.Drawing.Size(154, 23);
            this.button_commonAilments.TabIndex = 2;
            this.button_commonAilments.Text = "Common Ailments";
            this.button_commonAilments.Click += new System.EventHandler(this.button_commonAilments_Click);
            // 
            // button_appointmentStatus
            // 
            this.button_appointmentStatus.Location = new System.Drawing.Point(186, 58);
            this.button_appointmentStatus.Name = "button_appointmentStatus";
            this.button_appointmentStatus.Size = new System.Drawing.Size(154, 23);
            this.button_appointmentStatus.TabIndex = 1;
            this.button_appointmentStatus.Text = "Appointment Status";
            this.button_appointmentStatus.Click += new System.EventHandler(this.button_appointmentStatus_Click);
            // 
            // button_doctorWorkload
            // 
            this.button_doctorWorkload.Location = new System.Drawing.Point(186, 96);
            this.button_doctorWorkload.Name = "button_doctorWorkload";
            this.button_doctorWorkload.Size = new System.Drawing.Size(154, 23);
            this.button_doctorWorkload.TabIndex = 3;
            this.button_doctorWorkload.Text = "Doctor Workload";
            this.button_doctorWorkload.Click += new System.EventHandler(this.button_doctorWorkload_Click);
            // 
            // dataGridView_results
            // 
            this.dataGridView_results.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_results.Location = new System.Drawing.Point(12, 143);
            this.dataGridView_results.MultiSelect = false;
            this.dataGridView_results.Name = "dataGridView_results";
            this.dataGridView_results.ReadOnly = true;
            this.dataGridView_results.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_results.Size = new System.Drawing.Size(328, 150);
            this.dataGridView_results.TabIndex = 4;
            // 
            // label_reportTitle
            // 
            this.label_reportTitle.AutoSize = true;
            this.label_reportTitle.Location = new System.Drawing.Point(120, 33);
            this.label_reportTitle.Name = "label_reportTitle";
            this.label_reportTitle.Size = new System.Drawing.Size(107, 13);
            this.label_reportTitle.TabIndex = 6;
            this.label_reportTitle.Text = "Select a report below";
            // 
            // AnalyticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 309);
            this.Controls.Add(this.dataGridView_results);
            this.Controls.Add(this.button_doctorWorkload);
            this.Controls.Add(this.button_appointmentStatus);
            this.Controls.Add(this.button_commonAilments);
            this.Controls.Add(this.button_patientVisits);
            this.Controls.Add(this.label_reportTitle);
            this.Controls.Add(this.label_title);
            this.Name = "AnalyticsForm";
            this.Text = "Analytics";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_results)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Button button_patientVisits;
        private System.Windows.Forms.Button button_commonAilments;
        private System.Windows.Forms.Button button_appointmentStatus;
        private System.Windows.Forms.Button button_doctorWorkload;
        private System.Windows.Forms.DataGridView dataGridView_results;
        private System.Windows.Forms.Label label_reportTitle;
    }
}