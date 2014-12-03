namespace REGHOTELES
{
    partial class Rep_General
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
            this.reporteGeneralBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TurismoDataSet10 = new REGHOTELES.TurismoDataSet10();
            this.reporteGeneralTableAdapter = new REGHOTELES.TurismoDataSet10TableAdapters.reporteGeneralTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.reporteGeneralBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TurismoDataSet10)).BeginInit();
            this.SuspendLayout();
            // 
            // reporteGeneralBindingSource
            // 
            this.reporteGeneralBindingSource.DataMember = "reporteGeneral";
            this.reporteGeneralBindingSource.DataSource = this.TurismoDataSet10;
            // 
            // TurismoDataSet10
            // 
            this.TurismoDataSet10.DataSetName = "TurismoDataSet10";
            this.TurismoDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reporteGeneralTableAdapter
            // 
            this.reporteGeneralTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.reporteGeneralBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "REGHOTELES.ReporteGeneral.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(662, 539);
            this.reportViewer1.TabIndex = 0;
            // 
            // Rep_General
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 540);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Rep_General";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rep_General";
            this.Load += new System.EventHandler(this.Rep_General_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reporteGeneralBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TurismoDataSet10)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource reporteGeneralBindingSource;
        private TurismoDataSet10 TurismoDataSet10;
        private TurismoDataSet10TableAdapters.reporteGeneralTableAdapter reporteGeneralTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}