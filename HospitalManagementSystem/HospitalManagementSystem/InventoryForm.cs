using System;
using System.Configuration;
using System.Windows.Forms;
using Microsoft.AspNet.SignalR.Client;

namespace HospitalManagementSystem
{
    public partial class InventoryForm : Form
    {
        private readonly InventoryRepository _repository = new InventoryRepository();
        private HubConnection _hubConnection;
        private IHubProxy _hubProxy;

        public InventoryForm()
        {
            InitializeComponent();
            this.Load += InventoryForm_Load;
            this.FormClosing += InventoryForm_FormClosing;
        }

        private async void InventoryForm_Load(object sender, EventArgs e)
        {
            LoadInventory();
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

                // Listen for low stock alerts broadcast by ANY connected client
                _hubProxy.On<string, int>("receiveLowStockAlert", (itemName, quantity) =>
                {
                    this.Invoke((Action)(() =>
                    {
                        LoadInventory();
                        // Only pop a message box if this window didn't already know
                        // Kept lightweight on purpose for the demo.
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

        private void InventoryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _hubConnection?.Stop();
            _hubConnection?.Dispose();
        }

        // ---------- Data loading ----------

        private void LoadInventory()
        {
            try
            {
                var items = _repository.GetAllItems();
                dgvInventory.DataSource = null;
                dgvInventory.DataSource = items;

                // Highlight low-stock rows in the grid
                foreach (DataGridViewRow row in dgvInventory.Rows)
                {
                    var item = row.DataBoundItem as InventoryItem;
                    if (item != null && item.Quantity < item.LowStockThreshold)
                    {
                        row.DefaultCellStyle.BackColor = System.Drawing.Color.MistyRose;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load inventory: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ---------- Button handlers ----------

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtItemName.Text) || string.IsNullOrWhiteSpace(txtCategory.Text) || string.IsNullOrWhiteSpace(txtUnit.Text))
            {
                MessageBox.Show("Item name, category, and unit are required.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var item = new InventoryItem
            {
                ItemName = txtItemName.Text.Trim(),
                Category = txtCategory.Text.Trim(),
                Quantity = (int)nudQuantity.Value,
                Unit = txtUnit.Text.Trim(),
                LowStockThreshold = (int)nudThreshold.Value
            };

            try
            {
                _repository.AddItem(item);
                LoadInventory();
                CheckAndBroadcastLowStock(item.ItemName, item.Quantity, item.LowStockThreshold);

                txtItemName.Clear();
                txtCategory.Clear();
                txtUnit.Clear();
                nudQuantity.Value = 0;
                nudThreshold.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not add item: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateQuantity_Click(object sender, EventArgs e)
        {
            if (dgvInventory.CurrentRow == null)
            {
                MessageBox.Show("Select an item first.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selected = dgvInventory.CurrentRow.DataBoundItem as InventoryItem;
            if (selected == null) return;

            int newQuantity = (int)nudQuantity.Value;

            try
            {
                _repository.UpdateQuantity(selected.ItemID, newQuantity);
                LoadInventory();
                CheckAndBroadcastLowStock(selected.ItemName, newQuantity, selected.LowStockThreshold);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not update item: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvInventory.CurrentRow == null)
            {
                MessageBox.Show("Select an item first.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selected = dgvInventory.CurrentRow.DataBoundItem as InventoryItem;
            if (selected == null) return;

            var confirm = MessageBox.Show($"Delete '{selected.ItemName}'?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                _repository.DeleteItem(selected.ItemID);
                LoadInventory();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not delete item: " + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadInventory();
        }

        // ---------- Low stock broadcast ----------

        private void CheckAndBroadcastLowStock(string itemName, int quantity, int threshold)
        {
            if (quantity < threshold)
            {
                try
                {
                    _hubProxy?.Invoke("SendLowStockAlert", itemName, quantity);
                }
                catch (Exception)
                {
                    // Hub might not be reachable; item is still saved in SQL,
                    // so we don't block the user, just skip the real-time push.
                }
            }
        }
    }
}
