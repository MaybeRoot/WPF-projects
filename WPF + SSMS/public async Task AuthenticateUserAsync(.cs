public async Task AuthenticateUserAsync(string username, string password)
{
    // Соединение с базой данных (предполагается, что у вас уже есть строка подключения)
    string connectionString = "Data Source= ;Initial Catalog=Vibeman;Integrated Security=True;"; // В DataSource подставляется имя локального сервера SSMS или IP-aдрес

    using (SqlConnection connection = new SqlConnection(connectionString))
    {
        // Открываем соединение
        await connection.OpenAsync();

        // Запрос для проверки логина и пароля
        string query = "SELECT COUNT(*) FROM Пользователи WHERE Логин = @login AND Пароль = @pass";

        using (SqlCommand command = new SqlCommand(query, connection))
        {
            // Добавляем параметры
            command.Parameters.AddWithValue("@login", username);
            command.Parameters.AddWithValue("@pass", password);

            try
            {
                // Выполняем запрос асинхронно
                int count = (int)await command.ExecuteScalarAsync();

                var result = await command.ExecuteScalarAsync();


                if (result != null)
                {
                    string userRole = result.ToString();

                    // Открываем главное меню с ролью пользователя
                    MainForm mainMenu = new MainForm(userRole);
                    mainMenu.Show();
                    MessageBox.Show("Успешная авторизация!");
                }
                else
                {
                    // Проверяем, является ли ошибка неверным логином или паролем
                    if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                    {
                        MessageBox.Show("Введите логин и пароль");
                    }
                    else
                    {
                        // Проверяем сначала на неправильный логин, затем на пароль
                        string loginQuery = "SELECT COUNT(1) FROM Пользователи WHERE Логин = @login";
                        using (SqlCommand loginCommand = new SqlCommand(loginQuery, connection))
                        {
                            loginCommand.Parameters.AddWithValue("@login", username);
                            int loginCount = (int)await loginCommand.ExecuteScalarAsync();

                            if (loginCount == 0)
                            {
                                MessageBox.Show("Неверный логин");
                            }
                            else
                            {
                                MessageBox.Show("Неверный пароль");
                            }
                        }
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