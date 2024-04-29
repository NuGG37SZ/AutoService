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
    public class ServiceOrdersImpl : Repository<ServiceOrders>
    {
        public void Add(ServiceOrders entity)
        {
            try
            {
                int maxId = getMaxId();
                DbConnect.Connect();
                var command = DbConnect.connection.CreateCommand();
                command.CommandText = "INSERT INTO ServiceOrders (client_id, vehicle_id, order_date, service_type, `status`, estimated_cost, notes) " +
                         "VALUES (@client_id, @vehicle_id, @order_date, @service_type, @status, @estimated_cost, @notes)";
                command.Parameters.AddWithValue("@client_id", entity.ClientId);
                command.Parameters.AddWithValue("@vehicle_id", entity.VehicleId);
                command.Parameters.AddWithValue("@order_date", entity.OrderDate);
                command.Parameters.AddWithValue("@service_type", entity.ServiceType);
                command.Parameters.AddWithValue("@status", entity.Status);
                command.Parameters.AddWithValue("@estimated_cost", entity.EstimatedCost);
                command.Parameters.AddWithValue("@notes", entity.Notes);
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Заказ успешно добавлен!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Произошла ошибка, заказ не добавлен!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                string insertFinanceQuery = "INSERT INTO Finances (transaction_date, transaction_type, amount, description) " +
                    "VALUES (@transaction_date, @transaction_type, @amount, @description)";
                SQLiteCommand commandInsertFinance = new SQLiteCommand(insertFinanceQuery, DbConnect.connection);
                commandInsertFinance.Parameters.AddWithValue("@transaction_date", DateTime.Now);
                commandInsertFinance.Parameters.AddWithValue("@transaction_type", "Entering");
                commandInsertFinance.Parameters.AddWithValue("@amount", entity.EstimatedCost);
                commandInsertFinance.Parameters.AddWithValue("@description", $"New order, number {maxId}");
                commandInsertFinance.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show($"Ошибка SQLite при добавлении записи в ServiceOrders: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
            command.CommandText = "DELETE FROM ServiceOrders WHERE order_id = @id";
            command.Parameters.AddWithValue("@id", id);
            int rowsAffected = command.ExecuteNonQuery();

            var commandDelete = DbConnect.connection.CreateCommand();
            commandDelete.CommandText = $"DELETE FROM Finances WHERE description = 'New order, number number {id}'";
            commandDelete.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Заказ успешно удален!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Произошла ошибка, заказ не удален!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DbConnect.Disconnect();
        }

        public void Update(ServiceOrders entity)
        {
            DbConnect.Connect();

            var command = DbConnect.connection.CreateCommand();
            command.CommandText = "UPDATE ServiceOrders SET client_id = @client_id, vehicle_id = @vehicle_id, order_date = @order_date, " +
                "service_type = @service_type, status = @status, estimated_cost = @estimated_cost, notes = @notes  WHERE order_id = @id";

            command.Parameters.AddWithValue("@client_id", entity.ClientId);
            command.Parameters.AddWithValue("@vehicle_id", entity.VehicleId);
            command.Parameters.AddWithValue("@order_date", entity.OrderDate);
            command.Parameters.AddWithValue("@service_type", entity.ServiceType);
            command.Parameters.AddWithValue("@status", entity.Status);
            command.Parameters.AddWithValue("@estimated_cost", entity.EstimatedCost);
            command.Parameters.AddWithValue("@notes", entity.Notes);
            command.Parameters.AddWithValue("@id", entity.Id);
            int rowsAffected = command.ExecuteNonQuery();

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

            string query = "SELECT ServiceOrders.order_id AS ' ', Clients.full_name AS 'ФИО', " +
            "Vehicles.make AS 'Производитель', Vehicles.model AS 'Модель', Vehicles.Vin AS 'VIN', ServiceOrders.order_date AS 'Дата заказа', " +
            "ServiceOrders.service_type AS 'Тип услуги', ServiceOrders.status AS 'Статус', ServiceOrders.estimated_cost AS 'Стоимость' " +
            "FROM ServiceOrders " +
            "INNER JOIN Vehicles ON ServiceOrders.vehicle_id = Vehicles.vehicle_id " +
            "INNER JOIN Clients ON ServiceOrders.client_id = Clients.client_id " +
            "WHERE Clients.full_name LIKE @search " +
            "OR Vehicles.make LIKE @search " +
            "OR Vehicles.model LIKE @search " +
            "OR Vehicles.Vin LIKE @search " +
            "OR ServiceOrders.service_type LIKE @search " +
            "OR ServiceOrders.status LIKE @search";
            SQLiteCommand command = new SQLiteCommand(query, DbConnect.connection);
            command.Parameters.AddWithValue("@search", search);
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

            string query = "SELECT ServiceOrders.order_id AS ' ', Clients.full_name AS 'ФИО', " +
            "Vehicles.make AS 'Производитель', Vehicles.model AS 'Модель', Vehicles.Vin AS 'VIN', ServiceOrders.order_date AS 'Дата заказа', " +
            "ServiceOrders.service_type AS 'Тип услуги', ServiceOrders.status AS 'Статус', ServiceOrders.estimated_cost AS 'Стоимость' " +
            "FROM ServiceOrders " +
            "INNER JOIN Vehicles ON ServiceOrders.vehicle_id = Vehicles.vehicle_id " +
            "INNER JOIN Clients ON ServiceOrders.client_id = Clients.client_id";
            SQLiteCommand command = new SQLiteCommand(query, DbConnect.connection);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.RowHeadersVisible = false;

            DataGridViewColumn ordersId = dataGridView.Columns[" "];
            ordersId.Width = 50;

            DbConnect.Disconnect();
        }

        public int getMaxId()
        {
            int orderId = 0;
            string query = "SELECT MAX(order_id) FROM ServiceOrders";
            SQLiteCommand command = new SQLiteCommand(query, DbConnect.connection);
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    orderId = reader.GetInt32(0);
                }
            }
            return orderId;
        }
    }
}
