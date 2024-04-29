using AutoService.Classes;
using AutoService.MainForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoService
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            OpenForms.OpenFormInPanel(new Client(), panel2);
        }

        private void clientButton_Click(object sender, EventArgs e)
        {
            OpenForms.OpenFormInPanel(new Client(), panel2);
        }

        private void carButton_Click(object sender, EventArgs e)
        {
            OpenForms.OpenFormInPanel(new Vehicle(), panel2);
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            OpenForms.OpenFormInPanel(new Orders(), panel2);
        }

        private void staffButton_Click(object sender, EventArgs e)
        {
            OpenForms.OpenFormInPanel(new Employee(), panel2);
        }

        private void inventoryButton_Click(object sender, EventArgs e)
        {
            OpenForms.OpenFormInPanel(new Inventorys(), panel2);
        }

        private void moneyButton_Click(object sender, EventArgs e)
        {
            OpenForms.OpenFormInPanel(new Finance(), panel2);
        }

        private void serviceButton_Click(object sender, EventArgs e)
        {
            OpenForms.OpenFormInPanel(new MaintenanceSchedules(), panel2);
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            OpenForms.OpenFormInPanel(new Reports(), panel2);
        }

        private void orderPartsButton_Click(object sender, EventArgs e)
        {
            OpenForms.OpenFormInPanel(new OrderParts(), panel2);
        }
    }
}
