using AutoService.Classes;
using AutoService.Graph;
using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace AutoService.MainForms
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            ReportCurrentMonth();
        }

        private void FirstDate_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(FirstDate);
        }

        private void SecondDate_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(SecondDate);
        }

        private void ApplyFilter_Click(object sender, EventArgs e)
        {
            ReportThePeriod();
        }

        public void ReportThePeriod()
        {
            float amountExpenses = 0;
            float amountParishes = 0;
            float balancePeriod;

            DateTime firstDateReport = Convert.ToDateTime(FirstDate.Text);
            DateTime secondDateReport = Convert.ToDateTime(SecondDate.Text);

            DbConnect.Connect();

            string queryFirstMonth = "SELECT SUM(amount) FROM Finances " +
            "WHERE transaction_type = 'Expense' " +
            "AND transaction_date BETWEEN @firstDate AND @secondDate";
            using (SQLiteCommand command = new SQLiteCommand(queryFirstMonth, DbConnect.connection))
            {
                command.Parameters.AddWithValue("@firstDate", firstDateReport);
                command.Parameters.AddWithValue("@secondDate", secondDateReport);
                object result = command.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    amountExpenses = Convert.ToSingle(result);
                }
            }
            expenses.Text = amountExpenses.ToString();

            string querySecondMonth = "SELECT SUM(amount) FROM Finances " +
                "WHERE transaction_type = 'Income' " +
                "AND transaction_date BETWEEN @firstDate AND @secondDate";
            using (SQLiteCommand command = new SQLiteCommand(querySecondMonth, DbConnect.connection))
            {
                command.Parameters.AddWithValue("@firstDate", firstDateReport);
                command.Parameters.AddWithValue("@secondDate", secondDateReport);
                object result = command.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    amountParishes = Convert.ToSingle(result);
                }
            }
            parishes.Text = amountParishes.ToString();

            balancePeriod = amountParishes - amountExpenses;
            balanceMoney.Text = balancePeriod.ToString();

            DbConnect.Disconnect();
        }

        public void ReportCurrentMonth()
        {
            DbConnect.Connect();

            float amountExpenses = 0;
            float amountParishes = 0;
            float balanceMonth;

            string queryFirstMonth = "SELECT SUM(amount) FROM Finances WHERE transaction_type = 'Expense' " +
                "AND (strftime('%Y', transaction_date) = strftime('%Y', 'now') " +
                "AND strftime('%m', transaction_date) = strftime('%m', 'now'))";
            using (SQLiteCommand command = new SQLiteCommand(queryFirstMonth, DbConnect.connection))
            {
                object result = command.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    amountExpenses = Convert.ToSingle(result);
                }
            }
            expenses.Text = amountExpenses.ToString();

            string querySecondMonth = "SELECT SUM(amount) FROM Finances WHERE transaction_type = 'Income' " +
                "AND (strftime('%Y', transaction_date) = strftime('%Y', 'now') " +
                "AND strftime('%m', transaction_date) = strftime('%m', 'now'))";
            using (SQLiteCommand command = new SQLiteCommand(querySecondMonth, DbConnect.connection))
            {
                object result = command.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    amountParishes = Convert.ToSingle(result);
                }
            }
            parishes.Text = amountParishes.ToString();

            balanceMonth = amountParishes - amountExpenses;
            balanceMoney.Text = balanceMonth.ToString();

            DbConnect.Disconnect();
        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            ReportCurrentMonth();
            FirstDate.Text = "Дата с";
            SecondDate.Text = "Дата по";
        }

        private void ButtonBalance_Click(object sender, EventArgs e)
        {
            OpenForms.OpenFormInNewWindow(new GraphBalance());
        }

        private void ButtonExpenses_Click(object sender, EventArgs e)
        {
            OpenForms.OpenFormInNewWindow(new GraphExpenses());
        }

        private void ButtonParishes_Click(object sender, EventArgs e)
        {
            OpenForms.OpenFormInNewWindow(new GraphParishes());
        }
    }
}
