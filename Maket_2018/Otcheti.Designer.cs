namespace Maket_2018
{
    partial class Otcheti
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
            this.button1 = new System.Windows.Forms.Button();
            this.maketDataSet2 = new Maket_2018.MaketDataSet2();
            this.administrationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.administrationTableAdapter1 = new Maket_2018.MaketDataSet2TableAdapters.AdministrationTableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.maketDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.administrationBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(246, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // maketDataSet2
            // 
            this.maketDataSet2.DataSetName = "MaketDataSet2";
            this.maketDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // administrationBindingSource1
            // 
            this.administrationBindingSource1.DataMember = "Administration";
            this.administrationBindingSource1.DataSource = this.maketDataSet2;
            // 
            // administrationTableAdapter1
            // 
            this.administrationTableAdapter1.ClearBeforeFill = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(63, 83);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(196, 55);
            this.button4.TabIndex = 5;
            this.button4.Text = "Получить отчёт о зарплате сотрудников";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Otcheti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(349, 181);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Name = "Otcheti";
            this.Text = "Отчёты";
            this.Load += new System.EventHandler(this.Otcheti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.maketDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.administrationBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private MaketDataSet2 maketDataSet2;
        private System.Windows.Forms.BindingSource administrationBindingSource1;
        private MaketDataSet2TableAdapters.AdministrationTableAdapter administrationTableAdapter1;
        private System.Windows.Forms.Button button4;
    }
}