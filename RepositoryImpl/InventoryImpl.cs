using AutoService.Classes;
using AutoService.Entity;
using AutoService.Interface;
using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace AutoService.RepositoryImpl
{
    public class InventoryImpl : Repository<Inventory>
    {
        // Метод для добавления записей в таблицу Inventory
        public void Add(Inventory entity)
        {
            try
            {
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

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Запчасть успешно добавлена!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Произошла ошибка, запчасть не добавлена!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //при успешном добавлении записи в таблицу Inventory идет добавление записи в таблицу Finances
                //с расходом и ценой (кол-во * цена) и описанием New spare parts, number
                int maxId = 0;
                string query = $"SELECT MAX(inventory_id) FROM Inventory ";
                SQLiteCommand commandSecond = new SQLiteCommand(query, DbConnect.connection);
                using (SQLiteDataReader reader = commandSecond.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            maxId = reader.GetInt32(0);
                        }
                    }
                }

                string insertFinanceQuery = "INSERT INTO Finances (transaction_date, transaction_type, amount, description) " +
                    "VALUES (@transaction_date, @transaction_type, @amount, @description)";
                SQLiteCommand commandInsertFinance = new SQLiteCommand(insertFinanceQuery, DbConnect.connection);
                commandInsertFinance.Parameters.AddWithValue("@transaction_date", DateTime.Now);
                commandInsertFinance.Parameters.AddWithValue("@transaction_type", "Expense");
                commandInsertFinance.Parameters.AddWithValue("@amount", entity.Price * entity.Quantity);
                commandInsertFinance.Parameters.AddWithValue("@description", $"New spare parts, number {maxId}");
                commandInsertFinance.ExecuteNonQuery();
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

        // Метод для удаления записей в таблицу Inventory
        public void Delete(int id)
        {
            DbConnect.Connect();

            var command = DbConnect.connection.CreateCommand();
            command.CommandText = "DELETE FROM Inventory " +
                "WHERE inventory_id = @id";
            command.Parameters.AddWithValue("@id", id);
            int rowsAffected = command.ExecuteNonQuery();

            //при успешном удалении записи из таблицы Inventory, происходит и удаление из таблицы Finances
            var commandDelete = DbConnect.connection.CreateCommand();
            commandDelete.CommandText = $"DELETE FROM Finances " +
                $"WHERE description = 'New spare parts, number {id}'";
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

        // Метод для обновления записей в таблице Inventory
        public void Update(Inventory entity)
        {
            DbConnect.Connect();

            var command = DbConnect.connection.CreateCommand();
            command.CommandText = "UPDATE Inventory SET part_name = @part_name, part_number = @part_number, quantity = @quantity, " +
                "price = @price, supplier = @supplier, notes = @notes  " +
                "WHERE inventory_id = @id";
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

            //после обновления записи в таблице Inventory, происходит обновление цены и кол-во
            string querySecond = $"SELECT price, quantity FROM Inventory " +
                $"WHERE inventory_id = {entity.Id}";
            SQLiteCommand commandSecond = new SQLiteCommand(querySecond, DbConnect.connection);
            using (SQLiteDataReader reader = commandSecond.ExecuteReader())
            {
                if (reader.HasRows)
                {
                   while(reader.Read())
                   {
                        float newPrice = reader.GetFloat(0);
                        int newQuantity = reader.GetInt32(1);

                        string updateQuery = $"UPDATE Finances SET amount = {newPrice * newQuantity} " +
                                $"WHERE description = 'New spare parts, number {entity.Id}'";
                        SQLiteCommand commandUpdate = new SQLiteCommand(updateQuery, DbConnect.connection);
                        commandUpdate.ExecuteNonQuery();
                   }
                }
            }

            DbConnect.Disconnect();
        }

        // Метод для поиска записей в таблице Inventory и вывод их в датагрид
        public void SearchSelect(Control control, DataGridView dataGridView)
        {
            DbConnect.Connect();

            string search = $"%{control.Text}%";

            string query = "SELECT inventory_id AS ' ', part_name AS 'Наименование', part_number AS 'Номер', quantity AS 'Количество', " +
                "price AS 'Стоимость', supplier AS 'Поставщик', notes AS 'Примечание' " +
                "FROM Inventory " +
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

        // Метод для вывода всех записей в таблице Inventory и вывод их в датагрид
        public void SelectAllFields(DataGridView dataGridView)
        {
            DbConnect.Connect();

            string query = "SELECT inventory_id AS ' ', part_name AS 'Наименование', part_number AS 'Номер', quantity AS 'Количество', " +
                "price AS 'Стоимость', supplier AS 'Поставщик', notes AS 'Примечание' " +
                "FROM Inventory ";
            SQLiteCommand command = new SQLiteCommand(query, DbConnect.connection);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.RowHeadersVisible = false;

            DataGridViewColumn inventoryId = dataGridView.Columns[" "];
            DataGridViewColumn quantity = dataGridView.Columns["Количество"];
            DataGridViewColumn name = dataGridView.Columns["Наименование"];
            DataGridViewColumn price = dataGridView.Columns["Стоимость"];
            DataGridViewColumn supplier = dataGridView.Columns["Поставщик"];
            price.Width = 70;
            supplier.Width = 130;
            quantity.Width = 70;
            name.Width = 130;
            inventoryId.Width = 50;

            DbConnect.Disconnect();
        }

        public float getOldValuePrice(int inventoryId)
        {
            DbConnect.Connect();
            float oldValuePrice = 0;
            string query = $"SELECT price FROM Inventory " +
                $"WHERE inventory_id = {inventoryId} ";
            SQLiteCommand command = new SQLiteCommand(query, DbConnect.connection);
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        oldValuePrice = reader.GetFloat(0);
                    }
                }
            }
            DbConnect.Disconnect();
            return oldValuePrice;
        }

        public int getOldValueQuantity(int inventoryId)
        {
            DbConnect.Connect();
            int oldValueQuantity = 0;
            string query = $"SELECT quantity FROM Inventory " +
                $"WHERE inventory_id = {inventoryId} ";
            SQLiteCommand command = new SQLiteCommand(query, DbConnect.connection);
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        oldValueQuantity = Convert.ToInt32(reader.GetInt32(0));
                    }
                }
            }
            DbConnect.Disconnect();
            return oldValueQuantity;
        }

    }
}
