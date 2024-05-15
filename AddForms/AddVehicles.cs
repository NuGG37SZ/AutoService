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
    public partial class AddVehicles : Form, LoadingElementsCombobox
    {
        private VehiclesImpl vehiclesImpl = new VehiclesImpl();
        private Dictionary<int, string> clientsDictionary = new Dictionary<int, string>();
        public AddVehicles()
        {
            InitializeComponent();
        }

        private void AddVehicles_Load(object sender, EventArgs e)
        {
            LoadElemntsToCombobox();
        }

        public Vehicles InitializationVehicles()
        {
            Vehicles vehicles = new Vehicles
            {
                ClientId = Convert.ToInt32(Client.SelectedValue),
                Make = Make.Text,
                Model = Model.Text,
                Year = Convert.ToInt32(Year.Text),
                Vin = Vin.Text,
                Notes = Notes.Text
            };
            return vehicles;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            vehiclesImpl.Add(InitializationVehicles());
        }
        private void ClearTextBox(object sender, EventArgs e)
        {
            string name = (sender as Control).Name;
            Control control = this.Controls.Find(name, true).FirstOrDefault();
            control.Text = "";
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
                Client.DataSource = new BindingSource(clientsDictionary.ToList(), null);
                Client.DisplayMember = "Value"; 
                Client.ValueMember = "Key";
                Client.Text = "Клинеты";
            }

            DbConnect.Disconnect();
        }
    }
}
