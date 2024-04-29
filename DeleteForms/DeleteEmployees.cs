using AutoService.Classes;
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

namespace AutoService.DeleteForms
{
    public partial class DeleteEmployees : Form
    {
        private EmployeeImpl employeeImpl = new EmployeeImpl();
        public DeleteEmployees()
        {
            InitializeComponent();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            employeeImpl.Delete(Convert.ToInt32(idEmployees.Text));
        }

        private void idEmployees_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(idEmployees);
        }
    }
}
