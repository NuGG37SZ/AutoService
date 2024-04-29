using AutoService.Classes;
using AutoService.Entity;
using AutoService.MainForms;
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

namespace AutoService.AddForms
{
    public partial class AddClients : Form
    {
        private ClientImpl clientImpl = new ClientImpl();
        public AddClients()
        {
            InitializeComponent();
        }

        private void fullName_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(fullName);
        }

        private void phoneNumber_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(phoneNumber);
        }

        private void email_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(email);
        }

        private void address_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(address);
        }

        private void notes_DoubleClick(object sender, EventArgs e)
        {
            TextHelper.ClearText(notes);
        }

        private void save_Click(object sender, EventArgs e)
        {
            clientImpl.Add(InitializationClient());
        }

        public Clients InitializationClient()
        {
            Clients clients = new Clients
            {
                FullName = fullName.Text,
                PhoneNumber = phoneNumber.Text,
                Address = address.Text,
                Email = email.Text,
                Notes = notes.Text
            };
            return clients;
        }
    }
}
