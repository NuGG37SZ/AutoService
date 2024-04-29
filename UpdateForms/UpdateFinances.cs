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
    public partial class UpdateFinances : Form, LoadingElementsCombobox
    {
        private FinancesImpl financesImpl = new FinancesImpl();
        private List<int> financesIdList = new List<int>();
        private List<string> financesTransactionType = new List<string>();

        public UpdateFinances()
        {
            InitializeComponent();
        }

        public Finances InitializationEmployees()
        {
            DateTime dateTransaction = Convert.ToDateTime(transactionDate.Text);

            Finances finances = new Finances
            {
                Id = Convert.ToInt32(transaction.SelectedValue),
                TransactionDate = dateTransaction,
                TransactionType = transactionType.SelectedValue.ToString(),
                Amount = float.Parse(amount.Text),
                Description = description.Text,
            };
            return finances;
        }

        private void UpdateFinances_Load(object sender, EventArgs e)
        {
            LoadElemntsToCombobox();
        }

        private void transaction_SelectedValueChanged(object sender, EventArgs e)
        {
            DbConnect.Connect();
            string query = $"SELECT * FROM Finances WHERE transaction_id = {Convert.ToInt32(transaction.Text)}";
            SQLiteCommand command = new SQLiteCommand(query, DbConnect.connection);
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string transactionDates = reader["transaction_date"].ToString();
                        string transactionTypes = reader["transaction_type"].ToString();
                        float amounts = Convert.ToSingle(reader["amount"]);
                        string descriptions = reader["description"].ToString();

                        transactionDate.Text = transactionDates;
                        transactionType.Text = transactionTypes;
                        amount.Text = amounts.ToString();
                        description.Text = descriptions;
                    }

                }
            }
            DbConnect.Disconnect();
        }

        private void reload_Click(object sender, EventArgs e)
        {
            financesImpl.Update(InitializationEmployees());
        }

        public void LoadElemntsToCombobox()
        {
            DbConnect.Connect();
            string query = "SELECT transaction_id FROM Finances ";
            SQLiteCommand command = new SQLiteCommand(query, DbConnect.connection);
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    int transactionId = reader.GetInt32(0);
                    financesIdList.Add(transactionId);
                }
                transaction.DataSource = financesIdList;
            }
            DbConnect.Disconnect();

            DbConnect.Connect();
            string querySecond = "SELECT DISTINCT transaction_type FROM Finances ";
            SQLiteCommand commandSecond = new SQLiteCommand(querySecond, DbConnect.connection);
            using (SQLiteDataReader reader = commandSecond.ExecuteReader())
            {
                while (reader.Read())
                {
                    string transactionType = reader.GetString(0);
                    financesTransactionType.Add(transactionType);
                }
                transactionType.DataSource = financesTransactionType;
            }
            DbConnect.Disconnect();
        }
    }
}
