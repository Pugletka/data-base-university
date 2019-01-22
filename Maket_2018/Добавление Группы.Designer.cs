namespace Maket_2018
{
    partial class Добавление_Группы
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
            System.Windows.Forms.Label indexGroupLabel;
            System.Windows.Forms.Label surnameOfMonitorLabel;
            System.Windows.Forms.Label nameOfMonitorLabel;
            System.Windows.Forms.Label patronymicOfMonitorLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Добавление_Группы));
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.departmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maketDataSet2 = new Maket_2018.MaketDataSet2();
            this.patronymicOfMonitorTextBox = new System.Windows.Forms.TextBox();
            this.nameOfMonitorTextBox = new System.Windows.Forms.TextBox();
            this.surnameOfMonitorTextBox = new System.Windows.Forms.TextBox();
            this.indexGroupTextBox = new System.Windows.Forms.TextBox();
            this.groupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupsTableAdapter = new Maket_2018.MaketDataSet2TableAdapters.GroupsTableAdapter();
            this.tableAdapterManager = new Maket_2018.MaketDataSet2TableAdapters.TableAdapterManager();
            this.groupsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.groupsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.button2 = new System.Windows.Forms.Button();
            this.departmentsTableAdapter = new Maket_2018.MaketDataSet2TableAdapters.DepartmentsTableAdapter();
            idDepartmentsLabel = new System.Windows.Forms.Label();
            indexGroupLabel = new System.Windows.Forms.Label();
            surnameOfMonitorLabel = new System.Windows.Forms.Label();
            nameOfMonitorLabel = new System.Windows.Forms.Label();
            patronymicOfMonitorLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maketDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingNavigator)).BeginInit();
            this.groupsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // idDepartmentsLabel
            // 
            idDepartmentsLabel.AutoSize = true;
            idDepartmentsLabel.Location = new System.Drawing.Point(89, 75);
            idDepartmentsLabel.Name = "idDepartmentsLabel";
            idDepartmentsLabel.Size = new System.Drawing.Size(55, 13);
            idDepartmentsLabel.TabIndex = 0;
            idDepartmentsLabel.Text = "Кафедра:";
            // 
            // indexGroupLabel
            // 
            indexGroupLabel.AutoSize = true;
            indexGroupLabel.Location = new System.Drawing.Point(102, 107);
            indexGroupLabel.Name = "indexGroupLabel";
            indexGroupLabel.Size = new System.Drawing.Size(45, 13);
            indexGroupLabel.TabIndex = 2;
            indexGroupLabel.Text = "Группа:";
            // 
            // surnameOfMonitorLabel
            // 
            surnameOfMonitorLabel.AutoSize = true;
            surnameOfMonitorLabel.Location = new System.Drawing.Point(66, 133);
            surnameOfMonitorLabel.Name = "surnameOfMonitorLabel";
            surnameOfMonitorLabel.Size = new System.Drawing.Size(110, 13);
            surnameOfMonitorLabel.TabIndex = 4;
            surnameOfMonitorLabel.Text = "Фамилия старосты:";
            // 
            // nameOfMonitorLabel
            // 
            nameOfMonitorLabel.AutoSize = true;
            nameOfMonitorLabel.Location = new System.Drawing.Point(80, 159);
            nameOfMonitorLabel.Name = "nameOfMonitorLabel";
            nameOfMonitorLabel.Size = new System.Drawing.Size(83, 13);
            nameOfMonitorLabel.TabIndex = 6;
            nameOfMonitorLabel.Text = "Имя старосты:";
            // 
            // patronymicOfMonitorLabel
            // 
            patronymicOfMonitorLabel.AutoSize = true;
            patronymicOfMonitorLabel.Location = new System.Drawing.Point(56, 185);
            patronymicOfMonitorLabel.Name = "patronymicOfMonitorLabel";
            patronymicOfMonitorLabel.Size = new System.Drawing.Size(108, 13);
            patronymicOfMonitorLabel.TabIndex = 8;
            patronymicOfMonitorLabel.Text = "Отчество старосты:";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button3.Location = new System.Drawing.Point(818, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(61, 26);
            this.button3.TabIndex = 14;
            this.button3.Text = "Назад";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(patronymicOfMonitorLabel);
            this.panel1.Controls.Add(this.patronymicOfMonitorTextBox);
            this.panel1.Controls.Add(nameOfMonitorLabel);
            this.panel1.Controls.Add(this.nameOfMonitorTextBox);
            this.panel1.Controls.Add(surnameOfMonitorLabel);
            this.panel1.Controls.Add(this.surnameOfMonitorTextBox);
            this.panel1.Controls.Add(indexGroupLabel);
            this.panel1.Controls.Add(this.indexGroupTextBox);
            this.panel1.Controls.Add(idDepartmentsLabel);
            this.panel1.Location = new System.Drawing.Point(230, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 219);
            this.panel1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(64, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 11;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.departmentsBindingSource, "idDepartments", true));
            this.comboBox1.DataSource = this.departmentsBindingSource;
            this.comboBox1.DisplayMember = "NameDep";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(176, 75);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(187, 21);
            this.comboBox1.TabIndex = 10;
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
            // patronymicOfMonitorTextBox
            // 
            this.patronymicOfMonitorTextBox.Location = new System.Drawing.Point(176, 182);
            this.patronymicOfMonitorTextBox.Name = "patronymicOfMonitorTextBox";
            this.patronymicOfMonitorTextBox.Size = new System.Drawing.Size(187, 20);
            this.patronymicOfMonitorTextBox.TabIndex = 9;
            this.patronymicOfMonitorTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.patronymicOfMonitorTextBox_KeyPress);
            // 
            // nameOfMonitorTextBox
            // 
            this.nameOfMonitorTextBox.Location = new System.Drawing.Point(176, 156);
            this.nameOfMonitorTextBox.Name = "nameOfMonitorTextBox";
            this.nameOfMonitorTextBox.Size = new System.Drawing.Size(187, 20);
            this.nameOfMonitorTextBox.TabIndex = 7;
            this.nameOfMonitorTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameOfMonitorTextBox_KeyPress);
            // 
            // surnameOfMonitorTextBox
            // 
            this.surnameOfMonitorTextBox.Location = new System.Drawing.Point(176, 130);
            this.surnameOfMonitorTextBox.Name = "surnameOfMonitorTextBox";
            this.surnameOfMonitorTextBox.Size = new System.Drawing.Size(187, 20);
            this.surnameOfMonitorTextBox.TabIndex = 5;
            this.surnameOfMonitorTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.surnameOfMonitorTextBox_KeyPress);
            // 
            // indexGroupTextBox
            // 
            this.indexGroupTextBox.Location = new System.Drawing.Point(176, 104);
            this.indexGroupTextBox.Name = "indexGroupTextBox";
            this.indexGroupTextBox.Size = new System.Drawing.Size(187, 20);
            this.indexGroupTextBox.TabIndex = 3;
            this.indexGroupTextBox.TextChanged += new System.EventHandler(this.indexGroupTextBox_TextChanged);
            this.indexGroupTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.indexGroupTextBox_KeyPress);
            // 
            // groupsBindingSource
            // 
            this.groupsBindingSource.DataMember = "Groups";
            this.groupsBindingSource.DataSource = this.maketDataSet2;
            // 
            // groupsTableAdapter
            // 
            this.groupsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdministrationTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DepartmentsTableAdapter = null;
            this.tableAdapterManager.EITableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.FacultiesTableAdapter = null;
            this.tableAdapterManager.GroupsTableAdapter = this.groupsTableAdapter;
            this.tableAdapterManager.LearnersTableAdapter = null;
            this.tableAdapterManager.ReadingTableAdapter = null;
            this.tableAdapterManager.SubjectsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Maket_2018.MaketDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // groupsBindingNavigator
            // 
            this.groupsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.groupsBindingNavigator.BindingSource = this.groupsBindingSource;
            this.groupsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.groupsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.groupsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.groupsBindingNavigatorSaveItem});
            this.groupsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.groupsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.groupsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.groupsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.groupsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.groupsBindingNavigator.Name = "groupsBindingNavigator";
            this.groupsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.groupsBindingNavigator.Size = new System.Drawing.Size(891, 25);
            this.groupsBindingNavigator.TabIndex = 16;
            this.groupsBindingNavigator.Text = "bindingNavigator1";
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
            // groupsBindingNavigatorSaveItem
            // 
            this.groupsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.groupsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("groupsBindingNavigatorSaveItem.Image")));
            this.groupsBindingNavigatorSaveItem.Name = "groupsBindingNavigatorSaveItem";
            this.groupsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.groupsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.groupsBindingNavigatorSaveItem.Click += new System.EventHandler(this.groupsBindingNavigatorSaveItem_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button2.Location = new System.Drawing.Point(400, 298);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 42);
            this.button2.TabIndex = 17;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // departmentsTableAdapter
            // 
            this.departmentsTableAdapter.ClearBeforeFill = true;
            // 
            // Добавление_Группы
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(891, 377);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupsBindingNavigator);
            this.Controls.Add(this.panel1);
            this.Name = "Добавление_Группы";
            this.Text = "Добавление_Группы";
            this.Load += new System.EventHandler(this.Добавление_Группы_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maketDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingNavigator)).EndInit();
            this.groupsBindingNavigator.ResumeLayout(false);
            this.groupsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private MaketDataSet2 maketDataSet2;
        private System.Windows.Forms.BindingSource groupsBindingSource;
        private MaketDataSet2TableAdapters.GroupsTableAdapter groupsTableAdapter;
        private MaketDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator groupsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton groupsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox surnameOfMonitorTextBox;
        private System.Windows.Forms.TextBox indexGroupTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox patronymicOfMonitorTextBox;
        private System.Windows.Forms.TextBox nameOfMonitorTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource departmentsBindingSource;
        private MaketDataSet2TableAdapters.DepartmentsTableAdapter departmentsTableAdapter;
        private System.Windows.Forms.Label label1;
    }
}