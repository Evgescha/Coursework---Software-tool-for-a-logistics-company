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
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }

        private void Order_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.main.Show();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Все изменения в системе будут сохранены в базе данных.\r\n" +
              "Продолжить сохранение?",
              "Подтвердите сохранение",
              MessageBoxButtons.YesNo) == DialogResult.Yes)
                try
                {
                    заказTableAdapter.Update(logisticDataSet.заказ);
                    MessageBox.Show("Изменения сохранены");
                    loadData();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void loadData()
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "logisticDataSet.водитель". При необходимости она может быть перемещена или удалена.
            this.водительTableAdapter.Fill(this.logisticDataSet.водитель);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "logisticDataSet.трейлер". При необходимости она может быть перемещена или удалена.
            this.трейлерTableAdapter.Fill(this.logisticDataSet.трейлер);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "logisticDataSet.заказ". При необходимости она может быть перемещена или удалена.
            this.заказTableAdapter.Fill(this.logisticDataSet.заказ);
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            заказBindingSource.Filter = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            заказBindingSource.Filter = "[Расстояние_км] <500";
        }
    }
}
