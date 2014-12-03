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
    public partial class reportemunicipio : Form
    {
        public reportemunicipio()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Rep_Municipio mostrar = new Rep_Municipio();
            mostrar.nombreCiudad = Convert.ToString(cmbBuscar.SelectedValue);
           mostrar.Show();
      

        }

      

        private void reportemunicipio_Load(object sender, EventArgs e)
        {
            LoadComboCiudad();
        }


        private void LoadComboCiudad()
        {
            cmbBuscar.DataSource = CONEXION.GellAllCiudad();
            cmbBuscar.DisplayMember = "nombreCiudad";
            cmbBuscar.ValueMember = "nombreCiudad";

                string nombreCiudad = Convert.ToString(cmbBuscar.SelectedValue);

        }

        private void cmbBuscar_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

       
    }
}
