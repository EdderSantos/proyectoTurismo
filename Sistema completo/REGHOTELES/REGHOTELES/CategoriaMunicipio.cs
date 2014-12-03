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
    public partial class CategoriaMunicipio : Form
    {
        public CategoriaMunicipio()
        {
            InitializeComponent();
        }

        private void CategoriaMunicipio_Load(object sender, EventArgs e)
        {
            
            LoadComboCiudad();
       
        }

        private void LoadComboCiudad()
        {
            cmbLocalidad.DataSource = CONEXION.GellAllCiudad();
            cmbLocalidad.DisplayMember = "nombreCiudad";
            cmbLocalidad.ValueMember = "nombreCiudad";

            string nombreCiudad = Convert.ToString(cmbLocalidad.SelectedValue);

        }
        private void LoadComboCategoria(string nombreCiudad)
        {
            {
              cmbCategoria.DataSource = CONEXION.GellCategoriaByCiudad (nombreCiudad);
               cmbCategoria.DisplayMember = "categoria";
              cmbCategoria.ValueMember = "categoria";


                if (cmbCategoria.Items.Count != 0)
                {
                    string categoria = Convert.ToString(cmbCategoria.SelectedValue);

                    // LoadComboCiudad(nombreCiudad);
                }
                else
                {
                    //cbTrack.DataSource = null;
                    //dgvCustomer.DataSource = null;
                }

            }
        }

        private void cmbBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombreCiudad = Convert.ToString(cmbLocalidad.SelectedValue);

            LoadComboCategoria(nombreCiudad);
        }

        private void cmbCategoria_Click(object sender, EventArgs e)
        {
            string nombreCiudad = Convert.ToString(cmbLocalidad.SelectedValue);

            LoadComboCategoria(nombreCiudad);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ReporteCategoriacs mostrar = new ReporteCategoriacs();
            mostrar.nombreCiudad = Convert.ToString(cmbLocalidad.SelectedValue);
            mostrar.categoria = Convert.ToString(cmbCategoria.SelectedValue);
            mostrar.Show();
       
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
