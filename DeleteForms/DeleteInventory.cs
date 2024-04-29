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
    public partial class DeleteInventory : Form
    {
        private InventoryImpl inventoryImpl = new InventoryImpl();
        public DeleteInventory()
        {
            InitializeComponent();
        }

        private void idInventory_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(idInventory);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            inventoryImpl.Delete(Convert.ToInt32(idInventory.Text));
        }
    }
}
