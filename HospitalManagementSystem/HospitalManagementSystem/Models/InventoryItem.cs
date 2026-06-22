using System;

namespace HospitalManagementSystem
{
    public class InventoryItem
    {
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }
        public string Unit { get; set; }
        public int LowStockThreshold { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
