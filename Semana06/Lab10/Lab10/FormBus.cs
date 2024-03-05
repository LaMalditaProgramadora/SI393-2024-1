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
    public partial class FormBus : Form
    {
        private BusService busService = new BusService();

        public FormBus()
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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validación de campos
            if (tbMatricula.Text == "" || cbTipo.Text == "" || tbConductor.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // Creación del objeto
            Bus bus = new Bus()
            {
                Matricula = tbMatricula.Text,
                Tipo = cbTipo.Text,
                Conductor = tbConductor.Text,
                Rutas = new List<Ruta>()
            };

            // Registro de bus
            bool registrado = busService.Registrar(bus);
            if (!registrado)
            {
                MessageBox.Show("Ingrese una matrícula diferente");
                return;
            }

            // Mostrar en el ListView
            MostrarBusesEnDataGrid(busService.ListarTodo());
        }

        private void btnVerRutas_Click(object sender, EventArgs e)
        {
            if (dgBuses.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione bus");
                return;
            }

            String matricula = dgBuses.SelectedRows[0].Cells[0].Value.ToString();

            FormRuta formRuta = new FormRuta(matricula);
            formRuta.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            FormReporte formReporte = new FormReporte();
            formReporte.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
