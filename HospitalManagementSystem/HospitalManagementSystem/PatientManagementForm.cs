using System;
using System.Linq;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class PatientManagementForm : Form
    {
        HospitalContext context;

        public PatientManagementForm()
        {
            InitializeComponent();
            context = new HospitalContext();
            LoadPatients();
        }

        // loads all patients into the DataGridView
        private void LoadPatients()
        {
            try
            {
                dataGridView_patients.DataSource = context.Patients.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading patients: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // adds a new patient
        private void button_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_firstName.Text) ||
                string.IsNullOrWhiteSpace(textBox_lastName.Text))
            {
                MessageBox.Show("First and last name are required.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var patient = new Patient
                {
                    FirstName = textBox_firstName.Text,
                    LastName = textBox_lastName.Text,
                    DateOfBirth = dateTimePicker_dob.Value,
                    Gender = comboBox_gender.SelectedItem?.ToString(),
                    Phone = textBox_phone.Text,
                    Email = textBox_email.Text,
                    Address = textBox_address.Text,
                    BloodType = textBox_bloodType.Text,
                    MedicalHistory = textBox_medicalHistory.Text,
                    CreatedDate = DateTime.Now
                };

                context.Patients.Add(patient);
                context.SaveChanges();

                MessageBox.Show("Patient added successfully!");
                ClearInputs();
                LoadPatients();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding patient: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // updates the selected patient
        private void button_update_Click(object sender, EventArgs e)
        {
            if (dataGridView_patients.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a patient to update.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var selected = (Patient)dataGridView_patients.SelectedRows[0].DataBoundItem;
                var patient = context.Patients.Find(selected.PatientID);

                if (patient != null)
                {
                    patient.FirstName = textBox_firstName.Text;
                    patient.LastName = textBox_lastName.Text;
                    patient.DateOfBirth = dateTimePicker_dob.Value;
                    patient.Gender = comboBox_gender.SelectedItem?.ToString();
                    patient.Phone = textBox_phone.Text;
                    patient.Email = textBox_email.Text;
                    patient.Address = textBox_address.Text;
                    patient.BloodType = textBox_bloodType.Text;
                    patient.MedicalHistory = textBox_medicalHistory.Text;

                    context.SaveChanges();
                    MessageBox.Show("Patient updated successfully!");
                    ClearInputs();
                    LoadPatients();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating patient: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // deletes the selected patient
        private void button_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView_patients.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a patient to delete.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this patient?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No) return;

            try
            {
                var selected = (Patient)dataGridView_patients.SelectedRows[0].DataBoundItem;
                var patient = context.Patients.Find(selected.PatientID);

                if (patient != null)
                {
                    context.Patients.Remove(patient);
                    context.SaveChanges();
                    MessageBox.Show("Patient deleted successfully!");
                    ClearInputs();
                    LoadPatients();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting patient: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // when a row is double clicked, populate the text boxes
        private void dataGridView_patients_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView_patients.SelectedRows.Count > 0)
            {
                var selected = (Patient)dataGridView_patients.SelectedRows[0].DataBoundItem;

                textBox_firstName.Text = selected.FirstName;
                textBox_lastName.Text = selected.LastName;
                dateTimePicker_dob.Value = selected.DateOfBirth;
                comboBox_gender.SelectedItem = selected.Gender;
                textBox_phone.Text = selected.Phone;
                textBox_email.Text = selected.Email;
                textBox_address.Text = selected.Address;
                textBox_bloodType.Text = selected.BloodType;
                textBox_medicalHistory.Text = selected.MedicalHistory;
            }
        }

        // clears all fields and deselects the grid
        private void button_clear_Click(object sender, EventArgs e)
        {
            ClearInputs();
            dataGridView_patients.ClearSelection();
        }

        // clears all input fields
        private void ClearInputs()
        {
            textBox_firstName.Clear();
            textBox_lastName.Clear();
            textBox_phone.Clear();
            textBox_email.Clear();
            textBox_address.Clear();
            textBox_bloodType.Clear();
            textBox_medicalHistory.Clear();
        }
    }
}