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
    public partial class Добавление_Факультета : Form
    {
        public Добавление_Факультета()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form ifrm = new Факультеты();
            ifrm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "") 
            {
                label5.Text = "Введите Название!";
            }
            else
            {
                DataRow row;
                row = this.maketDataSet2.Faculties.NewRow();
                row["idEI"] = comboBox1.SelectedValue;
                row["NameFac"] = textBox3.Text;
                row["YearOfFoundation"] = textBox1.Text;
                row["LINK"] = textBox2.Text;
                this.maketDataSet2.Faculties.Rows.Add(row);
                this.facultiesTableAdapter1.Update(this.maketDataSet2.Faculties);
                Form ifrm = new Факультеты();
                ifrm.Show();
                this.Hide();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (e.KeyChar <= 47 || e.KeyChar >= 58)
            {
                e.Handled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Добавление_Факультета_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "maketDataSet2.EI". При необходимости она может быть перемещена или удалена.
            this.eITableAdapter.Fill(this.maketDataSet2.EI);

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
