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
    public partial class Main : Form
    {
        public static Main main;
        public Main()
        {
            InitializeComponent();
            main = this;
        }

        private void Main_Load(object sender, EventArgs e)
        {
          
        }

        private void справочникМарокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Brand().Show();
            this.Hide();
        }

        private void справочникФирмToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Firm().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Trailer().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Driver().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Order().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new MaxOrderCountByTrailer().Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new MaxOrderCount().Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new SummaryMoney().Show();
            this.Hide();
        }
    }
}
