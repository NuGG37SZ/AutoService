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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace AutoService
{
    public partial class Main : Form
    {
        private Color defaultColorButton = Color.Transparent;
        private Color buttonСolorPressed = Color.DimGray;

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
            clientButton.BackColor = buttonСolorPressed;

            carButton.BackColor = defaultColorButton;
            orderButton.BackColor = defaultColorButton;
            staffButton.BackColor = defaultColorButton;
            inventoryButton.BackColor = defaultColorButton;
            moneyButton.BackColor = defaultColorButton; 
            serviceButton.BackColor = defaultColorButton;
            reportButton.BackColor = defaultColorButton;
            orderPartsButton.BackColor = defaultColorButton;

            OpenForms.OpenFormInPanel(new Client(), panel2);
        }

        private void carButton_Click(object sender, EventArgs e)
        {
            carButton.BackColor = buttonСolorPressed;

            clientButton.BackColor = defaultColorButton;
            orderButton.BackColor = defaultColorButton;
            staffButton.BackColor = defaultColorButton;
            inventoryButton.BackColor = defaultColorButton;
            moneyButton.BackColor = defaultColorButton;
            serviceButton.BackColor = defaultColorButton;
            reportButton.BackColor = defaultColorButton;
            orderPartsButton.BackColor = defaultColorButton;

            OpenForms.OpenFormInPanel(new Vehicle(), panel2);
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            orderButton.BackColor = buttonСolorPressed;

            clientButton.BackColor = defaultColorButton;
            carButton.BackColor = defaultColorButton;
            staffButton.BackColor = defaultColorButton;
            inventoryButton.BackColor = defaultColorButton;
            moneyButton.BackColor = defaultColorButton;
            serviceButton.BackColor = defaultColorButton;
            reportButton.BackColor = defaultColorButton;
            orderPartsButton.BackColor = defaultColorButton;

            OpenForms.OpenFormInPanel(new Orders(), panel2);
        }

        private void staffButton_Click(object sender, EventArgs e)
        {
            staffButton.BackColor = buttonСolorPressed;

            clientButton.BackColor = defaultColorButton;
            carButton.BackColor = defaultColorButton;
            orderButton.BackColor = defaultColorButton;
            inventoryButton.BackColor = defaultColorButton;
            moneyButton.BackColor = defaultColorButton;
            serviceButton.BackColor = defaultColorButton;
            reportButton.BackColor = defaultColorButton;
            orderPartsButton.BackColor = defaultColorButton;

            OpenForms.OpenFormInPanel(new Employee(), panel2);
        }

        private void inventoryButton_Click(object sender, EventArgs e)
        {
            inventoryButton.BackColor = buttonСolorPressed;

            clientButton.BackColor = defaultColorButton;
            carButton.BackColor = defaultColorButton;
            orderButton.BackColor = defaultColorButton;
            staffButton.BackColor = defaultColorButton;
            moneyButton.BackColor = defaultColorButton;
            serviceButton.BackColor = defaultColorButton;
            reportButton.BackColor = defaultColorButton;
            orderPartsButton.BackColor = defaultColorButton;

            OpenForms.OpenFormInPanel(new Inventorys(), panel2);
        }

        private void moneyButton_Click(object sender, EventArgs e)
        {
            moneyButton.BackColor = buttonСolorPressed;

            clientButton.BackColor = defaultColorButton;
            carButton.BackColor = defaultColorButton;
            orderButton.BackColor = defaultColorButton;
            staffButton.BackColor = defaultColorButton;
            inventoryButton.BackColor = defaultColorButton;
            serviceButton.BackColor = defaultColorButton;
            reportButton.BackColor = defaultColorButton;
            orderPartsButton.BackColor = defaultColorButton;

            OpenForms.OpenFormInPanel(new Finance(), panel2);
        }

        private void serviceButton_Click(object sender, EventArgs e)
        {
            serviceButton.BackColor = buttonСolorPressed;

            clientButton.BackColor = defaultColorButton;
            carButton.BackColor = defaultColorButton;
            orderButton.BackColor = defaultColorButton;
            staffButton.BackColor = defaultColorButton;
            inventoryButton.BackColor = defaultColorButton;
            moneyButton.BackColor = defaultColorButton;
            reportButton.BackColor = defaultColorButton;
            orderPartsButton.BackColor = defaultColorButton;

            OpenForms.OpenFormInPanel(new MaintenanceSchedules(), panel2);
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            reportButton.BackColor = buttonСolorPressed;

            clientButton.BackColor = defaultColorButton;
            carButton.BackColor = defaultColorButton;
            orderButton.BackColor = defaultColorButton;
            staffButton.BackColor = defaultColorButton;
            inventoryButton.BackColor = defaultColorButton;
            moneyButton.BackColor = defaultColorButton;
            serviceButton.BackColor = defaultColorButton;
            orderPartsButton.BackColor = defaultColorButton;

            OpenForms.OpenFormInPanel(new Reports(), panel2);
        }

        private void orderPartsButton_Click(object sender, EventArgs e)
        {
            orderPartsButton.BackColor = buttonСolorPressed;

            clientButton.BackColor = defaultColorButton;
            carButton.BackColor = defaultColorButton;
            orderButton.BackColor = defaultColorButton;
            staffButton.BackColor = defaultColorButton;
            inventoryButton.BackColor = defaultColorButton;
            moneyButton.BackColor = defaultColorButton;
            serviceButton.BackColor = defaultColorButton;
            reportButton.BackColor = defaultColorButton;

            OpenForms.OpenFormInPanel(new OrderParts(), panel2);
        }
    }
}
