using AutoService.Classes;
using AutoService.RepositoryImpl;
using System;
using System.Windows.Forms;

namespace AutoService.DeleteForms
{
    public partial class DeleteInventory : Form
    {
        private InventoryImpl inventoryImpl = new InventoryImpl();
        public DeleteInventory()
        {
            InitializeComponent();
        }

        private void IdInventory_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(IdInventory);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            inventoryImpl.Delete(Convert.ToInt32(IdInventory.Text));
        }
    }
}
