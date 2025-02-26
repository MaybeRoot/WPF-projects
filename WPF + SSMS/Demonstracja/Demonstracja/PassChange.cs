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

namespace Demonstracja
{
    public partial class PassChange : Form
    {
        public string Username { get; set; } // Логин текущего пользователя

        public PassChange (string username)
        {
            InitializeComponent();
            Username = username; // Получаем текущий логин
        }

        private async void PassChangeBtn_Click(object sender, EventArgs e)
        {
            string currentPassword = CurPass.Text;
            string newPassword = NewPass.Text;
            string confirmPassword = PassValidation.Text;

            if (!ValidateInput(currentPassword, newPassword, confirmPassword))
            {
                return; // Если данные некорректны, останавливаем выполнение
            }

            MessageBox.Show("Пароль успешно изменён!","Удачно");
            await ChangePasswordAsync(Username, currentPassword, newPassword);
        }

        private bool ValidateInput(string currentPassword, string newPassword, string confirmPassword)
        {
            if (string.IsNullOrWhiteSpace(currentPassword) || string.IsNullOrWhiteSpace(newPassword) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Заполнены невсе поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Новый пароль и подтверждение не совпадают.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private async Task ChangePasswordAsync(string username, string currentPassword, string newPassword)
        {
            string connectionString = "Data Source= ;Initial Catalog=Vibeman;Integrated Security=True;"; // В DataSource подставляется имя локального сервера SSMS или IP-aдрес

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();

                // Проверяем текущий пароль
                string selectQuery = "SELECT Пароль FROM Пользователи WHERE Логин = @login";
                using (SqlCommand selectCommand = new SqlCommand(selectQuery, connection))
                {
                    selectCommand.Parameters.AddWithValue("@login", username);

                    var dbPassword = (string)await selectCommand.ExecuteScalarAsync();
                    if (dbPassword == null)
                    {
                        MessageBox.Show("Пользователь не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (dbPassword != currentPassword)
                    {
                        MessageBox.Show("Текущий пароль неверен.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Обновляем пароль
                string updateQuery = "UPDATE Пользователи SET Пароль = @newPassword WHERE Логин = @login";
                using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                {
                    updateCommand.Parameters.AddWithValue("@newPassword", newPassword);
                    updateCommand.Parameters.AddWithValue("@login", username);

                    await updateCommand.ExecuteNonQueryAsync();
                    MessageBox.Show("Пароль успешно изменён.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


    }
}
