using AutoService.Classes;
using AutoService.Entity;
using AutoService.RepositoryImpl;
using System;
using System.Linq;
using System.Windows.Forms;

namespace AutoService.AddForms
{
    public partial class AddClients : Form
    {
        private ClientImpl clientImpl = new ClientImpl();
        public AddClients()
        {
            InitializeComponent();
        }

        private void FullName_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(FullName);
        }

        private void PhoneNumber_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(PhoneNumber);
        }

        private void Email_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(Email);
        }

        private void Address_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(Address);
        }

        private void Notes_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(Notes);
        }

        private void ClearTextBox(object sender, EventArgs e)
        {
            string name = (sender as TextBox).Name;


            Controls[name].Text = "";
            //TextHelper.ClearText(Controls[name] as TextBox);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            clientImpl.Add(InitializationClient());
        }

        public Clients InitializationClient()
        {
            Clients clients = new Clients
            {
                FullName = FullName.Text,
                PhoneNumber = PhoneNumber.Text,
                Address = Address.Text,
                Email = Email.Text,
                Notes = Notes.Text
            };
            return clients;
        }
    }
}
