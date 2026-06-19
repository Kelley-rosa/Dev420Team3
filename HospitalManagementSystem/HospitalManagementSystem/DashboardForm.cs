using System;
using System.Configuration;
using System.Windows.Forms;
using Microsoft.AspNet.SignalR.Client;

namespace HospitalManagementSystem
{
    public partial class DashboardForm : Form
    {
        private HubConnection _hubConnection;
        private IHubProxy _hubProxy;

        // In-memory bed tracking (no Beds table in the DB yet, so we simulate it here)
        private int _totalBeds = 20;
        private int _availableBeds = 20;

        private bool _emergencyActive = false;

        public DashboardForm()
        {
            InitializeComponent();
            this.Load += DashboardForm_Load;
            this.FormClosing += DashboardForm_FormClosing;
        }

        private async void DashboardForm_Load(object sender, EventArgs e)
        {
            UpdateBedsLabel();
            UpdateEmergencyLabel();
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

                // Listen for bed status changes broadcast by ANY connected client
                _hubProxy.On<int, int>("receiveBedStatusUpdate", (available, total) =>
                {
                    this.Invoke((Action)(() =>
                    {
                        _availableBeds = available;
                        _totalBeds = total;
                        UpdateBedsLabel();
                    }));
                });

                // Listen for emergency status changes broadcast by ANY connected client
                _hubProxy.On<string>("receiveEmergencyStatusUpdate", (status) =>
                {
                    this.Invoke((Action)(() =>
                    {
                        _emergencyActive = status == "Alert";
                        UpdateEmergencyLabel();
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

        private void DashboardForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _hubConnection?.Stop();
            _hubConnection?.Dispose();
        }

        // ---------- UI helpers ----------

        private void UpdateBedsLabel()
        {
            lblBedsValue.Text = $"{_availableBeds} / {_totalBeds} available";
            lblBedsValue.ForeColor = _availableBeds == 0
                ? System.Drawing.Color.Red
                : (_availableBeds <= _totalBeds / 4 ? System.Drawing.Color.DarkOrange : System.Drawing.Color.DarkGreen);
        }

        private void UpdateEmergencyLabel()
        {
            if (_emergencyActive)
            {
                lblEmergencyValue.Text = "ALERT";
                lblEmergencyValue.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lblEmergencyValue.Text = "Normal";
                lblEmergencyValue.ForeColor = System.Drawing.Color.DarkGreen;
            }
        }

        // ---------- Button handlers ----------

        private void btnAdmit_Click(object sender, EventArgs e)
        {
            if (_availableBeds <= 0)
            {
                MessageBox.Show("No beds available.", "Capacity Reached",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _availableBeds--;
            UpdateBedsLabel();
            BroadcastBedStatus();
        }

        private void btnDischarge_Click(object sender, EventArgs e)
        {
            if (_availableBeds >= _totalBeds)
            {
                MessageBox.Show("All beds are already available.", "No Change",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            _availableBeds++;
            UpdateBedsLabel();
            BroadcastBedStatus();
        }

        private void btnToggleEmergency_Click(object sender, EventArgs e)
        {
            _emergencyActive = !_emergencyActive;
            UpdateEmergencyLabel();
            BroadcastEmergencyStatus();
        }

        // ---------- Broadcast helpers ----------

        private void BroadcastBedStatus()
        {
            try
            {
                _hubProxy?.Invoke("SendBedStatusUpdate", _availableBeds, _totalBeds);
            }
            catch (Exception)
            {
                // Hub might not be reachable; local state still updated, just skip the push.
            }
        }

        private void BroadcastEmergencyStatus()
        {
            try
            {
                _hubProxy?.Invoke("SendEmergencyStatusUpdate", _emergencyActive ? "Alert" : "Normal");
            }
            catch (Exception)
            {
                // Hub might not be reachable; local state still updated, just skip the push.
            }
        }
    }
}
