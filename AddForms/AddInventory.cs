using AutoService.Classes;
using AutoService.Entity;
using AutoService.MainForms;
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

namespace AutoService.AddForms
{
    public partial class AddInventory : Form
    {
        private InventoryImpl inventoryImpl = new InventoryImpl();
        public AddInventory()
        {
            InitializeComponent();
        }

        public Inventory InitializationInventory()
        {
            Inventory inventory = new Inventory
            {
                PartName = partName.Text,
                PartNumber = partNumber.Text,
                Quantity = Convert.ToInt32(quantity.Text),
                Price = float.Parse(price.Text),
                Supplier = supplier.Text,
                Notes = note.Text
            };
            return inventory;
        }

        private void partName_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(partName);
        }

        private void partNumber_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(partNumber);
        }

        private void price_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(price);
        }

        private void quantity_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(quantity);
        }

        private void supplier_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(supplier);
        }

        private void note_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(note);
        }

        private void save_Click(object sender, EventArgs e)
        {
            inventoryImpl.Add(InitializationInventory());
        }
    }
}
