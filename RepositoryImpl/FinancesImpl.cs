using AutoService.Classes;
using AutoService.Entity;
using AutoService.Interface;
using AutoService.MainForms;
using Guna.UI2.WinForms.Suite;
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
    public class FinancesImpl : Repository<Finances>
    {
        public void Add(Finances entity)
        {
            DbConnect.Connect();

            var command = DbConnect.connection.CreateCommand();
            command.CommandText = "INSERT INTO Finances (transaction_date, transaction_type, amount, description) " +
                     "VALUES (@transaction_date, @transaction_type, @amount, @description)";
            command.Parameters.AddWithValue("@transaction_date", entity.TransactionDate);
            command.Parameters.AddWithValue("@transaction_type", entity.TransactionType);
            command.Parameters.AddWithValue("@amount", entity.Amount);
            command.Parameters.AddWithValue("@description", entity.Description);
            int rowsAffected = command.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Операция успешно добавлена!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Произошла ошибка, операция не добавлена!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DbConnect.Disconnect();
        }

        public void Delete(int id)
        {
            DbConnect.Connect();

            string idStr = "";
            string querySelect = $"SELECT description FROM Finances WHERE transaction_id = {id} ";
            SQLiteCommand commandSelect = new SQLiteCommand(querySelect, DbConnect.connection);
            using (SQLiteDataReader reader = commandSelect.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string description = reader.GetString(0);

                        if (description.StartsWith("New order, number "))
                        {
                            idStr = getNumberFromString(description);
                        } 

                        if (description.StartsWith("New spare parts, number"))
                        {
                            idStr = getNumberFromString(description);
                        }
                    }
                }
            }

            int? inventoryId = null;
            if (!string.IsNullOrEmpty(idStr))
            {
                inventoryId = int.Parse(idStr);
            }

            int? orderId = null;
            if (!string.IsNullOrEmpty(idStr))
            {
                orderId = int.Parse(idStr);
            }

            using (SQLiteTransaction transaction = DbConnect.connection.BeginTransaction())
            {
                try
                {
                    var command = DbConnect.connection.CreateCommand();
                    command.CommandText = "DELETE FROM Finances WHERE transaction_id = @id";
                    command.Parameters.AddWithValue("@id", id);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Операция успешно удалена!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (orderId.HasValue)
                        {
                            string query = "DELETE FROM ServiceOrders WHERE order_id = @id";
                            SQLiteCommand commandDelete = new SQLiteCommand(query, DbConnect.connection);
                            commandDelete.Parameters.AddWithValue("@id", orderId.Value);
                            commandDelete.ExecuteNonQuery();
                        }

                        if (inventoryId.HasValue)
                        {
                            string query = "DELETE FROM Inventory WHERE inventory_id = @id";
                            SQLiteCommand commandDelete = new SQLiteCommand(query, DbConnect.connection);
                            commandDelete.Parameters.AddWithValue("@id", inventoryId.Value);
                            commandDelete.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Произошла ошибка, операция не удалена!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"Ошибка: {ex.Message}");
                }
            }
            DbConnect.Disconnect();
        }

        public void Update(Finances entity)
        {
            DbConnect.Connect();

            bool isSparePartsOrder = entity.Description.StartsWith("New spare parts, number");

            var command = DbConnect.connection.CreateCommand();
            command.CommandText = "UPDATE Finances SET transaction_date = @transaction_date, transaction_type = @transaction_type," +
                (isSparePartsOrder ? " description = @description" : " amount = @amount, description = @description") +
                " WHERE transaction_id = @id";

            command.Parameters.AddWithValue("@transaction_date", entity.TransactionDate);
            command.Parameters.AddWithValue("@transaction_type", entity.TransactionType);
            if (!isSparePartsOrder)
            {
                command.Parameters.AddWithValue("@amount", entity.Amount);
            }
            command.Parameters.AddWithValue("@description", entity.Description);
            command.Parameters.AddWithValue("@id", entity.Id);
            int rowsAffected = command.ExecuteNonQuery();

            if (entity.Description.StartsWith("New order, number "))
            {
                string idStr = getNumberFromString(entity.Description);
                int orderId = int.Parse(idStr);

                string updateQuery = $"UPDATE ServiceOrders SET estimated_cost = {entity.Amount} " +
                                $"WHERE order_id = {orderId}";
                SQLiteCommand commandUpdate = new SQLiteCommand(updateQuery, DbConnect.connection);
                commandUpdate.ExecuteNonQuery();
            }

            if (rowsAffected > 0)
            {
                if (isSparePartsOrder)
                {
                    MessageBox.Show("Операция успешна! Но цена не обновлена, так как эта транкзация на запчасти.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Операция успешно изменена!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Произошла ошибка, операция не изменена!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DbConnect.Disconnect();
        }


        public void SearchSelect(Control control, DataGridView dataGridView)
        {
            DbConnect.Connect();

            string search = $"%{control.Text}%";

            string query = "SELECT transaction_id AS ' ', transaction_date AS 'Дата транкзации', transaction_type AS 'Тип', " +
                "amount AS 'Сумма', description AS 'Описание' " +
                "FROM Finances " +
            "WHERE transaction_type LIKE @search " +
            "OR amount = @searchNumber OR amount LIKE @search " +
            "OR description LIKE @search ";
            SQLiteCommand command = new SQLiteCommand(query, DbConnect.connection);
            command.Parameters.AddWithValue("@search", search);
            command.Parameters.AddWithValue("@searchNumber", control.Text);

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

            string query = "SELECT transaction_id AS ' ', transaction_date AS 'Дата транкзации', transaction_type AS 'Тип', " +
                "amount AS 'Сумма', description AS 'Описание' " +
                "FROM Finances ";
            SQLiteCommand command = new SQLiteCommand(query, DbConnect.connection);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.RowHeadersVisible = false;

            DataGridViewColumn transactionId = dataGridView.Columns[" "];
            DataGridViewColumn transactionDates = dataGridView.Columns["Дата транкзации"];
            DataGridViewColumn transactionType = dataGridView.Columns["Тип"];
            DataGridViewColumn amount = dataGridView.Columns["Сумма"];
            DataGridViewColumn description  = dataGridView.Columns["Описание"];
            description.Width = 190;
            amount.Width = 100;
            transactionType.Width = 130;
            transactionDates.Width = 130;
            transactionId.Width = 50;

            DbConnect.Disconnect();
        }

        public string getNumberFromString(string str)
        {
            StringBuilder result = new StringBuilder();
            foreach (char c in str)
            {
                if (char.IsDigit(c))
                {
                    result.Append(c);
                }
            }
            return result.ToString();
        }
            
    }
}
