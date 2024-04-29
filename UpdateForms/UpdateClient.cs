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

namespace AutoService.UpdateForms
{
    public partial class UpdateClient : Form, LoadingElementsCombobox
    {
        private ClientImpl clientsImpl = new ClientImpl();
        private List<int> clientsList = new List<int>();
        public UpdateClient()
        {
            InitializeComponent();
        }

        private void UpdateClient_Load(object sender, EventArgs e)
        {
            LoadElemntsToCombobox();
        }

        private void reload_Click(object sender, EventArgs e)
        {
            clientsImpl.Update(InitializationClient());
        }

        public Clients InitializationClient()
        {
            Clients clients = new Clients
            {
                Id = Convert.ToInt32(client.Text),
                FullName = fullName.Text,
                PhoneNumber = phoneNumber.Text,
                Address = address.Text,
                Email = email.Text,
                Notes = notes.Text
            };
            return clients;
        }

        private void client_SelectedValueChanged(object sender, EventArgs e)
        {
            DbConnect.Connect();
            string query = $"SELECT * FROM Clients WHERE client_id = {Convert.ToInt32(client.Text)}";
            SQLiteCommand command = new SQLiteCommand(query, DbConnect.connection);
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string fullNames = reader["full_name"].ToString();
                        string phoneNumbers = reader["phone_number"].ToString();
                        string emails = reader["email"].ToString();
                        string addressStr = reader["address"].ToString();
                        string notesStr = reader["notes"].ToString();

                        fullName.Text = fullNames;
                        phoneNumber.Text = phoneNumbers;
                        email.Text = emails;
                        address.Text = addressStr;
                        notes.Text = notesStr;
                    }
                }
            }
            DbConnect.Disconnect();
        }

        public void LoadElemntsToCombobox()
        {
            DbConnect.Connect();
            string querySecond = "SELECT client_id FROM Clients ";
            SQLiteCommand commandSecond = new SQLiteCommand(querySecond, DbConnect.connection);
            using (SQLiteDataReader reader = commandSecond.ExecuteReader())
            {
                while (reader.Read())
                {
                    int clientId = reader.GetInt32(0);
                    clientsList.Add(clientId);
                }
                client.DataSource = clientsList;
            }
            DbConnect.Disconnect();
        }
    }
}
