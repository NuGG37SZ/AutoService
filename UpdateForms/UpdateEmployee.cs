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
                Id = Convert.ToInt32(employee.Text),
                FullName = fullName.Text,
                Position = position.Text,
                PhoneNumber = phoneNumber.Text,
                Email = email.Text,
                Schedule = schedule.Text,
                Skills = skills.Text
            };
            return employees;
        }

        private void reload_Click(object sender, EventArgs e)
        {
            employeeImpl.Update(InitializationEmployees());
        }

        private void employee_SelectedValueChanged(object sender, EventArgs e)
        {
            DbConnect.Connect();
            string query = $"SELECT * FROM Employees WHERE employee_id = {Convert.ToInt32(employee.Text)}";
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

                        fullName.Text = fullNames;
                        phoneNumber.Text = phoneNumbers;
                        position.Text = positions;
                        email.Text = emails;
                        schedule.Text = schedules;
                        skills.Text = skillStr;
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
                employee.DataSource = employeesList;
            }
            DbConnect.Disconnect();
        }
    }
}
