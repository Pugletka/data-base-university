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
//using System.Windows.Forms.DataVisualization.Charting;

namespace Maket_2018
{
    public partial class Запросы : Form
    {
        public Запросы()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form ifrm = new Admin();
            ifrm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                label4.Text = "Введите фамилию!";

            }
                else
                {

                  SqlConnection sqlConn = new SqlConnection("Data Source=DESKTOP-UQRTEF9\\SQLEXPRESS;Initial Catalog=Maket;Integrated Security=True");
                  sqlConn.Open();
                  SqlCommand sqlCom = new SqlCommand("SELECT *FROM Learners WHERE Surname='" + textBox1.Text.ToString() + "'", sqlConn);
                  SqlDataReader dr = sqlCom.ExecuteReader();
                  DataTable dt = new DataTable();
                  dt.Load(dr);
                  dataGridView1.DataSource = dt;
                  
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                label5.Text = "Введите фамилию!";

            }
              else
            {
                    SqlConnection sqlConn = new SqlConnection("Data Source=DESKTOP-UQRTEF9\\SQLEXPRESS;Initial Catalog=Maket;Integrated Security=True");
                    sqlConn.Open();
                    SqlCommand sqlCom = new SqlCommand("SELECT Surname [Фамилия], NameEmp [Имя], Patronymic [Отчество], Position [Должность], NameofSubject  [Дисциплина] FROM (Employees JOIN Reading ON (Employees.idEmployees=Reading.idEmployees)) JOIN Subjects ON(Subjects.idSubjects = Reading.idSubjects) WHERE Surname = '" + textBox2.Text.ToString() + "'", sqlConn);
                    SqlDataReader dr = sqlCom.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    dataGridView2.DataSource = dt;
                }

            }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Запросы_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "maketDataSet2.Groups". При необходимости она может быть перемещена или удалена.
            this.groupsTableAdapter.Fill(this.maketDataSet2.Groups);


        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConn = new SqlConnection("Data Source=DESKTOP-UQRTEF9\\SQLEXPRESS;Initial Catalog=Maket;Integrated Security=True");
            sqlConn.Open();
            SqlCommand sqlCom = new SqlCommand(" SELECT * FROM Employees WHERE AcademicDegree = '" + comboBox1.Text.ToString() + "'", sqlConn);
            SqlDataReader dr = sqlCom.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView4.DataSource = dt;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConn = new SqlConnection("Data Source=DESKTOP-UQRTEF9\\SQLEXPRESS;Initial Catalog=Maket;Integrated Security=True");
            sqlConn.Open();
            SqlCommand sqlCom = new SqlCommand("SELECT NameDep [Название], COUNT (Learners.NameLearner) As Количество_Студентов FROM Departments, Groups, Learners  WHERE Learners.idGroups = Groups.idGroups AND Groups.idDepartments = Departments.idDepartments GROUP BY NameDep", sqlConn);
            SqlDataReader dr = sqlCom.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView5.DataSource = dt;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConn = new SqlConnection("Data Source=DESKTOP-UQRTEF9\\SQLEXPRESS;Initial Catalog=Maket;Integrated Security=True");
            sqlConn.Open();
            SqlCommand sqlCom = new SqlCommand("SELECT NameDep [Кафедра], IndexGroup [Группа], Surname [Фамилия], NameLearner [Имя] FROM Departments, Groups, Learners WHERE Learners.idGroups=Groups.idGroups AND Groups.idDepartments = Departments.idDepartments ORDER BY NameDep, IndexGroup, Surname, NameLearner", sqlConn);
            SqlDataReader dr = sqlCom.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView6.DataSource = dt;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
