using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace reporteAnio
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
            if (this.dtpFechaDe.Value.CompareTo(this.dtpFechaHasta.Value) == 1)
            {
                MessageBox.Show("La fecha desde no puede ser mayor que hasta", "ERROR... ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                verReporteAnio mostrar = new verReporteAnio();
                mostrar.fechaDe = dtpFechaDe.Value.Date;
                mostrar.fechaHasta = dtpFechaHasta.Value.Date;
                mostrar.modulo = Convert.ToString(cmbModulo.SelectedValue);
                mostrar.ciudad = Convert.ToString(cmbCiudad.SelectedValue);
                mostrar.Show();
            }
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

        private void cmbCiudad_SelectedValueChanged(object sender, EventArgs e)
        {
            string nombreCiudad = Convert.ToString(cmbCiudad.SelectedValue);
            cargarComboModulos(nombreCiudad);
        }

        private void cmbModulo_SelectedValueChanged(object sender, EventArgs e)
        {
            //string nombreCiudad = Convert.ToString(cmbCiudad.SelectedValue);
            //cargarComboModulos(nombreCiudad);
        }

        private void cmbModulo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //string nombreCiudad = Convert.ToString(cmbCiudad.SelectedValue);
            //cargarComboModulos(nombreCiudad);
        }

        

       




    }
}
