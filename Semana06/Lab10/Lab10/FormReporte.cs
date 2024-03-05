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

        private void MostrarBusesEnDataGrid(List<Bus> buses)
        {
            if (buses.Count == 0)
            {
                dgBuses.DataSource = null;
                return;
            }
            dgBuses.DataSource = null;
            dgBuses.DataSource = buses;
        }

        private void MostrarRutasEnDataGrid(List<Ruta> rutas)
        {
            if (rutas.Count == 0)
            {
                dgRutas.DataSource = null;
                return;
            }
            dgRutas.DataSource = null;
            dgRutas.DataSource = rutas;
        }

        private void btnBuscarBusesConRutasMasLargas_Click(object sender, EventArgs e)
        {
            MostrarBusesEnDataGrid(busService.ListarBusesConRutasMasLargas());
        }

        private void btnBuscarBusesConMenosRutas_Click(object sender, EventArgs e)
        {
            MostrarBusesEnDataGrid(busService.ListarBusesConMenosRutas());
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
            MostrarRutasEnDataGrid(rutaService.ListarRutasPorConductorBus(conductor));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
