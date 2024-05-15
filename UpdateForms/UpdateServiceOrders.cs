using AutoService.Classes;
using AutoService.Entity;
using AutoService.Interface;
using AutoService.RepositoryImpl;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
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
            DateTime dateOrders = Convert.ToDateTime(DateOrder.Text);

            ServiceOrders serviceOrders = new ServiceOrders
            {
                Id = Convert.ToInt32(Order.SelectedValue),
                ClientId = Convert.ToInt32(Client.SelectedValue),
                VehicleId = Convert.ToInt32(Car.SelectedValue),
                OrderDate = dateOrders,
                ServiceType = ServiceType.Text,
                Status = Status.Text,
                EstimatedCost = float.Parse(Cost.Text),
                Notes = Notes.Text
            };

            return serviceOrders;
        }

        private void Order_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadElemntsToCombobox();
            DbConnect.Connect();
            string query = $"SELECT * FROM ServiceOrders " +
                $"WHERE order_id = {Convert.ToInt32(Order.Text)}";
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

                        Client.SelectedValue = clientId;
                        Car.SelectedValue = vehicleId;
                        DateOrder.Text = orderDate;
                        ServiceType.Text = serviceTypes;
                        Status.Text = statusStr;
                        Cost.Text = estimatedCost;
                        Notes.Text = notesStr;
                    }
                }
            }
            DbConnect.Disconnect();
        }

        private void Reload_Click(object sender, EventArgs e)
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
                Order.DataSource = orderList;
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
                Client.DataSource = new BindingSource(clientsDictionary, null);
                Client.DisplayMember = "Value";
                Client.ValueMember = "Key";
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
                Car.DataSource = new BindingSource(vehicleDictionary, null);
                Car.DisplayMember = "Value";
                Car.ValueMember = "Key";
            }
            DbConnect.Disconnect();
        }
    }
}
