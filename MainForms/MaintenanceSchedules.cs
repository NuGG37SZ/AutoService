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
        private void search_TextChanged(object sender, EventArgs e)
        {
            maintenanceScheduleImpl.SearchSelect(search, dataGridView1);
        }

        private void search_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(search);
        }

        private void reloadGrid_Click(object sender, EventArgs e)
        {
            maintenanceScheduleImpl.SelectAllFields(dataGridView1);
        }

        private void addValue_Click(object sender, EventArgs e)
        {
            OpenForms.OpenFormInNewWindow(new AddMaintenanceSchedule());
        }

        private void deleteValue_Click(object sender, EventArgs e)
        {
            OpenForms.OpenFormInNewWindow(new DeleteMaintenanceSchedule());
        }

        private void reloadValue_Click(object sender, EventArgs e)
        {
            OpenForms.OpenFormInNewWindow(new UpdateMaintenanceSchedule());
        }

        private void excelImport_Click(object sender, EventArgs e)
        {
            ExportExcelDataGridView.ExportExcel(dataGridView1);
        }
    }
}
