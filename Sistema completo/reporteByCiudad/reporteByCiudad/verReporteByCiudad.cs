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
    public partial class verReporteByCiudad : Form
    {
        public verReporteByCiudad()
        {
            InitializeComponent();
        }

        public DateTime fechaDe { get; set; }
        public DateTime fechaHasta { get; set; }
        public string ciudad { get; set; }

        private void verReporteByCiudad_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DSByCiudad.detallesByCiudad' table. You can move, or remove it, as needed.
            this.detallesByCiudadTableAdapter.Fill(this.DSByCiudad.detallesByCiudad,ciudad,fechaDe,fechaHasta);
            // TODO: This line of code loads data into the 'DSByCiudad.totEstatalByCiudad' table. You can move, or remove it, as needed.
            this.totEstatalByCiudadTableAdapter.Fill(this.DSByCiudad.totEstatalByCiudad, ciudad, fechaDe, fechaHasta);
            // TODO: This line of code loads data into the 'DSByCiudad.reporteEstatalByCiudad' table. You can move, or remove it, as needed.
            this.reporteEstatalByCiudadTableAdapter.Fill(this.DSByCiudad.reporteEstatalByCiudad, ciudad, fechaDe, fechaHasta);
            // TODO: This line of code loads data into the 'DSByCiudad.otrosEstatalByCiudad' table. You can move, or remove it, as needed.
            this.otrosEstatalByCiudadTableAdapter.Fill(this.DSByCiudad.otrosEstatalByCiudad, ciudad, fechaDe, fechaHasta);
            // TODO: This line of code loads data into the 'DSByCiudad.totNacionalByCiudad' table. You can move, or remove it, as needed.
            this.totNacionalByCiudadTableAdapter.Fill(this.DSByCiudad.totNacionalByCiudad, ciudad, fechaDe, fechaHasta);
            // TODO: This line of code loads data into the 'DSByCiudad.reporteNacionalByCiudad' table. You can move, or remove it, as needed.
            this.reporteNacionalByCiudadTableAdapter.Fill(this.DSByCiudad.reporteNacionalByCiudad, ciudad, fechaDe, fechaHasta);
            // TODO: This line of code loads data into the 'DSByCiudad.otrosNacionalByCiudad' table. You can move, or remove it, as needed.
            this.otrosNacionalByCiudadTableAdapter.Fill(this.DSByCiudad.otrosNacionalByCiudad, ciudad, fechaDe, fechaHasta);
            // TODO: This line of code loads data into the 'DSByCiudad.totInternacionalByCiudad' table. You can move, or remove it, as needed.
            this.totInternacionalByCiudadTableAdapter.Fill(this.DSByCiudad.totInternacionalByCiudad, ciudad, fechaDe, fechaHasta);
            // TODO: This line of code loads data into the 'DSByCiudad.reporteInternacionalByCiudad' table. You can move, or remove it, as needed.
            this.reporteInternacionalByCiudadTableAdapter.Fill(this.DSByCiudad.reporteInternacionalByCiudad, ciudad, fechaDe, fechaHasta);
            // TODO: This line of code loads data into the 'DSByCiudad.otrosInternacionalByCiudad' table. You can move, or remove it, as needed.
            this.otrosInternacionalByCiudadTableAdapter.Fill(this.DSByCiudad.otrosInternacionalByCiudad, ciudad, fechaDe, fechaHasta);
            // TODO: This line of code loads data into the 'DSByCiudad.totalVisitantesByCiudad' table. You can move, or remove it, as needed.
            this.totalVisitantesByCiudadTableAdapter.Fill(this.DSByCiudad.totalVisitantesByCiudad, ciudad, fechaDe, fechaHasta);
            // TODO: This line of code loads data into the 'DSByCiudad.cantidadAtendidosByCiudad' table. You can move, or remove it, as needed.
            this.cantidadAtendidosByCiudadTableAdapter.Fill(this.DSByCiudad.cantidadAtendidosByCiudad, ciudad, fechaDe, fechaHasta);
            // TODO: This line of code loads data into the 'DSByCiudad.totalInternacionalByCiudad' table. You can move, or remove it, as needed.
            this.totalInternacionalByCiudadTableAdapter.Fill(this.DSByCiudad.totalInternacionalByCiudad, ciudad, fechaDe, fechaHasta);
            // TODO: This line of code loads data into the 'DSByCiudad.totalNacionalByCiudad' table. You can move, or remove it, as needed.
            this.totalNacionalByCiudadTableAdapter.Fill(this.DSByCiudad.totalNacionalByCiudad, ciudad, fechaDe, fechaHasta);
            // TODO: This line of code loads data into the 'DSByCiudad.totalEEUUByCiudad' table. You can move, or remove it, as needed.
            this.totalEEUUByCiudadTableAdapter.Fill(this.DSByCiudad.totalEEUUByCiudad, ciudad, fechaDe, fechaHasta);
            // TODO: This line of code loads data into the 'DSByCiudad.reporteEEUUByCiudad' table. You can move, or remove it, as needed.
            this.reporteEEUUByCiudadTableAdapter.Fill(this.DSByCiudad.reporteEEUUByCiudad, ciudad, fechaDe, fechaHasta);
            // TODO: This line of code loads data into the 'DSByCiudad.reporteOtrosEEUUByCiudad' table. You can move, or remove it, as needed.
            this.reporteOtrosEEUUByCiudadTableAdapter.Fill(this.DSByCiudad.reporteOtrosEEUUByCiudad, ciudad, fechaDe, fechaHasta);
            // TODO: This line of code loads data into the 'DSByCiudad.promedioEstanciaAnioByCiudad' table. You can move, or remove it, as needed.
            this.promedioEstanciaAnioByCiudadTableAdapter.Fill(this.DSByCiudad.promedioEstanciaAnioByCiudad, ciudad, fechaDe, fechaHasta);
            // TODO: This line of code loads data into the 'DSByCiudad.diasEstanciaByCiudad' table. You can move, or remove it, as needed.
            this.diasEstanciaByCiudadTableAdapter.Fill(this.DSByCiudad.diasEstanciaByCiudad, ciudad, fechaDe, fechaHasta);
            // TODO: This line of code loads data into the 'DSByCiudad.siHospedanByCiudad' table. You can move, or remove it, as needed.
            this.siHospedanByCiudadTableAdapter.Fill(this.DSByCiudad.siHospedanByCiudad, ciudad, fechaDe, fechaHasta);
            // TODO: This line of code loads data into the 'DSByCiudad.noHospedajeByCiudad' table. You can move, or remove it, as needed.
            this.noHospedajeByCiudadTableAdapter.Fill(this.DSByCiudad.noHospedajeByCiudad, ciudad, fechaDe, fechaHasta);
            // TODO: This line of code loads data into the 'DSByCiudad.cantidadAdultosByCiudad' table. You can move, or remove it, as needed.
            this.cantidadAdultosByCiudadTableAdapter.Fill(this.DSByCiudad.cantidadAdultosByCiudad, ciudad, fechaDe, fechaHasta);
            // TODO: This line of code loads data into the 'DSByCiudad.cantidadNinosByCiudad' table. You can move, or remove it, as needed.
            this.cantidadNinosByCiudadTableAdapter.Fill(this.DSByCiudad.cantidadNinosByCiudad, ciudad, fechaDe, fechaHasta);
            // TODO: This line of code loads data into the 'DSByCiudad.cantidadMujeresByCiudad' table. You can move, or remove it, as needed.
            this.cantidadMujeresByCiudadTableAdapter.Fill(this.DSByCiudad.cantidadMujeresByCiudad, ciudad, fechaDe, fechaHasta);
            // TODO: This line of code loads data into the 'DSByCiudad.cantidadHombresByCiudad' table. You can move, or remove it, as needed.
            this.cantidadHombresByCiudadTableAdapter.Fill(this.DSByCiudad.cantidadHombresByCiudad, ciudad, fechaDe, fechaHasta);

            this.reportViewer1.RefreshReport();
        }
    }
}
