using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demonstracja
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void пользователиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.пользователиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.vibemanDataSet);

        }

        private void Users_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "vibemanDataSet.Пользователи". При необходимости она может быть перемещена или удалена.
            this.пользователиTableAdapter.Fill(this.vibemanDataSet.Пользователи);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "vibeDataSet.Пользователи". При необходимости она может быть перемещена или удалена.
            this.пользователиTableAdapter.Fill(this.vibemanDataSet.Пользователи);

        }

        private void пользователиBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.пользователиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.vibemanDataSet);

        }
    }
}
