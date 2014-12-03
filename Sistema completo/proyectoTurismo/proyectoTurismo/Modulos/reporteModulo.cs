using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace proyectoTurismo.Modulos
{
    public partial class reporteModulo : Form
    {
        public reporteModulo()
        {
            InitializeComponent();
        }

        private void reporteModulo_Load(object sender, EventArgs e)
        {
            LoadComboCiudadModulo();
        }

        private void LoadComboCiudadModulo()
        {
            cmbCiudad.DataSource = rellenarCombosRegModulo.GellAllciudadModulo();
            cmbCiudad.DisplayMember = "nombreCiudad";
            cmbCiudad.ValueMember = "nombreCiudad";
        }

        private void btnVerReporte_Click(object sender, EventArgs e)
        {
            verReporteMod mostrar = new verReporteMod();
            mostrar.ciudad = cmbCiudad.Text;
            mostrar.Show();
        }

       
    }
}
