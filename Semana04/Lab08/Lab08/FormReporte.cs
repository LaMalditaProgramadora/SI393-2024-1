using Lab08.entities;
using Lab08.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab08
{
    public partial class FormReporte : Form
    {
        private AgenciaService agenciaService = new AgenciaService();
        private InmuebleService inmuebleService = new InmuebleService();

        public FormReporte()
        {
            InitializeComponent();
        }


        private void MostrarAgencias(List<Agencia> agencias)
        {
            dgAgencias.DataSource = null;
            if (agencias.Count == 0)
            {
                return;
            }
            dgAgencias.DataSource = agencias;
        }

        private void MostrarInmuebles(List<Inmueble> inmuebles)
        {
            dgInmuebles.DataSource = null;
            if (inmuebles.Count == 0)
            {
                lblMontoTotalAlquilerInmuebles.Text = "0";
                return;
            }
            dgInmuebles.DataSource = inmuebles;
        }

        private void btnAgenciasAlquilerInmueblesMayorSuperficie_Click(object sender, EventArgs e)
        {
            MostrarAgencias(agenciaService.ListarMayorSuperficieInmueblesAlquiler());
        }

        private void btnAgenciasMayorCantidadInmueblesVenta_Click(object sender, EventArgs e)
        {
            MostrarAgencias(agenciaService.ListarMayorCantidadInmueblesVenta());
        }

        private void btnBuscarVenta_Click(object sender, EventArgs e)
        {
            // Validación de campos
            if (tbBuscar.Text == "")
            {
                MessageBox.Show("Ingrese código de agencia");
                return;
            }
            String codigoAgencia = tbBuscar.Text;

            MostrarInmuebles(inmuebleService.ListarPorAgenciaVenta(codigoAgencia));
        }

        private void btnBuscarAlquiler_Click(object sender, EventArgs e)
        {
            // Validación de campos
            if (tbBuscar.Text == "")
            {
                MessageBox.Show("Ingrese código de agencia");
                return;
            }
            String codigoAgencia = tbBuscar.Text;

            MostrarInmuebles(inmuebleService.ListarPorAgenciaAlquiler(codigoAgencia));


            // Hallar el monto de los inmuebles alquilados
            lblMontoTotalAlquilerInmuebles.Text = inmuebleService.ListarPorAgenciaAlquiler(codigoAgencia).Sum(i => i.Precio).ToString();
        }
    }
}
