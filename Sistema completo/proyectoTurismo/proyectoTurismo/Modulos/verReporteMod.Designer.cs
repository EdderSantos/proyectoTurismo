namespace proyectoTurismo.Modulos
{
    partial class verReporteMod
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
            this.modulosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DSmodulos = new proyectoTurismo.Modulos.DSmodulos();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.modulosTableAdapter = new proyectoTurismo.Modulos.DSmodulosTableAdapters.modulosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.modulosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSmodulos)).BeginInit();
            this.SuspendLayout();
            // 
            // modulosBindingSource
            // 
            this.modulosBindingSource.DataMember = "modulos";
            this.modulosBindingSource.DataSource = this.DSmodulos;
            // 
            // DSmodulos
            // 
            this.DSmodulos.DataSetName = "DSmodulos";
            this.DSmodulos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "modulosReo";
            reportDataSource1.Value = this.modulosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "proyectoTurismo.Modulos.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(662, 461);
            this.reportViewer1.TabIndex = 0;
            // 
            // modulosTableAdapter
            // 
            this.modulosTableAdapter.ClearBeforeFill = true;
            // 
            // verReporteMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 461);
            this.Controls.Add(this.reportViewer1);
            this.Name = "verReporteMod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "verReporteMod";
            this.Load += new System.EventHandler(this.verReporteMod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.modulosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSmodulos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource modulosBindingSource;
        private DSmodulos DSmodulos;
        private DSmodulosTableAdapters.modulosTableAdapter modulosTableAdapter;
    }
}