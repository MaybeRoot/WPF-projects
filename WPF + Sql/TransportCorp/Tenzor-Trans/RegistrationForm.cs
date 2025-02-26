using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tenzor_Trans
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void GoToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            Hide();
        }
        public Boolean UserExists()
        {
            DataBase db = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM Сотрудники WHERE логин = @uL", db.GetConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = UserNewLogin.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Введённый логин уже используется");
                return true;
            }
            else
                return false;
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (UserName.Text == "")
            {
                MessageBox.Show("Введите имя");
                return;
            }
            if (UserSurname.Text == "")
            {
                MessageBox.Show("Введите фамилию");
                return;
            }
            if (UserOtch.Text == "")
            {
                MessageBox.Show("Введите отчество");
                return;
            }

            if (UserExists())
            {
                return;
            }
            DataBase db = new DataBase();
            MySqlCommand commander = new MySqlCommand("INSERT INTO Сотрудники (`Фамилия`, `Имя`, `Отчество`, `Телефон`, `Адрес`, `логин`, `пароль`) VALUES (@surname, @name, @otch, @tel, @adrs, @log, @pas)", db.GetConnection());

            commander.Parameters.Add("@surname", MySqlDbType.VarChar).Value = UserSurname.Text;
            commander.Parameters.Add("@name", MySqlDbType.VarChar).Value = UserName.Text;
            commander.Parameters.Add("@otch", MySqlDbType.VarChar).Value = UserOtch.Text;
            commander.Parameters.Add("@tel", MySqlDbType.VarChar).Value = UserPhone.Text;
            commander.Parameters.Add("@adrs", MySqlDbType.VarChar).Value = UserAdress.Text;
            commander.Parameters.Add("@log", MySqlDbType.VarChar).Value = UserNewLogin.Text;
            commander.Parameters.Add("@pas", MySqlDbType.VarChar).Value = UserNewPassword.Text;

            db.openConnect();

            if (UserSurname.Text.Any(a => (a >= 'A' && a <= 'z') || UserName.Text.Any(b => (b >= 'A' && b <= 'z') || UserOtch.Text.Any(c => (c >= 'A' && c <= 'z')))))
            {
                MessageBox.Show("Латинские символы недопустимы!");
                return;
            }

            if (commander.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт успешно создан", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Не удалось создать аккаунт", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            db.closeConnect();
        }
    }
}
