using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1Popov
{
    public partial class RegistrationForm : Form
    {
        PostgresConnector bd = new PostgresConnector();

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            string login = textBoxLog.Text;
            string password = textBoxPass.Text;
            string telephone = maskedTextBoxTelephone.Text;
            string email = textBoxEmail.Text;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(telephone) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }

            if (!email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Неверный формат электронной почты.");
                return;
            }

            bd.openConnection();
            string updateQuryString = "INSERT INTO users (login, password, telephone, email) VALUES (@login, @password, @telephone, @email)";
            NpgsqlCommand cmd = new NpgsqlCommand(updateQuryString, bd.getConnection());
            cmd.Parameters.AddWithValue("login", login);
            cmd.Parameters.AddWithValue("password", password);
            cmd.Parameters.AddWithValue("telephone", telephone);
            cmd.Parameters.AddWithValue("email", email);
            cmd.ExecuteNonQuery();
            bd.closeConnection();
            MessageBox.Show("Регистрация прошла успешно!");

            this.Hide();
            LoginForm f1 = new LoginForm();
            f1.ShowDialog();
        }

        private void labelBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm f1 = new LoginForm();
            f1.ShowDialog();
        }

        private void RegistrationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
