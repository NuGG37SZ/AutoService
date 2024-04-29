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
    public partial class DeleteServiceOrders : Form
    {
        private ServiceOrdersImpl serviceOrdersImpl = new ServiceOrdersImpl();
        public DeleteServiceOrders()
        {
            InitializeComponent();
        }

        private void idServiceOrders_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(idServiceOrders);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            serviceOrdersImpl.Delete(Convert.ToInt32(idServiceOrders.Text));
        }
    }
}
