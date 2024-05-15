using AutoService.Classes;
using AutoService.Entity;
using AutoService.RepositoryImpl;
using System;
using System.Linq;
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
        private void ClearTextBox(object sender, EventArgs e)
        {
            string name = (sender as Control).Name;
            Control control = this.Controls.Find(name, true).FirstOrDefault();
            control.Text = "";
        }
    }
}
