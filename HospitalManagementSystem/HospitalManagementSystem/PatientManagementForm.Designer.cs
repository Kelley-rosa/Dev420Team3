namespace HospitalManagementSystem
{
    partial class PatientManagementForm
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
            this.label_firstName = new System.Windows.Forms.Label();
            this.label_lastName = new System.Windows.Forms.Label();
            this.label_dob = new System.Windows.Forms.Label();
            this.label_gender = new System.Windows.Forms.Label();
            this.label_phone = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.label_address = new System.Windows.Forms.Label();
            this.label_bloodType = new System.Windows.Forms.Label();
            this.label_medicalHistory = new System.Windows.Forms.Label();
            this.textBox_firstName = new System.Windows.Forms.TextBox();
            this.textBox_lastName = new System.Windows.Forms.TextBox();
            this.dateTimePicker_dob = new System.Windows.Forms.DateTimePicker();
            this.comboBox_gender = new System.Windows.Forms.ComboBox();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.textBox_bloodType = new System.Windows.Forms.TextBox();
            this.textBox_medicalHistory = new System.Windows.Forms.TextBox();
            this.button_add = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.dataGridView_patients = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_patients)).BeginInit();
            this.SuspendLayout();
            // 
            // label_firstName
            // 
            this.label_firstName.AutoSize = true;
            this.label_firstName.Location = new System.Drawing.Point(12, 15);
            this.label_firstName.Name = "label_firstName";
            this.label_firstName.Size = new System.Drawing.Size(57, 13);
            this.label_firstName.TabIndex = 13;
            this.label_firstName.Text = "First Name";
            // 
            // label_lastName
            // 
            this.label_lastName.AutoSize = true;
            this.label_lastName.Location = new System.Drawing.Point(241, 15);
            this.label_lastName.Name = "label_lastName";
            this.label_lastName.Size = new System.Drawing.Size(58, 13);
            this.label_lastName.TabIndex = 14;
            this.label_lastName.Text = "Last Name";
            // 
            // label_dob
            // 
            this.label_dob.AutoSize = true;
            this.label_dob.Location = new System.Drawing.Point(12, 49);
            this.label_dob.Name = "label_dob";
            this.label_dob.Size = new System.Drawing.Size(66, 13);
            this.label_dob.TabIndex = 15;
            this.label_dob.Text = "Date of Birth";
            // 
            // label_gender
            // 
            this.label_gender.AutoSize = true;
            this.label_gender.Location = new System.Drawing.Point(241, 48);
            this.label_gender.Name = "label_gender";
            this.label_gender.Size = new System.Drawing.Size(42, 13);
            this.label_gender.TabIndex = 16;
            this.label_gender.Text = "Gender";
            // 
            // label_phone
            // 
            this.label_phone.AutoSize = true;
            this.label_phone.Location = new System.Drawing.Point(12, 83);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(38, 13);
            this.label_phone.TabIndex = 17;
            this.label_phone.Text = "Phone";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Location = new System.Drawing.Point(241, 81);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(32, 13);
            this.label_email.TabIndex = 18;
            this.label_email.Text = "Email";
            // 
            // label_address
            // 
            this.label_address.AutoSize = true;
            this.label_address.Location = new System.Drawing.Point(12, 117);
            this.label_address.Name = "label_address";
            this.label_address.Size = new System.Drawing.Size(45, 13);
            this.label_address.TabIndex = 19;
            this.label_address.Text = "Address";
            // 
            // label_bloodType
            // 
            this.label_bloodType.AutoSize = true;
            this.label_bloodType.Location = new System.Drawing.Point(12, 151);
            this.label_bloodType.Name = "label_bloodType";
            this.label_bloodType.Size = new System.Drawing.Size(61, 13);
            this.label_bloodType.TabIndex = 20;
            this.label_bloodType.Text = "Blood Type";
            // 
            // label_medicalHistory
            // 
            this.label_medicalHistory.AutoSize = true;
            this.label_medicalHistory.Location = new System.Drawing.Point(9, 185);
            this.label_medicalHistory.Name = "label_medicalHistory";
            this.label_medicalHistory.Size = new System.Drawing.Size(79, 13);
            this.label_medicalHistory.TabIndex = 21;
            this.label_medicalHistory.Text = "Medical History";
            // 
            // textBox_firstName
            // 
            this.textBox_firstName.Location = new System.Drawing.Point(84, 12);
            this.textBox_firstName.Name = "textBox_firstName";
            this.textBox_firstName.Size = new System.Drawing.Size(120, 20);
            this.textBox_firstName.TabIndex = 0;
            // 
            // textBox_lastName
            // 
            this.textBox_lastName.Location = new System.Drawing.Point(305, 12);
            this.textBox_lastName.Name = "textBox_lastName";
            this.textBox_lastName.Size = new System.Drawing.Size(120, 20);
            this.textBox_lastName.TabIndex = 1;
            // 
            // dateTimePicker_dob
            // 
            this.dateTimePicker_dob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_dob.Location = new System.Drawing.Point(84, 46);
            this.dateTimePicker_dob.Name = "dateTimePicker_dob";
            this.dateTimePicker_dob.Size = new System.Drawing.Size(120, 20);
            this.dateTimePicker_dob.TabIndex = 2;
            // 
            // comboBox_gender
            // 
            this.comboBox_gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.comboBox_gender.Location = new System.Drawing.Point(305, 45);
            this.comboBox_gender.Name = "comboBox_gender";
            this.comboBox_gender.Size = new System.Drawing.Size(120, 21);
            this.comboBox_gender.TabIndex = 3;
            // 
            // textBox_phone
            // 
            this.textBox_phone.Location = new System.Drawing.Point(84, 80);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(120, 20);
            this.textBox_phone.TabIndex = 4;
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(305, 79);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(120, 20);
            this.textBox_email.TabIndex = 5;
            // 
            // textBox_address
            // 
            this.textBox_address.Location = new System.Drawing.Point(84, 114);
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(120, 20);
            this.textBox_address.TabIndex = 6;
            // 
            // textBox_bloodType
            // 
            this.textBox_bloodType.Location = new System.Drawing.Point(84, 148);
            this.textBox_bloodType.Name = "textBox_bloodType";
            this.textBox_bloodType.Size = new System.Drawing.Size(120, 20);
            this.textBox_bloodType.TabIndex = 7;
            // 
            // textBox_medicalHistory
            // 
            this.textBox_medicalHistory.Location = new System.Drawing.Point(12, 201);
            this.textBox_medicalHistory.Multiline = true;
            this.textBox_medicalHistory.Name = "textBox_medicalHistory";
            this.textBox_medicalHistory.Size = new System.Drawing.Size(413, 63);
            this.textBox_medicalHistory.TabIndex = 8;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(15, 280);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 9;
            this.button_add.Text = "Add";
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(121, 280);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(75, 23);
            this.button_update.TabIndex = 10;
            this.button_update.Text = "Update";
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(227, 280);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 23);
            this.button_delete.TabIndex = 11;
            this.button_delete.Text = "Delete";
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(616, 15);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(67, 23);
            this.button_clear.TabIndex = 22;
            this.button_clear.Text = "Clear";
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // dataGridView_patients
            // 
            this.dataGridView_patients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_patients.Location = new System.Drawing.Point(12, 324);
            this.dataGridView_patients.MultiSelect = false;
            this.dataGridView_patients.Name = "dataGridView_patients";
            this.dataGridView_patients.ReadOnly = true;
            this.dataGridView_patients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_patients.Size = new System.Drawing.Size(671, 150);
            this.dataGridView_patients.TabIndex = 12;
            this.dataGridView_patients.DoubleClick += new System.EventHandler(this.dataGridView_patients_DoubleClick);
            // 
            // PatientManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 488);
            this.Controls.Add(this.dataGridView_patients);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.textBox_medicalHistory);
            this.Controls.Add(this.textBox_bloodType);
            this.Controls.Add(this.textBox_address);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.textBox_phone);
            this.Controls.Add(this.comboBox_gender);
            this.Controls.Add(this.dateTimePicker_dob);
            this.Controls.Add(this.textBox_lastName);
            this.Controls.Add(this.textBox_firstName);
            this.Controls.Add(this.label_medicalHistory);
            this.Controls.Add(this.label_bloodType);
            this.Controls.Add(this.label_address);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.label_phone);
            this.Controls.Add(this.label_gender);
            this.Controls.Add(this.label_dob);
            this.Controls.Add(this.label_lastName);
            this.Controls.Add(this.label_firstName);
            this.Name = "PatientManagementForm";
            this.Text = "Patient Management";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_patients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_firstName;
        private System.Windows.Forms.Label label_lastName;
        private System.Windows.Forms.Label label_dob;
        private System.Windows.Forms.Label label_gender;
        private System.Windows.Forms.Label label_phone;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_address;
        private System.Windows.Forms.Label label_bloodType;
        private System.Windows.Forms.Label label_medicalHistory;
        private System.Windows.Forms.TextBox textBox_firstName;
        private System.Windows.Forms.TextBox textBox_lastName;
        private System.Windows.Forms.DateTimePicker dateTimePicker_dob;
        private System.Windows.Forms.ComboBox comboBox_gender;
        private System.Windows.Forms.TextBox textBox_phone;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.TextBox textBox_bloodType;
        private System.Windows.Forms.TextBox textBox_medicalHistory;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.DataGridView dataGridView_patients;
        private System.Windows.Forms.Button button_clear;
    }
}