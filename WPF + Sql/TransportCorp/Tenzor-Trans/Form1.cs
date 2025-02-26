using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Tenzor_Trans
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            String UserLogin = LoginUser.Text;
            String UserPass = LoginPass.Text;

            DataBase db = new DataBase();

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM Сотрудники WHERE логин = @uL AND пароль = @uP", db.GetConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = UserLogin;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = UserPass;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь авторизован", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainForm mainForm = new MainForm();
                mainForm.Show();
                Hide();
            }
            else
                MessageBox.Show("Введён неверный логин или пароль ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (LoginUser.Text == "" && LoginPass.Text == "")
            {
                MessageBox.Show("Вы ввели недостаточно данных");
            }
        }

        private void GoToRegistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm RegForm = new RegistrationForm();
            RegForm.Show();
            Hide();
        }
    }
}
