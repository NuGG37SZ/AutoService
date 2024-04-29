using AutoService.Classes;
using AutoService.Graph;
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



        private void firstDate_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(firstDate);
        }

        private void secondDate_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(secondDate);
        }

        private void applyFilter_Click(object sender, EventArgs e)
        {
            ReportThePeriod();
        }

        public void ReportThePeriod()
        {
            float amountExpenses = 0;
            float amountParishes = 0;
            float balancePeriod;

            DateTime firstDateReport = Convert.ToDateTime(firstDate.Text);
            DateTime secondDateReport = Convert.ToDateTime(secondDate.Text);

            DbConnect.Connect();

            string queryFirstMonth = "SELECT SUM(amount) FROM Finances " +
            "WHERE (transaction_type = 'Deposit' OR transaction_type = 'Withdrawal') " +
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
                "WHERE transaction_type = 'Entering' " +
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

            string queryFirstMonth = "SELECT SUM(amount) FROM Finances WHERE (transaction_type = 'Deposit' " +
                "OR transaction_type = 'Withdrawal') " +
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

            string querySecondMonth = "SELECT SUM(amount) FROM Finances WHERE transaction_type = 'Entering' " +
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

        private void reloadButton_Click(object sender, EventArgs e)
        {
            ReportCurrentMonth();
            firstDate.Text = "Дата с";
            secondDate.Text = "Дата по";
        }

        private void buttonBalance_Click(object sender, EventArgs e)
        {
            OpenForms.OpenFormInNewWindow(new GraphBalance());
        }

        private void buttonExpenses_Click(object sender, EventArgs e)
        {
            OpenForms.OpenFormInNewWindow(new GraphExpenses());
        }

        private void buttonParishes_Click(object sender, EventArgs e)
        {
            OpenForms.OpenFormInNewWindow(new GraphParishes());
        }
    }
}
