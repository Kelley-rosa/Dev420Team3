using System;
using System.Configuration;
using System.Windows.Forms;
using Microsoft.AspNet.SignalR.Client;

namespace HospitalManagementSystem
{
    public partial class ChatForm : Form
    {
        private HubConnection _hubConnection;
        private IHubProxy _hubProxy;

        public ChatForm()
        {
            InitializeComponent();
            this.Load += ChatForm_Load;
            this.FormClosing += ChatForm_FormClosing;
        }

        private async void ChatForm_Load(object sender, EventArgs e)
        {
            // Default a name so the box isn't empty;
            txtSenderName.Text = Environment.UserName;
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

                // Listen for chat messages broadcast by ANY connected client
                _hubProxy.On<string, string>("receiveChatMessage", (sender, message) =>
                {
                    this.Invoke((Action)(() =>
                    {
                        lstMessages.Items.Add($"{sender}: {message}");
                        lstMessages.TopIndex = lstMessages.Items.Count - 1;
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

        private void ChatForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _hubConnection?.Stop();
            _hubConnection?.Dispose();
        }

        // ---------- Sending messages ----------

        private void btnSend_Click(object sender, EventArgs e)
        {
            SendCurrentMessage();
        }

        private void txtMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // stops the ding/newline
                e.SuppressKeyPress = true;
                SendCurrentMessage();
            }
        }

        private void SendCurrentMessage()
        {
            string name = string.IsNullOrWhiteSpace(txtSenderName.Text) ? "Unknown" : txtSenderName.Text.Trim();
            string message = txtMessage.Text.Trim();

            if (string.IsNullOrWhiteSpace(message)) return;

            try
            {
                _hubProxy?.Invoke("SendChatMessage", name, message);
                txtMessage.Clear();
                txtMessage.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not send message. Make sure HospitalSignalRServer is running.\n\n" + ex.Message,
                    "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
