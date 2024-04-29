using AutoService.AddForms;
using AutoService.Classes;
using AutoService.RepositoryImpl;
using AutoService.UpdateForms;
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
    public partial class Client : Form
    {
        private ClientImpl clientsImpl = new ClientImpl();
        public Client()
        {
            InitializeComponent();
        }

        private void Client_Load(object sender, EventArgs e)
        {
            clientsImpl.SelectAllFields(dataGridView1);
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            clientsImpl.SearchSelect(search, dataGridView1);
        }

        private void search_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(search);
        }

        private void reloadGrid_Click(object sender, EventArgs e)
        {
            clientsImpl.SelectAllFields(dataGridView1);
        }

        private void addValue_Click(object sender, EventArgs e)
        {
            OpenForms.OpenFormInNewWindow(new AddClients());
        }

        private void deleteValue_Click(object sender, EventArgs e)
        {
            OpenForms.OpenFormInNewWindow(new DeleteClients());
        }

        private void reloadValue_Click(object sender, EventArgs e)
        {
            OpenForms.OpenFormInNewWindow(new UpdateClient());
        }

        private void excelImport_Click(object sender, EventArgs e)
        {
            ImportExcel.ExportExcel(dataGridView1);
        }
    }
}
