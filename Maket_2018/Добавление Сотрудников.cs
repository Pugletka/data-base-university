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
    public partial class Добавление_Сотрудников : Form
    {
        public Добавление_Сотрудников()
        {
            InitializeComponent();
        }

        private void Добавление_Сотрудников_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "maketDataSet2.Departments". При необходимости она может быть перемещена или удалена.
            this.departmentsTableAdapter.Fill(this.maketDataSet2.Departments);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form ifrm = new Сотрудники();
            ifrm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox3.Text == "" || textBox2.Text == "")
            {
                label1.Text = "Введите данные!";
            }
            else
            {
                DataRow row;
                row = this.maketDataSet2.Employees.NewRow();
                row["idDepartments"] = comboBox1.SelectedValue;
                row["Surname"] = textBox1.Text;
                row["NameEmp"] = textBox3.Text;
                row["Patronymic"] = textBox5.Text;
                row["Position"] = textBox2.Text;
                row["AcademicDegree"] = comboBox2.SelectedValue;
                row["AcademicTitle"] = comboBox3.SelectedValue;
                this.maketDataSet2.Employees.Rows.Add(row);
                this.employeesTableAdapter1.Update(this.maketDataSet2.Employees);
                Form ifrm = new Сотрудники();
                ifrm.Show();
                this.Hide();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.' && l != ' ')
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.' && l != ' ')
            {
                e.Handled = true;
            }
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.' && l != ' ')
            {
                e.Handled = true;
            }
        }

        private void comboBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.' && l != ' ')
            {
                e.Handled = true;
            }
        }
    }
}
