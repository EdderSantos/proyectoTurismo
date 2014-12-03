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
    public partial class verReporteAnio : Form
    {
        public verReporteAnio()
        {
            InitializeComponent();
        }


        public DateTime fechaDe { get; set; }
        public DateTime fechaHasta { get; set; }
        public string modulo { get; set; }
        public string ciudad { get; set; }

        private void verReporteAnio_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DSreporteAnio.detallesAnio' table. You can move, or remove it, as needed.
            this.detallesAnioTableAdapter.Fill(this.DSreporteAnio.detallesAnio,ciudad,modulo,fechaDe,fechaHasta);
            // TODO: This line of code loads data into the 'DSreporteAnio.totalVisitantesAnio' table. You can move, or remove it, as needed.
            this.totalVisitantesAnioTableAdapter.Fill(this.DSreporteAnio.totalVisitantesAnio,ciudad,modulo,fechaDe,fechaHasta);
            // TODO: This line of code loads data into the 'DSreporteAnio.cantidadAtendidosAnio' table. You can move, or remove it, as needed.
            this.cantidadAtendidosAnioTableAdapter.Fill(this.DSreporteAnio.cantidadAtendidosAnio,ciudad,modulo,fechaDe,fechaHasta);
            // TODO: This line of code loads data into the 'DSreporteAnio.totEstatalAnio' table. You can move, or remove it, as needed.
            this.totEstatalAnioTableAdapter.Fill(this.DSreporteAnio.totEstatalAnio,ciudad,modulo,fechaDe,fechaHasta);
            // TODO: This line of code loads data into the 'DSreporteAnio.reporteEstatalAnio' table. You can move, or remove it, as needed.
            this.reporteEstatalAnioTableAdapter.Fill(this.DSreporteAnio.reporteEstatalAnio,ciudad,modulo,fechaDe,fechaHasta);
            // TODO: This line of code loads data into the 'DSreporteAnio.otrosEstatalAnio' table. You can move, or remove it, as needed.
            this.otrosEstatalAnioTableAdapter.Fill(this.DSreporteAnio.otrosEstatalAnio,ciudad,modulo,fechaDe,fechaHasta);
            // TODO: This line of code loads data into the 'DSreporteAnio.totNacionalAnio' table. You can move, or remove it, as needed.
            this.totNacionalAnioTableAdapter.Fill(this.DSreporteAnio.totNacionalAnio,ciudad,modulo,fechaDe,fechaHasta);
            // TODO: This line of code loads data into the 'DSreporteAnio.reporteNacionalAnio' table. You can move, or remove it, as needed.
            this.reporteNacionalAnioTableAdapter.Fill(this.DSreporteAnio.reporteNacionalAnio,ciudad,modulo,fechaDe,fechaHasta);
            // TODO: This line of code loads data into the 'DSreporteAnio.otrosNacionalAnio' table. You can move, or remove it, as needed.
            this.otrosNacionalAnioTableAdapter.Fill(this.DSreporteAnio.otrosNacionalAnio,ciudad,modulo,fechaDe,fechaHasta);
            // TODO: This line of code loads data into the 'DSreporteAnio.totInternacionalAnio' table. You can move, or remove it, as needed.
            this.totInternacionalAnioTableAdapter.Fill(this.DSreporteAnio.totInternacionalAnio,ciudad,modulo,fechaDe,fechaHasta);
            // TODO: This line of code loads data into the 'DSreporteAnio.reporteInternacionalAnio' table. You can move, or remove it, as needed.
            this.reporteInternacionalAnioTableAdapter.Fill(this.DSreporteAnio.reporteInternacionalAnio,ciudad,modulo,fechaDe,fechaHasta);
            // TODO: This line of code loads data into the 'DSreporteAnio.otrosInternacionalAnio' table. You can move, or remove it, as needed.
            this.otrosInternacionalAnioTableAdapter.Fill(this.DSreporteAnio.otrosInternacionalAnio,ciudad,modulo,fechaDe,fechaHasta);
            // TODO: This line of code loads data into the 'DSreporteAnio.totalNacionalAnio' table. You can move, or remove it, as needed.
            this.totalNacionalAnioTableAdapter.Fill(this.DSreporteAnio.totalNacionalAnio,ciudad,modulo,fechaDe,fechaHasta);
            // TODO: This line of code loads data into the 'DSreporteAnio.totalInternacionalAnio' table. You can move, or remove it, as needed.
            this.totalInternacionalAnioTableAdapter.Fill(this.DSreporteAnio.totalInternacionalAnio,ciudad,modulo,fechaDe,fechaHasta);
            // TODO: This line of code loads data into the 'DSreporteAnio.totalEEUUAnio' table. You can move, or remove it, as needed.
            this.totalEEUUAnioTableAdapter.Fill(this.DSreporteAnio.totalEEUUAnio,ciudad,modulo,fechaDe,fechaHasta);
            // TODO: This line of code loads data into the 'DSreporteAnio.reporteEEUUAnio' table. You can move, or remove it, as needed.
            this.reporteEEUUAnioTableAdapter.Fill(this.DSreporteAnio.reporteEEUUAnio,ciudad,modulo,fechaDe,fechaHasta);
            // TODO: This line of code loads data into the 'DSreporteAnio.reporteOtrosEEUUAnio' table. You can move, or remove it, as needed.
            this.reporteOtrosEEUUAnioTableAdapter.Fill(this.DSreporteAnio.reporteOtrosEEUUAnio,ciudad,modulo,fechaDe,fechaHasta);
            // TODO: This line of code loads data into the 'DSreporteAnio.promedioEstanciaAnio' table. You can move, or remove it, as needed.
            this.promedioEstanciaAnioTableAdapter.Fill(this.DSreporteAnio.promedioEstanciaAnio,ciudad,modulo,fechaDe,fechaHasta);
            // TODO: This line of code loads data into the 'DSreporteAnio.diasEstanciaAnio' table. You can move, or remove it, as needed.
            this.diasEstanciaAnioTableAdapter.Fill(this.DSreporteAnio.diasEstanciaAnio,ciudad,modulo,fechaDe,fechaHasta);
            // TODO: This line of code loads data into the 'DSreporteAnio.siHospedanAnio' table. You can move, or remove it, as needed.
            this.siHospedanAnioTableAdapter.Fill(this.DSreporteAnio.siHospedanAnio,ciudad,modulo,fechaDe,fechaHasta);
            // TODO: This line of code loads data into the 'DSreporteAnio.noHospedajeAnio' table. You can move, or remove it, as needed.
            this.noHospedajeAnioTableAdapter.Fill(this.DSreporteAnio.noHospedajeAnio,ciudad,modulo,fechaDe,fechaHasta);
            // TODO: This line of code loads data into the 'DSreporteAnio.cantidadAdultosAnio' table. You can move, or remove it, as needed.
            this.cantidadAdultosAnioTableAdapter.Fill(this.DSreporteAnio.cantidadAdultosAnio,ciudad,modulo,fechaDe,fechaHasta);
            // TODO: This line of code loads data into the 'DSreporteAnio.cantidadHombresAnio' table. You can move, or remove it, as needed.
            this.cantidadHombresAnioTableAdapter.Fill(this.DSreporteAnio.cantidadHombresAnio,ciudad,modulo,fechaDe,fechaHasta);
            // TODO: This line of code loads data into the 'DSreporteAnio.cantidadMujeresAnio' table. You can move, or remove it, as needed.
            this.cantidadMujeresAnioTableAdapter.Fill(this.DSreporteAnio.cantidadMujeresAnio,ciudad,modulo,fechaDe,fechaHasta);
            // TODO: This line of code loads data into the 'DSreporteAnio.cantidadNinosAnio' table. You can move, or remove it, as needed.
            this.cantidadNinosAnioTableAdapter.Fill(this.DSreporteAnio.cantidadNinosAnio,ciudad,modulo,fechaDe,fechaHasta);

            this.reportViewer1.RefreshReport();
        }
    }
}
