namespace regEstablecimientos
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
            this.rep_LocalidadEstablecimientosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DtsEstablecimientos = new regEstablecimientos.DtsEstablecimientos();
            this.reporte_municipioEstablecimientosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reporte_municipioEstablecimientosTableAdapter = new regEstablecimientos.DtsEstablecimientosTableAdapters.reporte_municipioEstablecimientosTableAdapter();
            this.rep_LocalidadEstablecimientosTableAdapter = new regEstablecimientos.DtsEstablecimientosTableAdapters.rep_LocalidadEstablecimientosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.rep_LocalidadEstablecimientosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtsEstablecimientos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporte_municipioEstablecimientosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rep_LocalidadEstablecimientosBindingSource
            // 
            this.rep_LocalidadEstablecimientosBindingSource.DataMember = "rep_LocalidadEstablecimientos";
            this.rep_LocalidadEstablecimientosBindingSource.DataSource = this.DtsEstablecimientos;
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
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.rep_LocalidadEstablecimientosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "regEstablecimientos.rep_Localalidad.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1041, 569);
            this.reportViewer1.TabIndex = 0;
            // 
            // reporte_municipioEstablecimientosTableAdapter
            // 
            this.reporte_municipioEstablecimientosTableAdapter.ClearBeforeFill = true;
            // 
            // rep_LocalidadEstablecimientosTableAdapter
            // 
            this.rep_LocalidadEstablecimientosTableAdapter.ClearBeforeFill = true;
            // 
            // rep_Localidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 569);
            this.Controls.Add(this.reportViewer1);
            this.Name = "rep_Localidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REPORTE LOCALIDAD ";
            this.Load += new System.EventHandler(this.rep_Localidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rep_LocalidadEstablecimientosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtsEstablecimientos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporte_municipioEstablecimientosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource reporte_municipioEstablecimientosBindingSource;
        private DtsEstablecimientos DtsEstablecimientos;
        private DtsEstablecimientosTableAdapters.reporte_municipioEstablecimientosTableAdapter reporte_municipioEstablecimientosTableAdapter;
        private System.Windows.Forms.BindingSource rep_LocalidadEstablecimientosBindingSource;
        private DtsEstablecimientosTableAdapters.rep_LocalidadEstablecimientosTableAdapter rep_LocalidadEstablecimientosTableAdapter;
    }
}