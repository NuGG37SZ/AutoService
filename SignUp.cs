using AutoService.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Security;
using System.Web.UI.WebControls;
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


                        if (loginDb.Equals(loginBox.Text) && passwordDb.Equals(Hashing.Hash(passwordBox.Text)) && roleDB.Equals("administrator"))
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
