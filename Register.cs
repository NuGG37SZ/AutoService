using AutoService.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoService
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            DbConnect.Connect();
            string query = "INSERT INTO Users (login, password) " +
            "VALUES (@login, @password)";
            if (password.Text.Equals(confirmationPassword.Text))
            {
                using (SQLiteCommand command = new SQLiteCommand(query, DbConnect.connection))
                {
                    if (ValidationLogin.Validation(login.Text) && PasswordValidation.Validation(password.Text))
                    {
                        command.Parameters.AddWithValue("@login", login.Text);
                        command.Parameters.AddWithValue("@password", Hashing.Hash(password.Text));
                        command.ExecuteNonQuery();
                        MessageBox.Show("Вы успешно зарегестрировались!");
                        MessageBox.Show(Hashing.Hash(password.Text));
                    }
                }
            }
            else
            {
                MessageBox.Show("Пароли не совпадают");
            }
            DbConnect.Disconnect();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            OpenForms.OpenForm(this, new SignUp());
        }
    }
}
