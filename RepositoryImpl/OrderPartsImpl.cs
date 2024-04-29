using AutoService.Classes;
using AutoService.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoService.RepositoryImpl
{
    public class OrderPartsImpl
    {
        public void Add(OrderPart entity)
        {
            try
            {
                DbConnect.Connect();
                var command = DbConnect.connection.CreateCommand();
                command.CommandText = "INSERT INTO OrderParts (order_id, inventory_id, quantity) " +
                                      "VALUES (@order_id, @inventory_id, @quantity)";
                command.Parameters.AddWithValue("@order_id", entity.OrderId);
                command.Parameters.AddWithValue("@inventory_id", entity.InventoryId);
                command.Parameters.AddWithValue("@quantity", entity.Quantity);
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Запчасть успешно добавлена в заказ!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Произошла ошибка запчасть не добавлена в заказ!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                string findQuery = $"SELECT * FROM OrderParts WHERE inventory_id = {entity.InventoryId}";
                SQLiteCommand commandFind = new SQLiteCommand(findQuery, DbConnect.connection);
                using (SQLiteDataReader reader = commandFind.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            int inventoryId = Convert.ToInt32(reader["inventory_id"]);

                            string updateQuery = $"UPDATE Inventory SET quantity = quantity - {entity.Quantity} " +
                                $"WHERE inventory_id = {inventoryId}";
                            SQLiteCommand commandUpdate = new SQLiteCommand(updateQuery, DbConnect.connection);
                            commandUpdate.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show($"Ошибка SQLite: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DbConnect.Disconnect();
            }
        }

        public void Delete(int idOrders, int idInventory)
        {
            DbConnect.Connect();
            string findQuery = $"SELECT * FROM OrderParts WHERE inventory_id = {idInventory}";
            SQLiteCommand commandFind = new SQLiteCommand(findQuery, DbConnect.connection);
            using (SQLiteDataReader reader = commandFind.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int inventoryId = Convert.ToInt32(reader["inventory_id"]);
                        int quantity = Convert.ToInt32(reader["quantity"]);

                        string updateQuery = $"UPDATE Inventory SET quantity = quantity + {quantity} " +
                            $"WHERE inventory_id = {inventoryId}";
                        SQLiteCommand commandUpdate = new SQLiteCommand(updateQuery, DbConnect.connection);
                        commandUpdate.ExecuteNonQuery();
                    }
                }
            }

            var command = DbConnect.connection.CreateCommand();
            command.CommandText = "DELETE FROM OrderParts WHERE order_id = @idOrders AND inventory_id = @idInventory";
            command.Parameters.AddWithValue("@idOrders", idOrders);
            command.Parameters.AddWithValue("@idInventory", idInventory);
            int rowsAffected = command.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Запчасть успешно удалена из заказа!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Произошла ошибка, запчасть не удалена!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DbConnect.Disconnect();
        }

        public void Update(OrderPart entity)
        {
            DbConnect.Connect();
            int oldValueQuantity = getOldValueQuantity(entity.InventoryId, entity.OrderId);
            int newValueQuantity = entity.Quantity;

            var command = DbConnect.connection.CreateCommand();
            command.CommandText = "UPDATE OrderParts SET order_id = @order_id, inventory_id = @inventory_id, quantity = @quantity " +
                "WHERE order_id = @order_id AND inventory_id = @inventory_id";
            command.Parameters.AddWithValue("@order_id", entity.OrderId);
            command.Parameters.AddWithValue("@inventory_id", entity.InventoryId);
            command.Parameters.AddWithValue("@quantity", entity.Quantity);
            int rowsAffected = command.ExecuteNonQuery();

            string querySecond = $"SELECT quantity FROM Inventory WHERE inventory_id = {entity.InventoryId}";
            SQLiteCommand commandSecond = new SQLiteCommand(querySecond, DbConnect.connection);
            using (SQLiteDataReader reader = commandSecond.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int quantity = Convert.ToInt32(reader["quantity"]);

                        if (oldValueQuantity < newValueQuantity)
                        {
                            quantity -= newValueQuantity - oldValueQuantity;
                            string updateQuery = $"UPDATE Inventory SET quantity = {quantity} " +
                                    $"WHERE inventory_id = {entity.InventoryId}";
                            SQLiteCommand commandUpdate = new SQLiteCommand(updateQuery, DbConnect.connection);
                            commandUpdate.ExecuteNonQuery();
                        }
                        else
                        {
                            quantity += oldValueQuantity - newValueQuantity;
                            string updateQuery = $"UPDATE Inventory SET quantity = {quantity} " +
                                    $"WHERE inventory_id = {entity.InventoryId}";
                            SQLiteCommand commandUpdate = new SQLiteCommand(updateQuery, DbConnect.connection);
                            commandUpdate.ExecuteNonQuery();
                        }
                    }
                }
            }

            if (rowsAffected > 0)
            {
                MessageBox.Show("Заказ успешно изменен!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Произошла ошибка, заказ не изменен!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DbConnect.Disconnect();
        }

        public void SearchSelect(Control control, DataGridView dataGridView)
        {
            DbConnect.Connect();

            string search = $"%{control.Text}%";

            string query = "SELECT order_id AS 'Номер заказа', Inventory.part_name AS 'Название запчасти', " +
                "Inventory.part_number AS 'Номер детали', OrderParts.quantity AS 'Количество' " +
                "FROM OrderParts INNER JOIN Inventory ON OrderParts.inventory_id = Inventory.inventory_id " +
                "WHERE Inventory.part_name LIKE @search " +
                "OR Inventory.part_number LIKE @search " +
                "OR OrderParts.quantity LIKE @searchNumber " +
                "OR order_id LIKE @searchNumber ";
            SQLiteCommand command = new SQLiteCommand(query, DbConnect.connection);
            command.Parameters.AddWithValue("@search", search);
            command.Parameters.AddWithValue("@searchNumber", Convert.ToInt32(control.Text));
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.RowHeadersVisible = false;

            DbConnect.Disconnect();
        }

        public void SelectAllFields(DataGridView dataGridView)
        {
            DbConnect.Connect();

            string query = "SELECT order_id AS 'Номер заказа', Inventory.part_name AS 'Название запчасти', " +
                "Inventory.part_number AS 'Номер детали', OrderParts.quantity AS 'Количество' " +
                "FROM OrderParts INNER JOIN Inventory ON OrderParts.inventory_id = Inventory.inventory_id ";
            SQLiteCommand command = new SQLiteCommand(query, DbConnect.connection);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.RowHeadersVisible = false;

            DataGridViewColumn orderId = dataGridView.Columns["Номер заказа"];
            DataGridViewColumn partName = dataGridView.Columns["Название запчасти"];
            DataGridViewColumn partNumber = dataGridView.Columns["Номер детали"];
            DataGridViewColumn quantity = dataGridView.Columns["Количество"];

            orderId.Width = 120;
            partName.Width = 190;
            partNumber.Width = 170;
            quantity.Width = 130;

            DbConnect.Disconnect();
        }

        public int getOldValueQuantity(int inventoryId, int orderId)
        {
            int oldValueQuantity = 0;
            string queryThird = $"SELECT quantity FROM OrderParts WHERE inventory_id = {inventoryId} " +
                $"AND order_id = {orderId}";
            SQLiteCommand commandThird = new SQLiteCommand(queryThird, DbConnect.connection);
            using (SQLiteDataReader reader = commandThird.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        oldValueQuantity = Convert.ToInt32(reader["quantity"]);
                    }
                }
            }
            return oldValueQuantity;
        }
    }
}
