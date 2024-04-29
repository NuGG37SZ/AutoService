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
    public partial class DeleteСlients : Form
    {
        private ClientImpl clientImpl = new ClientImpl();
        public DeleteСlients()
        {
            InitializeComponent();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            clientImpl.Delete(Convert.ToInt32(idClient.Text));
        }

        private void idClient_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(idClient);
        }
    }
}
