using Microsoft.AspNet.SignalR;

namespace HospitalSignalRServer
{
    public class HospitalHub : Hub
    {
        // --- Appointments ---
        public void SendAppointmentUpdate(string action, string appointmentInfo)
        {
            // action = "Added", "Updated", or "Cancelled"
            Clients.All.receiveAppointmentUpdate(action, appointmentInfo);
        }

        // --- Dashboard ---
        public void SendBedStatusUpdate(int availableBeds, int totalBeds)
        {
            Clients.All.receiveBedStatusUpdate(availableBeds, totalBeds);
        }

        public void SendEmergencyStatusUpdate(string status)
        {
            Clients.All.receiveEmergencyStatusUpdate(status);
        }

        // --- Inventory ---
        public void SendLowStockAlert(string itemName, int quantity)
        {
            Clients.All.receiveLowStockAlert(itemName, quantity);
        }

        // --- Chat ---
        public void SendChatMessage(string sender, string message)
        {
            Clients.All.receiveChatMessage(sender, message);
        }
    }
}
