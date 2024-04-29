using AutoService.Classes;
using AutoService.Entity;
using AutoService.Interface;
using AutoService.MainForms;
using AutoService.RepositoryImpl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoService.AddForms
{
    public partial class AddServiceOrders : Form, LoadingElementsCombobox
    {
        private ServiceOrdersImpl serviceOrdersImpl = new ServiceOrdersImpl();
        private Dictionary<int, string> clientsDictionary = new Dictionary<int, string>();
        private Dictionary<int, string> vehicleDictionary = new Dictionary<int, string>();
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

            DateTime dateOrders = Convert.ToDateTime(orderDate.Text);

            ServiceOrders serviceOrders = new ServiceOrders
            {
                ClientId = Convert.ToInt32(client.SelectedValue),
                VehicleId = Convert.ToInt32(car.SelectedValue),
                OrderDate = dateOrders,
                ServiceType = serviceType.Text,
                Status = status.Text,
                EstimatedCost = float.Parse(cost.Text),
                Notes = note.Text
            };
            return serviceOrders;
        }

        private void orderDate_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(orderDate);
        }

        private void serviceType_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(serviceType);
        }

        private void status_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(status);
        }

        private void cost_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(cost);
        }

        private void note_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(note);
        }

        private void save_Click(object sender, EventArgs e)
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
                client.DataSource = new BindingSource(clientsDictionary, null);
                client.DisplayMember = "Value";
                client.ValueMember = "Key";

                client.Text = "Клиент";
            }


            string querySecond = "SELECT vehicle_id, vin FROM Vehicles ";

            SQLiteCommand commandSecond = new SQLiteCommand(querySecond, DbConnect.connection);
            using (SQLiteDataReader reader = commandSecond.ExecuteReader())
            {
                while (reader.Read())
                {
                    int vehicleId = reader.GetInt32(0);
                    string vehicleVin = reader.GetString(1);
                    vehicleDictionary.Add(vehicleId, vehicleVin);
                }
                car.DataSource = new BindingSource(vehicleDictionary, null);
                car.DisplayMember = "Value";
                car.ValueMember = "Key";

                car.Text = "Автомобиль";
            }

            DbConnect.Disconnect();
        }
    }
}

