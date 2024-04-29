using AutoService.Classes;
using AutoService.Entity;
using AutoService.Interface;
using AutoService.MainForms;
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

namespace AutoService.AddForms
{
    public partial class AddOrderParts : Form, LoadingElementsCombobox
    {
        private OrderPartsImpl orderPartsImpl = new OrderPartsImpl();
        private Dictionary<int, string> inventoryDictionary = new Dictionary<int, string>();
        private List<int> ordersList = new List<int>();

        public AddOrderParts()
        {
            InitializeComponent();
        }

        private void AddOrderParts_Load(object sender, EventArgs e)
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

        private void quantity_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(quantity);
        }

        private void save_Click(object sender, EventArgs e)
        {
            orderPartsImpl.Add(InitializationOrderPart());
        }

        public void LoadElemntsToCombobox()
        {
            DbConnect.Connect();

            string query = "SELECT inventory_id, part_number FROM Inventory ORDER BY inventory_id ";
            SQLiteCommand command = new SQLiteCommand(query, DbConnect.connection);
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    int inventoryId = reader.GetInt32(0);
                    string partNumber = reader.GetString(1);
                    inventoryDictionary.Add(inventoryId, partNumber);
                }
                inventory.DataSource = new BindingSource(inventoryDictionary.ToList(), null);
                inventory.DisplayMember = "Value";
                inventory.ValueMember = "Key";
                inventory.Text = "Запчасть";
            }

            string querySecond = "SELECT order_id FROM ServiceOrders ";
            SQLiteCommand commandSecond = new SQLiteCommand(querySecond, DbConnect.connection);
            using (SQLiteDataReader reader = commandSecond.ExecuteReader())
            {
                while (reader.Read())
                {
                    int ordersId = reader.GetInt32(0);
                    ordersList.Add(ordersId);
                }
                orders.DataSource = ordersList;

                orders.Text = "Номер заказа";
            }

            DbConnect.Disconnect();
        }
    }
}
