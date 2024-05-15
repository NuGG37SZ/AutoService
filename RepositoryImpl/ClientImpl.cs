using AutoService.Classes;
using AutoService.Entity;
using AutoService.Interface;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace AutoService.RepositoryImpl
{
    public class ClientImpl : Repository<Clients>
    {
        public void Add(Clients entity)
        {
            DbConnect.Connect();

            var command = DbConnect.connection.CreateCommand();
            command.CommandText = "INSERT INTO Clients (full_name, phone_number, email, address, notes) " +
                     "VALUES (@fullName, @phoneNumber, @email, @address, @notes)";
            command.Parameters.AddWithValue("@fullName", entity.FullName);
            command.Parameters.AddWithValue("@phoneNumber", entity.PhoneNumber);
            command.Parameters.AddWithValue("@email", entity.Email);
            command.Parameters.AddWithValue("@address", entity.Address);
            command.Parameters.AddWithValue("@notes", entity.Notes);
            int rowsAffected = command.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Клиент успешно добавлен!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Произошла ошибка клиент не добавлен!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DbConnect.Disconnect();
        }

        public void Delete(int id)
        {
            DbConnect.Connect();

            var command = DbConnect.connection.CreateCommand();
            command.CommandText = "DELETE FROM Clients WHERE client_id = @id";
            command.Parameters.AddWithValue("@id", id);
            int rowsAffected = command.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Клиент успешно удален!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Произошла ошибка, клиент не удален!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DbConnect.Disconnect();
        }

        public void Update(Clients entity)
        {
            DbConnect.Connect();

            var command = DbConnect.connection.CreateCommand();
            command.CommandText = "UPDATE Clients SET full_name = @fullName, phone_number = @phoneNumber, email = @email, address = @address, " +
                "notes = @notes " +
                "WHERE client_id = @id";
            command.Parameters.AddWithValue("@fullName", entity.FullName);
            command.Parameters.AddWithValue("@phoneNumber", entity.PhoneNumber);
            command.Parameters.AddWithValue("@email", entity.Email);
            command.Parameters.AddWithValue("@address", entity.Address);
            command.Parameters.AddWithValue("@notes", entity.Notes);
            command.Parameters.AddWithValue("@id", entity.Id);
            int rowsAffected = command.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Клиент успешно изменен!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Произошла ошибка, клиент не изменен!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DbConnect.Disconnect();
        }

        public void SearchSelect(Control control, DataGridView dataGridView)
        {
            DbConnect.Connect();

            string search = $"%{control.Text}%";

            string query = "SELECT client_id AS ' ', full_name AS 'ФИО', phone_number AS 'Номер телефона', " +
                "email AS 'Почта', address AS 'Адрес', notes AS 'Примечание' " +
                "FROM Clients " +
                "WHERE full_name LIKE @search " +
                "OR phone_number LIKE @search " +
                "OR email LIKE @search " +
                "OR address LIKE @search ";
            SQLiteCommand command = new SQLiteCommand(query, DbConnect.connection);
            command.Parameters.AddWithValue("@search", search);
            command.Parameters.AddWithValue("@search_full", control.Text);
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

            string query = "SELECT client_id AS ' ', full_name AS 'ФИО', phone_number AS 'Номер телефона', " +
                "email AS 'Почта', address AS 'Адрес', notes AS 'Примечание' " + 
                "FROM Clients";
            SQLiteCommand command = new SQLiteCommand(query, DbConnect.connection);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.RowHeadersVisible = false;

            DataGridViewColumn clientId = dataGridView.Columns[" "];
            DataGridViewColumn fullName = dataGridView.Columns["ФИО"];
            DataGridViewColumn notes = dataGridView.Columns["Примечание"];
            clientId.Width = 50;
            fullName.Width = 130;
            notes.Width = 120;

            DbConnect.Disconnect();
        }
    }
}
