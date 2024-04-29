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
    public partial class DeleteVehicles : Form
    {
        private VehiclesImpl vehiclesImpl = new VehiclesImpl();
        public DeleteVehicles()
        {
            InitializeComponent();
        }

        private void idVehicles_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(idVehicles);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            vehiclesImpl.Delete(Convert.ToInt32(idVehicles));
        }
    }
}
