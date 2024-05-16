using AutoService.Classes;
using AutoService.MainForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AutoService
{
    public partial class Main : Form
    {
        private Color defaultColorButton = Color.Transparent; // дефолтный цвет кнопки
        private Color buttonСolorPressed = Color.DimGray; // цвет который меняется при нажатии на кнопку
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            ResetButtonColors();
            ClientButton.BackColor = buttonСolorPressed;
            OpenForms.OpenFormInPanel(new Client(), panel2);
        }

        private void ClientButton_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            ClientButton.BackColor = buttonСolorPressed;
            OpenForms.OpenFormInPanel(new Client(), panel2);
        }

        private void CarButton_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            CarButton.BackColor = buttonСolorPressed;
            OpenForms.OpenFormInPanel(new Vehicle(), panel2);
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            OrderButton.BackColor = buttonСolorPressed;
            OpenForms.OpenFormInPanel(new Orders(), panel2);
        }

        private void StaffButton_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            StaffButton.BackColor = buttonСolorPressed;
            OpenForms.OpenFormInPanel(new Employee(), panel2);
        }

        private void InventoryButton_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            InventoryButton.BackColor = buttonСolorPressed;
            OpenForms.OpenFormInPanel(new Inventorys(), panel2);
        }

        private void MoneyButton_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            MoneyButton.BackColor = buttonСolorPressed;
            OpenForms.OpenFormInPanel(new Finance(), panel2);
        }

        private void ServiceButton_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            ServiceButton.BackColor = buttonСolorPressed;
            OpenForms.OpenFormInPanel(new MaintenanceSchedules(), panel2);
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            ReportButton.BackColor = buttonСolorPressed;
            OpenForms.OpenFormInPanel(new Reports(), panel2);
        }

        private void OrderPartsButton_Click(object sender, EventArgs e)
        {
            ResetButtonColors();
            OrderPartsButton.BackColor = buttonСolorPressed;
            OpenForms.OpenFormInPanel(new OrderParts(), panel2);
        }

        //Метод для сбрасывания цвета кнопок
        private void ResetButtonColors()
        {
            ClientButton.BackColor = defaultColorButton;
            CarButton.BackColor = defaultColorButton;
            OrderButton.BackColor = defaultColorButton;
            StaffButton.BackColor = defaultColorButton;
            InventoryButton.BackColor = defaultColorButton;
            MoneyButton.BackColor = defaultColorButton;
            ServiceButton.BackColor = defaultColorButton;
            ReportButton.BackColor = defaultColorButton;
            OrderPartsButton.BackColor = defaultColorButton;
        }
    }
}
