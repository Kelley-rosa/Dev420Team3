using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace HospitalManagementSystem
{
    public class InventoryRepository
    {
        private readonly string _connectionString =
            ConfigurationManager.ConnectionStrings["SQLConnection"].ConnectionString;

        public List<InventoryItem> GetAllItems()
        {
            var items = new List<InventoryItem>();

            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string query = "SELECT ItemID, ItemName, Category, Quantity, Unit, LowStockThreshold, LastUpdated FROM Inventory ORDER BY ItemName";

                using (var cmd = new SqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        items.Add(new InventoryItem
                        {
                            ItemID = (int)reader["ItemID"],
                            ItemName = reader["ItemName"].ToString(),
                            Category = reader["Category"].ToString(),
                            Quantity = (int)reader["Quantity"],
                            Unit = reader["Unit"].ToString(),
                            LowStockThreshold = (int)reader["LowStockThreshold"],
                            LastUpdated = (DateTime)reader["LastUpdated"]
                        });
                    }
                }
            }

            return items;
        }

        public int AddItem(InventoryItem item)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string query = @"INSERT INTO Inventory (ItemName, Category, Quantity, Unit, LowStockThreshold, LastUpdated)
                                  VALUES (@ItemName, @Category, @Quantity, @Unit, @LowStockThreshold, GETDATE());
                                  SELECT CAST(SCOPE_IDENTITY() as int);";

                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ItemName", item.ItemName);
                    cmd.Parameters.AddWithValue("@Category", item.Category);
                    cmd.Parameters.AddWithValue("@Quantity", item.Quantity);
                    cmd.Parameters.AddWithValue("@Unit", item.Unit);
                    cmd.Parameters.AddWithValue("@LowStockThreshold", item.LowStockThreshold);

                    return (int)cmd.ExecuteScalar();
                }
            }
        }

        public void UpdateQuantity(int itemId, int newQuantity)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string query = @"UPDATE Inventory
                                  SET Quantity = @Quantity, LastUpdated = GETDATE()
                                  WHERE ItemID = @ItemID";

                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Quantity", newQuantity);
                    cmd.Parameters.AddWithValue("@ItemID", itemId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteItem(int itemId)
        {
            using (var conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string query = "DELETE FROM Inventory WHERE ItemID = @ItemID";

                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ItemID", itemId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
