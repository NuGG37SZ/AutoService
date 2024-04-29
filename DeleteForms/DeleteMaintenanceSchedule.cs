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
    public partial class DeleteMaintenanceSchedule : Form
    {
        private MaintenanceScheduleImpl maintenanceScheduleImpl = new MaintenanceScheduleImpl();
        public DeleteMaintenanceSchedule()
        {
            InitializeComponent();
        }

        private void idMaintenanceSchedule_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(idMaintenanceSchedule);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            maintenanceScheduleImpl.Delete(Convert.ToInt32(idMaintenanceSchedule.Text));
        }
    }
}
