using AutoService.AddForms;
using AutoService.Classes;
using AutoService.DeleteForms;
using AutoService.RepositoryImpl;
using AutoService.UpdateForms;
using System;
using System.Windows.Forms;

namespace AutoService.MainForms
{
    public partial class MaintenanceSchedules : Form
    {
        private MaintenanceScheduleImpl maintenanceScheduleImpl = new MaintenanceScheduleImpl();
        public MaintenanceSchedules()
        {
            InitializeComponent();
        }

        private void MaintenanceSchedule_Load(object sender, EventArgs e)
        {
            maintenanceScheduleImpl.SelectAllFields(dataGridView1);
        }
        private void Search_TextChanged(object sender, EventArgs e)
        {
            maintenanceScheduleImpl.SearchSelect(Search, dataGridView1);
        }

        private void Search_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(Search);
        }

        private void ReloadGrid_Click(object sender, EventArgs e)
        {
            Search.Text = "Поиск";
            maintenanceScheduleImpl.SelectAllFields(dataGridView1);
        }

        private void AddValue_Click(object sender, EventArgs e)
        {
            OpenForms.OpenFormInNewWindow(new AddMaintenanceSchedule());
        }

        private void DeleteValue_Click(object sender, EventArgs e)
        {
            OpenForms.OpenFormInNewWindow(new DeleteMaintenanceSchedule());
        }

        private void ReloadValue_Click(object sender, EventArgs e)
        {
            OpenForms.OpenFormInNewWindow(new UpdateMaintenanceSchedule());
        }

        private void ExcelImport_Click(object sender, EventArgs e)
        {
            ExportExcelDataGridView.ExportExcel(dataGridView1);
        }
    }
}
