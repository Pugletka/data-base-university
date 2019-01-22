namespace Maket_2018
{
    partial class ДобавитьКафедру
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
            System.Windows.Forms.Label nameDepLabel;
            System.Windows.Forms.Label yearOfFoundationLabel;
            System.Windows.Forms.Label numberLabel;
            System.Windows.Forms.Label idFacultiesLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ДобавитьКафедру));
            this.tableAdapterManager1 = new Maket_2018.MaketDataSet1TableAdapters.TableAdapterManager();
            this.maketDataSet = new Maket_2018.MaketDataSet();
            this.facultiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facultiesTableAdapter = new Maket_2018.MaketDataSetTableAdapters.FacultiesTableAdapter();
            this.tableAdapterManager = new Maket_2018.MaketDataSetTableAdapters.TableAdapterManager();
            this.facultiesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.facultiesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.departmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentsTableAdapter = new Maket_2018.MaketDataSetTableAdapters.DepartmentsTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.facultiesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.maketDataSet2 = new Maket_2018.MaketDataSet2();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.yearOfFoundationTextBox = new System.Windows.Forms.TextBox();
            this.nameDepTextBox = new System.Windows.Forms.TextBox();
            this.facultiesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.facultiesTableAdapter1 = new Maket_2018.MaketDataSet2TableAdapters.FacultiesTableAdapter();
            this.departmentsTableAdapter1 = new Maket_2018.MaketDataSet3TableAdapters.DepartmentsTableAdapter();
            this.departmentsTableAdapter2 = new Maket_2018.MaketDataSetTableAdapters.DepartmentsTableAdapter();
            this.departmentsTableAdapter3 = new Maket_2018.MaketDataSet2TableAdapters.DepartmentsTableAdapter();
            nameDepLabel = new System.Windows.Forms.Label();
            yearOfFoundationLabel = new System.Windows.Forms.Label();
            numberLabel = new System.Windows.Forms.Label();
            idFacultiesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.maketDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultiesBindingNavigator)).BeginInit();
            this.facultiesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facultiesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maketDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultiesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameDepLabel
            // 
            nameDepLabel.AutoSize = true;
            nameDepLabel.Location = new System.Drawing.Point(3, 78);
            nameDepLabel.Name = "nameDepLabel";
            nameDepLabel.Size = new System.Drawing.Size(109, 13);
            nameDepLabel.TabIndex = 0;
            nameDepLabel.Text = "Название кафедры:";
            // 
            // yearOfFoundationLabel
            // 
            yearOfFoundationLabel.AutoSize = true;
            yearOfFoundationLabel.Location = new System.Drawing.Point(9, 127);
            yearOfFoundationLabel.Name = "yearOfFoundationLabel";
            yearOfFoundationLabel.Size = new System.Drawing.Size(97, 13);
            yearOfFoundationLabel.TabIndex = 2;
            yearOfFoundationLabel.Text = "Год образования:";
            // 
            // numberLabel
            // 
            numberLabel.AutoSize = true;
            numberLabel.Location = new System.Drawing.Point(51, 171);
            numberLabel.Name = "numberLabel";
            numberLabel.Size = new System.Drawing.Size(55, 13);
            numberLabel.TabIndex = 4;
            numberLabel.Text = "Телефон:";
            // 
            // idFacultiesLabel
            // 
            idFacultiesLabel.AutoSize = true;
            idFacultiesLabel.Location = new System.Drawing.Point(45, 38);
            idFacultiesLabel.Name = "idFacultiesLabel";
            idFacultiesLabel.Size = new System.Drawing.Size(66, 13);
            idFacultiesLabel.TabIndex = 8;
            idFacultiesLabel.Text = "Факультет:";
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = Maket_2018.MaketDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.UsersTableAdapter = null;
            // 
            // maketDataSet
            // 
            this.maketDataSet.DataSetName = "MaketDataSet";
            this.maketDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // facultiesBindingSource
            // 
            this.facultiesBindingSource.DataMember = "Faculties";
            this.facultiesBindingSource.DataSource = this.maketDataSet;
            // 
            // facultiesTableAdapter
            // 
            this.facultiesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdministrationTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DepartmentsTableAdapter = null;
            this.tableAdapterManager.EITableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.FacultiesTableAdapter = this.facultiesTableAdapter;
            this.tableAdapterManager.GroupsTableAdapter = null;
            this.tableAdapterManager.LearnersTableAdapter = null;
            this.tableAdapterManager.ReadingTableAdapter = null;
            this.tableAdapterManager.SubjectsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Maket_2018.MaketDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // facultiesBindingNavigator
            // 
            this.facultiesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.facultiesBindingNavigator.BindingSource = this.facultiesBindingSource;
            this.facultiesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.facultiesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.facultiesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.facultiesBindingNavigatorSaveItem});
            this.facultiesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.facultiesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.facultiesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.facultiesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.facultiesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.facultiesBindingNavigator.Name = "facultiesBindingNavigator";
            this.facultiesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.facultiesBindingNavigator.Size = new System.Drawing.Size(616, 25);
            this.facultiesBindingNavigator.TabIndex = 0;
            this.facultiesBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
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
            // facultiesBindingNavigatorSaveItem
            // 
            this.facultiesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.facultiesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("facultiesBindingNavigatorSaveItem.Image")));
            this.facultiesBindingNavigatorSaveItem.Name = "facultiesBindingNavigatorSaveItem";
            this.facultiesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.facultiesBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.facultiesBindingNavigatorSaveItem.Click += new System.EventHandler(this.facultiesBindingNavigatorSaveItem_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button3.Location = new System.Drawing.Point(554, 28);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(61, 26);
            this.button3.TabIndex = 15;
            this.button3.Text = "Назад";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button2.Location = new System.Drawing.Point(301, 312);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 42);
            this.button2.TabIndex = 14;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // departmentsBindingSource
            // 
            this.departmentsBindingSource.DataMember = "Departments";
            this.departmentsBindingSource.DataSource = this.maketDataSet;
            // 
            // departmentsTableAdapter
            // 
            this.departmentsTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(idFacultiesLabel);
            this.panel1.Controls.Add(numberLabel);
            this.panel1.Controls.Add(this.numberTextBox);
            this.panel1.Controls.Add(yearOfFoundationLabel);
            this.panel1.Controls.Add(this.yearOfFoundationTextBox);
            this.panel1.Controls.Add(nameDepLabel);
            this.panel1.Controls.Add(this.nameDepTextBox);
            this.panel1.Location = new System.Drawing.Point(171, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 224);
            this.panel1.TabIndex = 16;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.facultiesBindingSource2, "idFaculties", true));
            this.comboBox1.DataSource = this.facultiesBindingSource2;
            this.comboBox1.DisplayMember = "NameFac";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(119, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.ValueMember = "idFaculties";
            // 
            // facultiesBindingSource2
            // 
            this.facultiesBindingSource2.DataMember = "Faculties";
            this.facultiesBindingSource2.DataSource = this.maketDataSet2;
            // 
            // maketDataSet2
            // 
            this.maketDataSet2.DataSetName = "MaketDataSet2";
            this.maketDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(119, 168);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(121, 20);
            this.numberTextBox.TabIndex = 5;
            this.numberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberTextBox_KeyPress);
            // 
            // yearOfFoundationTextBox
            // 
            this.yearOfFoundationTextBox.Location = new System.Drawing.Point(119, 124);
            this.yearOfFoundationTextBox.Name = "yearOfFoundationTextBox";
            this.yearOfFoundationTextBox.Size = new System.Drawing.Size(121, 20);
            this.yearOfFoundationTextBox.TabIndex = 3;
            this.yearOfFoundationTextBox.TextChanged += new System.EventHandler(this.yearOfFoundationTextBox_TextChanged);
            this.yearOfFoundationTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.yearOfFoundationTextBox_KeyPress);
            // 
            // nameDepTextBox
            // 
            this.nameDepTextBox.Location = new System.Drawing.Point(119, 75);
            this.nameDepTextBox.Name = "nameDepTextBox";
            this.nameDepTextBox.Size = new System.Drawing.Size(121, 20);
            this.nameDepTextBox.TabIndex = 1;
            this.nameDepTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameDepTextBox_KeyPress);
            // 
            // facultiesBindingSource1
            // 
            this.facultiesBindingSource1.DataMember = "Faculties";
            this.facultiesBindingSource1.DataSource = this.maketDataSet2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(214, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 25);
            this.label6.TabIndex = 25;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // facultiesTableAdapter1
            // 
            this.facultiesTableAdapter1.ClearBeforeFill = true;
            // 
            // departmentsTableAdapter1
            // 
            this.departmentsTableAdapter1.ClearBeforeFill = true;
            // 
            // departmentsTableAdapter2
            // 
            this.departmentsTableAdapter2.ClearBeforeFill = true;
            // 
            // departmentsTableAdapter3
            // 
            this.departmentsTableAdapter3.ClearBeforeFill = true;
            // 
            // ДобавитьКафедру
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(616, 352);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.facultiesBindingNavigator);
            this.Name = "ДобавитьКафедру";
            this.Text = "Добавление Кафедры";
            this.Load += new System.EventHandler(this.ДобавитьКафедру_Load);
            ((System.ComponentModel.ISupportInitialize)(this.maketDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultiesBindingNavigator)).EndInit();
            this.facultiesBindingNavigator.ResumeLayout(false);
            this.facultiesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facultiesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maketDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultiesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaketDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private MaketDataSet maketDataSet;
        private System.Windows.Forms.BindingSource facultiesBindingSource;
        private MaketDataSetTableAdapters.FacultiesTableAdapter facultiesTableAdapter;
        private MaketDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator facultiesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton facultiesBindingNavigatorSaveItem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource departmentsBindingSource;
        private MaketDataSetTableAdapters.DepartmentsTableAdapter departmentsTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.TextBox yearOfFoundationTextBox;
        private System.Windows.Forms.TextBox nameDepTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private MaketDataSet2 maketDataSet2;
        private System.Windows.Forms.BindingSource facultiesBindingSource1;
        private MaketDataSet2TableAdapters.FacultiesTableAdapter facultiesTableAdapter1;
        private MaketDataSet3TableAdapters.DepartmentsTableAdapter departmentsTableAdapter1;
        private MaketDataSetTableAdapters.DepartmentsTableAdapter departmentsTableAdapter2;
        private MaketDataSet2TableAdapters.DepartmentsTableAdapter departmentsTableAdapter3;
        private System.Windows.Forms.BindingSource facultiesBindingSource2;
    }
}