using AutoService.AddForms;
using AutoService.Classes;
using AutoService.DeleteForms;
using AutoService.RepositoryImpl;
using AutoService.UpdateForms;
using System;
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

        private void Search_TextChanged(object sender, EventArgs e)
        {
            employeeImpl.SearchSelect(Search, dataGridView1);
        }

        private void Search_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(Search);
        }

        private void ReloadGrid_Click(object sender, EventArgs e)
        {
            Search.Text = "Поиск";
            employeeImpl.SelectAllFields(dataGridView1);
        }

        private void AddValue_Click(object sender, EventArgs e)
        {
            OpenForms.OpenFormInNewWindow(new AddEmployee());
        }

        private void DeleteValue_Click(object sender, EventArgs e)
        {
            OpenForms.OpenFormInNewWindow(new DeleteEmployees());
        }

        private void ReloadValue_Click(object sender, EventArgs e)
        {
            OpenForms.OpenFormInNewWindow(new UpdateEmployee());
        }

        private void ExcelImport_Click(object sender, EventArgs e)
        {
            ExportExcelDataGridView.ExportExcel(dataGridView1);
        }

        
    }
}
