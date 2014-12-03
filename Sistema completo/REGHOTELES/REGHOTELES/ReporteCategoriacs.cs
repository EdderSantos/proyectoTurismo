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
    
    public partial class ReporteCategoriacs : Form
    {

        public string nombreCiudad { get; set; }
        public string nombreComercial { get; set; }
        public string categoria { get; set; }
        public ReporteCategoriacs()
        {
            InitializeComponent();
        }

        private void ReporteCategoriacs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'proyectoTurismoDataSet2.repCatMun' table. You can move, or remove it, as needed.
            this.repCatMunTableAdapter.Fill(this.proyectoTurismoDataSet2.repCatMun,nombreComercial,nombreCiudad,categoria);
            // TODO: This line of code loads data into the 'proyectoTurismoDataSet2.reporteCategoria' table. You can move, or remove it, as needed.
            this.reporteCategoriaTableAdapter.Fill(this.proyectoTurismoDataSet2.reporteCategoria,nombreCiudad,categoria);
       
            this.reportViewer1.RefreshReport();
        }
    }
}
