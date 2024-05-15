using AutoService.Classes;
using AutoService.Entity;
using AutoService.RepositoryImpl;
using System;
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
            DateTime dateTransaction = Convert.ToDateTime(TransactionDate.Text);

            Finances finances = new Finances
            {
                TransactionDate = dateTransaction,
                TransactionType = TransactionType.Text,
                Amount = float.Parse(Amount.Text),
                Description = Description.Text,
            };
            return finances;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            financesImpl.Add(InitializationEmployees());
        }

        private void TransactionDate_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(TransactionDate);
        }

        private void TransactionType_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(TransactionType);
        }

        private void Amount_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(Amount);
        }

        private void Description_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(Description);
        }
    }
}
