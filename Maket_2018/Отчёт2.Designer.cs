namespace Maket_2018
{
    partial class Отчёт2
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
            this.MaketDataSet2 = new Maket_2018.MaketDataSet2();
            this.AdministrationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AdministrationTableAdapter = new Maket_2018.MaketDataSet2TableAdapters.AdministrationTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.MaketDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdministrationBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Maket_2018.Отчёт2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(771, 341);
            this.reportViewer1.TabIndex = 0;
            // 
            // Отчёт2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 341);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Отчёт2";
            this.Text = "Отчёт2";
            this.Load += new System.EventHandler(this.Отчёт2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MaketDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdministrationBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource AdministrationBindingSource;
        private MaketDataSet2 MaketDataSet2;
        private MaketDataSet2TableAdapters.AdministrationTableAdapter AdministrationTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}