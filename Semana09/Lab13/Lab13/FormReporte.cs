using Lab13.entities;
using Lab13.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab13
{
    public partial class FormReporte : Form
    {
        private ReporteCantidadService reporteCantidadService = new ReporteCantidadService();
        private ReporteMontoService reporteMontoService = new ReporteMontoService();
        private PaseoService paseoService = new PaseoService();

        public FormReporte()
        {
            InitializeComponent();
        }

        private void MostrarReportesCantidad(List<ReporteCantidad> reportesCantidad)
        {
            dgReportesCantidad.DataSource = null;
            if (reportesCantidad.Count == 0)
            {
                return;
            }
            else
            {
                dgReportesCantidad.DataSource = reportesCantidad;
            }
        }

        private void MostrarReportesMonto(List<ReporteMonto> reportesMonto)
        {
            dgReportesMonto.DataSource = null;
            if (reportesMonto.Count == 0)
            {
                return;
            }
            else
            {
                dgReportesMonto.DataSource = reportesMonto;
            }
        }

        private void btnObtenerCantidadPaseosPorObjetivo_Click(object sender, EventArgs e)
        {
            MostrarReportesCantidad(reporteCantidadService.ListarCantidadPorObjetivoPaseo());
        }

        private void btnObtenerMontoPorTamañoPerros_Click(object sender, EventArgs e)
        {
            MostrarReportesMonto(reporteMontoService.ListarMontoPorTamañoPerros());
        }

        private void btnObtenerMontoPorPaseadorYFecha_Click(object sender, EventArgs e)
        {
            if (tbDNI.Text == "" || dtpFecha.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            String DNI = tbDNI.Text;
            DateTime fecha = dtpFecha.Value.Date;

            double monto = paseoService.ObtenerMontoPorPaseadorYFecha(DNI, fecha);
            lblMonto.Text = monto.ToString();
        }

        private void btnObtenerCantidadPaseosPorPaseadorYTamañoGrande_Click(object sender, EventArgs e)
        {
            if (tbDNI.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            String DNI = tbDNI.Text;

            int cantidad = paseoService.ObtenerCantidadPaseosPorPaseadorYTamañoGrande(DNI);
            lblCantidad.Text = cantidad.ToString();
        }
    }
}
