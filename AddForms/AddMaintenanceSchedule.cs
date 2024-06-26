﻿using AutoService.Classes;
using AutoService.Entity;
using AutoService.Interface;
using AutoService.MainForms;
using AutoService.RepositoryImpl;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
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
            if (!int.TryParse(Car.SelectedValue.ToString(), out int vehicleId) || 
                !DateTime.TryParse(LastServiceDate.Text, out DateTime lastServiceDates) ||
                !DateTime.TryParse(NextServiceDate.Text, out DateTime nextServiceDates))
            {
                MessageBox.Show("Некорректные входные данные");
                return new MaintenanceSchedule();
            }

            MaintenanceSchedule maintenanceSchedules = new MaintenanceSchedule
            {
                VehicleId = vehicleId,
                LastServiceDate = lastServiceDates,
                NextServiceDate = nextServiceDates,
                ServiceType = ServiceType.Text,
                Notes = Notes.Text,
            };
            return maintenanceSchedules;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            maintenanceScheduleImpl.Add(InitializationMaintenanceSchedules());
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

            string query = "SELECT * FROM Vehicles " +
                "ORDER BY vehicle_id ";
            SQLiteCommand command = new SQLiteCommand(query, DbConnect.connection);
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    int vehiclesId = reader.GetInt32(0);
                    string vehiclesVin = reader.GetString(5);
                    vehicleDictionary.Add(vehiclesId, vehiclesVin);
                }
                Car.DataSource = new BindingSource(vehicleDictionary, null);
                Car.DisplayMember = "Value";
                Car.ValueMember = "Key";
                Car.Text = "Автомобиль";
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
                ServiceType.DataSource = serviceTypeList;

                ServiceType.Text = "Тип услуги";
            }
            DbConnect.Disconnect();
        }
    }
}
