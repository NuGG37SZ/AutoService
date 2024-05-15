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

            DateTime dateOrders = Convert.ToDateTime(OrderDate.Text);

            ServiceOrders serviceOrders = new ServiceOrders
            {
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

        private void client_SelectedValueChanged(object sender, EventArgs e)
        {
            DbConnect.Connect();
            string query = "SELECT vin FROM Vehicles WHERE client_id = @client_id";
            SQLiteCommand command = new SQLiteCommand(query, DbConnect.connection);
            string[] values = Client.SelectedValue.ToString().Split(',');
            int clientId = Convert.ToInt32(values[0].Trim().Replace('[', ' '));
            Car.Items.Clear();
            command.Parameters.AddWithValue("@client_id", clientId);
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    string vin = reader["vin"].ToString();
                    Car.Items.Add(vin);
                }
            }
            DbConnect.Disconnect();
        }
    }
}

