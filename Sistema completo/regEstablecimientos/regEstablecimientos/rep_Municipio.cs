using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace regEstablecimientos
{
    public partial class rep_Municipio : Form
    {
        public string nombreMunicipio { get; set; }
        public rep_Municipio()
        {
            InitializeComponent();
        }

        private void rep_Municipio_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DtsEstablecimientos.reporte_municipioEstablecimientos' Puede moverla o quitarla según sea necesario.
            this.reporte_municipioEstablecimientosTableAdapter.Fill(this.DtsEstablecimientos.reporte_municipioEstablecimientos,nombreMunicipio);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
