using AutoService.AddForms;
using AutoService.Classes;
using AutoService.DeleteForms;
using AutoService.RepositoryImpl;
using AutoService.UpdateForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoService.MainForms
{
    public partial class Employee : Form
    {
        private EmployeeImpl employeeImpl = new EmployeeImpl();
        public Employee()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            employeeImpl.SelectAllFields(dataGridView1);
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            employeeImpl.SearchSelect(search, dataGridView1);
        }

        private void search_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(search);
        }

        private void reloadGrid_Click(object sender, EventArgs e)
        {
            employeeImpl.SelectAllFields(dataGridView1);
        }

        private void addValue_Click(object sender, EventArgs e)
        {
            OpenForms.OpenFormInNewWindow(new AddEmployee());
        }

        private void deleteValue_Click(object sender, EventArgs e)
        {
            OpenForms.OpenFormInNewWindow(new DeleteEmployees());
        }

        private void reloadValue_Click(object sender, EventArgs e)
        {
            OpenForms.OpenFormInNewWindow(new UpdateEmployee());
        }

        private void excelImport_Click(object sender, EventArgs e)
        {
            ExportExcelDataGridView.ExportExcel(dataGridView1);
        }

        
    }
}
