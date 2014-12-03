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
    public partial class rep_Muni : Form
    {
        public rep_Muni()
        {
            InitializeComponent();
        }

        private void rep_Muni_Load(object sender, EventArgs e)
        {
            LoadComboCiudad();
        }
        private void LoadComboCiudad()
        {
            cmbBuscar.DataSource = regEstablecimientoss.CONEXION.GellAllCiudad();
            cmbBuscar.DisplayMember = "nombreCiudad";
            cmbBuscar.ValueMember = "nombreCiudad";

            string nombreCiudad = Convert.ToString(cmbBuscar.SelectedValue);

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            rep_Municipio mostrar = new rep_Municipio();
            mostrar.nombreMunicipio = Convert.ToString(cmbBuscar.SelectedValue);
            mostrar.Show();
    
        }
    }
}
