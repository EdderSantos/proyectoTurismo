namespace REGHOTELES
{
    partial class ReporteCategoriacs
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSet1 = new REGHOTELES.DataSet1();
            this.reporteMunicipioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reporteMunicipioTableAdapter = new REGHOTELES.DataSet1TableAdapters.reporteMunicipioTableAdapter();
            this.proyectoTurismoDataSet2 = new REGHOTELES.proyectoTurismoDataSet2();
            this.repCatMunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repCatMunTableAdapter = new REGHOTELES.proyectoTurismoDataSet2TableAdapters.repCatMunTableAdapter();
            this.reporteCategoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reporteCategoriaTableAdapter = new REGHOTELES.proyectoTurismoDataSet2TableAdapters.reporteCategoriaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteMunicipioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoTurismoDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCatMunBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteCategoriaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.repCatMunBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.reporteCategoriaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "REGHOTELES.Rep_Categoria.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(725, 499);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reporteMunicipioBindingSource
            // 
            this.reporteMunicipioBindingSource.DataMember = "reporteMunicipio";
            this.reporteMunicipioBindingSource.DataSource = this.DataSet1;
            // 
            // reporteMunicipioTableAdapter
            // 
            this.reporteMunicipioTableAdapter.ClearBeforeFill = true;
            // 
            // proyectoTurismoDataSet2
            // 
            this.proyectoTurismoDataSet2.DataSetName = "proyectoTurismoDataSet2";
            this.proyectoTurismoDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // repCatMunBindingSource
            // 
            this.repCatMunBindingSource.DataMember = "repCatMun";
            this.repCatMunBindingSource.DataSource = this.proyectoTurismoDataSet2;
            // 
            // repCatMunTableAdapter
            // 
            this.repCatMunTableAdapter.ClearBeforeFill = true;
            // 
            // reporteCategoriaBindingSource
            // 
            this.reporteCategoriaBindingSource.DataMember = "reporteCategoria";
            this.reporteCategoriaBindingSource.DataSource = this.proyectoTurismoDataSet2;
            // 
            // reporteCategoriaTableAdapter
            // 
            this.reporteCategoriaTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteCategoriacs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 499);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteCategoriacs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteCategoriacs";
            this.Load += new System.EventHandler(this.ReporteCategoriacs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteMunicipioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoTurismoDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCatMunBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteCategoriaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource reporteMunicipioBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.reporteMunicipioTableAdapter reporteMunicipioTableAdapter;
        private System.Windows.Forms.BindingSource repCatMunBindingSource;
        private proyectoTurismoDataSet2 proyectoTurismoDataSet2;
        private System.Windows.Forms.BindingSource reporteCategoriaBindingSource;
        private proyectoTurismoDataSet2TableAdapters.repCatMunTableAdapter repCatMunTableAdapter;
        private proyectoTurismoDataSet2TableAdapters.reporteCategoriaTableAdapter reporteCategoriaTableAdapter;
    }
}