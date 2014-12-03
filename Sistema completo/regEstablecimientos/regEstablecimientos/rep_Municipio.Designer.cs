namespace regEstablecimientos
{
    partial class rep_Municipio
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DtsEstablecimientos = new regEstablecimientos.DtsEstablecimientos();
            this.reporte_municipioEstablecimientosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reporte_municipioEstablecimientosTableAdapter = new regEstablecimientos.DtsEstablecimientosTableAdapters.reporte_municipioEstablecimientosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DtsEstablecimientos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporte_municipioEstablecimientosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.reporte_municipioEstablecimientosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "regEstablecimientos.rep_Municipio.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(871, 532);
            this.reportViewer1.TabIndex = 0;
            // 
            // DtsEstablecimientos
            // 
            this.DtsEstablecimientos.DataSetName = "DtsEstablecimientos";
            this.DtsEstablecimientos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reporte_municipioEstablecimientosBindingSource
            // 
            this.reporte_municipioEstablecimientosBindingSource.DataMember = "reporte_municipioEstablecimientos";
            this.reporte_municipioEstablecimientosBindingSource.DataSource = this.DtsEstablecimientos;
            // 
            // reporte_municipioEstablecimientosTableAdapter
            // 
            this.reporte_municipioEstablecimientosTableAdapter.ClearBeforeFill = true;
            // 
            // rep_Municipio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 532);
            this.Controls.Add(this.reportViewer1);
            this.Name = "rep_Municipio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "rep_Municipio";
            this.Load += new System.EventHandler(this.rep_Municipio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtsEstablecimientos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporte_municipioEstablecimientosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource reporte_municipioEstablecimientosBindingSource;
        private DtsEstablecimientos DtsEstablecimientos;
        private DtsEstablecimientosTableAdapters.reporte_municipioEstablecimientosTableAdapter reporte_municipioEstablecimientosTableAdapter;

    }
}