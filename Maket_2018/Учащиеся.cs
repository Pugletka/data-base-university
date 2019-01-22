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
    public partial class Учащиеся : Form
    {
        public Учащиеся()
        {
            InitializeComponent();
        }

        private void Учащиеся_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "maketDataSet2.Groups". При необходимости она может быть перемещена или удалена.
            this.groupsTableAdapter.Fill(this.maketDataSet2.Groups);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "maketDataSet2.Learners". При необходимости она может быть перемещена или удалена.
            this.learnersTableAdapter.Fill(this.maketDataSet2.Learners);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            learnersTableAdapter.Update(maketDataSet2);
            this.Validate();
            this.learnersBindingSource.EndEdit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form ifrm = new Vvod();
            ifrm.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {  
            this.Hide();
            Добавление_Учащихся learners = new Добавление_Учащихся();
            learners.ShowDialog();
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            learnersBindingSource.Filter = "Surname like'" + toolStripTextBox1.Text + "%'";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
