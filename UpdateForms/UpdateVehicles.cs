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
    public partial class UpdateVehicles : Form, LoadingElementsCombobox
    {
        private List<int> vehiclesList = new List<int>();
        private Dictionary<int, string> clientsDictionary = new Dictionary<int, string>();
        private VehiclesImpl vehiclesImpl = new VehiclesImpl();
        public UpdateVehicles()
        {
            InitializeComponent();
        }

        private void UpdateVehicles_Load(object sender, EventArgs e)
        {
            LoadElemntsToCombobox();
        }

        public Vehicles InitializationVehicles()
        {
            Vehicles vehicles = new Vehicles
            {
                Id = Convert.ToInt32(Vehicle.SelectedValue),
                ClientId = Convert.ToInt32(Client.SelectedValue),
                Make = Make.Text,
                Model = Model.Text,
                Year = Convert.ToInt32(Year.Text),
                Vin = Vin.Text,
                Notes = Notes.Text
            };
            return vehicles;
        }

        private void Vehicle_SelectedValueChanged(object sender, EventArgs e)
        {
            LoadElemntsToCombobox();
            DbConnect.Connect();
            string query = $"SELECT * FROM Vehicles " +
                $"WHERE vehicle_id = {Convert.ToInt32(Vehicle.Text)}";
            SQLiteCommand command = new SQLiteCommand(query, DbConnect.connection);
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int clientId = Convert.ToInt32(reader["client_id"]);
                        string makes = reader["make"].ToString();
                        string models = reader["model"].ToString();
                        string years = reader["year"].ToString();
                        string vins = reader["vin"].ToString();
                        string notesStr = reader["notes"].ToString();

                        Client.SelectedValue = clientId;
                        Make.Text = makes;
                        Model.Text = models;
                        Year.Text = years;
                        Vin.Text = vins;
                        Notes.Text = notesStr;
                    }
                }
            }
            DbConnect.Disconnect();
        }

        private void Reload_Click(object sender, EventArgs e)
        {
            vehiclesImpl.Update(InitializationVehicles());
        }

        public void LoadElemntsToCombobox()
        {
            DbConnect.Connect();
            string query = "SELECT vehicle_id FROM Vehicles ";
            SQLiteCommand command = new SQLiteCommand(query, DbConnect.connection);
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    int vehicleId = reader.GetInt32(0);
                    vehiclesList.Add(vehicleId);
                }
                Vehicle.DataSource = vehiclesList;
            }
            DbConnect.Disconnect();

            clientsDictionary.Clear();
            DbConnect.Connect();
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
        }
    }
}
