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
    public partial class Отчёт2 : Form
    {
        public Отчёт2()
        {
            InitializeComponent();
        }

        private void Отчёт2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "MaketDataSet2.Administration". При необходимости она может быть перемещена или удалена.
            this.AdministrationTableAdapter.Fill(this.MaketDataSet2.Administration);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
