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
            DateTime dateTransaction = Convert.ToDateTime(TransactionDate.Text);

            Finances finances = new Finances
            {
                Id = Convert.ToInt32(Transaction.SelectedValue),
                TransactionDate = dateTransaction,
                TransactionType = TransactionType.SelectedValue.ToString(),
                Amount = float.Parse(Amount.Text),
                Description = Description.Text,
            };
            return finances;
        }

        private void UpdateFinances_Load(object sender, EventArgs e)
        {
            LoadElemntsToCombobox();
        }

        private void Transaction_SelectedValueChanged(object sender, EventArgs e)
        {
            DbConnect.Connect();
            string query = $"SELECT * FROM Finances " +
                $"WHERE transaction_id = {Convert.ToInt32(Transaction.Text)}";
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

                        TransactionDate.Text = transactionDates;
                        TransactionType.Text = transactionTypes;
                        Amount.Text = amounts.ToString();
                        Description.Text = descriptions;
                    }

                }
            }
            DbConnect.Disconnect();
        }

        private void Reload_Click(object sender, EventArgs e)
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
                Transaction.DataSource = financesIdList;
            }
            DbConnect.Disconnect();
        }
    }
}
