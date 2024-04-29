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

        private void search_TextChanged(object sender, EventArgs e)
        {
            inventoryImpl.SearchSelect(search, dataGridView1);
        }

        private void search_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(search);
        }

        private void reloadGrid_Click(object sender, EventArgs e)
        {
            inventoryImpl.SelectAllFields(dataGridView1);
        }

        private void addValue_Click(object sender, EventArgs e)
        {
            OpenForms.OpenFormInNewWindow(new AddInventory());
        }

        private void deleteValue_Click(object sender, EventArgs e)
        {
            OpenForms.OpenFormInNewWindow(new DeleteInventory());
        }

        private void reloadValue_Click(object sender, EventArgs e)
        {
            OpenForms.OpenFormInNewWindow(new UpdateInventory());
        }

        private void excelImport_Click(object sender, EventArgs e)
        {
            ExportExcelDataGridView.ExportExcel(dataGridView1);
        }
    }
}
