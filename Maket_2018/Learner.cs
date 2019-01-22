using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;

namespace Maket_2018
{
    public partial class Learner : Form
    {
        public Learner()
        {
            InitializeComponent();
        }

        private void Learner_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "maketDataSet2.Subjects". При необходимости она может быть перемещена или удалена.
            this.subjectsTableAdapter.Fill(this.maketDataSet2.Subjects);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "maketDataSet2.Employees". При необходимости она может быть перемещена или удалена.
            this.employeesTableAdapter.Fill(this.maketDataSet2.Employees);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "maketDataSet2.Departments". При необходимости она может быть перемещена или удалена.
            this.departmentsTableAdapter.Fill(this.maketDataSet2.Departments);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "maketDataSet2.Faculties". При необходимости она может быть перемещена или удалена.
            this.facultiesTableAdapter.Fill(this.maketDataSet2.Faculties);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                label1.Text = "Введите фамилию!";

            }
            else
            {
                SqlConnection sqlConn = new SqlConnection("Data Source=DESKTOP-UQRTEF9\\SQLEXPRESS;Initial Catalog=Maket;Integrated Security=True");
                sqlConn.Open();
                SqlCommand sqlCom = new SqlCommand("SELECT Surname [Фамилия], NameEmp [Имя], Patronymic [Отчество], Position [Должность], NameofSubject  [Дисциплина] FROM (Employees JOIN Reading ON (Employees.idEmployees=Reading.idEmployees)) JOIN Subjects ON(Subjects.idSubjects = Reading.idSubjects) WHERE Surname = '" + textBox1.Text.ToString() + "'", sqlConn);
                SqlDataReader dr = sqlCom.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
            }

        }

        private void facultiesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.facultiesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.maketDataSet2);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConn = new SqlConnection("Data Source=DESKTOP-UQRTEF9\\SQLEXPRESS;Initial Catalog=Maket;Integrated Security=True");
            sqlConn.Open();
            SqlCommand sqlCom = new SqlCommand("SELECT NameEI, AVG(Salary) AS AVG_Salary FROM Administration JOIN EI ON (Administration.idEI = EI.idEI) GROUP BY NameEI", sqlConn);
            SqlDataReader dr = sqlCom.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView4.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConn = new SqlConnection("Data Source=DESKTOP-UQRTEF9\\SQLEXPRESS;Initial Catalog=Maket;Integrated Security=True");
            sqlConn.Open();
            SqlCommand sqlCom = new SqlCommand(" SELECT IndexGroup, NameOfMonitor, SurnameOfMonitor, PatronymicOfMonitor, COUNT(Learners.NameLearner) As CountStudInGroups FROM Groups, Learners WHERE Learners.idGroups = Groups.idGroups GROUP BY IndexGroup, NameOfMonitor, SurnameOfMonitor, PatronymicOfMonitor ", sqlConn);
            SqlDataReader dr = sqlCom.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView5.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form ifrm = new Form2();
            ifrm.Show();
            this.Hide();
        }

        private void facultiesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void CornflowerBlue(object sender, PaintEventArgs e)
        {

        }
    }
}
