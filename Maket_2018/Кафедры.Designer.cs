namespace Maket_2018
{
    partial class Кафедры
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
            System.Windows.Forms.Label idDepartmentsLabel;
            System.Windows.Forms.Label nameDepLabel;
            System.Windows.Forms.Label numberLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Кафедры));
            this.panel1 = new System.Windows.Forms.Panel();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.departmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maketDataSet2 = new Maket_2018.MaketDataSet2();
            this.nameDepTextBox = new System.Windows.Forms.TextBox();
            this.idDepartmentsTextBox = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDepartmentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idFacultiesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearOfFoundationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentsTableAdapter = new Maket_2018.MaketDataSet2TableAdapters.DepartmentsTableAdapter();
            this.facultiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facultiesTableAdapter = new Maket_2018.MaketDataSet2TableAdapters.FacultiesTableAdapter();
            this.tableAdapterManager = new Maket_2018.MaketDataSet2TableAdapters.TableAdapterManager();
            this.facultiesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKDepartmentsFacultiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            idDepartmentsLabel = new System.Windows.Forms.Label();
            nameDepLabel = new System.Windows.Forms.Label();
            numberLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maketDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultiesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDepartmentsFacultiesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idDepartmentsLabel
            // 
            idDepartmentsLabel.AutoSize = true;
            idDepartmentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            idDepartmentsLabel.Location = new System.Drawing.Point(35, 46);
            idDepartmentsLabel.Name = "idDepartmentsLabel";
            idDepartmentsLabel.Size = new System.Drawing.Size(56, 16);
            idDepartmentsLabel.TabIndex = 1;
            idDepartmentsLabel.Text = "Индекс";
            // 
            // nameDepLabel
            // 
            nameDepLabel.AutoSize = true;
            nameDepLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            nameDepLabel.Location = new System.Drawing.Point(30, 88);
            nameDepLabel.Name = "nameDepLabel";
            nameDepLabel.Size = new System.Drawing.Size(74, 16);
            nameDepLabel.TabIndex = 2;
            nameDepLabel.Text = "Название";
            // 
            // numberLabel
            // 
            numberLabel.AutoSize = true;
            numberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            numberLabel.Location = new System.Drawing.Point(35, 131);
            numberLabel.Name = "numberLabel";
            numberLabel.Size = new System.Drawing.Size(68, 16);
            numberLabel.TabIndex = 4;
            numberLabel.Text = "Телефон";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(numberLabel);
            this.panel1.Controls.Add(this.numberTextBox);
            this.panel1.Controls.Add(nameDepLabel);
            this.panel1.Controls.Add(this.nameDepTextBox);
            this.panel1.Controls.Add(idDepartmentsLabel);
            this.panel1.Controls.Add(this.idDepartmentsTextBox);
            this.panel1.Location = new System.Drawing.Point(548, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 190);
            this.panel1.TabIndex = 6;
            // 
            // numberTextBox
            // 
            this.numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.departmentsBindingSource, "Number", true));
            this.numberTextBox.Location = new System.Drawing.Point(115, 127);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(177, 20);
            this.numberTextBox.TabIndex = 5;
            this.numberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberTextBox_KeyPress);
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
            // nameDepTextBox
            // 
            this.nameDepTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.departmentsBindingSource, "NameDep", true));
            this.nameDepTextBox.Location = new System.Drawing.Point(115, 84);
            this.nameDepTextBox.Name = "nameDepTextBox";
            this.nameDepTextBox.Size = new System.Drawing.Size(177, 20);
            this.nameDepTextBox.TabIndex = 3;
            this.nameDepTextBox.TextChanged += new System.EventHandler(this.nameDepTextBox_TextChanged);
            this.nameDepTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameDepTextBox_KeyPress);
            // 
            // idDepartmentsTextBox
            // 
            this.idDepartmentsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.departmentsBindingSource, "idDepartments", true));
            this.idDepartmentsTextBox.Location = new System.Drawing.Point(115, 42);
            this.idDepartmentsTextBox.Name = "idDepartmentsTextBox";
            this.idDepartmentsTextBox.ReadOnly = true;
            this.idDepartmentsTextBox.Size = new System.Drawing.Size(177, 20);
            this.idDepartmentsTextBox.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button4.Location = new System.Drawing.Point(787, 359);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 42);
            this.button4.TabIndex = 17;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button3.Location = new System.Drawing.Point(507, 359);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 42);
            this.button3.TabIndex = 16;
            this.button3.Text = "Добавить Кафедру";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button2.Location = new System.Drawing.Point(657, 359);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 42);
            this.button2.TabIndex = 15;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.Location = new System.Drawing.Point(817, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 26);
            this.button1.TabIndex = 14;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(158, 22);
            this.toolStripLabel1.Text = "Введите название кафедры:";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.toolStripLabel1,
            this.toolStripTextBox1,
            this.toolStripButton1});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(903, 25);
            this.bindingNavigator1.TabIndex = 2;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDepartmentsDataGridViewTextBoxColumn,
            this.idFacultiesDataGridViewTextBoxColumn,
            this.nameDepDataGridViewTextBoxColumn,
            this.yearOfFoundationDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.departmentsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(493, 150);
            this.dataGridView1.TabIndex = 18;
            // 
            // idDepartmentsDataGridViewTextBoxColumn
            // 
            this.idDepartmentsDataGridViewTextBoxColumn.DataPropertyName = "idDepartments";
            this.idDepartmentsDataGridViewTextBoxColumn.FillWeight = 50F;
            this.idDepartmentsDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDepartmentsDataGridViewTextBoxColumn.Name = "idDepartmentsDataGridViewTextBoxColumn";
            this.idDepartmentsDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDepartmentsDataGridViewTextBoxColumn.Width = 50;
            // 
            // idFacultiesDataGridViewTextBoxColumn
            // 
            this.idFacultiesDataGridViewTextBoxColumn.DataPropertyName = "idFaculties";
            this.idFacultiesDataGridViewTextBoxColumn.HeaderText = "Факультет";
            this.idFacultiesDataGridViewTextBoxColumn.Name = "idFacultiesDataGridViewTextBoxColumn";
            this.idFacultiesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDepDataGridViewTextBoxColumn
            // 
            this.nameDepDataGridViewTextBoxColumn.DataPropertyName = "NameDep";
            this.nameDepDataGridViewTextBoxColumn.HeaderText = "Название";
            this.nameDepDataGridViewTextBoxColumn.Name = "nameDepDataGridViewTextBoxColumn";
            this.nameDepDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yearOfFoundationDataGridViewTextBoxColumn
            // 
            this.yearOfFoundationDataGridViewTextBoxColumn.DataPropertyName = "YearOfFoundation";
            this.yearOfFoundationDataGridViewTextBoxColumn.HeaderText = "Год образования";
            this.yearOfFoundationDataGridViewTextBoxColumn.Name = "yearOfFoundationDataGridViewTextBoxColumn";
            this.yearOfFoundationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // departmentsTableAdapter
            // 
            this.departmentsTableAdapter.ClearBeforeFill = true;
            // 
            // facultiesBindingSource
            // 
            this.facultiesBindingSource.DataMember = "Faculties";
            this.facultiesBindingSource.DataSource = this.maketDataSet2;
            // 
            // facultiesTableAdapter
            // 
            this.facultiesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdministrationTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DepartmentsTableAdapter = this.departmentsTableAdapter;
            this.tableAdapterManager.EITableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.FacultiesTableAdapter = this.facultiesTableAdapter;
            this.tableAdapterManager.GroupsTableAdapter = null;
            this.tableAdapterManager.LearnersTableAdapter = null;
            this.tableAdapterManager.ReadingTableAdapter = null;
            this.tableAdapterManager.SubjectsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Maket_2018.MaketDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // facultiesDataGridView
            // 
            this.facultiesDataGridView.AllowUserToAddRows = false;
            this.facultiesDataGridView.AllowUserToDeleteRows = false;
            this.facultiesDataGridView.AutoGenerateColumns = false;
            this.facultiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.facultiesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3});
            this.facultiesDataGridView.DataSource = this.facultiesBindingSource;
            this.facultiesDataGridView.Location = new System.Drawing.Point(12, 246);
            this.facultiesDataGridView.Name = "facultiesDataGridView";
            this.facultiesDataGridView.ReadOnly = true;
            this.facultiesDataGridView.Size = new System.Drawing.Size(291, 220);
            this.facultiesDataGridView.TabIndex = 18;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idFaculties";
            this.dataGridViewTextBoxColumn1.FillWeight = 50F;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NameFac";
            this.dataGridViewTextBoxColumn3.FillWeight = 200F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Название Факультета";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // fKDepartmentsFacultiesBindingSource
            // 
            this.fKDepartmentsFacultiesBindingSource.DataMember = "FK_Departments_Faculties";
            this.fKDepartmentsFacultiesBindingSource.DataSource = this.facultiesBindingSource;
            // 
            // Кафедры
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(903, 609);
            this.Controls.Add(this.facultiesDataGridView);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bindingNavigator1);
            this.Name = "Кафедры";
            this.Text = "Кафедры";
            this.Load += new System.EventHandler(this.Кафедры_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maketDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultiesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKDepartmentsFacultiesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.TextBox nameDepTextBox;
        private System.Windows.Forms.TextBox idDepartmentsTextBox;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaketDataSet2 maketDataSet2;
        private System.Windows.Forms.BindingSource departmentsBindingSource;
        private MaketDataSet2TableAdapters.DepartmentsTableAdapter departmentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDepartmentsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFacultiesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDepDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearOfFoundationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource facultiesBindingSource;
        private MaketDataSet2TableAdapters.FacultiesTableAdapter facultiesTableAdapter;
        private MaketDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView facultiesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource fKDepartmentsFacultiesBindingSource;
    }
}