using AutoService.Classes;
using AutoService.Entity;
using AutoService.Interface;
using AutoService.RepositoryImpl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoService.UpdateForms
{
    public partial class UpdateServiceOrders : Form, LoadingElementsCombobox
    {
        private ServiceOrdersImpl serviceOrdersImpl = new ServiceOrdersImpl();
        private Dictionary<int, string> clientsDictionary = new Dictionary<int, string>();
        private Dictionary<int, string> vehicleDictionary = new Dictionary<int, string>();
        private List<int> orderList = new List<int>();
        public UpdateServiceOrders()
        {
            InitializeComponent();
        }

        private void UpdateServiceOrders_Load(object sender, EventArgs e)
        {
            LoadElemntsToCombobox();
        }

        public ServiceOrders InitializationServiceOrders()
        {
            DateTime dateOrders = Convert.ToDateTime(dateOrder.Text);

            ServiceOrders serviceOrders = new ServiceOrders
            {
                Id = Convert.ToInt32(order.SelectedValue),
                ClientId = Convert.ToInt32(client.SelectedValue),
                VehicleId = Convert.ToInt32(car.SelectedValue),
                OrderDate = dateOrders,
                ServiceType = serviceType.Text,
                Status = status.Text,
                EstimatedCost = float.Parse(cost.Text),
                Notes = notes.Text
            };

            return serviceOrders;
        }

        private void order_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadElemntsToCombobox();
            DbConnect.Connect();
            string query = $"SELECT * FROM ServiceOrders WHERE order_id = {Convert.ToInt32(order.Text)}";
            SQLiteCommand command = new SQLiteCommand(query, DbConnect.connection);
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int clientId = Convert.ToInt32(reader["client_id"]);
                        int vehicleId = Convert.ToInt32(reader["vehicle_id"]);
                        string orderDate = reader["order_date"].ToString();
                        string serviceTypes = reader["service_type"].ToString();
                        string statusStr = reader["status"].ToString();
                        string estimatedCost = reader["estimated_cost"].ToString();
                        string notesStr = reader["notes"].ToString();

                        client.SelectedValue = clientId;
                        car.SelectedValue = vehicleId;
                        dateOrder.Text = orderDate;
                        serviceType.Text = serviceTypes;
                        status.Text = statusStr;
                        cost.Text = estimatedCost;
                        notes.Text = notesStr;
                    }
                }
            }
            DbConnect.Disconnect();
        }

        private void reload_Click(object sender, EventArgs e)
        {
            serviceOrdersImpl.Update(InitializationServiceOrders());
        }

        public void LoadElemntsToCombobox()
        {
            DbConnect.Connect();
            string query = "SELECT order_id FROM ServiceOrders ";
            SQLiteCommand command = new SQLiteCommand(query, DbConnect.connection);
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    int orderId = reader.GetInt32(0);
                    orderList.Add(orderId);
                }
                order.DataSource = orderList;
            }
            DbConnect.Disconnect();

            DbConnect.Connect();
            clientsDictionary.Clear();
            string querySecond = "SELECT * FROM Clients ";
            SQLiteCommand commandSecond = new SQLiteCommand(querySecond, DbConnect.connection);
            using (SQLiteDataReader reader = commandSecond.ExecuteReader())
            {
                while (reader.Read())
                {
                    int clientId = reader.GetInt32(0);
                    string clientFullName = reader.GetString(1);
                    clientsDictionary.Add(clientId, clientFullName);
                }
                client.DataSource = new BindingSource(clientsDictionary, null);
                client.DisplayMember = "Value";
                client.ValueMember = "Key";
            }
            DbConnect.Disconnect();

            DbConnect.Connect();
            vehicleDictionary.Clear();
            string queryThird = "SELECT * FROM Vehicles ";
            SQLiteCommand commandThird = new SQLiteCommand(queryThird, DbConnect.connection);
            using (SQLiteDataReader reader = commandThird.ExecuteReader())
            {
                while (reader.Read())
                {
                    int vehicleId = reader.GetInt32(0);
                    string vehicleVin = reader.GetString(5);
                    vehicleDictionary.Add(vehicleId, vehicleVin);
                }
                car.DataSource = new BindingSource(vehicleDictionary, null);
                car.DisplayMember = "Value";
                car.ValueMember = "Key";
            }
            DbConnect.Disconnect();
        }
    }
}
