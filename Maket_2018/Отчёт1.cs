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
    public partial class Отчёт1 : Form
    {
        public Отчёт1()
        {
            InitializeComponent();
        }

        private void Отчёт1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "MaketDataSet2.Administration". При необходимости она может быть перемещена или удалена.
            this.AdministrationTableAdapter.Fill(this.MaketDataSet2.Administration);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form ifrm = new Otcheti();
            ifrm.Show();
            this.Hide();
        }
    }
}
