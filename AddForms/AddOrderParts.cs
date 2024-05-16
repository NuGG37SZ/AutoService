using AutoService.Classes;
using AutoService.Entity;
using AutoService.Interface;
using AutoService.MainForms;
using AutoService.RepositoryImpl;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
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
            try
            {
                OrderPart orderPart = new OrderPart
                {
                    OrderId = Convert.ToInt32(Orders.SelectedValue),
                    InventoryId = Convert.ToInt32(Inventory.SelectedValue),
                    Quantity = Convert.ToInt32(Quantity.Text)
                };
                return orderPart;
            } 
            catch (NullReferenceException ex) 
            {
                MessageBox.Show(ex.Message);
                return new OrderPart();
            } 
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
                return new OrderPart();
            }
        }

        private void ClearTextBox(object sender, EventArgs e)
        {
            string name = (sender as Control).Name;
            Control control = this.Controls.Find(name, true).FirstOrDefault();
            control.Text = "";
        }

        private void Save_Click(object sender, EventArgs e)
        {
            orderPartsImpl.Add(InitializationOrderPart());
        }

        public void LoadElemntsToCombobox()
        {
            DbConnect.Connect();

            string query = "SELECT inventory_id, part_number FROM Inventory " +
                "ORDER BY inventory_id ";
            SQLiteCommand command = new SQLiteCommand(query, DbConnect.connection);
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    int inventoryId = reader.GetInt32(0);
                    string partNumber = reader.GetString(1);
                    inventoryDictionary.Add(inventoryId, partNumber);
                }
                Inventory.DataSource = new BindingSource(inventoryDictionary.ToList(), null);
                Inventory.DisplayMember = "Value";
                Inventory.ValueMember = "Key";
                Inventory.Text = "Запчасть";
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
                Orders.DataSource = ordersList;

                Orders.Text = "Номер заказа";
            }

            DbConnect.Disconnect();
        }
    }
}
