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
    public partial class ДобавитьКафедру : Form
    {
        public ДобавитьКафедру()
        {
            InitializeComponent();
        }

        private void facultiesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.facultiesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.maketDataSet);

        }

        private void ДобавитьКафедру_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "maketDataSet2.Faculties". При необходимости она может быть перемещена или удалена.
            this.facultiesTableAdapter1.Fill(this.maketDataSet2.Faculties);



        }

        private void button3_Click(object sender, EventArgs e)
        {
            Кафедры ifrm = new Кафедры();
            ifrm.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (nameDepTextBox.Text == "")
            {
                label6.Text = "Введите Название!";
            }
            else
            {
                DataRow row;
                row = this.maketDataSet2.Departments.NewRow();
                row["idFaculties"] = comboBox1.SelectedValue;
                row["NameDep"] = nameDepTextBox.Text;
                row["YearOfFoundation"] = yearOfFoundationTextBox.Text;
                row["Number"] = numberTextBox.Text;
                this.maketDataSet2.Departments.Rows.Add(row);
                this.departmentsTableAdapter3.Update(this.maketDataSet2.Departments);
                Form ifrm = new Кафедры();
                ifrm.Show();
                this.Hide();
            }
        }

        private void nameDepTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.' && l != ' ')
            {
                e.Handled = true;
            }
        }

        private void yearOfFoundationTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (e.KeyChar <= 47 || e.KeyChar >= 58)
            {
                e.Handled = true;
            }
        }

        private void numberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (e.KeyChar <= 47 || e.KeyChar >= 58)
            {
                e.Handled = true;
            }
        }

        private void yearOfFoundationTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
