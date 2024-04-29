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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                ClientId = Convert.ToInt32(client.SelectedValue),
                Make = make.Text,
                Model = model.Text,
                Year = Convert.ToInt32(year.Text),
                Vin = vin.Text,
                Notes = notes.Text
            };
            return vehicles;
        }

        private void save_Click(object sender, EventArgs e)
        {
            vehiclesImpl.Add(InitializationVehicles());
        }

        private void make_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(make);
        }

        private void model_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(model);
        }

        private void year_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(year);
        }

        private void vin_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(vin);
        }

        private void notes_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(notes);
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
                client.DataSource = new BindingSource(clientsDictionary.ToList(), null);
                client.DisplayMember = "Value"; 
                client.ValueMember = "Key";
                client.Text = "Клинеты";
            }

            DbConnect.Disconnect();
        }
    }
}
