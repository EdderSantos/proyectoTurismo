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
    public partial class reporteLocalidad : Form
    {
        public reporteLocalidad()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            rep_Localidad mostrar = new rep_Localidad();
            mostrar.nombreLocalidad = Convert.ToString(cmbLocalidad.SelectedValue);
            mostrar.Show();
            this.Hide();
        }

        private void reporteLocalidad_Load(object sender, EventArgs e)
        {
            
        }

       
        public string nombreCiudad { get; set; }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            rep_Localidad mostrar = new rep_Localidad();
            mostrar.nombreLocalidad =cmbLocalidad.Text;
            mostrar.Show();
         
        }

        private void reporteLocalidad_Load_1(object sender, EventArgs e)
        {

            LoadComboCiudad();
        }
        private void LoadComboLocalidades(string nombreCiudad)
        {
            cmbLocalidad.DataSource = CONEXION.GellLocalidadByCiudad(nombreCiudad);
            cmbLocalidad.DisplayMember = "nombreLocalidad";
            cmbLocalidad.ValueMember = "nombreLocalidad";


            if (cmbLocalidad.Items.Count != 0)
            {
                string nombreLocalidad = Convert.ToString(cmbLocalidad.SelectedValue);
                


               
            }
            else
            {
               

            }

        }

        private void LoadComboCiudad()
        {
            cmbMunicipio.DataSource = CONEXION.GellAllCiudad();
            cmbMunicipio.DisplayMember = "nombreCiudad";
            cmbMunicipio.ValueMember = "nombreCiudad";


            if (cmbMunicipio.Items.Count != 0)
            {
                string nombreCiudad = Convert.ToString(cmbMunicipio.SelectedValue);

                cmbLocalidad.DataSource = null;
               

                LoadComboLocalidades(nombreCiudad);
            }
            else
            {
                cmbLocalidad.DataSource = null;
                

            }

        }

        private void cmbLocalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombreLocalidad = Convert.ToString(cmbLocalidad.SelectedValue);
        }

        private void cmbMunicipio_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombreCiudad = Convert.ToString(cmbMunicipio.SelectedValue);

            LoadComboLocalidades(nombreCiudad);
        }

        private void cmbMunicipio_Click(object sender, EventArgs e)
        {
            LoadComboCiudad();
        }
        
    }
}
