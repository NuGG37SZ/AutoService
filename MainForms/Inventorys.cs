using AutoService.AddForms;
using AutoService.Classes;
using AutoService.DeleteForms;
using AutoService.RepositoryImpl;
using AutoService.UpdateForms;
using System;
using System.Windows.Forms;

namespace AutoService.MainForms
{
    public partial class Inventorys : Form
    {
        private InventoryImpl inventoryImpl = new InventoryImpl();
        public Inventorys()
        {
            InitializeComponent();
        }

        private void Inventorys_Load(object sender, EventArgs e)
        {
            inventoryImpl.SelectAllFields(dataGridView1);
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            inventoryImpl.SearchSelect(Search, dataGridView1);
        }

        private void Search_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(Search);
        }

        private void ReloadGrid_Click(object sender, EventArgs e)
        {
            Search.Text = "Поиск";
            inventoryImpl.SelectAllFields(dataGridView1);
        }

        private void AddValue_Click(object sender, EventArgs e)
        {
            OpenForms.OpenFormInNewWindow(new AddInventory());
        }

        private void DeleteValue_Click(object sender, EventArgs e)
        {
            OpenForms.OpenFormInNewWindow(new DeleteInventory());
        }

        private void ReloadValue_Click(object sender, EventArgs e)
        {
            OpenForms.OpenFormInNewWindow(new UpdateInventory());
        }

        private void ExcelImport_Click(object sender, EventArgs e)
        {
            ExportExcelDataGridView.ExportExcel(dataGridView1);
        }
    }
}
