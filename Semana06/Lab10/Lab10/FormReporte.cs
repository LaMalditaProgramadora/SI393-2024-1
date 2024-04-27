using Lab10.entities;
using Lab10.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab10
{
    public partial class FormReporte : Form
    {
        private BusService busService = new BusService();
        private RutaService rutaService = new RutaService();

        public FormReporte()
        {
            InitializeComponent();
        }

        private void MostrarBuses(List<Bus> buses)
        {
            dgBuses.DataSource = null;

            if (buses.Count == 0)
            {
                return;
            }
            else
            {
                dgBuses.DataSource = buses;
            }
        }

        private void MostrarRutas(List<Ruta> rutas)
        {
            dgRutas.DataSource = null;
            if (rutas.Count == 0)
            {
                return;
            }
            else
            {
                dgRutas.DataSource = rutas;
            }
        }

        private void btnBuscarBusesConRutasMasLargas_Click(object sender, EventArgs e)
        {
            MostrarBuses(busService.ListarBusesConRutasMasLargas());
        }

        private void btnBuscarBusesConMenosRutas_Click(object sender, EventArgs e)
        {
            MostrarBuses(busService.ListarBusesConMenosRutas());
        }

        private void btnBuscarRutasPorConductorBus_Click(object sender, EventArgs e)
        {
            // Validación de campos
            if (tbConductor.Text == "")
            {
                MessageBox.Show("Ingrese conductor");
                return;
            }

            String conductor = tbConductor.Text;
            MostrarRutas(rutaService.ListarRutasPorConductorBus(conductor));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
