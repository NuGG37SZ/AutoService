using AutoService.Classes;
using AutoService.Entity;
using AutoService.Interface;
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
    public class InventoryImpl : Repository<Inventory>
    {
        public void Add(Inventory entity)
        {
            try
            {
                int maxId = getMaxId();

                DbConnect.Connect();
                var command = DbConnect.connection.CreateCommand();
                command.CommandText = "INSERT INTO Inventory (part_name, part_number, quantity, price, supplier, notes) " +
                         "VALUES (@part_name, @part_number, @quantity, @price, @supplier, @notes)";
                command.Parameters.AddWithValue("@part_name", entity.PartName);
                command.Parameters.AddWithValue("@part_number", entity.PartNumber);
                command.Parameters.AddWithValue("@quantity", entity.Quantity);
                command.Parameters.AddWithValue("@price", entity.Price);
                command.Parameters.AddWithValue("@supplier", entity.Supplier);
                command.Parameters.AddWithValue("@notes", entity.Notes);
                int rowsAffected = command.ExecuteNonQuery();

                string insertFinanceQuery = "INSERT INTO Finances (transaction_date, transaction_type, amount, description) " +
                        "VALUES (@transaction_date, @transaction_type, @amount, @description)";
                SQLiteCommand commandInsertFinance = new SQLiteCommand(insertFinanceQuery, DbConnect.connection);
                commandInsertFinance.Parameters.AddWithValue("@transaction_date", DateTime.Now);
                commandInsertFinance.Parameters.AddWithValue("@transaction_type", "Withdrawal");
                commandInsertFinance.Parameters.AddWithValue("@amount", entity.Price * entity.Quantity);
                commandInsertFinance.Parameters.AddWithValue("@description", $"New spare parts, number {maxId}");
                commandInsertFinance.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Запчасть успешно добавлена!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Произошла ошибка, запчасть не добавлена!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (SQLiteException ex)
            {
                MessageBox.Show($"Ошибка SQLite при добавлении записи в Inventory: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (ex.Message.Contains("Finances"))
                {
                    MessageBox.Show($"Ошибка SQLite при добавлении записи в Finances: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            finally
            {
                DbConnect.Disconnect();
            }
        }

        public void Delete(int id)
        {
            DbConnect.Connect();

            var command = DbConnect.connection.CreateCommand();
            command.CommandText = "DELETE FROM Inventory WHERE inventory_id = @id";
            command.Parameters.AddWithValue("@id", id);
            int rowsAffected = command.ExecuteNonQuery();

            var commandDelete = DbConnect.connection.CreateCommand();
            commandDelete.CommandText = $"DELETE FROM Finances WHERE description = New spare parts, number {id}";
            commandDelete.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Запчасть успешно удалена!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Произошла ошибка, запчасть не удалена!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DbConnect.Disconnect();
        }

        public void Update(Inventory entity)
        {
            DbConnect.Connect();

            var command = DbConnect.connection.CreateCommand();

            command.CommandText = "UPDATE Inventory SET part_name = @part_name, part_number = @part_number, quantity = @quantity, " +
                "price = @price, supplier = @supplier, notes = @notes  WHERE inventory_id = @id";
            command.Parameters.AddWithValue("@part_name", entity.PartName);
            command.Parameters.AddWithValue("@part_number", entity.PartNumber);
            command.Parameters.AddWithValue("@quantity", entity.Quantity);
            command.Parameters.AddWithValue("@price", Math.Round(entity.Price, 2));
            command.Parameters.AddWithValue("@supplier", entity.Supplier);
            command.Parameters.AddWithValue("@notes", entity.Notes);
            command.Parameters.AddWithValue("@id", entity.Id);
            int rowsAffected = command.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Запчасть успешно изменена!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Произошла ошибка, запчасть не изменена!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DbConnect.Disconnect();
        }

        public void SearchSelect(Control control, DataGridView dataGridView)
        {
            DbConnect.Connect();

            string search = $"%{control.Text}%";

            string query = "SELECT * FROM Inventory " +
            "WHERE part_name LIKE @search " +
            "OR part_name LIKE @search " +
            "OR part_number LIKE @search " +
            "OR quantity LIKE @searchNumbers " +
            "OR price LIKE @searchNumbers " +
            "OR supplier LIKE @search " +
            "OR notes LIKE @search";
            SQLiteCommand command = new SQLiteCommand(query, DbConnect.connection);
            command.Parameters.AddWithValue("@search", search);
            command.Parameters.AddWithValue("@searchNumbers", control.Text);
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

            string query = "SELECT * FROM Inventory";
            SQLiteCommand command = new SQLiteCommand(query, DbConnect.connection);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.RowHeadersVisible = false;

            DbConnect.Disconnect();
        }

        public int getMaxId()
        {
            int InventoryId = 0;
            string query = "SELECT MAX(inventory_id) FROM Inventory;";
            SQLiteCommand command = new SQLiteCommand(query, DbConnect.connection);
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    InventoryId = reader.GetInt32(0);
                }
            }
            return InventoryId;
        }


    }
}
