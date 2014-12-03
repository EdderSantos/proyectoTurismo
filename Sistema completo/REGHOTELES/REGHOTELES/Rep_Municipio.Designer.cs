namespace REGHOTELES
{
    partial class Rep_Municipio
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reporteMunicipioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new REGHOTELES.DataSet1();
            this.reporteMunicipioTableAdapter = new REGHOTELES.DataSet1TableAdapters.reporteMunicipioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reporteMunicipioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoScroll = true;
            this.reportViewer1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "MUNICIPIO";
            reportDataSource1.Value = this.reporteMunicipioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "REGHOTELES.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1096, 538);
            this.reportViewer1.TabIndex = 0;
            // 
            // reporteMunicipioBindingSource
            // 
            this.reporteMunicipioBindingSource.DataMember = "reporteMunicipio";
            this.reporteMunicipioBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reporteMunicipioTableAdapter
            // 
            this.reporteMunicipioTableAdapter.ClearBeforeFill = true;
            // 
            // Rep_Municipio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 538);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Rep_Municipio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rep_Municipio";
            this.Load += new System.EventHandler(this.Rep_Municipio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reporteMunicipioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource reporteMunicipioBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.reporteMunicipioTableAdapter reporteMunicipioTableAdapter;

    }
}