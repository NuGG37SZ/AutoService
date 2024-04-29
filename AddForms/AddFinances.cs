using AutoService.Classes;
using AutoService.Entity;
using AutoService.MainForms;
using AutoService.RepositoryImpl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoService.AddForms
{
    public partial class AddFinances : Form
    {
        private FinancesImpl financesImpl = new FinancesImpl();
        public AddFinances()
        {
            InitializeComponent();
        }

        public Finances InitializationEmployees()
        {
            DateTime dateTransaction = Convert.ToDateTime(transactionDate.Text);

            Finances finances = new Finances
            {
                TransactionDate = dateTransaction,
                TransactionType = transactionType.Text,
                Amount = float.Parse(amount.Text),
                Description = description.Text,
            };
            return finances;
        }

        private void save_Click(object sender, EventArgs e)
        {
            financesImpl.Add(InitializationEmployees());
        }

        private void transactionDate_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(transactionDate);
        }

        private void transactionType_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(transactionType);
        }

        private void amount_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(amount);
        }

        private void description_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(description);
        }
    }
}
