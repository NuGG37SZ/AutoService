using AutoService.Classes;
using AutoService.Entity;
using AutoService.Interface;
using AutoService.RepositoryImpl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoService.UpdateForms
{
    public partial class UpdateInventory : Form, LoadingElementsCombobox
    {
        private InventoryImpl inventoryImpl = new InventoryImpl();
        private List<int> inventoryList = new List<int>();
        public UpdateInventory()
        {
            InitializeComponent();
        }
        private void UpdateInventory_Load(object sender, EventArgs e)
        {
            LoadElemntsToCombobox();
        }

        public Inventory InitializationInventory()
        {
            Inventory inventorys = new Inventory
            {
                Id = Convert.ToInt32(inventory.SelectedValue),
                PartName = name.Text,
                PartNumber = number.Text,
                Quantity = Convert.ToInt32(quantity.Text),
                Price = float.Parse(price.Text),
                Supplier = supplier.Text,
                Notes = notes.Text
            };
            return inventorys;
        }

        private void inventory_SelectedValueChanged(object sender, EventArgs e)
        {
            DbConnect.Connect();
            string query = $"SELECT * FROM Inventory WHERE inventory_id = {Convert.ToInt32(inventory.Text)}";
            SQLiteCommand command = new SQLiteCommand(query, DbConnect.connection);
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string partName = reader["part_name"].ToString();
                        string partNumber = reader["part_number"].ToString();
                        int quantitys = Convert.ToInt32(reader["quantity"]);
                        string prices = reader["price"].ToString();
                        string suppliers = reader["supplier"].ToString();
                        string notesStr = reader["notes"].ToString();

                        name.Text = partName;
                        number.Text = partNumber;
                        quantity.Text = quantitys.ToString();
                        price.Text = prices;
                        supplier.Text = suppliers;
                        notes.Text = notesStr;
                    }
                }
            }
            DbConnect.Disconnect();
        }

        public void LoadElemntsToCombobox()
        {
            DbConnect.Connect();
            string querySecond = "SELECT inventory_id FROM Inventory ";
            SQLiteCommand commandSecond = new SQLiteCommand(querySecond, DbConnect.connection);
            using (SQLiteDataReader reader = commandSecond.ExecuteReader())
            {
                while (reader.Read())
                {
                    int inventoryId = reader.GetInt32(0);
                    inventoryList.Add(inventoryId);
                }
                inventory.DataSource = inventoryList;
            }
            DbConnect.Disconnect();
        }

        private void reload_Click(object sender, EventArgs e)
        {
            inventoryImpl.Update(InitializationInventory());
        }
    }
}
