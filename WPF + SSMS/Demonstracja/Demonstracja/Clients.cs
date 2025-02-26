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
    public partial class Clients : Form
    {
        public Clients()
        {
            InitializeComponent();
        }

        private void клиентBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.клиентBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.vibeDataSet);

        }

        private void Clients_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "vibeDataSet.Клиент". При необходимости она может быть перемещена или удалена.
            this.клиентTableAdapter.Fill(this.vibeDataSet.Клиент);

        }
    }
}
