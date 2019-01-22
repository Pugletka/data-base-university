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
    public partial class Группы : Form
    {
        public Группы()
        {
            InitializeComponent();
        }

        private void Группы_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "maketDataSet2.Departments". При необходимости она может быть перемещена или удалена.
            this.departmentsTableAdapter1.Fill(this.maketDataSet2.Departments);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "maketDataSet2.Groups". При необходимости она может быть перемещена или удалена.
            this.groupsTableAdapter1.Fill(this.maketDataSet2.Groups);


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in groupsDataGridView.SelectedRows)
            {
                groupsDataGridView.Rows.Remove(row);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Добавление_Группы faculties = new Добавление_Группы();
            faculties.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form ifrm = new Vvod();
            ifrm.Show();
            this.Hide();
        }

        private void groupsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupsTableAdapter1.Update(maketDataSet2);
            this.Validate();
            this.groupsBindingSource1.EndEdit();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.' && l != ' ')
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.' && l != ' ')
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.' && l != ' ')
            {
                e.Handled = true;
            }
        }
    }
}
