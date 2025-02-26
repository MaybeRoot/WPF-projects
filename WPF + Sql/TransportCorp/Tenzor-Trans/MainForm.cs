using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Tenzor_Trans
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadData();
            FillSupplyComboBox();
            FillProviderComboBox();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            Hide();
        }

        public void LoadData()
        {
            DataBase db = new DataBase();
            string connectString = "server=localhost;database=Cklad;Uid=root;Pwd=;";
            MySqlConnection myConnection = new MySqlConnection(connectString);

            myConnection.Open();

            // Первый запрос
            string query = "SELECT ID_Склада, Сотрудники.ID_Сотрудника, Фамилия, Имя, Поставка.ID_Поставки, Товары.Наименование, Название, Склад.Адрес FROM Склад JOIN Сотрудники ON Склад.ID_Сотрудника = Сотрудники.ID_Сотрудника JOIN Поставка ON Склад.ID_Поставки = Поставка.ID_Поставки JOIN Товары ON Поставка.ID_Товара = Товары.ID_Товара ORDER BY ID_Склада;";
            MySqlCommand command = new MySqlCommand(query, myConnection);
            MySqlDataReader reader = command.ExecuteReader();
            List<string[]> dataSklad = new List<string[]>();
            while (reader.Read())
            {
                dataSklad.Add(new string[8]);
                dataSklad[dataSklad.Count - 1][0] = reader[0].ToString();
                dataSklad[dataSklad.Count - 1][1] = reader[1].ToString();
                dataSklad[dataSklad.Count - 1][2] = reader[2].ToString();
                dataSklad[dataSklad.Count - 1][3] = reader[3].ToString();
                dataSklad[dataSklad.Count - 1][4] = reader[4].ToString();
                dataSklad[dataSklad.Count - 1][5] = reader[5].ToString();
                dataSklad[dataSklad.Count - 1][6] = reader[6].ToString();
                dataSklad[dataSklad.Count - 1][7] = reader[7].ToString();
            }
            reader.Close();
            foreach (string[] s in dataSklad)
                SkladDataGrid.Rows.Add(s);

            // Второй запрос
            string query2 = "SELECT ID_Поставки, ID_Товара, Количество, ЕдиницаИзмер FROM Поставка ORDER BY ID_Поставки";
            MySqlCommand command2 = new MySqlCommand(query2, myConnection);
            MySqlDataReader reader2 = command2.ExecuteReader();
            List<string[]> dataSupply = new List<string[]>();
            while (reader2.Read())
            {
                dataSupply.Add(new string[4]);
                dataSupply[dataSupply.Count - 1][0] = reader2[0].ToString();
                dataSupply[dataSupply.Count - 1][1] = reader2[1].ToString();
                dataSupply[dataSupply.Count - 1][2] = reader2[2].ToString();
                dataSupply[dataSupply.Count - 1][3] = reader2[3].ToString();
            }
            reader2.Close();
            foreach (string[] s2 in dataSupply)
                SupplyDataGrid.Rows.Add(s2);

            // Третий запрос
            string query3 = "SELECT ID_Товара, ID_Поставщика, Наименование, Цена FROM Товары ORDER BY ID_Товара";
            MySqlCommand command3 = new MySqlCommand(query3, myConnection);
            MySqlDataReader reader3 = command3.ExecuteReader();
            List<string[]> dataProd = new List<string[]>();
            while (reader3.Read())
            {
                dataProd.Add(new string[4]);
                dataProd[dataProd.Count - 1][0] = reader3[0].ToString();
                dataProd[dataProd.Count - 1][1] = reader3[1].ToString();
                dataProd[dataProd.Count - 1][2] = reader3[2].ToString();
                dataProd[dataProd.Count - 1][3] = reader3[3].ToString();
            }
            reader3.Close();
            foreach (string[] s3 in dataProd)
                ProductDataGrid.Rows.Add(s3);

            // Четвертый запрос
            string query4 = "SELECT ID_Поставщика, Фамилия, Имя, Отчество, Телефон, Адрес FROM Поставщики ORDER BY ID_Поставщика";
            MySqlCommand command4 = new MySqlCommand(query4, myConnection);
            MySqlDataReader reader4 = command4.ExecuteReader();
            List<string[]> dataProvider = new List<string[]>();
            while (reader4.Read())
            {
                dataProvider.Add(new string[6]);
                dataProvider[dataProvider.Count - 1][0] = reader4[0].ToString();
                dataProvider[dataProvider.Count - 1][1] = reader4[1].ToString();
                dataProvider[dataProvider.Count - 1][2] = reader4[2].ToString();
                dataProvider[dataProvider.Count - 1][3] = reader4[3].ToString();
                dataProvider[dataProvider.Count - 1][4] = reader4[4].ToString();
                dataProvider[dataProvider.Count - 1][5] = reader4[5].ToString();
            }
            reader4.Close();
            foreach (string[] s4 in dataProvider)
                ProviderDataGrid.Rows.Add(s4);

            myConnection.Close();
        }


        private void FillSupplyComboBox()
        {
            DataBase db = new DataBase();
            string connectString = "server=localhost;database=Cklad;Uid=root;Pwd=;";
            MySqlConnection myConnection = new MySqlConnection(connectString);
            myConnection.Open();
            ComboBoxSupp.Items.Clear();
            string query = "SELECT ID_Сотрудника, Имя, Фамилия FROM Сотрудники ORDER BY ID_Сотрудника";
            MySqlCommand command = new MySqlCommand(query, myConnection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string EmlpoName = $"{reader["Имя"]} {reader["Фамилия"]}";
                ComboBoxEmplo.Items.Add(new KeyValuePair<int, string>((int)reader["ID_Сотрудника"], EmlpoName));
            }
            reader.Close();

            string query2 = "SELECT Поставка.ID_Поставки, Товары.Наименование FROM Товары, Поставка WHERE Поставка.ID_Товара = Товары.ID_Товара ORDER BY Товары.ID_Товара";
            MySqlCommand command2 = new MySqlCommand(query2, myConnection);
            MySqlDataReader reader2 = command2.ExecuteReader();
            while (reader2.Read())
            {
                string SupplyName = $"{reader2["Наименование"]}";
                ComboBoxSupp.Items.Add(new KeyValuePair<int, string>((int)reader2["ID_Поставки"], SupplyName));
                SupplyComboBox.Items.Add(new KeyValuePair<int, string>((int)reader2["ID_Поставки"], SupplyName));
            }
            reader2.Close();
            myConnection.Close();

        }
        private void FillProviderComboBox()
        {
            DataBase db = new DataBase();
            string connectString = "server=localhost;database=Cklad;Uid=root;Pwd=;";
            MySqlConnection myConnection = new MySqlConnection(connectString);
            myConnection.Open();
            ComboBoxProvider.Items.Clear();
            string query = "SELECT * FROM Поставщики ORDER BY ID_Поставщика";
            MySqlCommand command = new MySqlCommand(query, myConnection);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string providerName = $"{reader["Имя"]} {reader["Фамилия"]}";
                ComboBoxProvider.Items.Add(new KeyValuePair<int, string>((int)reader["ID_Поставщика"], providerName));
            }
            reader.Close();
            myConnection.Close();
        }

        public void RefreshData()
        {
            SkladDataGrid.Rows.Clear();
            LoadData();
        }

        private void SkladEnterBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void SkladDelBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void SkladDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SkladPage_Click(object sender, EventArgs e)
        {

        }

        private void SkladEnterBtn_Click_1(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            MySqlCommand commander = new MySqlCommand("INSERT INTO Склад (ID_Сотрудника, ID_Поставки, Название, Адрес) VALUES (@EID, @SID, @Pcnt , @Pmeas)", db.GetConnection());

            commander.Parameters.Add("@EID", MySqlDbType.Int16).Value = ((KeyValuePair<int, string>)ComboBoxEmplo.SelectedItem).Key;
            commander.Parameters.Add("@SID", MySqlDbType.Int16).Value = ((KeyValuePair<int, string>)ComboBoxSupp.SelectedItem).Key;
            commander.Parameters.Add("@Pcnt", MySqlDbType.VarChar).Value = SkladName.Text;
            commander.Parameters.Add("@Pmeas", MySqlDbType.VarChar).Value = SkladAdress.Text;
            db.openConnect();
            if (SkladName.Text.Any(a => (a >= 'A' && a <= 'z')) || SkladAdress.Text.Any(a => (a >= 'A' && a <= 'z')))
            {
                MessageBox.Show("Латинские символы недопустимы!");
                return;
            }

            if (commander.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Запись добавлена успешно");
                RefreshData();
            }
            else MessageBox.Show("Не удалось добавить запись");

            db.closeConnect();
        }

        private void SkladDelBtn_Click_1(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            if (SkladDataGrid.SelectedRows.Count > 0) // Проверка наличия выбранных строк для удаления
            {
                int selectedIndex = SkladDataGrid.SelectedRows[0].Index; // Получение индекса выбранной строки
                int idToDelete = Convert.ToInt32(SkladDataGrid.Rows[selectedIndex].Cells["ID_Склада"].Value);

                MySqlCommand command = new MySqlCommand("DELETE FROM Склад WHERE ID_Склада = @id", db.GetConnection());
                command.Parameters.Add("@id", MySqlDbType.Int32).Value = idToDelete;

                db.openConnect();
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Запись успешно удалена");
                    RefreshData(); // Обновить DataGridView после удаления записи
                }
                else
                {
                    MessageBox.Show("Не удалось удалить запись");
                }
                db.closeConnect();
            }
            else
            {
                MessageBox.Show("Выберите строку для удаления");
            }
        }
        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void SuppEnterBtn_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            MySqlCommand commander = new MySqlCommand("INSERT INTO Поставка (ID_Поставки, ID_Товара, Количество, ЕдиницаИзмер) VALUES (NULL, @PID, @Pcnt , @Pmeas)", db.GetConnection());

            commander.Parameters.Add("@PID", MySqlDbType.Int16).Value = ((KeyValuePair<int, string>)SupplyComboBox.SelectedItem).Key;
            commander.Parameters.Add("@Pcnt", MySqlDbType.VarChar).Value = SupplyCount.Text;
            commander.Parameters.Add("@Pmeas", MySqlDbType.VarChar).Value = SupplyMeasure.Text;
            db.openConnect();
            if (SupplyMeasure.Text.Any(a => (a >= 'A' && a <= 'z')))
            {
                MessageBox.Show("Латинские символы недопустимы!");
                return;
            }

            if (commander.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Запись добавлена успешно");
                RefreshData();
            }
            else MessageBox.Show("Не удалось добавить запись");

            db.closeConnect();
        }

        private void SuppDelBtn_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            if (SupplyDataGrid.SelectedRows.Count > 0) // Проверка наличия выбранных строк для удаления
            {
                int selectedIndex = SupplyDataGrid.SelectedRows[0].Index; // Получение индекса выбранной строки
                int idToDelete = Convert.ToInt32(SupplyDataGrid.Rows[selectedIndex].Cells["ID_Поставки"].Value);

                MySqlCommand delcommand = new MySqlCommand("DELETE FROM Поставка WHERE ID_Поставки = @id", db.GetConnection());
                delcommand.Parameters.Add("@id", MySqlDbType.Int32).Value = idToDelete;

                db.openConnect();
                if (delcommand.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Запись успешно удалена");
                    RefreshData(); // Обновить DataGridView после удаления записи
                }
                else
                {
                    MessageBox.Show("Не удалось удалить запись");
                }
                db.closeConnect();
            }
            else
            {
                MessageBox.Show("Выберите строку для удаления");
            }
        }

        private void ProviderEnterBtn_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            MySqlCommand commander = new MySqlCommand("INSERT INTO Поставщики (`Фамилия`, `Имя`, `Отчество`, `Телефон`, `Адрес`) VALUES (@surname, @name , @otch, @tel, @adres)", db.GetConnection());

            commander.Parameters.Add("@surname", MySqlDbType.VarChar).Value = ProviderSurname.Text;
            commander.Parameters.Add("@name", MySqlDbType.VarChar).Value = ProviderName.Text;
            commander.Parameters.Add("@otch", MySqlDbType.VarChar).Value = ProviderOtch.Text;
            commander.Parameters.Add("@tel", MySqlDbType.VarChar).Value = ProviderPhone.Text;
            commander.Parameters.Add("@adres", MySqlDbType.VarChar).Value = ProviderAdress.Text;
            db.openConnect();
            if (ProviderName.Text.Any(a => (a >= 'A' && a <= 'z') || ProviderSurname.Text.Any(b => (b >= 'A' && b <= 'z') || ProviderOtch.Text.Any(c => (c >= 'A' && c <= 'z')))))
            {
                MessageBox.Show("Латинские символы недопустимы!");
                return;
            }

            if (commander.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Поставщик успешно добавлен");
                RefreshData();
            }
            else MessageBox.Show("Не удалось добавить поставщика");

            db.closeConnect();
        }

        private void ProviderDelBtn_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            if (ProviderDataGrid.SelectedRows.Count > 0) // Проверка наличия выбранных строк для удаления
            {
                int selectedIndex = ProviderDataGrid.SelectedRows[0].Index; // Получение индекса выбранной строки
                int idToDelete = Convert.ToInt32(ProviderDataGrid.Rows[selectedIndex].Cells["ID_Поставщика"].Value);

                MySqlCommand command = new MySqlCommand("DELETE FROM Поставщики WHERE ID_Поставщика = @id", db.GetConnection());
                command.Parameters.Add("@id", MySqlDbType.Int32).Value = idToDelete;

                db.openConnect();
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Запись успешно удалена");
                    RefreshData(); // Обновить DataGridView после удаления записи
                }
                else
                {
                    MessageBox.Show("Не удалось удалить запись");
                }
                db.closeConnect();
            }
            else
            {
                MessageBox.Show("Выберите строку для удаления");
            }
        }

        private void ProdEnterBtn_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            MySqlCommand commander = new MySqlCommand("INSERT INTO Товары (ID_Товара,ID_Поставщика, Наименование, Цена) VALUES (NULL, @PID, @Pname , @ProdPr)", db.GetConnection());

            commander.Parameters.Add("@PID", MySqlDbType.Int16).Value = ((KeyValuePair<int, string>)ComboBoxProvider.SelectedItem).Key;
            commander.Parameters.Add("@Pname", MySqlDbType.VarChar).Value = ProductName.Text;
            commander.Parameters.Add("@ProdPr", MySqlDbType.VarChar).Value = Price.Text;
            db.openConnect();
            if (ProductName.Text.Any(a => (a >= 'A' && a <= 'z') || Price.Text.Any(b => (b >= 'A' && b <= 'z'))))
            {
                MessageBox.Show("Латинские символы недопустимы!");
                return;
            }

            if (commander.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Запись добавлена успешно");
                RefreshData();
            }
            else MessageBox.Show("Не удалось добавить запись");

            db.closeConnect();
        }

        private void ProdDelBtn_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            if (ProductDataGrid.SelectedRows.Count > 0) // Проверка наличия выбранных строк для удаления
            {
                int selectedIndex = ProductDataGrid.SelectedRows[0].Index; // Получение индекса выбранной строки
                int idToDelete = Convert.ToInt32(ProductDataGrid.Rows[selectedIndex].Cells["ID_Товара"].Value);

                MySqlCommand command = new MySqlCommand("DELETE FROM Товары WHERE ID_Товара = @id", db.GetConnection());
                command.Parameters.Add("@id", MySqlDbType.Int32).Value = idToDelete;

                db.openConnect();
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Запись успешно удалена");
                    RefreshData(); // Обновить DataGridView после удаления записи
                }
                else
                {
                    MessageBox.Show("Не удалось удалить запись");
                }
                db.closeConnect();
            }
            else
            {
                MessageBox.Show("Выберите строку для удаления");
            }
        }
    }
}
