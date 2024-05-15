using AutoService.Classes;
using AutoService.Entity;
using AutoService.RepositoryImpl;
using System;
using System.Linq;
using System.Windows.Forms;

namespace AutoService.AddForms
{
    public partial class AddEmployee : Form
    {
        private EmployeeImpl employee = new EmployeeImpl();
        public AddEmployee()
        {
            InitializeComponent();
        }

        public Employees InitializationEmployees()
        {
            Employees employees = new Employees
            {
                FullName = FullName.Text,
                Position = Position.Text,
                PhoneNumber = PhoneNumber.Text,
                Email = Email.Text,
                Schedule = Schedule.Text,
                Skills = Skills.Text
            };
            return employees;
        }
        private void ClearTextBox(object sender, EventArgs e)
        {
            string name = (sender as Control).Name;
            Control control = this.Controls.Find(name, true).FirstOrDefault();
            control.Text = "";
        }

        private void Save_Click(object sender, EventArgs e)
        {
            employee.Add(InitializationEmployees());
        }
    }
}
