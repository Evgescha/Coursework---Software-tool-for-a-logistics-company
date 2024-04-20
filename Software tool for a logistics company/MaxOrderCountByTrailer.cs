using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_tool_for_a_logistics_company
{
    public partial class MaxOrderCountByTrailer : Form
    {
        public MaxOrderCountByTrailer()
        {
            InitializeComponent();
        }

        private void MaxOrderCount_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "logisticDataSet.трейлер". При необходимости она может быть перемещена или удалена.
            this.трейлерTableAdapter.Fill(this.logisticDataSet.трейлер);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "logisticDataSet.TrailerOrderCount". При необходимости она может быть перемещена или удалена.
            this.trailerOrderCountTableAdapter.FillByTrailerWithMaxOrderCount(this.logisticDataSet.TrailerOrderCount);
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void MaxOrderCount_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.main.Show();
        }
    }
}
