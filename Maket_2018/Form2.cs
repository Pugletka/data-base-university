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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        public string llogin, ppassword;

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "maketDataSet1.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.maketDataSet1.Users);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form ifrm = new Form1();
            ifrm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void login_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            llogin = login.Text;
            ppassword = password.Text;
            if (llogin == "Администратор")
            {
                if (ppassword == "12345") { Admin adm = new Admin (); adm.Show(); this.Close(); }
                else { const string message = "Неверный пароль!"; var result = MessageBox.Show(message); }
            }
            //if (llogin == "Сотрудник")
            //{
            //    if (ppassword == "1234") { Employee emp = new Employee(); emp.Show(); this.Close(); }
            //    else { const string message = "Неверный пароль!"; var result = MessageBox.Show(message); }
            //}
            if (llogin == "Учащийся")
            {
                if (ppassword == "123") { Learner lea = new Learner(); lea.Show(); this.Close(); }
                else { const string message = "Неверный пароль!"; var result = MessageBox.Show(message); }
            }
        }
    }
}
