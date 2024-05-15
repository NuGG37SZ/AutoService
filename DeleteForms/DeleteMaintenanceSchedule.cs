using AutoService.Classes;
using AutoService.RepositoryImpl;
using System;
using System.Windows.Forms;

namespace AutoService.DeleteForms
{
    public partial class DeleteMaintenanceSchedule : Form
    {
        private MaintenanceScheduleImpl maintenanceScheduleImpl = new MaintenanceScheduleImpl();
        public DeleteMaintenanceSchedule()
        {
            InitializeComponent();
        }

        private void IdMaintenanceSchedule_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(IdMaintenanceSchedule);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            maintenanceScheduleImpl.Delete(Convert.ToInt32(IdMaintenanceSchedule.Text));
        }
    }
}
