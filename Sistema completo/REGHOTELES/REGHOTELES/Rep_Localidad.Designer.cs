namespace REGHOTELES
{
    partial class rep_Localidad
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
            this.reporteLocalidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new REGHOTELES.DataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reporteLocalidadTableAdapter = new REGHOTELES.DataSet1TableAdapters.reporteLocalidadTableAdapter();
            this.detReporteLocalidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detReporteLocalidadTableAdapter = new REGHOTELES.DataSet1TableAdapters.detReporteLocalidadTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reporteLocalidadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detReporteLocalidadBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reporteLocalidadBindingSource
            // 
            this.reporteLocalidadBindingSource.DataMember = "reporteLocalidad";
            this.reporteLocalidadBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "LOCALIDADES";
            reportDataSource1.Value = this.reporteLocalidadBindingSource;
            reportDataSource2.Name = "detRepLocalidad";
            reportDataSource2.Value = this.detReporteLocalidadBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "REGHOTELES.LOCALIDADES.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 13);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1066, 490);
            this.reportViewer1.TabIndex = 0;
            // 
            // reporteLocalidadTableAdapter
            // 
            this.reporteLocalidadTableAdapter.ClearBeforeFill = true;
            // 
            // detReporteLocalidadBindingSource
            // 
            this.detReporteLocalidadBindingSource.DataMember = "detReporteLocalidad";
            this.detReporteLocalidadBindingSource.DataSource = this.DataSet1;
            // 
            // detReporteLocalidadTableAdapter
            // 
            this.detReporteLocalidadTableAdapter.ClearBeforeFill = true;
            // 
            // rep_Localidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 535);
            this.Controls.Add(this.reportViewer1);
            this.Name = "rep_Localidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REPORTE LOCALIDAD";
            this.Load += new System.EventHandler(this.rep_Localidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reporteLocalidadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detReporteLocalidadBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource reporteLocalidadBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.reporteLocalidadTableAdapter reporteLocalidadTableAdapter;
        private System.Windows.Forms.BindingSource detReporteLocalidadBindingSource;
        private DataSet1TableAdapters.detReporteLocalidadTableAdapter detReporteLocalidadTableAdapter;
    }
}