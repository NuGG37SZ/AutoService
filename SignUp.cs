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
using System.Threading;
using System.Threading.Tasks;
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
            string query = "SELECT * FROM Users";
            string passwordToLogin = Hashing.Hash(password.Text);
            bool isUserValid = false;

            using (SQLiteCommand command = new SQLiteCommand(query, DbConnect.connection))
            {
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string loginDb = reader.GetValue(1).ToString();
                        string passwordDb = reader.GetValue(2).ToString();
                        string roleDB = reader.GetValue(3).ToString();

                        if (loginDb.Equals(login.Text) && passwordDb.Equals(passwordToLogin) && roleDB.Equals("administrator"))
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
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            OpenForms.OpenForm(this, new Register());
        }

        private void enter_Click(object sender, EventArgs e)
        {
            ValidateSignUp();
        }
    }
}
