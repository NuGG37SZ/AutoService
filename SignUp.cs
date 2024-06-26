﻿using AutoService.Classes;
using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace AutoService
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        public void ValidateSignUp()
        {
            DbConnect.Connect();
            string query = "SELECT * FROM Users";
            bool isUserValid = false;

            using (SQLiteCommand command = new SQLiteCommand(query, DbConnect.connection))
            {
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string loginDb = reader.GetString(1);
                        string passwordDb = reader.GetString(2);
                        string roleDB = reader.GetString(3);


                        if (loginDb.Equals(LoginBox.Text) && passwordDb.Equals(Hashing.Hash(PasswordBox.Text)) && roleDB.Equals("administrator"))
                        {
                            isUserValid = true;
                            break;
                        }
                    }
                }
            }

            if (isUserValid)
            {
                MessageBox.Show("Добро пожаловать!!!");
                OpenForms.OpenForm(this, new Main());
            }
            else
            {
                MessageBox.Show("Перепроверьте введенные данные!!!");
            }
            DbConnect.Disconnect();
        }

        

        private void Sign_Click(object sender, EventArgs e)
        {
            ValidateSignUp();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            OpenForms.OpenForm(this, new Register());
        }
    }
}
