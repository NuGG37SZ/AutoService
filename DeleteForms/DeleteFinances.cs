using AutoService.Classes;
using AutoService.RepositoryImpl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void idTransaction_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(idTransaction);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            financesImpl.Delete(Convert.ToInt32(idTransaction.Text));
        }
    }
}
