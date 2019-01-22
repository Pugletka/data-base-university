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
    public partial class Добавление_Группы : Form
    {
        public Добавление_Группы()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form ifrm = new Группы();
            ifrm.Show();
            this.Hide();
        }

        private void groupsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.groupsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.maketDataSet2);

        }

        private void Добавление_Группы_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "maketDataSet2.Departments". При необходимости она может быть перемещена или удалена.
            this.departmentsTableAdapter.Fill(this.maketDataSet2.Departments);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "maketDataSet2.Groups". При необходимости она может быть перемещена или удалена.
            this.groupsTableAdapter.Fill(this.maketDataSet2.Groups);

        }

        private void indexGroupTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void surnameOfMonitorTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.' && l != ' ')
            {
                e.Handled = true;
            }
        }

        private void nameOfMonitorTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.' && l != ' ')
            {
                e.Handled = true;
            }
        }

        private void patronymicOfMonitorTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.' && l != ' ')
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (indexGroupTextBox.Text == "")
            {
                label1.Text = "Введите индекс группы!";
            }
            else
            {
                DataRow row;
                row = this.maketDataSet2.Groups.NewRow();
                row["idDepartments"] = comboBox1.SelectedValue;
                row["IndexGroup"] = indexGroupTextBox.Text;
                row["SurnameOfMonitor"] = surnameOfMonitorTextBox.Text;
                row["NameOfMonitor"] = nameOfMonitorTextBox.Text;
                row["PatronymicOfMonitor"] = patronymicOfMonitorTextBox.Text;
                this.maketDataSet2.Groups.Rows.Add(row);
                this.groupsTableAdapter.Update(this.maketDataSet2.Groups);
                Form ifrm = new Группы();
                ifrm.Show();
                this.Hide();
            }
        }

        private void indexGroupTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
