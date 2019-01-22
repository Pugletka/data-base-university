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
    public partial class Сотрудники : Form
    {
        public Сотрудники()
        {
            InitializeComponent();
        }

        private void employeesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.maketDataSet2);

        }

        private void Сотрудники_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "maketDataSet2.Departments". При необходимости она может быть перемещена или удалена.
            this.departmentsTableAdapter.Fill(this.maketDataSet2.Departments);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "maketDataSet2.Employees". При необходимости она может быть перемещена или удалена.
            this.employeesTableAdapter.Fill(this.maketDataSet2.Employees);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in employeesDataGridView.SelectedRows)
            {
                employeesDataGridView.Rows.Remove(row);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            employeesTableAdapter.Update(maketDataSet2);
            this.Validate();
            this.employeesBindingSource.EndEdit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form ifrm = new Vvod();
            ifrm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Добавление_Сотрудников faculties = new Добавление_Сотрудников();
            faculties.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nameEmpLabel_Click(object sender, EventArgs e)
        {

        }

        private void nameEmpTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void academicTitleLabel_Click(object sender, EventArgs e)
        {

        }

        private void patronymicLabel_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void surnameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.' && l != ' ')
            {
                e.Handled = true;
            }
        }

        private void nameEmpTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.' && l != ' ')
            {
                e.Handled = true;
            }
        }

        private void patronymicTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.' && l != ' ')
            {
                e.Handled = true;
            }
        }

        private void positionTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.' && l != ' ')
            {
                e.Handled = true;
            }
        }

        private void academicDegreeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.' && l != ' ')
            {
                e.Handled = true;
            }
        }

        private void academicTitleTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.' && l != ' ')
            {
                e.Handled = true;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            employeesBindingSource.Filter = "NameFac like'" + toolStripTextBox1.Text + "%'";
        }
    }
}
