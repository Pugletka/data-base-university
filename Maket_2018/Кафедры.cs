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
    public partial class Кафедры : Form
    {
        public Кафедры()
        {
            InitializeComponent();
        }

        private void Кафедры_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "maketDataSet2.Faculties". При необходимости она может быть перемещена или удалена.
            this.facultiesTableAdapter.Fill(this.maketDataSet2.Faculties);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "maketDataSet2.Departments". При необходимости она может быть перемещена или удалена.
            this.departmentsTableAdapter.Fill(this.maketDataSet2.Departments);


            // TODO: данная строка кода позволяет загрузить данные в таблицу "maketDataSet2.Departments". При необходимости она может быть перемещена или удалена.
            this.departmentsTableAdapter.Fill(this.maketDataSet2.Departments);
          


        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            departmentsBindingSource.Filter = "NameDep like'" + toolStripTextBox1.Text + "%'";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form ifrm = new Vvod();
            ifrm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            departmentsTableAdapter.Update(maketDataSet2);
            this.Validate();
            this.departmentsBindingSource.EndEdit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ДобавитьКафедру faculties = new ДобавитьКафедру();
            faculties.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void numberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (e.KeyChar <= 47 || e.KeyChar >= 58)
            {
                e.Handled = true;
            }
        }

        private void nameDepTextBox_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void nameDepTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.' && l != ' ')
            {
                e.Handled = true;
            }
        }
    }
}
