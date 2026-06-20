using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class AnalyticsForm : Form
    {
        private string connectionString =
            ConfigurationManager.ConnectionStrings["SQLConnection"].ConnectionString;

        public AnalyticsForm()
        {
            InitializeComponent();
        }

        // shows total patients registered per month
        private void button_patientVisits_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // group patient records by the month they were created to show visit trends
                    string query = @"SELECT FORMAT(CreatedDate, 'yyyy-MM') as Month, COUNT(*) as PatientCount
                                     FROM Patients
                                     GROUP BY FORMAT(CreatedDate, 'yyyy-MM')
                                     ORDER BY Month";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView_results.DataSource = dataTable;

                    label_reportTitle.Text = "Patient Registrations by Month";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading report: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // shows appointment counts grouped by reason, common ailments
        private void button_commonAilments_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // group appointments by reason to find the most common ailments
                    string query = @"SELECT Reason, COUNT(*) as VisitCount
                                     FROM Appointments
                                     WHERE Reason IS NOT NULL AND Reason != ''
                                     GROUP BY Reason
                                     ORDER BY VisitCount DESC";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView_results.DataSource = dataTable;

                    label_reportTitle.Text = "Common Ailments by Visit Reason";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading report: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // shows appointment status breakdown
        private void button_appointmentStatus_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // count appointments grouped by their current status
                    string query = @"SELECT Status, COUNT(*) as Count
                                     FROM Appointments
                                     GROUP BY Status
                                     ORDER BY Count DESC";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView_results.DataSource = dataTable;

                    label_reportTitle.Text = "Appointments by Status";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading report: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // shows doctors ranked by number of appointments
        private void button_doctorWorkload_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // count how many appointments each doctor has handled
                    string query = @"SELECT DoctorName, COUNT(*) as AppointmentCount
                                     FROM Appointments
                                     GROUP BY DoctorName
                                     ORDER BY AppointmentCount DESC";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView_results.DataSource = dataTable;

                    label_reportTitle.Text = "Doctor Workload";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading report: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}