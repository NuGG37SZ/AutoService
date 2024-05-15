using AutoService.Classes;
using AutoService.MainForms;
using System;
using System.Drawing;
using System.Windows.Forms;

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

        private void ClientButton_Click(object sender, EventArgs e)
        {
            ClientButton.BackColor = buttonСolorPressed;

            CarButton.BackColor = defaultColorButton;
            OrderButton.BackColor = defaultColorButton;
            StaffButton.BackColor = defaultColorButton;
            InventoryButton.BackColor = defaultColorButton;
            MoneyButton.BackColor = defaultColorButton; 
            ServiceButton.BackColor = defaultColorButton;
            ReportButton.BackColor = defaultColorButton;
            OrderPartsButton.BackColor = defaultColorButton;

            OpenForms.OpenFormInPanel(new Client(), panel2);
        }

        private void CarButton_Click(object sender, EventArgs e)
        {
            CarButton.BackColor = buttonСolorPressed;

            ClientButton.BackColor = defaultColorButton;
            OrderButton.BackColor = defaultColorButton;
            StaffButton.BackColor = defaultColorButton;
            InventoryButton.BackColor = defaultColorButton;
            MoneyButton.BackColor = defaultColorButton;
            ServiceButton.BackColor = defaultColorButton;
            ReportButton.BackColor = defaultColorButton;
            OrderPartsButton.BackColor = defaultColorButton;

            OpenForms.OpenFormInPanel(new Vehicle(), panel2);
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            OrderButton.BackColor = buttonСolorPressed;

            ClientButton.BackColor = defaultColorButton;
            CarButton.BackColor = defaultColorButton;
            StaffButton.BackColor = defaultColorButton;
            InventoryButton.BackColor = defaultColorButton;
            MoneyButton.BackColor = defaultColorButton;
            ServiceButton.BackColor = defaultColorButton;
            ReportButton.BackColor = defaultColorButton;
            OrderPartsButton.BackColor = defaultColorButton;

            OpenForms.OpenFormInPanel(new Orders(), panel2);
        }

        private void StaffButton_Click(object sender, EventArgs e)
        {
            StaffButton.BackColor = buttonСolorPressed;

            ClientButton.BackColor = defaultColorButton;
            CarButton.BackColor = defaultColorButton;
            OrderButton.BackColor = defaultColorButton;
            InventoryButton.BackColor = defaultColorButton;
            MoneyButton.BackColor = defaultColorButton;
            ServiceButton.BackColor = defaultColorButton;
            ReportButton.BackColor = defaultColorButton;
            OrderPartsButton.BackColor = defaultColorButton;

            OpenForms.OpenFormInPanel(new Employee(), panel2);
        }

        private void InventoryButton_Click(object sender, EventArgs e)
        {
            InventoryButton.BackColor = buttonСolorPressed;

            ClientButton.BackColor = defaultColorButton;
            CarButton.BackColor = defaultColorButton;
            OrderButton.BackColor = defaultColorButton;
            StaffButton.BackColor = defaultColorButton;
            MoneyButton.BackColor = defaultColorButton;
            ServiceButton.BackColor = defaultColorButton;
            ReportButton.BackColor = defaultColorButton;
            OrderPartsButton.BackColor = defaultColorButton;

            OpenForms.OpenFormInPanel(new Inventorys(), panel2);
        }

        private void MoneyButton_Click(object sender, EventArgs e)
        {
            MoneyButton.BackColor = buttonСolorPressed;

            ClientButton.BackColor = defaultColorButton;
            CarButton.BackColor = defaultColorButton;
            OrderButton.BackColor = defaultColorButton;
            StaffButton.BackColor = defaultColorButton;
            InventoryButton.BackColor = defaultColorButton;
            ServiceButton.BackColor = defaultColorButton;
            ReportButton.BackColor = defaultColorButton;
            OrderPartsButton.BackColor = defaultColorButton;

            OpenForms.OpenFormInPanel(new Finance(), panel2);
        }

        private void ServiceButton_Click(object sender, EventArgs e)
        {
            ServiceButton.BackColor = buttonСolorPressed;

            ClientButton.BackColor = defaultColorButton;
            CarButton.BackColor = defaultColorButton;
            OrderButton.BackColor = defaultColorButton;
            StaffButton.BackColor = defaultColorButton;
            InventoryButton.BackColor = defaultColorButton;
            MoneyButton.BackColor = defaultColorButton;
            ReportButton.BackColor = defaultColorButton;
            OrderPartsButton.BackColor = defaultColorButton;

            OpenForms.OpenFormInPanel(new MaintenanceSchedules(), panel2);
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            ReportButton.BackColor = buttonСolorPressed;

            ClientButton.BackColor = defaultColorButton;
            CarButton.BackColor = defaultColorButton;
            OrderButton.BackColor = defaultColorButton;
            StaffButton.BackColor = defaultColorButton;
            InventoryButton.BackColor = defaultColorButton;
            MoneyButton.BackColor = defaultColorButton;
            ServiceButton.BackColor = defaultColorButton;
            OrderPartsButton.BackColor = defaultColorButton;

            OpenForms.OpenFormInPanel(new Reports(), panel2);
        }

        private void OrderPartsButton_Click(object sender, EventArgs e)
        {
            OrderPartsButton.BackColor = buttonСolorPressed;

            ClientButton.BackColor = defaultColorButton;
            CarButton.BackColor = defaultColorButton;
            OrderButton.BackColor = defaultColorButton;
            StaffButton.BackColor = defaultColorButton;
            InventoryButton.BackColor = defaultColorButton;
            MoneyButton.BackColor = defaultColorButton;
            ServiceButton.BackColor = defaultColorButton;
            ReportButton.BackColor = defaultColorButton;

            OpenForms.OpenFormInPanel(new OrderParts(), panel2);
        }
    }
}
