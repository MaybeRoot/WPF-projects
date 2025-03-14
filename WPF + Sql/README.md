# Документация к проекту: Win Forms .Net Core и OSP
## Ввденение
Проект представляет собой систему авторизации для компании с возможностью регистрации новых пользователей, проверкой уровня доступа и управлением данными через интерактивные формы.
**Основные функции:**
- Регистрация и авторизация пользователей.
- Хранение данных в Microsoft SQL Server.
- Взаимодействие с данными БД через UI.

## Требования 
- Среда разработки: Visual Studio 2022 или выше.
- Платформа: .NET Framework 4.8.
- База данных: Open Serber Panel 5.7+.
- Дополнительно: Библиотеки для работы с SQL (System.Data.SqlClient).

## Установка и настройка
1. Открыть Open Server Panel и запустить локальный сервер
2. Открыть PHPMyAdmin и перейти на вкладку Экспорт
3. Экспортировать предварително скачанный Cklad.sql
*В проекте уже указан путь подключения, при необходимости поменяйте следующую строчку в классе DataBase*
```csharp
// Строка подключения к БД
MySqlConnection connection = new MySqlConnection("server = localhost; port = 3306; username = root; password = ; database = Cklad");
    }
}
```
***👍 Теперь можно пользоваться***

## Архитектура проекта
### Слои приложения 
- UI (Пользовательский интерфейс)
  - **LoginForm** : форма авторизации
  - **RegistrationForm** : форма регистрации
  - **MainForm** : главная форма
- Бизнес-логика
  - При нажатии на кнопку *LoginButton* происходит проверка введённых учётных данных
  - Класс *UserExists* используется при регистрации для проверки введёных о пользователе данных на сходство с уже имеющимися

## Руководство пользователя
### Регистрация
- Запустите приложение.
- Нажмите "Зарегистрироваться".
- Введите логин, пароль и выберите роль (если доступно).
- Данные сохранятся в БД.

### Авторизация
- Введите логин и пароль.
- При успехе система перенаправит в MainForm.
- При ошибке появится сообщение "Вы ввели неверный логин или пароль".
