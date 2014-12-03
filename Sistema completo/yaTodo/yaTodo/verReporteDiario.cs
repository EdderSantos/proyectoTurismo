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
    public partial class verReporteDiario : Form
    {
        public verReporteDiario()
        {
            InitializeComponent();
        }

        public DateTime fecha { get; set; }
        public string modulo { get; set; }
        public string ciudad { get; set; }

        private void verReporteDiario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DSreporteDiario.detalles' table. You can move, or remove it, as needed.
            this.detallesTableAdapter.Fill(this.DSreporteDiario.detalles,fecha,modulo,ciudad);
            // TODO: This line of code loads data into the 'DSreporteDiario.totEstar' table. You can move, or remove it, as needed.
            this.totEstarTableAdapter.Fill(this.DSreporteDiario.totEstar,modulo,fecha,ciudad);
            // TODO: This line of code loads data into the 'DSreporteDiario.reportesEstatal' table. You can move, or remove it, as needed.
            this.reportesEstatalTableAdapter.Fill(this.DSreporteDiario.reportesEstatal,modulo,ciudad,fecha);
            // TODO: This line of code loads data into the 'DSreporteDiario.otrosEstatal' table. You can move, or remove it, as needed.
            this.otrosEstatalTableAdapter.Fill(this.DSreporteDiario.otrosEstatal,modulo,fecha,ciudad);
            // TODO: This line of code loads data into the 'DSreporteDiario.totNacional' table. You can move, or remove it, as needed.
            this.totNacionalTableAdapter.Fill(this.DSreporteDiario.totNacional,modulo,fecha,ciudad);
            // TODO: This line of code loads data into the 'DSreporteDiario.reportesNacional' table. You can move, or remove it, as needed.
            this.reportesNacionalTableAdapter.Fill(this.DSreporteDiario.reportesNacional,modulo,ciudad,fecha);
            // TODO: This line of code loads data into the 'DSreporteDiario.otrosNacional' table. You can move, or remove it, as needed.
            this.otrosNacionalTableAdapter.Fill(this.DSreporteDiario.otrosNacional,modulo,fecha,ciudad);
            // TODO: This line of code loads data into the 'DSreporteDiario.totInternacional' table. You can move, or remove it, as needed.
            this.totInternacionalTableAdapter.Fill(this.DSreporteDiario.totInternacional,modulo,fecha,ciudad);
            // TODO: This line of code loads data into the 'DSreporteDiario.reportesInternacional' table. You can move, or remove it, as needed.
            this.reportesInternacionalTableAdapter.Fill(this.DSreporteDiario.reportesInternacional,modulo,ciudad,fecha);
            // TODO: This line of code loads data into the 'DSreporteDiario.otroInternacional' table. You can move, or remove it, as needed.
            this.otroInternacionalTableAdapter.Fill(this.DSreporteDiario.otroInternacional,modulo,fecha,ciudad);
            // TODO: This line of code loads data into the 'DSreporteDiario.totalInternacional' table. You can move, or remove it, as needed.
            this.totalInternacionalTableAdapter.Fill(this.DSreporteDiario.totalInternacional,fecha,modulo,ciudad);
            // TODO: This line of code loads data into the 'DSreporteDiario.totalNacionales' table. You can move, or remove it, as needed.
            this.totalNacionalesTableAdapter.Fill(this.DSreporteDiario.totalNacionales,fecha,modulo,ciudad);
            // TODO: This line of code loads data into the 'DSreporteDiario.promedioEstancia' table. You can move, or remove it, as needed.
            this.promedioEstanciaTableAdapter.Fill(this.DSreporteDiario.promedioEstancia,modulo,ciudad,fecha);
            // TODO: This line of code loads data into the 'DSreporteDiario.diasEstancia' table. You can move, or remove it, as needed.
            this.diasEstanciaTableAdapter.Fill(this.DSreporteDiario.diasEstancia,modulo,ciudad,fecha);
            // TODO: This line of code loads data into the 'DSreporteDiario.cantAtendidos' table. You can move, or remove it, as needed.
            this.cantAtendidosTableAdapter.Fill(this.DSreporteDiario.cantAtendidos,modulo,ciudad,fecha);
            // TODO: This line of code loads data into the 'DSreporteDiario.siHospedaje' table. You can move, or remove it, as needed.
            this.siHospedajeTableAdapter.Fill(this.DSreporteDiario.siHospedaje,modulo,ciudad,fecha);
            // TODO: This line of code loads data into the 'DSreporteDiario.noHospedaje' table. You can move, or remove it, as needed.
            this.noHospedajeTableAdapter.Fill(this.DSreporteDiario.noHospedaje,modulo,ciudad,fecha);
            // TODO: This line of code loads data into the 'DSreporteDiario.cantAdultos' table. You can move, or remove it, as needed.
            this.cantAdultosTableAdapter.Fill(this.DSreporteDiario.cantAdultos,modulo,ciudad,fecha);
            // TODO: This line of code loads data into the 'DSreporteDiario.cantMujeres' table. You can move, or remove it, as needed.
            this.cantMujeresTableAdapter.Fill(this.DSreporteDiario.cantMujeres,modulo,ciudad,fecha);
            // TODO: This line of code loads data into the 'DSreporteDiario.cantHombres' table. You can move, or remove it, as needed.
            this.cantHombresTableAdapter.Fill(this.DSreporteDiario.cantHombres,modulo,ciudad,fecha);
            // TODO: This line of code loads data into the 'DSreporteDiario.cantNinos' table. You can move, or remove it, as needed.
            this.cantNinosTableAdapter.Fill(this.DSreporteDiario.cantNinos,modulo,ciudad,fecha);
            // TODO: This line of code loads data into the 'DSreporteDiario.cantNinos' table. You can move, or remove it, as needed.
            this.totalVisitantesTableAdapter.Fill(this.DSreporteDiario.totalVisitantes, modulo, ciudad, fecha);
            // TODO: This line of code loads data into the 'DSreporteDiario.cantNinos' table. You can move, or remove it, as needed.   
            this.totalEEUUTableAdapter.Fill(this.DSreporteDiario.totalEEUU, ciudad, modulo, fecha);
            // TODO: This line of code loads data into the 'DSreporteDiario.cantNinos' table. You can move, or remove it, as needed.
            this.reporteEuuTableAdapter.Fill(this.DSreporteDiario.reporteEuu,fecha,modulo,ciudad);
            // TODO: This line of code loads data into the 'DSreporteDiario.cantNinos' table. You can move, or remove it, as needed.
            this.reporteOtrosEuuTableAdapter.Fill(this.DSreporteDiario.reporteOtrosEuu,fecha,modulo,ciudad);

            this.reportViewer1.RefreshReport();
        }
    }
}
