using AutoService.Classes;
using AutoService.RepositoryImpl;
using System;
using System.Windows.Forms;

namespace AutoService.DeleteForms
{
    public partial class DeleteServiceOrders : Form
    {
        private ServiceOrdersImpl serviceOrdersImpl = new ServiceOrdersImpl();
        public DeleteServiceOrders()
        {
            InitializeComponent();
        }

        private void IdServiceOrders_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(IdServiceOrders);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            serviceOrdersImpl.Delete(Convert.ToInt32(IdServiceOrders.Text));
        }
    }
}
