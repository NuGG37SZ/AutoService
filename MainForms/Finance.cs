using AutoService.AddForms;
using AutoService.Classes;
using AutoService.DeleteForms;
using AutoService.RepositoryImpl;
using AutoService.UpdateForms;
using System;
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

        private void Search_TextChanged(object sender, EventArgs e)
        {
            financesImpl.SearchSelect(Search, dataGridView1);
        }

        private void Search_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(Search);
        }

        private void ReloadGrid_Click(object sender, EventArgs e)
        {
            Search.Text = "Поиск";
            financesImpl.SelectAllFields(dataGridView1);
        }

        private void AddValue_Click(object sender, EventArgs e)
        {
            OpenForms.OpenFormInNewWindow(new AddFinances());
        }

        private void DeleteValue_Click(object sender, EventArgs e)
        {
            OpenForms.OpenFormInNewWindow(new DeleteFinances());
        }

        private void ReloadValue_Click(object sender, EventArgs e)
        {
            OpenForms.OpenFormInNewWindow(new UpdateFinances());
        }

        private void ExcelImport_Click(object sender, EventArgs e)
        {
            ExportExcelDataGridView.ExportExcel(dataGridView1);
        }
    }
}
