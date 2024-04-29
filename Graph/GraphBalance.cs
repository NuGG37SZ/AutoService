using AutoService.Classes;
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

namespace AutoService.Graph
{
    public partial class GraphBalance : Form
    {
        public GraphBalance()
        {
            InitializeComponent();
        }

        private void GraphBalance_Load(object sender, EventArgs e)
        {
            getBalanceCurrentYear();
            CreateChart(dataGridView1, "Баланс за текущий год", "Balance");
        }

        private void CreateChart(DataGridView grid, string nameTitle, string seriesName)
        {
            try
            {
                chart1.Series.Clear();
                chart1.Series.Add(seriesName);

                for (int i = 0; i < grid.RowCount; i++)
                {
                    var value = grid.Rows[i].Cells[1].Value?.ToString() ?? "";
                    var name = grid.Rows[i].Cells[0].Value?.ToString() ?? "";
                    chart1.Series[seriesName].Points.AddXY(name, value);
                }
                chart1.Titles.Clear();
                chart1.Titles.Add(nameTitle);

                chart1.ChartAreas[0].AxisX.Title = grid.Columns[0].HeaderText;
                chart1.ChartAreas[0].AxisY.Title = grid.Columns[1].HeaderText;
                MessageBox.Show("График сформирован", "Успех");
            }

            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Ошибка: Недостаточно столбцов в DataGridView", "Ошибка");
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка: недопустимые данные в DataGridView", "Ошибка");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка");
            }
        }

        private void getBalanceCurrentYear()
        {
            DbConnect.Connect();

            DataTable balanceTable = new DataTable();
            balanceTable.Columns.Add("Месяц", typeof(int));
            balanceTable.Columns.Add("Баланс", typeof(float));

            int currentYear = DateTime.Now.Year;

            for (int month = 1; month <= 12; month++)
            {
                string queryBalance = $"SELECT SUM(CASE WHEN transaction_type = 'Income' " +
                      $"THEN amount ELSE -amount END) AS Balance " +
                      $"FROM Finances " +
                      $"WHERE strftime('%Y', CAST(transaction_date AS TEXT)) = '{currentYear}' " +
                      $"AND strftime('%m', CAST(transaction_date AS TEXT)) = '{month.ToString("00")}'";
                using (SQLiteCommand command = new SQLiteCommand(queryBalance, DbConnect.connection))
                {
                    object result = command.ExecuteScalar();
                    float balance = result != DBNull.Value ? Convert.ToSingle(result) : 0;

                    balanceTable.Rows.Add(month, balance);
                }
            }
            dataGridView1.DataSource = balanceTable;
            dataGridView1.Columns[0].Width = 80;
            dataGridView1.Columns[1].Width = 132;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;

            DbConnect.Disconnect();
        }
    }
}
