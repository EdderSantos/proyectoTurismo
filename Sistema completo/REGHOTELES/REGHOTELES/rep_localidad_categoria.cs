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
    public partial class rep_localidad_categoria : Form
    {
        public string nombreLocalidad { get; set; }
        public string nombreComercial { get; set; }
        public string categoria { get; set; }
        public rep_localidad_categoria()
        {
            InitializeComponent();
        }

        private void rep_localidad_categoria_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'proyectoTurismoDataSet3.rep_cat_localidad' table. You can move, or remove it, as needed.
            this.rep_cat_localidadTableAdapter.Fill(this.proyectoTurismoDataSet3.rep_cat_localidad,nombreLocalidad,categoria);
            // TODO: This line of code loads data into the 'proyectoTurismoDataSet3.repCatLoc' table. You can move, or remove it, as needed.
            this.repCatLocTableAdapter.Fill(this.proyectoTurismoDataSet3.repCatLoc,nombreLocalidad,nombreLocalidad,categoria);

            this.reportViewer1.RefreshReport();
        }
    }
}
