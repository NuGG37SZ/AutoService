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

            var command = DbConnect.connection.CreateCommand();
            command.CommandText = "DELETE FROM Finances WHERE transaction_id = @id";
            command.Parameters.AddWithValue("@id", id);
            int rowsAffected = command.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Операция успешно удалена!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Произошла ошибка, операция не удалена!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DbConnect.Disconnect();
        }

        public void Update(Finances entity)
        {
            DbConnect.Connect();

            var command = DbConnect.connection.CreateCommand();
            command.CommandText = "UPDATE Finances SET transaction_date = @transaction_date, transaction_type = @transaction_type," +
                " amount = @amount, description = @description WHERE transaction_id = @id";
            command.Parameters.AddWithValue("@transaction_date", entity.TransactionDate);
            command.Parameters.AddWithValue("@transaction_type", entity.TransactionType);
            command.Parameters.AddWithValue("@amount", entity.Amount);
            command.Parameters.AddWithValue("@description", entity.Description);
            command.Parameters.AddWithValue("@id", entity.Id);
            int rowsAffected = command.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Операция успешно изменена!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            DataGridViewColumn transactionDate = dataGridView.Columns["Дата транкзации"];
            DataGridViewColumn transactionType = dataGridView.Columns["Тип"];
            DataGridViewColumn amount = dataGridView.Columns["Сумма"];
            DataGridViewColumn description  = dataGridView.Columns["Описание"];
            description.Width = 190;
            amount.Width = 100;
            transactionType.Width = 130;
            transactionDate.Width = 130;
            transactionId.Width = 50;

            DbConnect.Disconnect();
        }


    }
}
