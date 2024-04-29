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
    public partial class UpdateMaintenanceSchedule : Form, LoadingElementsCombobox
    {
        private MaintenanceScheduleImpl maintenanceScheduleImpl = new MaintenanceScheduleImpl();
        private List<int> scheduleIdList = new List<int>();
        private List<string> serviceTypeList = new List<string>();
        private Dictionary<int, string> vehicleDictionary = new Dictionary<int, string>();
        public UpdateMaintenanceSchedule()
        {
            InitializeComponent();
        }

        private void UpdateMaintenanceSchedule_Load(object sender, EventArgs e)
        {
            LoadElemntsToCombobox();
        }

        public MaintenanceSchedule InitializationMaintenanceSchedules()
        {
            DateTime lastServiceDates = Convert.ToDateTime(lastServiceDate.Text);
            DateTime nextServiceDates = Convert.ToDateTime(nextServiceDate.Text);

            MaintenanceSchedule maintenanceSchedules = new MaintenanceSchedule
            {
                Id = Convert.ToInt32(schedule.SelectedValue),
                VehicleId = Convert.ToInt32(car.SelectedValue),
                LastServiceDate = lastServiceDates,
                NextServiceDate = nextServiceDates,
                ServiceType = serviceType.Text,
                Notes = notes.Text,
            };
            return maintenanceSchedules;
        }

        private void schedule_SelectedValueChanged(object sender, EventArgs e)
        {
            DbConnect.Connect();
            string query = $"SELECT * FROM MaintenanceSchedule WHERE schedule_id = {Convert.ToInt32(schedule.Text)}";
            SQLiteCommand command = new SQLiteCommand(query, DbConnect.connection);
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int vehicleId = Convert.ToInt32(reader["vehicle_id"]);
                        string lastServiceDates = reader["last_service_date"].ToString();
                        string nextServiceDates = reader["next_service_date"].ToString();
                        string serviceTypes = reader["service_type"].ToString();
                        string notesStr = reader["notes"].ToString();

                        car.SelectedValue = vehicleId;
                        lastServiceDate.Text = lastServiceDates;
                        nextServiceDate.Text = nextServiceDates;
                        serviceType.Text = serviceTypes;
                        notes.Text = notesStr;
                    }
                }
            }
            DbConnect.Disconnect();
        }

        private void reload_Click(object sender, EventArgs e)
        {
            maintenanceScheduleImpl.Update(InitializationMaintenanceSchedules());
        }

        public void LoadElemntsToCombobox()
        {
            DbConnect.Connect();
            string query = "SELECT vehicle_id, vin FROM Vehicles ";
            SQLiteCommand command = new SQLiteCommand(query, DbConnect.connection);
            using (SQLiteDataReader reader = command.ExecuteReader())
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
            }
            DbConnect.Disconnect();

            DbConnect.Connect();
            string querySecond = "SELECT DISTINCT service_type FROM ServiceOrders ";
            SQLiteCommand commandSecond = new SQLiteCommand(querySecond, DbConnect.connection);
            using (SQLiteDataReader reader = commandSecond.ExecuteReader())
            {
                while (reader.Read())
                {
                    string transactionType = reader.GetString(0);
                    serviceTypeList.Add(transactionType);
                }
                serviceType.DataSource = serviceTypeList;
            }
            DbConnect.Disconnect();

            DbConnect.Connect();
            string queryThird = "SELECT schedule_id FROM MaintenanceSchedule ";
            SQLiteCommand commandThird = new SQLiteCommand(queryThird, DbConnect.connection);
            using (SQLiteDataReader reader = commandThird.ExecuteReader())
            {
                while (reader.Read())
                {
                    int scheduleId = reader.GetInt32(0);
                    scheduleIdList.Add(scheduleId);
                }
                schedule.DataSource = scheduleIdList;
            }
            DbConnect.Disconnect();
        }
    }
}
