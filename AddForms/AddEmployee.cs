using AutoService.Classes;
using AutoService.Entity;
using AutoService.RepositoryImpl;
using System;
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

        private void FullName_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(FullName);
        }

        private void Position_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(Position);
        }

        private void PhoneNumber_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(PhoneNumber);
        }

        private void Email_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(Email);
        }

        private void Schedule_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(Schedule);
        }

        private void Skills_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(Skills);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            employee.Add(InitializationEmployees());
        }
    }
}
