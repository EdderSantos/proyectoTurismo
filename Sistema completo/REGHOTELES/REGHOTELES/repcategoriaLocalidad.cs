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
    public partial class repcategoriaLocalidad : Form
    {
        public repcategoriaLocalidad()
        {
            InitializeComponent();
        }

        private void repcategoriaLocalidad_Load(object sender, EventArgs e)
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
                cmbCategoria.DataSource = null;
                

                LoadComboCategoriaLoc(nombreLocalidad);
            }
            else
            {
                cmbCategoria.DataSource = null;
              
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
                cmbCategoria.DataSource = null;

                LoadComboLocalidades(nombreCiudad);
            }
            else
            {
                cmbLocalidad.DataSource = null;
                cmbCategoria.DataSource = null;

            }

        }

        private void LoadComboCategoriaLoc(string nombreLocalidad)
        {
            {
                cmbCategoria.DataSource = null;
                cmbCategoria.DataSource = CONEXION.GellCategoriaByLocalidad(nombreLocalidad);
                cmbCategoria.DisplayMember = "categoria";
                cmbCategoria.ValueMember = "categoria";


                if (cmbCategoria.Items.Count != 0)
                {

                    string categoria = Convert.ToString(cmbCategoria.SelectedValue);

                    
                }
                else
                {
                    cmbCategoria.DataSource = null;
               
                    
                }

            }
        }

        private void cmbLocalidad_SelectedIndexChanged(object sender, EventArgs e)
        {

            cmbCategoria.DataSource = null;

            string nombreLocalidad = Convert.ToString(cmbLocalidad.SelectedValue);

            LoadComboCategoriaLoc(nombreLocalidad);
        }

        private void cmbCategoria_Click(object sender, EventArgs e)
        {
            string nombreLocalidad = Convert.ToString(cmbLocalidad.SelectedValue);

            LoadComboCategoriaLoc(nombreLocalidad);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            rep_localidad_categoria mostrar = new rep_localidad_categoria();
            mostrar.nombreLocalidad= Convert.ToString(cmbLocalidad.SelectedValue);
            mostrar.categoria = Convert.ToString(cmbCategoria.SelectedValue);
            mostrar.Show();
   
        }

        private void cmbMunicipio_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombreCiudad = Convert.ToString(cmbMunicipio.SelectedValue);

            LoadComboLocalidades(nombreCiudad);
        }

        private void cmbLocalidad_Click(object sender, EventArgs e)
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
