using AutoService.Classes;
using AutoService.RepositoryImpl;
using System;
using System.Windows.Forms;

namespace AutoService.DeleteForms
{
    public partial class DeleteFinances : Form
    {
        private FinancesImpl financesImpl = new FinancesImpl();
        public DeleteFinances()
        {
            InitializeComponent();
        }

        private void IdTransaction_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(IdTransaction);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            financesImpl.Delete(Convert.ToInt32(IdTransaction.Text));
        }
    }
}
