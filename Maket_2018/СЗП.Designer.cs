namespace Maket_2018
{
    partial class СЗП
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.button1 = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.MaketDataSet2 = new Maket_2018.MaketDataSet2();
            this.AdministrationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AdministrationTableAdapter = new Maket_2018.MaketDataSet2TableAdapters.AdministrationTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.MaketDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdministrationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(792, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.AdministrationBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Maket_2018.СЗП.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(883, 261);
            this.reportViewer1.TabIndex = 3;
            // 
            // MaketDataSet2
            // 
            this.MaketDataSet2.DataSetName = "MaketDataSet2";
            this.MaketDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AdministrationBindingSource
            // 
            this.AdministrationBindingSource.DataMember = "Administration";
            this.AdministrationBindingSource.DataSource = this.MaketDataSet2;
            // 
            // AdministrationTableAdapter
            // 
            this.AdministrationTableAdapter.ClearBeforeFill = true;
            // 
            // СЗП
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "СЗП";
            this.Text = "СЗП";
            this.Load += new System.EventHandler(this.СЗП_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MaketDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdministrationBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource AdministrationBindingSource;
        private MaketDataSet2 MaketDataSet2;
        private MaketDataSet2TableAdapters.AdministrationTableAdapter AdministrationTableAdapter;
    }
}