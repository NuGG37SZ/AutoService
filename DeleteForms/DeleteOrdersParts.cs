using AutoService.Classes;
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

namespace AutoService.DeleteForms
{
    public partial class DeleteOrdersParts : Form, LoadingElementsCombobox
    {
        private OrderPartsImpl orderPartsImpl = new OrderPartsImpl();
        private Dictionary<int, string> inventoryDictionary = new Dictionary<int, string>();
        private List<int> ordersList = new List<int>();
        public DeleteOrdersParts()
        {
            InitializeComponent();
        }

        private void DeleteOrdersParts_Load(object sender, EventArgs e)
        {
            LoadElemntsToCombobox();
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

                inventory.Text = "Запчасть";
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

                orders.Text = "Номер заказа";
            }

            DbConnect.Disconnect();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            orderPartsImpl.Delete(Convert.ToInt32(orders.SelectedValue), 
                Convert.ToInt32(inventory.SelectedValue));
        }
    }
}
