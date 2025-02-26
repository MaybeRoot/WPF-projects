using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Demonstracja
{
    public partial class Author : Form
    {
        public Author()
        {
            InitializeComponent();
            
        }


        private async void AuthorBtn_Click(object sender, EventArgs e)
        {
            string username = UserLogin.Text;
            string password = UserPass.Text;
            await AuthenticateUserAsync(username, password);
        }
        // Словарь для отслеживания неудачных попыток входа
        private static readonly ConcurrentDictionary<string, int> FailedAttempts = new ConcurrentDictionary<string, int>();
        private const int MaxFailedAttempts = 3;

        public async Task AuthenticateUserAsync(string username, string password)
        {
            string connectionString = "Data Source= ; Initial Catalog=Vibeman;Integrated Security=True;"; // В DataSource подставляется имя локального сервера SSMS или IP-aдрес

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();

                // Запрос для проверки логина и пароля
                string query = "SELECT Логин, Роль, Доступ_запрещен, Пароль FROM Пользователи WHERE Логин = @login";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@login", username);

                    try
                    {
                        // Выполняем запрос и читаем результат
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            if (reader.Read())
                            {
                                string userRole = reader["Роль"].ToString();
                                string curUser = reader["Логин"].ToString();
                                string accessDenied = reader["Доступ_запрещен"].ToString();
                                string dbPassword = reader["Пароль"].ToString();

                                // Если доступ заблокирован
                                if (accessDenied.Equals("да", StringComparison.OrdinalIgnoreCase))
                                {
                                    MessageBox.Show("Ваш доступ заблокирован. Свяжитесь с администратором.");
                                    return;
                                }

                                // Проверяем пароль
                                if (password != dbPassword)
                                {
                                    reader.Close(); // Закрываем reader перед выполнением следующей команды

                                    // Увеличиваем счетчик неудачных попыток
                                    FailedAttempts.AddOrUpdate(username, 1, (_, attempts) => attempts + 1);
                                    int attemptsLeft = MaxFailedAttempts - FailedAttempts[username];

                                    // Если неудачных попыток >= MaxFailedAttempts, блокируем пользователя
                                    if (FailedAttempts[username] >= MaxFailedAttempts)
                                    {
                                        string blockUserQuery = "UPDATE Пользователи SET Доступ_запрещен = 'да' WHERE Логин = @login";
                                        using (SqlCommand blockCommand = new SqlCommand(blockUserQuery, connection))
                                        {
                                            blockCommand.Parameters.AddWithValue("@login", username);
                                            await blockCommand.ExecuteNonQueryAsync();
                                        }

                                        MessageBox.Show("Ваш доступ заблокирован из-за 3 неудачных попыток входа.");
                                        FailedAttempts.TryRemove(username, out _); // Удаляем запись из словаря
                                        return;
                                    }

                                    MessageBox.Show($"Неверный пароль. Осталось попыток: {attemptsLeft}");
                                    return;
                                }

                                // Если пароль верный, сбрасываем счетчик неудачных попыток
                                FailedAttempts.TryRemove(username, out _);

                                // Обновляем дату входа
                                reader.Close(); // Закрываем reader перед выполнением следующей команды
                                string updateLoginTimeQuery = "UPDATE Пользователи SET Последний_логин = GETDATE() WHERE Логин = @login";
                                using (SqlCommand updateCommand = new SqlCommand(updateLoginTimeQuery, connection))
                                {
                                    updateCommand.Parameters.AddWithValue("@login", username);
                                    await updateCommand.ExecuteNonQueryAsync();
                                }

                                // Открываем главное меню
                                MainForm mainMenu = new MainForm(curUser,userRole);
                                mainMenu.Show();
                                this.Hide();
                                MessageBox.Show("Пользователь успешно авторизован.");
                            }
                            else
                            {
                                // Если пользователь с таким логином не найден
                                MessageBox.Show("Неверный логин или пароль");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка: {ex.Message}");
                    }
                }
            }
        }
    }
}

