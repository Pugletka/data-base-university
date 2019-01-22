namespace Maket_2018
{
    partial class Добавление_Учащихся
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
            System.Windows.Forms.Label surnameLabel;
            System.Windows.Forms.Label nameLearnerLabel;
            System.Windows.Forms.Label patronymicLabel;
            System.Windows.Forms.Label idGroupsLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Добавление_Учащихся));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maketDataSet2 = new Maket_2018.MaketDataSet2();
            this.patronymicTextBox = new System.Windows.Forms.TextBox();
            this.nameLearnerTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.learnersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.learnersTableAdapter = new Maket_2018.MaketDataSet2TableAdapters.LearnersTableAdapter();
            this.tableAdapterManager = new Maket_2018.MaketDataSet2TableAdapters.TableAdapterManager();
            this.groupsTableAdapter = new Maket_2018.MaketDataSet2TableAdapters.GroupsTableAdapter();
            this.learnersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.learnersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            surnameLabel = new System.Windows.Forms.Label();
            nameLearnerLabel = new System.Windows.Forms.Label();
            patronymicLabel = new System.Windows.Forms.Label();
            idGroupsLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maketDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.learnersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.learnersBindingNavigator)).BeginInit();
            this.learnersBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Location = new System.Drawing.Point(59, 83);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new System.Drawing.Size(59, 13);
            surnameLabel.TabIndex = 0;
            surnameLabel.Text = "Фамилия:";
            // 
            // nameLearnerLabel
            // 
            nameLearnerLabel.AutoSize = true;
            nameLearnerLabel.Location = new System.Drawing.Point(61, 113);
            nameLearnerLabel.Name = "nameLearnerLabel";
            nameLearnerLabel.Size = new System.Drawing.Size(32, 13);
            nameLearnerLabel.TabIndex = 2;
            nameLearnerLabel.Text = "Имя:";
            // 
            // patronymicLabel
            // 
            patronymicLabel.AutoSize = true;
            patronymicLabel.Location = new System.Drawing.Point(61, 152);
            patronymicLabel.Name = "patronymicLabel";
            patronymicLabel.Size = new System.Drawing.Size(57, 13);
            patronymicLabel.TabIndex = 4;
            patronymicLabel.Text = "Отчество:";
            // 
            // idGroupsLabel
            // 
            idGroupsLabel.AutoSize = true;
            idGroupsLabel.Location = new System.Drawing.Point(59, 43);
            idGroupsLabel.Name = "idGroupsLabel";
            idGroupsLabel.Size = new System.Drawing.Size(45, 13);
            idGroupsLabel.TabIndex = 6;
            idGroupsLabel.Text = "Группа:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.Location = new System.Drawing.Point(547, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 26);
            this.button1.TabIndex = 15;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button2.Location = new System.Drawing.Point(254, 278);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 42);
            this.button2.TabIndex = 16;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(idGroupsLabel);
            this.panel1.Controls.Add(patronymicLabel);
            this.panel1.Controls.Add(this.patronymicTextBox);
            this.panel1.Controls.Add(nameLearnerLabel);
            this.panel1.Controls.Add(this.nameLearnerTextBox);
            this.panel1.Controls.Add(surnameLabel);
            this.panel1.Controls.Add(this.surnameTextBox);
            this.panel1.Location = new System.Drawing.Point(125, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 183);
            this.panel1.TabIndex = 17;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.groupsBindingSource, "idGroups", true));
            this.comboBox1.DataSource = this.groupsBindingSource;
            this.comboBox1.DisplayMember = "IndexGroup";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(129, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.ValueMember = "idGroups";
            // 
            // groupsBindingSource
            // 
            this.groupsBindingSource.DataMember = "Groups";
            this.groupsBindingSource.DataSource = this.maketDataSet2;
            // 
            // maketDataSet2
            // 
            this.maketDataSet2.DataSetName = "MaketDataSet2";
            this.maketDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patronymicTextBox
            // 
            this.patronymicTextBox.Location = new System.Drawing.Point(129, 145);
            this.patronymicTextBox.Name = "patronymicTextBox";
            this.patronymicTextBox.Size = new System.Drawing.Size(180, 20);
            this.patronymicTextBox.TabIndex = 5;
            this.patronymicTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.patronymicTextBox_KeyPress);
            // 
            // nameLearnerTextBox
            // 
            this.nameLearnerTextBox.Location = new System.Drawing.Point(129, 113);
            this.nameLearnerTextBox.Name = "nameLearnerTextBox";
            this.nameLearnerTextBox.Size = new System.Drawing.Size(180, 20);
            this.nameLearnerTextBox.TabIndex = 3;
            this.nameLearnerTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameLearnerTextBox_KeyPress);
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(129, 76);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(180, 20);
            this.surnameTextBox.TabIndex = 1;
            this.surnameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.surnameTextBox_KeyPress);
            // 
            // learnersBindingSource
            // 
            this.learnersBindingSource.DataMember = "Learners";
            this.learnersBindingSource.DataSource = this.maketDataSet2;
            // 
            // learnersTableAdapter
            // 
            this.learnersTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.LearnersTableAdapter = this.learnersTableAdapter;
            this.tableAdapterManager.ReadingTableAdapter = null;
            this.tableAdapterManager.SubjectsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Maket_2018.MaketDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // groupsTableAdapter
            // 
            this.groupsTableAdapter.ClearBeforeFill = true;
            // 
            // learnersBindingNavigator
            // 
            this.learnersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.learnersBindingNavigator.BindingSource = this.learnersBindingSource;
            this.learnersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.learnersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.learnersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.learnersBindingNavigatorSaveItem});
            this.learnersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.learnersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.learnersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.learnersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.learnersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.learnersBindingNavigator.Name = "learnersBindingNavigator";
            this.learnersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.learnersBindingNavigator.Size = new System.Drawing.Size(609, 25);
            this.learnersBindingNavigator.TabIndex = 18;
            this.learnersBindingNavigator.Text = "bindingNavigator1";
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
            // learnersBindingNavigatorSaveItem
            // 
            this.learnersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.learnersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("learnersBindingNavigatorSaveItem.Image")));
            this.learnersBindingNavigatorSaveItem.Name = "learnersBindingNavigatorSaveItem";
            this.learnersBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.learnersBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.learnersBindingNavigatorSaveItem.Click += new System.EventHandler(this.learnersBindingNavigatorSaveItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(213, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 19;
            // 
            // Добавление_Учащихся
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(609, 326);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.learnersBindingNavigator);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Name = "Добавление_Учащихся";
            this.Text = "Добавление_Учащихся";
            this.Load += new System.EventHandler(this.Добавление_Учащихся_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maketDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.learnersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.learnersBindingNavigator)).EndInit();
            this.learnersBindingNavigator.ResumeLayout(false);
            this.learnersBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private MaketDataSet2 maketDataSet2;
        private System.Windows.Forms.BindingSource learnersBindingSource;
        private MaketDataSet2TableAdapters.LearnersTableAdapter learnersTableAdapter;
        private MaketDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator learnersBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton learnersBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox patronymicTextBox;
        private System.Windows.Forms.TextBox nameLearnerTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private MaketDataSet2TableAdapters.GroupsTableAdapter groupsTableAdapter;
        private System.Windows.Forms.BindingSource groupsBindingSource;
    }
}