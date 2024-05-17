using AutoService.Classes;
using AutoService.Entity;
using AutoService.Interface;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace AutoService.RepositoryImpl
{
    public class MaintenanceScheduleImpl : Repository<MaintenanceSchedule>
    {
        // Метод для добавления записей в таблицу MaintenanceSchedule
        public void Add(MaintenanceSchedule entity)
        {
            DbConnect.Connect();
            try
            {
                var command = DbConnect.connection.CreateCommand();
                command.CommandText = "INSERT INTO MaintenanceSchedule (vehicle_id, last_service_date, next_service_date, service_type, " +
                    "notes) " +
                         "VALUES (@vehicle_id, @last_service_date, @next_service_date, @service_type, @notes)";
                command.Parameters.AddWithValue("@vehicle_id", entity.VehicleId);
                command.Parameters.AddWithValue("@last_service_date", entity.LastServiceDate);
                command.Parameters.AddWithValue("@next_service_date", entity.NextServiceDate);
                command.Parameters.AddWithValue("@service_type", entity.ServiceType);
                command.Parameters.AddWithValue("@notes", entity.Notes);
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Обслуживание успешно добавлено!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Произошла ошибка, обслуживание не добавлена!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } 
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DbConnect.Disconnect();
        }

        // Метод для удаления записей в таблицу MaintenanceSchedule
        public void Delete(int id)
        {
            DbConnect.Connect();

            var command = DbConnect.connection.CreateCommand();
            command.CommandText = "DELETE FROM MaintenanceSchedule " +
                "WHERE schedule_id = @id";
            command.Parameters.AddWithValue("@id", id);
            int rowsAffected = command.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Обслуживание успешно удалено!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Произошла ошибка, обслуживание не удалена!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DbConnect.Disconnect();
        }

        // Метод для обновления записей в таблице MaintenanceSchedule
        public void Update(MaintenanceSchedule entity)
        {
            DbConnect.Connect();

            var command = DbConnect.connection.CreateCommand();
            command.CommandText = "UPDATE MaintenanceSchedule SET vehicle_id = @vehicle_id, last_service_date = @last_service_date, " +
                "next_service_date = @next_service_date, service_type = @service_type, notes = @notes " +
                "WHERE schedule_id = @id";
            command.Parameters.AddWithValue("@vehicle_id", entity.VehicleId);
            command.Parameters.AddWithValue("@last_service_date", entity.LastServiceDate);
            command.Parameters.AddWithValue("@next_service_date", entity.NextServiceDate);
            command.Parameters.AddWithValue("@service_type", entity.ServiceType);
            command.Parameters.AddWithValue("@notes", entity.Notes);
            command.Parameters.AddWithValue("@id", entity.Id);
            int rowsAffected = command.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Обслуживание успешно изменено!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Произошла ошибка, обслуживание не изменено!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DbConnect.Disconnect();
        }

        // Метод для поиска записей в таблице MaintenanceSchedule и вывод их в датагрид
        public void SearchSelect(Control control, DataGridView dataGridView)
        {
            DbConnect.Connect();

            string search = $"%{control.Text}%";

            string query = "SELECT  schedule_id AS ' ', Vehicles.make AS 'Производитель', Vehicles.model 'Модель', Vehicles.vin AS 'VIN', " +
                "last_service_date AS 'Последняя дата обслуживания', next_service_date AS 'Следующая дата обслуживания', " +
                "service_type AS 'Тип услуги', MaintenanceSchedule.notes AS 'Примечание' " +
                "FROM MaintenanceSchedule " +
                "INNER JOIN Vehicles ON MaintenanceSchedule.vehicle_id = Vehicles.vehicle_id " +
                "WHERE service_type LIKE @search " +
                "OR MaintenanceSchedule.notes LIKE @search " +
                "OR Vehicles.make LIKE @search " +
                "OR Vehicles.model LIKE @search " +
                "OR Vehicles.vin LIKE @search";
            SQLiteCommand command = new SQLiteCommand(query, DbConnect.connection);
            command.Parameters.AddWithValue("@search", search);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.RowHeadersVisible = false;

            DataGridViewColumn scheduleId = dataGridView.Columns[" "];
            scheduleId.Width = 50;

            DbConnect.Disconnect();
        }

        // Метод для вывода всех записей в таблице MaintenanceSchedule и вывод их в датагрид
        public void SelectAllFields(DataGridView dataGridView)
        {
            DbConnect.Connect();

            string query = "SELECT  schedule_id AS ' ', Vehicles.make AS 'Производитель', Vehicles.model 'Модель', Vehicles.vin AS 'VIN', " +
                "last_service_date AS 'Последняя дата обслуживания', next_service_date AS 'Следующая дата обслуживания', " +
                "service_type AS 'Тип услуги', MaintenanceSchedule.notes AS 'Примечание' " +
                "FROM MaintenanceSchedule " +
                "INNER JOIN Vehicles ON MaintenanceSchedule.vehicle_id = Vehicles.vehicle_id ";
            SQLiteCommand command = new SQLiteCommand(query, DbConnect.connection);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.RowHeadersVisible = false;

            DataGridViewColumn scheduleId = dataGridView.Columns[" "];
            scheduleId.Width = 50;

            DbConnect.Disconnect();
        }
    }
}
        

