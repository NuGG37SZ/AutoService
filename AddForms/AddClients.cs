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

        private void ClearTextBox(object sender, EventArgs e)
        {
            string name = (sender as Control).Name;
            Control control = this.Controls.Find(name, true).FirstOrDefault();
            control.Text = "";
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
