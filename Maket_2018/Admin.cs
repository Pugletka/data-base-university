using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maket_2018
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vvod redakt = new Vvod();
            redakt.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form ifrm = new Form2();
            ifrm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Запросы zap = new Запросы();
            zap.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Otcheti otc = new Otcheti();
            otc.ShowDialog();
        }
    }
}
