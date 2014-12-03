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
    public partial class rep_Localidad : Form
    {
        public string nombreLocalidad{ get; set; }
        public rep_Localidad()
        {
            InitializeComponent();
        }

        private void rep_Localidad_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DtsEstablecimientos.rep_LocalidadEstablecimientos' Puede moverla o quitarla según sea necesario.
            this.rep_LocalidadEstablecimientosTableAdapter.Fill(this.DtsEstablecimientos.rep_LocalidadEstablecimientos,nombreLocalidad);
 this.reportViewer1.RefreshReport();
        }
    }
}
