using AutoService.Classes;
using AutoService.Entity;
using AutoService.MainForms;
using AutoService.RepositoryImpl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                FullName = fullName.Text,
                Position = position.Text,
                PhoneNumber = phoneNumber.Text,
                Email = email.Text,
                Schedule = schedule.Text,
                Skills = skills.Text
            };
            return employees;
        }

        private void fullName_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(fullName);
        }

        private void position_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(position);
        }

        private void phoneNumber_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(phoneNumber);
        }

        private void email_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(email);
        }

        private void schedule_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(schedule);
        }

        private void skills_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(skills);
        }

        private void save_Click(object sender, EventArgs e)
        {
            employee.Add(InitializationEmployees());
        }
    }
}
