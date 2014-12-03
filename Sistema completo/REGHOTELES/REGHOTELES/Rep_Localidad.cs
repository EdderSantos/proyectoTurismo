using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace REGHOTELES
{
    public partial class rep_Localidad : Form
    {
        public string nombreLocalidad { get; set; }
        public rep_Localidad()
        {
            InitializeComponent();
        }

        private void rep_Localidad_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.reporteLocalidad' Puede moverla o quitarla según sea necesario.
            this.reporteLocalidadTableAdapter.Fill(this.DataSet1.reporteLocalidad,nombreLocalidad);
            this.detReporteLocalidadTableAdapter.Fill(this.DataSet1.detReporteLocalidad, nombreLocalidad);

            this.reportViewer1.RefreshReport();
        }
    }
}
