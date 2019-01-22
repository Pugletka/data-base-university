using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Maket_2018
{
    public partial class Otcheti : Form
    {
        public Otcheti()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form ifrm = new Admin();
            ifrm.Show();
            this.Hide();
        }

        private void Otcheti_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "maketDataSet2.Administration". При необходимости она может быть перемещена или удалена.
            this.administrationTableAdapter1.Fill(this.maketDataSet2.Administration);
        

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form ifrm = new Отчёт1();
            ifrm.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form ifrm = new Отчёт2();
            ifrm.Show();
            this.Hide();
        }
    }
}
