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
    public partial class UpdateEmployee : Form, LoadingElementsCombobox
    {
        private EmployeeImpl employeeImpl = new EmployeeImpl();
        private List<int> employeesList = new List<int>();
        public UpdateEmployee()
        {
            InitializeComponent();
        }

        private void UpdateEmployee_Load(object sender, EventArgs e)
        {
            LoadElemntsToCombobox();
        }
        public Employees InitializationEmployees()
        {
            Employees employees = new Employees
            {
                Id = Convert.ToInt32(Employee.Text),
                FullName = FullName.Text,
                Position = Position.Text,
                PhoneNumber = PhoneNumber.Text,
                Email = Email.Text,
                Schedule = Schedule.Text,
                Skills = Skills.Text
            };
            return employees;
        }

        private void Reload_Click(object sender, EventArgs e)
        {
            employeeImpl.Update(InitializationEmployees());
        }

        private void Employee_SelectedValueChanged(object sender, EventArgs e)
        {
            DbConnect.Connect();
            string query = $"SELECT * FROM Employees WHERE employee_id = {Convert.ToInt32(Employee.Text)}";
            SQLiteCommand command = new SQLiteCommand(query, DbConnect.connection);
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string fullNames = reader["full_name"].ToString();
                        string positions = reader["position"].ToString();
                        string phoneNumbers = reader["phone_number"].ToString();
                        string emails = reader["email"].ToString();
                        string schedules = reader["schedule"].ToString();
                        string skillStr = reader["skills"].ToString();

                        FullName.Text = fullNames;
                        PhoneNumber.Text = phoneNumbers;
                        Position.Text = positions;
                        Email.Text = emails;
                        Schedule.Text = schedules;
                        Skills.Text = skillStr;
                    }
                }
            }
            DbConnect.Disconnect();
        }

        public void LoadElemntsToCombobox()
        {
            DbConnect.Connect();
            string query = "SELECT employee_id FROM Employees ";
            SQLiteCommand command = new SQLiteCommand(query, DbConnect.connection);
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    int employeeId = reader.GetInt32(0);
                    employeesList.Add(employeeId);
                }
                Employee.DataSource = employeesList;
            }
            DbConnect.Disconnect();
        }
    }
}
