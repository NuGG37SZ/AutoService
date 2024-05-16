using AutoService.Entity;
using AutoService.RepositoryImpl;
using System;
using System.Linq;
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
            if (!float.TryParse(Price.Text, out float price) || !int.TryParse(Quantity.Text, out int quantity))
            {
                MessageBox.Show("Некорректные входные данные");
                return new Inventory();
            }

            Inventory inventory = new Inventory
            {
                PartName = PartName.Text,
                PartNumber = PartNumber.Text,
                Quantity = quantity,
                Price = price,
                Supplier = Supplier.Text,
                Notes = Notes.Text
            };
            return inventory;
        }
        private void ClearTextBox(object sender, EventArgs e)
        {
            string name = (sender as Control).Name;
            Control control = this.Controls.Find(name, true).FirstOrDefault();
            control.Text = "";
        }

        private void Save_Click(object sender, EventArgs e)
        {
            inventoryImpl.Add(InitializationInventory());
        }
    }
}
