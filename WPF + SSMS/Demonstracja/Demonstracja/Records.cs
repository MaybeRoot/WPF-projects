using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.IO;
using ClosedXML.Excel;
using System.Data.SqlClient;

namespace Demonstracja
{
    public partial class Records : Form
    {
        public Records()
        {
            InitializeComponent();
        }

        private async void recordGen_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=  ;Initial Catalog=Vibeman;Integrated Security=True;"; // В DataSource подставляется имя локального сервера SSMS или IP-aдрес
            string excelFilePath = "D:\\Отчёт.xlsx"; // Путь сохранения отчёта 

            try
            {
                // Создаём Excel-документ
                using (var workbook = new XLWorkbook())
                {
                    // Проверяем, какой RadioButton выбран
                    if (GuestsBase.Checked)
                    {
                        await ExportTableToExcel(workbook, connectionString, "Постояльцы");
                    }
                    else if (ClientsBase.Checked)
                    {
                        await ExportTableToExcel(workbook, connectionString, "Клиент");
                    }
                    else if (RoomsBase.Checked)
                    {
                        await ExportTableToExcel(workbook, connectionString, "НомернойФонд");
                    }
                    else
                    {
                        MessageBox.Show("Пожалуйста, выберите таблицу для экспорта.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Сохраняем Excel-файл
                    workbook.SaveAs(excelFilePath);
                    MessageBox.Show($"Данные успешно выгружены в файл: {excelFilePath}", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private static async Task ExportTableToExcel(XLWorkbook workbook, string connectionString, string tableName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();
                // Получаем данные из таблицы
                string query = $"SELECT * FROM {tableName}";
                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    // Добавляем данные в Excel-лист
                    var worksheet = workbook.Worksheets.Add(tableName);
                    worksheet.Cell(1, 1).InsertTable(dataTable);
                    // Настраиваем ширину столбцов
                    worksheet.Columns().AdjustToContents();
                }
            }
        }

        private void Records_Load(object sender, EventArgs e)
        {

        }
    }
}