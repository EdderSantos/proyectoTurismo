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
    public partial class rep_Loc : Form
    {
        public rep_Loc()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            rep_Localidad mostrar = new rep_Localidad();
            mostrar.nombreLocalidad = cmbLocalidad.Text;
            mostrar.Show();
       
        }
  
        private void rep_Loc_Load(object sender, EventArgs e)
        {
            LoadComboCiudad();
        }

        private void LoadComboCiudad()
        {
            cmbMunicipio.DataSource = cargarCombos.GellAllCiudad();
            cmbMunicipio.DisplayMember = "nombreCiudad";
            cmbMunicipio.ValueMember = "nombreCiudad";


            if (cmbMunicipio.Items.Count != 0)
            {
                string nombreCiudad = Convert.ToString(cmbMunicipio.SelectedValue);

                LoadComboLocalidades(nombreCiudad);
            }
            else
            {
                //cmbLocalidad.DataSource = null;

            }

        }
        private void LoadComboLocalidades(string nombreCiudad)
        {

            cmbLocalidad.DataSource = cargarCombos.GellLocalidadByCiudad(nombreCiudad);
            cmbLocalidad.DisplayMember = "nombreLocalidad";
            cmbLocalidad.ValueMember = "nombreLocalidad";


            if (cmbLocalidad.Items.Count != 0)
            {
                string nombreLocalidad = Convert.ToString(cmbLocalidad.SelectedValue);

                // LoadComboCiudad(nombreCiudad);
            }
            else
            {
                //cbTrack.DataSource = null;
                //dgvCustomer.DataSource = null;
            }


        }

        private void cmbLocalidad_SelectedValueChanged(object sender, EventArgs e)
        {

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

        private void cmbLocalidad_Click(object sender, EventArgs e)
        {
            string nombreCiudad = Convert.ToString(cmbMunicipio.SelectedValue);

            LoadComboLocalidades(nombreCiudad);
        }
    }
}
