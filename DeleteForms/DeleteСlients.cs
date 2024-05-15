using AutoService.Classes;
using AutoService.RepositoryImpl;
using System;
using System.Windows.Forms;

namespace AutoService.DeleteForms
{
    public partial class DeleteСlients : Form
    {
        private ClientImpl clientImpl = new ClientImpl();
        public DeleteСlients()
        {
            InitializeComponent();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            clientImpl.Delete(Convert.ToInt32(IdClient.Text));
        }

        private void IdClient_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(IdClient);
        }
    }
}
