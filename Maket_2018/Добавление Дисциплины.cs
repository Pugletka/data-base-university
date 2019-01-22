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
    public partial class Добавление_Дисциплины : Form
    {
        public Добавление_Дисциплины()
        {
            InitializeComponent();
        }

        private void subjectsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.subjectsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.maketDataSet2);

        }

        private void Добавление_Дисциплины_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "maketDataSet2.Employees". При необходимости она может быть перемещена или удалена.
            this.employeesTableAdapter.Fill(this.maketDataSet2.Employees);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "maketDataSet2.Subjects". При необходимости она может быть перемещена или удалена.
            this.subjectsTableAdapter.Fill(this.maketDataSet2.Subjects);

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                label1.Text = "Введите название группы!";
            }
            else
            {
                DataRow row;
                row = this.maketDataSet2.Subjects.NewRow();
                row["NameofSubject"] = textBox1.Text;
                this.maketDataSet2.Subjects.Rows.Add(row);
                this.subjectsTableAdapter.Update(this.maketDataSet2.Subjects);
                Form ifrm = new Дисциплины();
                ifrm.Show();
                this.Hide();
            }          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form ifrm = new Дисциплины();
            ifrm.Show();
            this.Hide();
        }

        private void nameofSubjectLabel_Click(object sender, EventArgs e)
        {

        }

        private void button2_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
