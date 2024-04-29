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
    public partial class UpdateOrderParts : Form, LoadingElementsCombobox
    {
        private OrderPartsImpl orderPartsImpl = new OrderPartsImpl();
        private Dictionary<int, string> inventoryDictionary = new Dictionary<int, string>();
        private List<int> ordersList = new List<int>();
        public UpdateOrderParts()
        {
            InitializeComponent();
        }
        private void UpdateOrderParts_Load(object sender, EventArgs e)
        {
            LoadElemntsToCombobox();
        }

        public OrderPart InitializationOrderPart()
        {
            OrderPart orderPart = new OrderPart
            {
                OrderId = Convert.ToInt32(orders.SelectedValue),
                InventoryId = Convert.ToInt32(inventory.SelectedValue),
                Quantity = Convert.ToInt32(quantity.Text)
            };
            return orderPart;
        }

        private void orders_SelectedValueChanged(object sender, EventArgs e)
        {
            DbConnect.Connect();
            string query = $"SELECT * FROM OrderParts WHERE inventory_id = {Convert.ToInt32(inventory.SelectedValue)} " +
                $"AND order_id = {Convert.ToInt32(orders.Text)}";
            SQLiteCommand command = new SQLiteCommand(query, DbConnect.connection);
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int orderId = Convert.ToInt32(reader["order_id"]);
                        int inventoryId = Convert.ToInt32(reader["inventory_id"]);
                        int quantitys = Convert.ToInt32(reader["quantity"]);

                        orders.Text = orderId.ToString();
                        inventory.SelectedValue = inventoryId;
                        quantity.Text = quantitys.ToString();
                    }
                }
            }
            DbConnect.Disconnect();
        }

        private void reload_Click(object sender, EventArgs e)
        {
            orderPartsImpl.Update(InitializationOrderPart());
        }

        public void LoadElemntsToCombobox()
        {
            DbConnect.Connect();

            string query = "SELECT Inventory.inventory_id, part_number FROM Inventory " +
                "INNER JOIN OrderParts ON Inventory.inventory_id = OrderParts.inventory_id";
            SQLiteCommand command = new SQLiteCommand(query, DbConnect.connection);
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    int inventoryId = reader.GetInt32(0);
                    string partNumber = reader.GetString(1);
                    inventoryDictionary.Add(inventoryId, partNumber);
                }
                inventory.DataSource = new BindingSource(inventoryDictionary, null);
                inventory.DisplayMember = "Value";
                inventory.ValueMember = "Key";
            }

            string querySecond = "SELECT DISTINCT order_id FROM OrderParts ";
            SQLiteCommand commandSecond = new SQLiteCommand(querySecond, DbConnect.connection);
            using (SQLiteDataReader reader = commandSecond.ExecuteReader())
            {
                while (reader.Read())
                {
                    int ordersId = reader.GetInt32(0);
                    ordersList.Add(ordersId);
                }
                orders.DataSource = ordersList;
            }

            DbConnect.Disconnect();
        }
    }
}
