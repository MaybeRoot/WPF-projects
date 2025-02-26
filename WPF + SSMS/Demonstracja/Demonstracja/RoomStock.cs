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
    public partial class RoomStock : Form
    {
        public RoomStock()
        {
            InitializeComponent();
        }

        private void номернойФондBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.номернойФондBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.vibeDataSet);

        }

        private void RoomStock_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "vibeDataSet.НомернойФонд". При необходимости она может быть перемещена или удалена.
            this.номернойФондTableAdapter.Fill(this.vibeDataSet.НомернойФонд);

        }
    }
}
