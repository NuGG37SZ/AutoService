using AutoService.Classes;
using AutoService.Entity;
using AutoService.Interface;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace AutoService.RepositoryImpl
{
    public class EmployeeImpl : Repository<Employees>
    {
        public void Add(Employees entity)
        {
            DbConnect.Connect();
            var command = DbConnect.connection.CreateCommand();
            command.CommandText = "INSERT INTO Employees (full_name, position, phone_number, email, schedule, skills) " +
                     "VALUES (@full_name, @position, @phone_number, @email, @schedule, @skills)";
            command.Parameters.AddWithValue("@full_name", entity.FullName);
            command.Parameters.AddWithValue("@position", entity.Position);
            command.Parameters.AddWithValue("@phone_number", entity.PhoneNumber);
            command.Parameters.AddWithValue("@email", entity.Email);
            command.Parameters.AddWithValue("@schedule", entity.Schedule);
            command.Parameters.AddWithValue("@skills", entity.Skills);
            int rowsAffected = command.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Сотрудник успешно добавлен!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Произошла ошибка сотрудник не добавлен!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DbConnect.Disconnect();
        }

        public void Delete(int id)
        {
            DbConnect.Connect();

            var command = DbConnect.connection.CreateCommand();
            command.CommandText = "DELETE FROM Employees " +
                "WHERE employee_id = @id";
            command.Parameters.AddWithValue("@id", id);
            int rowsAffected = command.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Сотрудник успешно удален!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Произошла ошибка, сотрудник не удален!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DbConnect.Disconnect();
        }

        public void Update(Employees entity)
        {
            DbConnect.Connect();

            var command = DbConnect.connection.CreateCommand();
            command.CommandText = "UPDATE Employees SET full_name = @full_name, position = @position, phone_number = @phone_number, " +
                "email = @email, schedule = @schedule, skills = @skills " +
                "WHERE employee_id = @id";
            command.Parameters.AddWithValue("@full_name", entity.FullName);
            command.Parameters.AddWithValue("@position", entity.Position);
            command.Parameters.AddWithValue("@phone_number", entity.PhoneNumber);
            command.Parameters.AddWithValue("@email", entity.Email);
            command.Parameters.AddWithValue("@schedule", entity.Schedule);
            command.Parameters.AddWithValue("@skills", entity.Skills);
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

            string query = "SELECT employee_id AS ' ', full_name AS 'ФИО', position AS 'Должность', phone_number AS 'Номер телефона', " +
                "email AS 'Почта', schedule AS 'График работы', skills AS 'Навыки' " +
                "FROM Employees " +
                "WHERE full_name LIKE @search " +
                "OR position LIKE @search " +
                "OR phone_number LIKE @search " +
                "OR email LIKE @search " +
                "OR schedule LIKE @search " +
                "OR skills LIKE @search ";
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

            string query = "SELECT employee_id AS ' ', full_name AS 'ФИО', position AS 'Должность', phone_number AS 'Номер телефона', " +
                "email AS 'Почта', schedule AS 'График работы', skills AS 'Навыки' " +
                "FROM Employees";
            SQLiteCommand command = new SQLiteCommand(query, DbConnect.connection);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.RowHeadersVisible = false;

            DataGridViewColumn employeeId = dataGridView.Columns[" "];
            DataGridViewColumn fullName = dataGridView.Columns["ФИО"];
            employeeId.Width = 50;
            fullName.Width = 130;

            DbConnect.Disconnect();
        }
    }
}
