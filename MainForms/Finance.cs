using AutoService.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoService.MainForms
{
    public partial class Finance : Form
    {
        private FinancesImpl financesImpl = new FinancesImpl();
        public Finance()
        {
            InitializeComponent();
        }

        private void Finances_Load(object sender, EventArgs e)
        {
            financesImpl.SelectAllFields(dataGridView1);
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            financesImpl.SearchSelect(search, dataGridView1);
        }

        private void search_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(search);
        }

        private void reloadGrid_Click(object sender, EventArgs e)
        {
            financesImpl.SelectAllFields(dataGridView1)
        }

        private void addValue_Click(object sender, EventArgs e)
        {
            OpenForms.OpenFormInNewWindow(new AddFinances());
        }

        private void deleteValue_Click(object sender, EventArgs e)
        {
            OpenForms.OpenFormInNewWindow(new DeleteFinances());
        }

        private void reloadValue_Click(object sender, EventArgs e)
        {
            OpenForms.OpenFormInNewWindow(new UpdateFinances());
        }

        private void excelImport_Click(object sender, EventArgs e)
        {
            ExportExcelDataGridView.ExportExcel(dataGridView1);
        }
    }
}
