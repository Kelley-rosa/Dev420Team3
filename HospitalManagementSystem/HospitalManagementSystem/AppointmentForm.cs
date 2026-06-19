using System;
using System.Configuration;
using System.Windows.Forms;
using HospitalManagementSystem.Models;
using Microsoft.AspNet.SignalR.Client;

namespace HospitalManagementSystem
{
    public partial class AppointmentForm : Form
    {
        private readonly AppointmentRepository _repository = new AppointmentRepository();
        private HubConnection _hubConnection;
        private IHubProxy _hubProxy;

        public AppointmentForm()
        {
            InitializeComponent();
            this.Load += AppointmentForm_Load;
            this.FormClosing += AppointmentForm_FormClosing;
        }

        private async void AppointmentForm_Load(object sender, EventArgs e)
        {
            LoadAppointments();
            await ConnectToHubAsync();
        }

        // ---------- SignalR connection ----------

        private async System.Threading.Tasks.Task ConnectToHubAsync()
        {
            try
            {
                string hubUrl = ConfigurationManager.ConnectionStrings["SignalRConnection"].ConnectionString;
                _hubConnection = new HubConnection(hubUrl);
                _hubProxy = _hubConnection.CreateHubProxy("HospitalHub");

                // Listen for appointment updates broadcast by ANY client
                _hubProxy.On<string, string>("receiveAppointmentUpdate", (action, info) =>
                {
                    // SignalR callbacks arrive on a background thread
                    this.Invoke((Action)(() =>
                    {
                        LoadAppointments();
                    }));
                });

                await _hubConnection.Start();

                lblConnectionStatus.Text = "SignalR: Connected";
                lblConnectionStatus.ForeColor = System.Drawing.Color.Green;
            }
            catch (Exception ex)
            {
                lblConnectionStatus.Text = "SignalR: Disconnected";
                lblConnectionStatus.ForeColor = System.Drawing.Color.Red;
                MessageBox.Show("Could not connect to the SignalR hub. Make sure HospitalSignalRServer is running.\n\n" + ex.Message,
                    "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AppointmentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _hubConnection?.Stop();
            _hubConnection?.Dispose();
        }

        // ---------- Data loading ----------

        private void LoadAppointments()
        {
            try
            {
                var appointments = _repository.GetAllAppointments();
                dgvAppointments.DataSource = null;
                dgvAppointments.DataSource = appointments;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load appointments: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ---------- Button handlers ----------

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtPatientID.Text.Trim(), out int patientId))
            {
                MessageBox.Show("Please enter a valid numeric Patient ID.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDoctorName.Text))
            {
                MessageBox.Show("Please enter a doctor name.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var appt = new Appointment
            {
                PatientID = patientId,
                DoctorName = txtDoctorName.Text.Trim(),
                AppointmentDate = dtpAppointmentDate.Value,
                Reason = txtReason.Text.Trim(),
                Status = "Scheduled"
            };

            try
            {
                int newId = _repository.AddAppointment(appt);
                LoadAppointments();
                BroadcastAppointmentUpdate("Added", $"Appointment #{newId} for Patient {patientId} with Dr. {appt.DoctorName}");

                txtPatientID.Clear();
                txtDoctorName.Clear();
                txtReason.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not add appointment: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (dgvAppointments.CurrentRow == null)
            {
                MessageBox.Show("Select an appointment to cancel first.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selected = dgvAppointments.CurrentRow.DataBoundItem as Appointment;
            if (selected == null) return;

            try
            {
                _repository.CancelAppointment(selected.AppointmentID);
                LoadAppointments();
                BroadcastAppointmentUpdate("Cancelled", $"Appointment #{selected.AppointmentID} was cancelled");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not cancel appointment: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadAppointments();
        }

        // ---------- Broadcast helper ----------

        private void BroadcastAppointmentUpdate(string action, string info)
        {
            try
            {
                _hubProxy?.Invoke("SendAppointmentUpdate", action, info);
            }
            catch (Exception)
            {
                // Hub might not be reachable; appointment is still saved in SQL,
                // so we don't block the user, just skip the real-time push.
            }
        }
    }
}
