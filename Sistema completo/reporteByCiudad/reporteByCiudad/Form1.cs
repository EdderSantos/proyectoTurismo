using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace reporteByCiudad
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
                verReporteByCiudad mostrar = new verReporteByCiudad();
                mostrar.fechaDe = dtpFechaDe.Value.Date;
                mostrar.fechaHasta = dtpFechaHasta.Value.Date;
                mostrar.ciudad = Convert.ToString(cmbCiudad.SelectedValue);
                mostrar.Show();
            }
        }


        private void cargarComboCiudad()
        {
            cmbCiudad.DataSource = rellenarCombo.GellAllCiudades();
            cmbCiudad.DisplayMember = "nombreCiudad";
            cmbCiudad.ValueMember = "nombreCiudad";

            //if (cmbCiudad.Items.Count != 0)
            //{
            //    string nombreCiudad = Convert.ToString(cmbCiudad.SelectedValue);

            //    cargarComboModulos(nombreCiudad);
            //}
            //else
            //{
            //    cmbModulo.DataSource = null;
            //    //cbTrack.DataSource = null;
            //    //dgvCustomer.DataSource = null;
            //}

        }

    

       

        

    }
}
