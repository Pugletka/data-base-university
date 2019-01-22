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
    public partial class Добавление_Учащихся : Form
    {
        public Добавление_Учащихся()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form ifrm = new Учащиеся();
            ifrm.Show();
            this.Hide();
        }

        private void learnersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.learnersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.maketDataSet2);

        }

        private void Добавление_Учащихся_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "maketDataSet2.Groups". При необходимости она может быть перемещена или удалена.
            this.groupsTableAdapter.Fill(this.maketDataSet2.Groups);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "maketDataSet2.Learners". При необходимости она может быть перемещена или удалена.
            this.learnersTableAdapter.Fill(this.maketDataSet2.Learners);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (surnameTextBox.Text == "" || nameLearnerTextBox.Text == "")
            {
                label1.Text = "Введите данные!";
            }
            else
            {
                DataRow row;
                row = this.maketDataSet2.Learners.NewRow();
                row["idGroups"] = comboBox1.SelectedValue;
                row["Surname"] = surnameTextBox.Text;
                row["NameLearner"] = nameLearnerTextBox.Text;
                row["Patronymic"] = patronymicTextBox.Text;
                this.maketDataSet2.Learners.Rows.Add(row);
                this.learnersTableAdapter.Update(this.maketDataSet2.Learners);
                Form ifrm = new Учащиеся();
                ifrm.Show();
                this.Hide();
            }
        }

        private void surnameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.' && l != ' ')
            {
                e.Handled = true;
            }
        }

        private void nameLearnerTextBox_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
