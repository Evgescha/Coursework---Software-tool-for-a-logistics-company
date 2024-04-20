using System;
using System.Windows.Forms;

namespace Software_tool_for_a_logistics_company
{
    public partial class Brand : Form
    {
        public Brand()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Все изменения в системе будут сохранены в базе данных.\r\n" +
               "Продолжить сохранение?",
               "Подтвердите сохранение",
               MessageBoxButtons.YesNo) == DialogResult.Yes)
                try
                {
                    маркаTableAdapter.Update(logisticDataSet.марка);
                    MessageBox.Show("Изменения сохранены");
                    loadData();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void loadData()
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "logisticDataSet.марка". При необходимости она может быть перемещена или удалена.
            this.маркаTableAdapter.Fill(this.logisticDataSet.марка);
        }

        private void Brand_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void Brand_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.main.Show();
        }
    }
}
