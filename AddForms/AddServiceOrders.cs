using AutoService.Classes;
using AutoService.Entity;
using AutoService.Interface;
using AutoService.RepositoryImpl;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;

namespace AutoService.AddForms
{
    public partial class AddServiceOrders : Form, LoadingElementsCombobox
    {
        private ServiceOrdersImpl serviceOrdersImpl = new ServiceOrdersImpl();
        private Dictionary<int, string> clientsDictionary = new Dictionary<int, string>();
        private Dictionary<int, string> vehiclesDictionary = new Dictionary<int, string>();
        public AddServiceOrders()
        {
            InitializeComponent();
        }

        private void AddServiceOrders_Load(object sender, EventArgs e)
        {
            LoadElemntsToCombobox();
        }

        public ServiceOrders InitializationServiceOrders()
        {
            if (!int.TryParse(Client.SelectedValue.ToString(), out int clientId) ||
                !int.TryParse(Car.SelectedValue.ToString(), out int vehicleId) ||
                 !float.TryParse(Cost.Text, out float cost) ||
                 DateTime.TryParse(OrderDate.Text, out DateTime dateOrders))
            {
                MessageBox.Show("Некорректные входные данные");
                return new ServiceOrders();
            }

            ServiceOrders serviceOrders = new ServiceOrders
            {
                ClientId = clientId,
                VehicleId = vehicleId,
                OrderDate = dateOrders,
                ServiceType = ServiceType.Text,
                Status = Status.Text,
                EstimatedCost = cost,
                Notes = Notes.Text
            };
            return serviceOrders;
        }

        private void ClearTextBox(object sender, EventArgs e)
        {
            string name = (sender as Control).Name;
            Control control = this.Controls.Find(name, true).FirstOrDefault();
            control.Text = "";
        }

        private void Save_Click(object sender, EventArgs e)
        {
            serviceOrdersImpl.Add(InitializationServiceOrders());
        }

        public void LoadElemntsToCombobox()
        {
            DbConnect.Connect();

            string query = "SELECT client_id, full_name FROM Clients ";
            SQLiteCommand command = new SQLiteCommand(query, DbConnect.connection);
            using (SQLiteDataReader reader = command.ExecuteReader())
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
                Client.Text = "Клиент";
            }
            DbConnect.Disconnect();
        }

        private void Client_SelectedValueChanged(object sender, EventArgs e)
        {
            DbConnect.Connect();
            string query = "SELECT vehicle_id, vin FROM Vehicles " +
                "WHERE client_id = @client_id";
            SQLiteCommand command = new SQLiteCommand(query, DbConnect.connection);
            string[] values = Client.SelectedValue.ToString().Split(',');
            int clientId = Convert.ToInt32(values[0].Trim().Replace("[", ""));
            command.Parameters.AddWithValue("@client_id", clientId);
            vehiclesDictionary.Clear();
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    string vin = reader["vin"].ToString();
                    int id = Convert.ToInt32(reader["vehicle_id"]);
                    if (vehiclesDictionary.ContainsKey(id))
                    {
                        vehiclesDictionary[id] = vin;
                    }
                    else
                    {
                        vehiclesDictionary.Add(id, vin);
                    }         
                }
                Car.DataSource = new BindingSource(vehiclesDictionary, null);
                Car.DisplayMember = "Value";
                Car.ValueMember = "Key";
                Car.Text = "Автомобиль";
            }
            DbConnect.Disconnect();
        }
    }
}

