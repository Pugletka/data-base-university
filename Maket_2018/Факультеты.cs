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
    public partial class Факультеты : Form
    {
        public Факультеты()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {      
            Form ifrm = new Vvod();
            ifrm.Show();
            this.Hide();
        }

        private void Факультеты_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "maketDataSet2.EI". При необходимости она может быть перемещена или удалена.
            this.eITableAdapter.Fill(this.maketDataSet2.EI);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "maketDataSet2.Departments". При необходимости она может быть перемещена или удалена.
            this.departmentsTableAdapter.Fill(this.maketDataSet2.Departments);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "maketDataSet2.Faculties". При необходимости она может быть перемещена или удалена.
            this.facultiesTableAdapter.Fill(this.maketDataSet2.Faculties);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            facultiesTableAdapter.Update(maketDataSet2);
            this.Validate();
            this.facultiesBindingSource.EndEdit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Добавление_Факультета faculties = new Добавление_Факультета();
            faculties.ShowDialog();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
               dataGridView1.Rows.Remove(row);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.' && l != ' ')
            {
                e.Handled = true;
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            facultiesBindingSource.Filter = "NameFac like'" + toolStripTextBox1.Text + "%'";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (e.KeyChar <= 47 || e.KeyChar >= 58)
            {
                e.Handled = true;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
