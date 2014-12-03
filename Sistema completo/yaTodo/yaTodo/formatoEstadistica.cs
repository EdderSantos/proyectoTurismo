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
    public partial class formatoEstadistica : Form
    {
        public formatoEstadistica()
        {
            InitializeComponent();
        }
        public DateTime fecha { get; set; }
        public string modulo { get; set; }
        public string ciudad { get; set; }

        private void formatoEstadistica_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DSreporteDiario.formatoEstadisticaDiaria' table. You can move, or remove it, as needed.
            this.formatoEstadisticaDiariaTableAdapter.Fill(this.DSreporteDiario.formatoEstadisticaDiaria,fecha,modulo,ciudad);
            // TODO: This line of code loads data into the 'DSreporteDiario.formatoEstadisticaDiaria' table. You can move, or remove it, as needed.
            this.detalles1TableAdapter.Fill(this.DSreporteDiario.detalles1, fecha, modulo, ciudad);

            this.reportViewer1.RefreshReport();
        }
    }
}
