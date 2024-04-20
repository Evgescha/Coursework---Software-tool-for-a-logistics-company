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
    public partial class SummaryMoney : Form
    {
        public SummaryMoney()
        {
            InitializeComponent();
        }

        private void SummaryMoney_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "logisticDataSet.SummaryMoney". При необходимости она может быть перемещена или удалена.
            this.summaryMoneyTableAdapter.FillBySummaruMoney(this.logisticDataSet.SummaryMoney);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++) {
                try {
                    sum += float.Parse(dataGridView1[3, i].Value.ToString());
                } catch(Exception ex) { }
            }
            MessageBox.Show($"Общая сумма по заказам составила {sum}");
        }

        private void SummaryMoney_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.main.Show();
        }
    }
}
