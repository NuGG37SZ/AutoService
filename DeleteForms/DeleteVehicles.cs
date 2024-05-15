using AutoService.Classes;
using AutoService.RepositoryImpl;
using System;
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

        private void IdVehicles_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(IdVehicles);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            vehiclesImpl.Delete(Convert.ToInt32(IdVehicles));
        }
    }
}
