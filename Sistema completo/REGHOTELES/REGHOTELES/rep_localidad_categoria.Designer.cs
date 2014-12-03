namespace REGHOTELES
{
    partial class rep_localidad_categoria
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
            this.rep_cat_localidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoTurismoDataSet3 = new REGHOTELES.proyectoTurismoDataSet3();
            this.repCatLocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rep_cat_localidadTableAdapter = new REGHOTELES.proyectoTurismoDataSet3TableAdapters.rep_cat_localidadTableAdapter();
            this.repCatLocTableAdapter = new REGHOTELES.proyectoTurismoDataSet3TableAdapters.repCatLocTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.rep_cat_localidadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoTurismoDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCatLocBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rep_cat_localidadBindingSource
            // 
            this.rep_cat_localidadBindingSource.DataMember = "rep_cat_localidad";
            this.rep_cat_localidadBindingSource.DataSource = this.proyectoTurismoDataSet3;
            // 
            // proyectoTurismoDataSet3
            // 
            this.proyectoTurismoDataSet3.DataSetName = "proyectoTurismoDataSet3";
            this.proyectoTurismoDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // repCatLocBindingSource
            // 
            this.repCatLocBindingSource.DataMember = "repCatLoc";
            this.repCatLocBindingSource.DataSource = this.proyectoTurismoDataSet3;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.rep_cat_localidadBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.repCatLocBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "REGHOTELES.Rep_Cat_Loc.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(560, 324);
            this.reportViewer1.TabIndex = 0;
            // 
            // rep_cat_localidadTableAdapter
            // 
            this.rep_cat_localidadTableAdapter.ClearBeforeFill = true;
            // 
            // repCatLocTableAdapter
            // 
            this.repCatLocTableAdapter.ClearBeforeFill = true;
            // 
            // rep_localidad_categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 324);
            this.Controls.Add(this.reportViewer1);
            this.Name = "rep_localidad_categoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "rep_localidad_categoria";
            this.Load += new System.EventHandler(this.rep_localidad_categoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rep_cat_localidadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoTurismoDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repCatLocBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource rep_cat_localidadBindingSource;
        private proyectoTurismoDataSet3 proyectoTurismoDataSet3;
        private System.Windows.Forms.BindingSource repCatLocBindingSource;
        private proyectoTurismoDataSet3TableAdapters.rep_cat_localidadTableAdapter rep_cat_localidadTableAdapter;
        private proyectoTurismoDataSet3TableAdapters.repCatLocTableAdapter repCatLocTableAdapter;
    }
}