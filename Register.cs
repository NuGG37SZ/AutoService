using AutoService.Classes;
using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace AutoService
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            DbConnect.Connect();
            string query = "INSERT INTO Users (login, password) " +
            "VALUES (@login, @password)";
            if (Password.Text.Equals(ConfirmationPassword.Text))
            {
                SQLiteCommand command = new SQLiteCommand(query, DbConnect.connection);
                if (ValidationLogin.Validation(Login.Text) && PasswordValidation.Validation(Password.Text))
                {
                    command.Parameters.AddWithValue("@login", Login.Text);
                    command.Parameters.AddWithValue("@password", Hashing.Hash(Password.Text));
                    command.ExecuteNonQuery();
                    MessageBox.Show("Вы успешно зарегестрировались!");
                }
            }
            else
            {
                MessageBox.Show("Пароли не совпадают");
            }
            DbConnect.Disconnect();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            OpenForms.OpenForm(this, new SignUp());
        }
    }
}
