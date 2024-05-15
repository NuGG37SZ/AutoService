using AutoService.Classes;
using AutoService.Entity;
using AutoService.Interface;
using AutoService.RepositoryImpl;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
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
                Id = Convert.ToInt32(Inventory.SelectedValue),
                PartName = Names.Text,
                PartNumber = Number.Text,
                Quantity = Convert.ToInt32(Quantity.Text),
                Price = float.Parse(Price.Text),
                Supplier = Supplier.Text,
                Notes = Notes.Text
            };
            return inventorys;
        }

        private void Inventory_SelectedValueChanged(object sender, EventArgs e)
        {
            DbConnect.Connect();
            string query = $"SELECT * FROM Inventory " +
                $"WHERE inventory_id = {Convert.ToInt32(Inventory.Text)}";
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
                        float prices = reader.GetFloat(reader.GetOrdinal("price")); 
                        string suppliers = reader["supplier"].ToString();
                        string notesStr = reader["notes"].ToString();

                        Names.Text = partName;
                        Number.Text = partNumber;
                        Quantity.Text = quantitys.ToString();
                        Price.Text = prices.ToString(); 
                        Supplier.Text = suppliers;
                        Notes.Text = notesStr;
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
                Inventory.DataSource = inventoryList;
            }
            DbConnect.Disconnect();
        }

        private void Reload_Click(object sender, EventArgs e)
        {
            inventoryImpl.Update(InitializationInventory());
        }
    }
}
