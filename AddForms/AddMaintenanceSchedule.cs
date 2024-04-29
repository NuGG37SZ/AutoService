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
    public partial class AddMaintenanceSchedule : Form, LoadingElementsCombobox
    {
        private MaintenanceScheduleImpl maintenanceScheduleImpl = new MaintenanceScheduleImpl();
        private Dictionary<int, string> vehicleDictionary = new Dictionary<int, string>();
        private List<string> serviceTypeList = new List<string>();
        public AddMaintenanceSchedule()
        {
            InitializeComponent();
        }

        private void AddMaintenanceSchedule_Load(object sender, EventArgs e)
        {
            LoadElemntsToCombobox();
        }

        public MaintenanceSchedule InitializationMaintenanceSchedules()
        {
            
            DateTime lastServiceDates = Convert.ToDateTime(lastServiceDate.Text);
            DateTime nextServiceDates = Convert.ToDateTime(nextServiceDate.Text);

            MaintenanceSchedule maintenanceSchedules = new MaintenanceSchedule
            {
                VehicleId = Convert.ToInt32(car.SelectedValue),
                LastServiceDate = lastServiceDates,
                NextServiceDate = nextServiceDates,
                ServiceType = serviceType.Text,
                Notes = note.Text,
            };
            return maintenanceSchedules;
        }

        private void save_Click(object sender, EventArgs e)
        {
            maintenanceScheduleImpl.Add(InitializationMaintenanceSchedules());
        }

        private void lastServiceDate_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(lastServiceDate);
        }

        private void nextServiceDate_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(nextServiceDate);
        }

        private void note_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(note);
        }

        public void LoadElemntsToCombobox()
        {
            DbConnect.Connect();

            string query = "SELECT * FROM Vehicles ORDER BY vehicle_id ";
            SQLiteCommand command = new SQLiteCommand(query, DbConnect.connection);
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    int vehiclesId = reader.GetInt32(0);
                    string vehiclesVin = reader.GetString(5);
                    vehicleDictionary.Add(vehiclesId, vehiclesVin);
                }
                car.DataSource = new BindingSource(vehicleDictionary, null);
                car.DisplayMember = "Value";
                car.ValueMember = "Key";

                car.Text = "Автомобиль";
            }

            string querySecond = "SELECT DISTINCT service_type FROM ServiceOrders ";
            SQLiteCommand commandSecond = new SQLiteCommand(querySecond, DbConnect.connection);
            using (SQLiteDataReader reader = commandSecond.ExecuteReader())
            {
                while (reader.Read())
                {
                    string serviceTypeField = reader.GetString(0);
                    serviceTypeList.Add(serviceTypeField);
                }
                serviceType.DataSource = serviceTypeList;

                serviceType.Text = "Тип услуги";
            }

            DbConnect.Disconnect();
        }
    }
}
