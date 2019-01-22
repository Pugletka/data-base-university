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
    public partial class Дисциплины : Form
    {
        public Дисциплины()
        {
            InitializeComponent();
        }

        private void subjectsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //this.Validate();
            //this.subjectsBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.maketDataSet2);

        }

        private void Дисциплины_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "maketDataSet2.Employees". При необходимости она может быть перемещена или удалена.
            this.employeesTableAdapter.Fill(this.maketDataSet2.Employees);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "maketDataSet2.Reading". При необходимости она может быть перемещена или удалена.
            this.readingTableAdapter.Fill(this.maketDataSet2.Reading);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "maketDataSet2.Subjects". При необходимости она может быть перемещена или удалена.
            this.subjectsTableAdapter.Fill(this.maketDataSet2.Subjects);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "maketDataSet2.Reading". При необходимости она может быть перемещена или удалена.
            this.readingTableAdapter.Fill(this.maketDataSet2.Reading);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "maketDataSet2.Employees". При необходимости она может быть перемещена или удалена.
            this.employeesTableAdapter.Fill(this.maketDataSet2.Employees);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "maketDataSet2.Reading". При необходимости она может быть перемещена или удалена.
            this.readingTableAdapter.Fill(this.maketDataSet2.Reading);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "maketDataSet2.Subjects". При необходимости она может быть перемещена или удалена.
            this.subjectsTableAdapter.Fill(this.maketDataSet2.Subjects);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "maketDataSet2.Employees". При необходимости она может быть перемещена или удалена.
            this.employeesTableAdapter.Fill(this.maketDataSet2.Employees);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "maketDataSet2.Reading". При необходимости она может быть перемещена или удалена.
            this.readingTableAdapter.Fill(this.maketDataSet2.Reading);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "maketDataSet2.Subjects". При необходимости она может быть перемещена или удалена.
            this.subjectsTableAdapter.Fill(this.maketDataSet2.Subjects);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form ifrm = new Vvod();
            ifrm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in subjectsDataGridView.SelectedRows)
            {
                subjectsDataGridView.Rows.Remove(row);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            subjectsTableAdapter.Update(maketDataSet2);
            this.Validate();
            this.subjectsBindingSource.EndEdit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Добавление_Дисциплины faculties = new Добавление_Дисциплины();
            faculties.ShowDialog();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.' && l != ' ')
            {
                e.Handled = true;
            }
        }
    }
}
