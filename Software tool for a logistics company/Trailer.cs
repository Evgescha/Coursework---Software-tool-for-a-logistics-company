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
    public partial class Trailer : Form
    {
        public Trailer()
        {
            InitializeComponent();
        }

        private void Trailer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.main.Show();
        }

        private void Trailer_Load(object sender, EventArgs e)
        {
            loadData();           
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dataGridView2_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Все изменения в системе будут сохранены в базе данных.\r\n" +
              "Продолжить сохранение?",
              "Подтвердите сохранение",
              MessageBoxButtons.YesNo) == DialogResult.Yes)
                try
                {
                    трейлерTableAdapter.Update(logisticDataSet.трейлер);
                    MessageBox.Show("Изменения сохранены");
                    loadData();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void loadData()
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "logisticDataSet.водитель". При необходимости она может быть перемещена или удалена.
            this.водительTableAdapter.Fill(this.logisticDataSet.водитель);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "logisticDataSet.заказ". При необходимости она может быть перемещена или удалена.
            this.заказTableAdapter.Fill(this.logisticDataSet.заказ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "logisticDataSet.фирма". При необходимости она может быть перемещена или удалена.
            this.фирмаTableAdapter.Fill(this.logisticDataSet.фирма);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "logisticDataSet.марка". При необходимости она может быть перемещена или удалена.
            this.маркаTableAdapter.Fill(this.logisticDataSet.марка);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "logisticDataSet.трейлер". При необходимости она может быть перемещена или удалена.
            this.трейлерTableAdapter.Fill(this.logisticDataSet.трейлер);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.трейлерTableAdapter.FillByTop5BySize(this.logisticDataSet.трейлер);
        }
    }
}
