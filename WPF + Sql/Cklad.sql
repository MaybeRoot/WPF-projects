-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1:3306
-- Время создания: Апр 21 2024 г., 20:58
-- Версия сервера: 5.6.51
-- Версия PHP: 7.2.34

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `Cklad`
--

-- --------------------------------------------------------

--
-- Структура таблицы `Поставка`
--

CREATE TABLE `Поставка` (
  `ID_Поставки` int(11) NOT NULL,
  `ID_Товара` int(11) NOT NULL,
  `Количество` int(32) NOT NULL,
  `ЕдиницаИзмер` varchar(16) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `Поставка`
--

INSERT INTO `Поставка` (`ID_Поставки`, `ID_Товара`, `Количество`, `ЕдиницаИзмер`) VALUES
(1, 1, 4, 'комплекта'),
(2, 2, 5, 'штук(а)'),
(4, 4, 40, 'штук(а)'),
(5, 3, 50, 'штук(а)'),
(6, 1, 5, 'комплектов');

-- --------------------------------------------------------

--
-- Структура таблицы `Поставщики`
--

CREATE TABLE `Поставщики` (
  `ID_Поставщика` int(16) NOT NULL,
  `Фамилия` varchar(32) NOT NULL,
  `Имя` varchar(32) NOT NULL,
  `Отчество` varchar(32) NOT NULL,
  `Телефон` bigint(32) NOT NULL,
  `Адрес` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `Поставщики`
--

INSERT INTO `Поставщики` (`ID_Поставщика`, `Фамилия`, `Имя`, `Отчество`, `Телефон`, `Адрес`) VALUES
(1, 'Соколов', 'Константин', 'Вадимович', 9823756789, 'г. Ростов-на-Дону, ул. Извилистая 13/2'),
(2, 'Ханджа', 'Игорь', 'Степанович', 9882424141, 'г. Ростов-на-Дону, ул. Большая Садовая 213'),
(3, 'Киселёв', 'Максим', 'Евгенеевич', 9185523523, 'г. Ростов-на-Дону, пр. Ворошиловский 65'),
(6, 'Микрочел', 'Алексей', 'Витальевич', 9782234561, 'г. Ростов-на-Дону, пр. Ворошиловский 23А'),
(7, 'Макрочел', 'Иван', 'Алексеевич', 9816776321, 'г. Батайск, ул. Фрунзе 125');

-- --------------------------------------------------------

--
-- Структура таблицы `Склад`
--

CREATE TABLE `Склад` (
  `ID_Склада` int(11) NOT NULL,
  `ID_Сотрудника` int(11) NOT NULL,
  `ID_Поставки` int(11) NOT NULL,
  `Название` varchar(255) NOT NULL,
  `Адрес` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `Склад`
--

INSERT INTO `Склад` (`ID_Склада`, `ID_Сотрудника`, `ID_Поставки`, `Название`, `Адрес`) VALUES
(1, 1, 1, 'Склад номер 1', 'г. Ростов-на-Дону, ул. Красноармейская 256'),
(2, 5, 2, 'Склад номер 2', 'г. Ростов-на-Дону, ул. Максима Горького 214'),
(3, 5, 5, 'Склад номер 2', 'г. Ростов-на-Дону, ул. Максима Горького 214');

-- --------------------------------------------------------

--
-- Структура таблицы `Товары`
--

CREATE TABLE `Товары` (
  `ID_Товара` int(11) NOT NULL,
  `ID_Поставщика` int(16) NOT NULL,
  `Наименование` varchar(255) NOT NULL,
  `Цена` int(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `Товары`
--

INSERT INTO `Товары` (`ID_Товара`, `ID_Поставщика`, `Наименование`, `Цена`) VALUES
(1, 1, 'Жалюзи', 3000),
(2, 2, 'Тумба', 2500),
(3, 6, 'Розетка', 150),
(4, 7, 'Лампа', 750),
(7, 3, 'Стол', 4000);

-- --------------------------------------------------------

--
-- Структура таблицы `Сотрудники`
--

CREATE TABLE `Сотрудники` (
  `ID_Сотрудника` int(11) NOT NULL,
  `Фамилия` varchar(32) NOT NULL,
  `Имя` varchar(32) NOT NULL,
  `Отчество` varchar(32) NOT NULL,
  `Телефон` bigint(32) NOT NULL,
  `Адрес` varchar(255) NOT NULL,
  `логин` varchar(100) NOT NULL,
  `пароль` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `Сотрудники`
--

INSERT INTO `Сотрудники` (`ID_Сотрудника`, `Фамилия`, `Имя`, `Отчество`, `Телефон`, `Адрес`, `логин`, `пароль`) VALUES
(1, 'Логвинов', 'Илья', 'Сергеевич', 89287731123, 'г. Ростов-на-Дону, ул. Пушкина 145', 'ilogvin', '545'),
(5, 'Цаль', 'Игорь', 'Кириллович', 89184256782, 'г. Ростов-на-Дону, ул. Максима Горького 52', 'tsalik', '765');

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `Поставка`
--
ALTER TABLE `Поставка`
  ADD PRIMARY KEY (`ID_Поставки`),
  ADD KEY `ID_Товара` (`ID_Товара`);

--
-- Индексы таблицы `Поставщики`
--
ALTER TABLE `Поставщики`
  ADD PRIMARY KEY (`ID_Поставщика`);

--
-- Индексы таблицы `Склад`
--
ALTER TABLE `Склад`
  ADD PRIMARY KEY (`ID_Склада`),
  ADD KEY `ID_Сотрудника` (`ID_Сотрудника`),
  ADD KEY `ID_Поставки` (`ID_Поставки`);

--
-- Индексы таблицы `Товары`
--
ALTER TABLE `Товары`
  ADD PRIMARY KEY (`ID_Товара`),
  ADD KEY `ID_Поставщика` (`ID_Поставщика`);

--
-- Индексы таблицы `Сотрудники`
--
ALTER TABLE `Сотрудники`
  ADD PRIMARY KEY (`ID_Сотрудника`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `Поставка`
--
ALTER TABLE `Поставка`
  MODIFY `ID_Поставки` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT для таблицы `Поставщики`
--
ALTER TABLE `Поставщики`
  MODIFY `ID_Поставщика` int(16) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT для таблицы `Склад`
--
ALTER TABLE `Склад`
  MODIFY `ID_Склада` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT для таблицы `Товары`
--
ALTER TABLE `Товары`
  MODIFY `ID_Товара` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT для таблицы `Сотрудники`
--
ALTER TABLE `Сотрудники`
  MODIFY `ID_Сотрудника` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `Поставка`
--
ALTER TABLE `Поставка`
  ADD CONSTRAINT `поставка_ibfk_1` FOREIGN KEY (`ID_Товара`) REFERENCES `Товары` (`ID_Товара`);

--
-- Ограничения внешнего ключа таблицы `Склад`
--
ALTER TABLE `Склад`
  ADD CONSTRAINT `склад_ibfk_1` FOREIGN KEY (`ID_Поставки`) REFERENCES `Поставка` (`ID_Поставки`),
  ADD CONSTRAINT `сотрудники_ibfk_2` FOREIGN KEY (`ID_Сотрудника`) REFERENCES `Сотрудники` (`ID_Сотрудника`);

--
-- Ограничения внешнего ключа таблицы `Товары`
--
ALTER TABLE `Товары`
  ADD CONSTRAINT `товары_ibfk_1` FOREIGN KEY (`ID_Поставщика`) REFERENCES `Поставщики` (`ID_Поставщика`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
