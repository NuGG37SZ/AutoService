using AutoService.AddForms;
using AutoService.Classes;
using AutoService.DeleteForms;
using AutoService.RepositoryImpl;
using AutoService.UpdateForms;
using System;
using System.Windows.Forms;

namespace AutoService.MainForms
{
    public partial class Vehicle : Form
    {
        private VehiclesImpl vehiclesImpl = new VehiclesImpl();
        public Vehicle()
        {
            InitializeComponent();
        }

        private void Vehicle_Load(object sender, EventArgs e)
        {
            vehiclesImpl.SelectAllFields(dataGridView1);
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            vehiclesImpl.SearchSelect(Search, dataGridView1);
        }

        private void Search_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(Search);
        }

        private void ReloadGrid_Click(object sender, EventArgs e)
        {
            Search.Text = "Поиск";
            vehiclesImpl.SelectAllFields(dataGridView1);
        }

        private void AddValue_Click(object sender, EventArgs e)
        {
            OpenForms.OpenFormInNewWindow(new AddVehicles());
        }

        private void DeleteValue_Click(object sender, EventArgs e)
        {
            OpenForms.OpenFormInNewWindow(new DeleteVehicles());
        }

        private void ReloadValue_Click(object sender, EventArgs e)
        {
            OpenForms.OpenFormInNewWindow(new UpdateVehicles());
        }

        private void ExcelImport_Click(object sender, EventArgs e)
        {
            ExportExcelDataGridView.ExportExcel(dataGridView1);
        }
    }
}
