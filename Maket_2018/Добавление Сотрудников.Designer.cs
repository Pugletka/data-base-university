namespace Maket_2018
{
    partial class Добавление_Сотрудников
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label academicDegreeLabel;
            System.Windows.Forms.Label academicTitleLabel;
            System.Windows.Forms.Label positionLabel;
            System.Windows.Forms.Label patronymicLabel;
            System.Windows.Forms.Label nameEmpLabel;
            System.Windows.Forms.Label surnameLabel;
            System.Windows.Forms.Label idDepartmentsLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.departmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maketDataSet2 = new Maket_2018.MaketDataSet2();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.departmentsTableAdapter = new Maket_2018.MaketDataSet2TableAdapters.DepartmentsTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.employeesTableAdapter1 = new Maket_2018.MaketDataSet2TableAdapters.EmployeesTableAdapter();
            this.employeesTableAdapter2 = new Maket_2018.MaketDataSetTableAdapters.EmployeesTableAdapter();
            this.employeesTableAdapter3 = new Maket_2018.MaketDataSet3TableAdapters.EmployeesTableAdapter();
            academicDegreeLabel = new System.Windows.Forms.Label();
            academicTitleLabel = new System.Windows.Forms.Label();
            positionLabel = new System.Windows.Forms.Label();
            patronymicLabel = new System.Windows.Forms.Label();
            nameEmpLabel = new System.Windows.Forms.Label();
            surnameLabel = new System.Windows.Forms.Label();
            idDepartmentsLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maketDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // academicDegreeLabel
            // 
            academicDegreeLabel.AutoSize = true;
            academicDegreeLabel.Location = new System.Drawing.Point(187, 97);
            academicDegreeLabel.Name = "academicDegreeLabel";
            academicDegreeLabel.Size = new System.Drawing.Size(91, 13);
            academicDegreeLabel.TabIndex = 12;
            academicDegreeLabel.Text = "Учёная степень:";
            // 
            // academicTitleLabel
            // 
            academicTitleLabel.AutoSize = true;
            academicTitleLabel.Location = new System.Drawing.Point(415, 95);
            academicTitleLabel.Name = "academicTitleLabel";
            academicTitleLabel.Size = new System.Drawing.Size(86, 13);
            academicTitleLabel.TabIndex = 10;
            academicTitleLabel.Text = "Учёное звание:";
            // 
            // positionLabel
            // 
            positionLabel.AutoSize = true;
            positionLabel.Location = new System.Drawing.Point(-1, 100);
            positionLabel.Name = "positionLabel";
            positionLabel.Size = new System.Drawing.Size(68, 13);
            positionLabel.TabIndex = 8;
            positionLabel.Text = "Должность:";
            // 
            // patronymicLabel
            // 
            patronymicLabel.AutoSize = true;
            patronymicLabel.Location = new System.Drawing.Point(433, 65);
            patronymicLabel.Name = "patronymicLabel";
            patronymicLabel.Size = new System.Drawing.Size(57, 13);
            patronymicLabel.TabIndex = 6;
            patronymicLabel.Text = "Отчество:";
            // 
            // nameEmpLabel
            // 
            nameEmpLabel.AutoSize = true;
            nameEmpLabel.Location = new System.Drawing.Point(187, 65);
            nameEmpLabel.Name = "nameEmpLabel";
            nameEmpLabel.Size = new System.Drawing.Size(93, 13);
            nameEmpLabel.TabIndex = 4;
            nameEmpLabel.Text = "Имя сотрудника:";
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Location = new System.Drawing.Point(8, 61);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new System.Drawing.Size(59, 13);
            surnameLabel.TabIndex = 2;
            surnameLabel.Text = "Фамилия:";
            // 
            // idDepartmentsLabel
            // 
            idDepartmentsLabel.AutoSize = true;
            idDepartmentsLabel.Location = new System.Drawing.Point(193, 20);
            idDepartmentsLabel.Name = "idDepartmentsLabel";
            idDepartmentsLabel.Size = new System.Drawing.Size(55, 13);
            idDepartmentsLabel.TabIndex = 0;
            idDepartmentsLabel.Text = "Кафедра:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox3);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(academicDegreeLabel);
            this.panel1.Controls.Add(academicTitleLabel);
            this.panel1.Controls.Add(positionLabel);
            this.panel1.Controls.Add(patronymicLabel);
            this.panel1.Controls.Add(nameEmpLabel);
            this.panel1.Controls.Add(surnameLabel);
            this.panel1.Controls.Add(idDepartmentsLabel);
            this.panel1.Location = new System.Drawing.Point(43, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(653, 136);
            this.panel1.TabIndex = 19;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Профессор",
            "Доцент ",
            "-"});
            this.comboBox3.Location = new System.Drawing.Point(501, 92);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 21;
            this.comboBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox3_KeyPress);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Доктор технических наук",
            "Кандидат технических наук",
            "-"});
            this.comboBox2.Location = new System.Drawing.Point(288, 92);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(113, 21);
            this.comboBox2.TabIndex = 20;
            this.comboBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox2_KeyPress);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.departmentsBindingSource, "idDepartments", true));
            this.comboBox1.DataSource = this.departmentsBindingSource;
            this.comboBox1.DisplayMember = "NameDep";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(288, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.ValueMember = "idDepartments";
            // 
            // departmentsBindingSource
            // 
            this.departmentsBindingSource.DataMember = "Departments";
            this.departmentsBindingSource.DataSource = this.maketDataSet2;
            // 
            // maketDataSet2
            // 
            this.maketDataSet2.DataSetName = "MaketDataSet2";
            this.maketDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(502, 62);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(120, 20);
            this.textBox5.TabIndex = 17;
            this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(288, 62);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(114, 20);
            this.textBox3.TabIndex = 15;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(67, 94);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(114, 20);
            this.textBox2.TabIndex = 14;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(67, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(114, 20);
            this.textBox1.TabIndex = 13;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // departmentsTableAdapter
            // 
            this.departmentsTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button2.Location = new System.Drawing.Point(336, 301);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 42);
            this.button2.TabIndex = 20;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button3.Location = new System.Drawing.Point(687, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(61, 26);
            this.button3.TabIndex = 21;
            this.button3.Text = "Назад";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(275, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 22;
            // 
            // employeesTableAdapter1
            // 
            this.employeesTableAdapter1.ClearBeforeFill = true;
            // 
            // employeesTableAdapter2
            // 
            this.employeesTableAdapter2.ClearBeforeFill = true;
            // 
            // employeesTableAdapter3
            // 
            this.employeesTableAdapter3.ClearBeforeFill = true;
            // 
            // Добавление_Сотрудников
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(760, 393);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Name = "Добавление_Сотрудников";
            this.Text = "Добавление_Сотрудников";
            this.Load += new System.EventHandler(this.Добавление_Сотрудников_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maketDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private MaketDataSet2 maketDataSet2;
        private System.Windows.Forms.BindingSource departmentsBindingSource;
        private MaketDataSet2TableAdapters.DepartmentsTableAdapter departmentsTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private MaketDataSet2TableAdapters.EmployeesTableAdapter employeesTableAdapter1;
        private MaketDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter2;
        private MaketDataSet3TableAdapters.EmployeesTableAdapter employeesTableAdapter3;
    }
}