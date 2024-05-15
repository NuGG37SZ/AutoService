using AutoService.Classes;
using AutoService.RepositoryImpl;
using System;
using System.Windows.Forms;

namespace AutoService.DeleteForms
{
    public partial class DeleteEmployees : Form
    {
        private EmployeeImpl employeeImpl = new EmployeeImpl();
        public DeleteEmployees()
        {
            InitializeComponent();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            employeeImpl.Delete(Convert.ToInt32(IdEmployees.Text));
        }

        private void IdEmployees_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(IdEmployees);
        }
    }
}
