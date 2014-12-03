using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace yaTodo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarComboCiudad();
        }

        private void btnVerReporte_Click(object sender, EventArgs e)
        {
            verReporteDiario mostrar = new verReporteDiario();
            mostrar.fecha = dateTimePicker1.Value.Date;
            mostrar.modulo = cmbModulo.Text;
            mostrar.ciudad = cmbCiudad.Text;
            mostrar.Show();
        }

        private void cargarComboCiudad()
        {
            cmbCiudad.DataSource = rellenarCombos.GellAllCiudades();
            cmbCiudad.DisplayMember = "nombreCiudad";
            cmbCiudad.ValueMember = "nombreCiudad";

            if (cmbCiudad.Items.Count != 0)
            {
                string nombreCiudad = Convert.ToString(cmbCiudad.SelectedValue);

                cargarComboModulos(nombreCiudad);
            }
            else
            {
                 cmbModulo.DataSource = null;
                //cbTrack.DataSource = null;
                //dgvCustomer.DataSource = null;
            }

        }

        private void cargarComboModulos(string nombreCiudad)
        {
            cmbModulo.DataSource = rellenarCombos.GellModulos(nombreCiudad);
            cmbModulo.DisplayMember = "nombreModulo";
            cmbModulo.ValueMember = "nombreModulo";


            //if (cmbCiudad.Items.Count != 0)
            //{
            //    int idCiudad = Convert.ToInt32(cmbCiudad.SelectedValue);

            //    LoadComboTrack(AlbumId);
            //}
            //else
            //{
            //    cbTrack.DataSource = null;
            //    dgvCustomer.DataSource = null;
            //}

        }

        private void cmbModulo_SelectedValueChanged(object sender, EventArgs e)
        {
            //string nombreCiudad = Convert.ToString(cmbCiudad.SelectedValue);
            //cargarComboModulos(nombreCiudad);
        }

        private void cmbCiudad_SelectedValueChanged(object sender, EventArgs e)
        {
            string nombreCiudad = Convert.ToString(cmbCiudad.SelectedValue);
            cargarComboModulos(nombreCiudad);
        }

        private void cmbModulo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //string nombreCiudad = Convert.ToString(cmbCiudad.SelectedValue);
            //cargarComboModulos(nombreCiudad);
        }

        private void btnFormato_Click(object sender, EventArgs e)
        {
            formatoEstadistica mostrar = new formatoEstadistica();
            mostrar.fecha = dateTimePicker1.Value.Date;
            mostrar.modulo = cmbModulo.Text;
            mostrar.ciudad = cmbCiudad.Text;
            mostrar.Show();
        }


        
    }
}
