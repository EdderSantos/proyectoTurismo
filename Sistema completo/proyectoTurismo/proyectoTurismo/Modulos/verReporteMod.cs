using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace proyectoTurismo.Modulos
{
    public partial class verReporteMod : Form
    {
        public verReporteMod()
        {
            InitializeComponent();
        }

        public string ciudad { get; set; }

        private void verReporteMod_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DSmodulos.modulos' table. You can move, or remove it, as needed.
            this.modulosTableAdapter.Fill(this.DSmodulos.modulos,ciudad);

            this.reportViewer1.RefreshReport();
        }
    }
}
