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
    public partial class Firm : Form
    {
        public Firm()
        {
            InitializeComponent();
        }

        private void Firm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void Firm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.main.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Все изменения в системе будут сохранены в базе данных.\r\n" +
               "Продолжить сохранение?",
               "Подтвердите сохранение",
               MessageBoxButtons.YesNo) == DialogResult.Yes)
                try
                {
                    фирмаTableAdapter.Update(logisticDataSet.фирма);
                    MessageBox.Show("Изменения сохранены");
                    loadData();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void loadData()
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "logisticDataSet.фирма". При необходимости она может быть перемещена или удалена.
            this.фирмаTableAdapter.Fill(this.logisticDataSet.фирма);
        }
    }
}
