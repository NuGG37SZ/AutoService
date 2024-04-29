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
    public class VehiclesImpl : Repository<Vehicles>
    {
        public void Add(Vehicles entity)
        {
            DbConnect.Connect();

            var command = DbConnect.connection.CreateCommand();
            command.CommandText = "INSERT INTO Vehicles (client_id, make, model, `year`, vin, notes) " +
                     "VALUES (@client_id, @make, @model, @year, @vin, @notes)";
            command.Parameters.AddWithValue("@client_id", entity.ClientId);
            command.Parameters.AddWithValue("@make", entity.Make);
            command.Parameters.AddWithValue("@model", entity.Model);
            command.Parameters.AddWithValue("@year", entity.Year);
            command.Parameters.AddWithValue("@vin", entity.Vin);
            command.Parameters.AddWithValue("@notes", entity.Notes);
            int rowsAffected = command.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Автомобиль успешно добавлен!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Произошла ошибка, автомобиль не добавлен!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DbConnect.Disconnect();
        }

        public void Delete(int id)
        {
            DbConnect.Connect();

            var command = DbConnect.connection.CreateCommand();
            command.CommandText = "DELETE FROM Vehicles WHERE vehicle_id = @id";
            command.Parameters.AddWithValue("@id", id);
            int rowsAffected = command.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Автомобиль успешно удален!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Произошла ошибка, автомобиль не удален!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DbConnect.Disconnect();
        }

        public void Update(Vehicles entity)
        {
            DbConnect.Connect();

            var command = DbConnect.connection.CreateCommand();
            command.CommandText = "UPDATE Vehicles SET client_id = @client_id, make = @make, model = @model, " +
                "`year` = @year, vin = @vin, notes = @notes  WHERE vehicle_id = @id";
            command.Parameters.AddWithValue("@client_id", entity.ClientId);
            command.Parameters.AddWithValue("@make", entity.Make);
            command.Parameters.AddWithValue("@model", entity.Model);
            command.Parameters.AddWithValue("@year", entity.Year);
            command.Parameters.AddWithValue("@vin", entity.Vin);
            command.Parameters.AddWithValue("@notes", entity.Notes);
            command.Parameters.AddWithValue("@id", entity.Id);
            int rowsAffected = command.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Автомобиль успешно изменен!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Произошла ошибка, автомобиль не изменен!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DbConnect.Disconnect();
        }

        public void SearchSelect(Control control, DataGridView dataGridView)
        {
            DbConnect.Connect();

            string search = $"%{control.Text}%";

            string query = "SELECT vehicle_id AS ' ', Clients.full_name 'ФИО', make AS 'Производитель', model AS 'Модель', " +
                "year AS 'Год', vin 'VIN', Vehicles.notes AS 'Примечание' " +
                "FROM Vehicles " +
                "INNER JOIN Clients ON Vehicles.client_id = Clients.client_id " +
                "WHERE make LIKE @search " +
                "OR model LIKE @search " +
                "OR vin LIKE @search " +
                "OR Clients.full_name LIKE @search ";
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

            string query = "SELECT vehicle_id AS ' ', Clients.full_name 'ФИО', make AS 'Производитель', model AS 'Модель', " +
                "year AS 'Год', vin 'VIN', Vehicles.notes AS 'Примечание' " +
                "FROM Vehicles " +
                "INNER JOIN Clients ON Vehicles.client_id = Clients.client_id ";
            SQLiteCommand command = new SQLiteCommand(query, DbConnect.connection);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.RowHeadersVisible = false;

            DataGridViewColumn vehicleId = dataGridView.Columns[" "];
            DataGridViewColumn fullName = dataGridView.Columns["ФИО"];
            vehicleId.Width = 50;
            fullName.Width = 130;

            DbConnect.Disconnect();
        }
    }
}
