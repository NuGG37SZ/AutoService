using AutoService.Classes;
using AutoService.Entity;
using AutoService.RepositoryImpl;
using System;
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
                PartName = PartName.Text,
                PartNumber = PartNumber.Text,
                Quantity = Convert.ToInt32(Quantity.Text),
                Price = float.Parse(Price.Text),
                Supplier = Supplier.Text,
                Notes = Notes.Text
            };
            return inventory;
        }

        private void PartName_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(PartName);
        }

        private void PartNumber_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(PartNumber);
        }

        private void Price_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(Price);
        }

        private void Quantity_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(Quantity);
        }

        private void Supplier_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(Supplier);
        }

        private void Notes_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(Notes);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            inventoryImpl.Add(InitializationInventory());
        }
    }
}
