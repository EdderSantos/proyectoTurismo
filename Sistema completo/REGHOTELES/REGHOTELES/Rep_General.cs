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
    public partial class Rep_General : Form
    {
        public string nombreCiudad { get; set; }
        public string nombreComercial{ get; set; }
        public Rep_General()
        {
            InitializeComponent();
        }

        private void Rep_General_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'TurismoDataSet10.reporteGeneral' Puede moverla o quitarla según sea necesario.
            this.reporteGeneralTableAdapter.Fill(this.TurismoDataSet10.reporteGeneral,nombreComercial,nombreCiudad);

            this.reportViewer1.RefreshReport();
        }

       
    }
}
