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
    public partial class Guests : Form
    {
        public Guests()
        {
            InitializeComponent();
        }

        private void постояльцыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.постояльцыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.vibeDataSet);

        }

        private void Guests_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "vibeDataSet.Постояльцы". При необходимости она может быть перемещена или удалена.
            this.постояльцыTableAdapter.Fill(this.vibeDataSet.Постояльцы);

        }
    }
}
