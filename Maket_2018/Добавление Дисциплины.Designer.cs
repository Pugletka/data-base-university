namespace Maket_2018
{
    partial class Добавление_Дисциплины
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
            System.Windows.Forms.Label nameofSubjectLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Добавление_Дисциплины));
            this.maketDataSet2 = new Maket_2018.MaketDataSet2();
            this.subjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subjectsTableAdapter = new Maket_2018.MaketDataSet2TableAdapters.SubjectsTableAdapter();
            this.tableAdapterManager = new Maket_2018.MaketDataSet2TableAdapters.TableAdapterManager();
            this.employeesTableAdapter = new Maket_2018.MaketDataSet2TableAdapters.EmployeesTableAdapter();
            this.subjectsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.subjectsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.readingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.readingTableAdapter1 = new Maket_2018.MaketDataSet2TableAdapters.ReadingTableAdapter();
            this.employeesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.subjectsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.employeesBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.subjectsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.employeesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.subjectsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.subjectsTableAdapter1 = new Maket_2018.MaketDataSet2TableAdapters.SubjectsTableAdapter();
            this.subjectsTableAdapter2 = new Maket_2018.MaketDataSet3TableAdapters.SubjectsTableAdapter();
            this.subjectsTableAdapter3 = new Maket_2018.MaketDataSetTableAdapters.SubjectsTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            nameofSubjectLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.maketDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingNavigator)).BeginInit();
            this.subjectsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.readingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // nameofSubjectLabel
            // 
            nameofSubjectLabel.AutoSize = true;
            nameofSubjectLabel.Location = new System.Drawing.Point(8, 67);
            nameofSubjectLabel.Name = "nameofSubjectLabel";
            nameofSubjectLabel.Size = new System.Drawing.Size(125, 13);
            nameofSubjectLabel.TabIndex = 1;
            nameofSubjectLabel.Text = "Название дисциплины:";
            nameofSubjectLabel.Click += new System.EventHandler(this.nameofSubjectLabel_Click);
            // 
            // maketDataSet2
            // 
            this.maketDataSet2.DataSetName = "MaketDataSet2";
            this.maketDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // subjectsBindingSource
            // 
            this.subjectsBindingSource.DataMember = "Subjects";
            this.subjectsBindingSource.DataSource = this.maketDataSet2;
            // 
            // subjectsTableAdapter
            // 
            this.subjectsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdministrationTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DepartmentsTableAdapter = null;
            this.tableAdapterManager.EITableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = this.employeesTableAdapter;
            this.tableAdapterManager.FacultiesTableAdapter = null;
            this.tableAdapterManager.GroupsTableAdapter = null;
            this.tableAdapterManager.LearnersTableAdapter = null;
            this.tableAdapterManager.ReadingTableAdapter = null;
            this.tableAdapterManager.SubjectsTableAdapter = this.subjectsTableAdapter;
            this.tableAdapterManager.UpdateOrder = Maket_2018.MaketDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // subjectsBindingNavigator
            // 
            this.subjectsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.subjectsBindingNavigator.BindingSource = this.subjectsBindingSource;
            this.subjectsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.subjectsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.subjectsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.subjectsBindingNavigatorSaveItem});
            this.subjectsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.subjectsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.subjectsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.subjectsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.subjectsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.subjectsBindingNavigator.Name = "subjectsBindingNavigator";
            this.subjectsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.subjectsBindingNavigator.Size = new System.Drawing.Size(565, 25);
            this.subjectsBindingNavigator.TabIndex = 0;
            this.subjectsBindingNavigator.Text = "bindingNavigator1";
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
            // subjectsBindingNavigatorSaveItem
            // 
            this.subjectsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.subjectsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("subjectsBindingNavigatorSaveItem.Image")));
            this.subjectsBindingNavigatorSaveItem.Name = "subjectsBindingNavigatorSaveItem";
            this.subjectsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.subjectsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.subjectsBindingNavigatorSaveItem.Click += new System.EventHandler(this.subjectsBindingNavigatorSaveItem_Click);
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.maketDataSet2;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button2.Location = new System.Drawing.Point(236, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 42);
            this.button2.TabIndex = 18;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button2_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(nameofSubjectLabel);
            this.panel1.Location = new System.Drawing.Point(106, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(305, 133);
            this.panel1.TabIndex = 19;
            // 
            // readingBindingSource
            // 
            this.readingBindingSource.DataMember = "Reading";
            this.readingBindingSource.DataSource = this.maketDataSet2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(171, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 24);
            this.label2.TabIndex = 20;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button3.Location = new System.Drawing.Point(501, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(61, 26);
            this.button3.TabIndex = 22;
            this.button3.Text = "Назад";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // readingTableAdapter1
            // 
            this.readingTableAdapter1.ClearBeforeFill = true;
            // 
            // employeesBindingSource2
            // 
            this.employeesBindingSource2.DataMember = "Employees";
            this.employeesBindingSource2.DataSource = this.maketDataSet2;
            // 
            // subjectsBindingSource1
            // 
            this.subjectsBindingSource1.DataMember = "Subjects";
            this.subjectsBindingSource1.DataSource = this.maketDataSet2;
            // 
            // employeesBindingSource3
            // 
            this.employeesBindingSource3.DataMember = "Employees";
            this.employeesBindingSource3.DataSource = this.maketDataSet2;
            // 
            // subjectsBindingSource2
            // 
            this.subjectsBindingSource2.DataMember = "Subjects";
            this.subjectsBindingSource2.DataSource = this.maketDataSet2;
            // 
            // employeesBindingSource1
            // 
            this.employeesBindingSource1.DataMember = "Employees";
            this.employeesBindingSource1.DataSource = this.maketDataSet2;
            // 
            // subjectsBindingSource3
            // 
            this.subjectsBindingSource3.DataMember = "Subjects";
            this.subjectsBindingSource3.DataSource = this.maketDataSet2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(139, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // subjectsTableAdapter1
            // 
            this.subjectsTableAdapter1.ClearBeforeFill = true;
            // 
            // subjectsTableAdapter2
            // 
            this.subjectsTableAdapter2.ClearBeforeFill = true;
            // 
            // subjectsTableAdapter3
            // 
            this.subjectsTableAdapter3.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(65, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 10;
            // 
            // Добавление_Дисциплины
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(565, 290);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.subjectsBindingNavigator);
            this.Controls.Add(this.panel1);
            this.Name = "Добавление_Дисциплины";
            this.Text = "Добавление_Дисциплины";
            this.Load += new System.EventHandler(this.Добавление_Дисциплины_Load);
            ((System.ComponentModel.ISupportInitialize)(this.maketDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingNavigator)).EndInit();
            this.subjectsBindingNavigator.ResumeLayout(false);
            this.subjectsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.readingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaketDataSet2 maketDataSet2;
        private System.Windows.Forms.BindingSource subjectsBindingSource;
        private MaketDataSet2TableAdapters.SubjectsTableAdapter subjectsTableAdapter;
        private MaketDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator subjectsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton subjectsBindingNavigatorSaveItem;
        private MaketDataSet2TableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private MaketDataSet2TableAdapters.ReadingTableAdapter readingTableAdapter1;
        private System.Windows.Forms.BindingSource subjectsBindingSource1;
        private System.Windows.Forms.BindingSource employeesBindingSource2;
        private System.Windows.Forms.BindingSource employeesBindingSource3;
        private System.Windows.Forms.BindingSource subjectsBindingSource2;
        private System.Windows.Forms.BindingSource readingBindingSource;
        private System.Windows.Forms.BindingSource employeesBindingSource1;
        private System.Windows.Forms.BindingSource subjectsBindingSource3;
        private System.Windows.Forms.TextBox textBox1;
        private MaketDataSet2TableAdapters.SubjectsTableAdapter subjectsTableAdapter1;
        private MaketDataSet3TableAdapters.SubjectsTableAdapter subjectsTableAdapter2;
        private MaketDataSetTableAdapters.SubjectsTableAdapter subjectsTableAdapter3;
        private System.Windows.Forms.Label label1;
    }
}