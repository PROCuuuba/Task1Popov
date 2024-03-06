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
    public partial class LoginForm : Form
    {
        PostgresConnector bd = new PostgresConnector();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            string login = textBoxLog.Text;
            string password = textBoxPass.Text;

            NpgsqlCommand cmd_ex = new NpgsqlCommand($"SELECT COUNT(*) FROM users " +
                $"WHERE login = '{login}' and " +
                $"password = '{password}'", bd.getConnection());

            bd.openConnection();

            int user = Convert.ToInt32(cmd_ex.ExecuteScalar());

            bd.closeConnection();

            if (user > 0)
            {
                this.Hide();
                ItemsForm f1 = new ItemsForm();
                f1.ShowDialog();
            }
            else MessageBox.Show("Неправильно введён логин или пароль.");
        }

        private void labelRegistration_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm f2 = new RegistrationForm();
            f2.ShowDialog();
        }
    }
}
