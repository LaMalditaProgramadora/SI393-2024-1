using Lab08.controllers;
using Lab08.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Lab08
{

    public partial class Form1 : Form
    {
        private AgenciaController agenciaController = new AgenciaController();
        private InmuebleController inmuebleController = new InmuebleController();

        public Form1()
        {
            InitializeComponent();
        }

        private void MostrarAgenciasEnDataGrid(List<Agencia> agencias)
        {
            if (agencias.Count == 0)
            {
                dgAgencias.DataSource = null;
                return;
            }
            dgAgencias.DataSource = null;
            dgAgencias.DataSource = agencias;
        }

        private void MostrarInmueblesEnDataGrid(List<Inmueble> inmuebles)
        {
            if (inmuebles.Count == 0)
            {
                dgInmuebles.DataSource = null;
                lblMontoTotalAlquilerInmuebles.Text = "0";
                return;
            }
            dgInmuebles.DataSource = null;
            dgInmuebles.DataSource = inmuebles;

            // Hallar el monto de los inmuebles alquilados
            List<Inmueble> inmueblesTemp = inmuebles.FindAll(i => i.Condicion.Equals("Alquiler"));
            lblMontoTotalAlquilerInmuebles.Text = inmueblesTemp.Sum(i => i.Precio).ToString();
        }

        private void btnAgregarAgencia_Click(object sender, EventArgs e)
        {
            // Validación de campos
            if (tbAgenciaCodigo.Text == "" || tbAgenciaDireccion.Text == "" ||
                tbAgenciaCiudad.Text == "" || tbAgenciaTelefono.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // Crear el objeto
            Agencia agencia = new Agencia()
            {
                Codigo = tbAgenciaCodigo.Text,
                Direccion = tbAgenciaDireccion.Text,
                Ciudad = tbAgenciaCiudad.Text,
                Telefono = tbAgenciaTelefono.Text,
                Inmuebles = new List<Inmueble>()
            };

            // Registrar
            bool registrado = agenciaController.Registrar(agencia);
            if (!registrado)
            {
                MessageBox.Show("Ingrese otro código");
                return;
            }

            // Mostrar en el DataGrid
            MostrarAgenciasEnDataGrid(AgenciaController.Listar());
        }

        private void btnLimpiarAgencia_Click(object sender, EventArgs e)
        {
            MostrarAgenciasEnDataGrid(AgenciaController.Listar());
        }

        private void btnAgregarInmueble_Click(object sender, EventArgs e)
        {
            // Validación de agencia seleccionada
            if (dgAgencias.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una agencia");
                return;
            }

            // Validación de campos
            if (tbInmuebleCodigo.Text == "" || tbInmuebleDireccion.Text == "" ||
                tbInmuebleSuperficie.Text == "" || tbInmueblePrecio.Text == "" ||
                cbInmuebleCondicion.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // Crear el objeto
            Inmueble inmueble = new Inmueble()
            {
                Codigo = tbInmuebleCodigo.Text,
                Direccion = tbInmuebleDireccion.Text,
                Superficie = double.Parse(tbInmuebleSuperficie.Text),
                Precio = double.Parse(tbInmueblePrecio.Text),
                Condicion = cbInmuebleCondicion.Text
            };

            // Registrar
            String codigoAgencia = dgAgencias.SelectedRows[0].Cells[0].Value.ToString();
            bool registrado = inmuebleController.Registrar(codigoAgencia, inmueble);
            if (!registrado)
            {
                MessageBox.Show("Ingrese otro código");
                return;
            }

            // Mostrar en DataGrid
            MostrarInmueblesEnDataGrid(inmuebleController.ListarPorAgencia(codigoAgencia));
        }


        private void btnLimpiarInmueble_Click(object sender, EventArgs e)
        {
            MostrarInmueblesEnDataGrid(new List<Inmueble>());
        }

        private void btnAgenciasAlquilerInmueblesMayorSuperficie_Click(object sender, EventArgs e)
        {
            MostrarAgenciasEnDataGrid(agenciaController.ListarMayorSuperficieInmueblesAlquiler());
        }

        private void btnAgenciasMayorCantidadInmueblesVenta_Click(object sender, EventArgs e)
        {
            MostrarAgenciasEnDataGrid(agenciaController.ListarMayorCantidadInmueblesVenta());
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Validación de campos
            if (tbBuscar.Text == "")
            {
                MessageBox.Show("Ingrese código de agencia");
                return;
            }

            MostrarInmueblesEnDataGrid(inmuebleController.ListarPorAgenciaVenta(tbBuscar.Text));
        }

        private void dgAgencias_SelectionChanged(object sender, EventArgs e)
        {
            // Validación
            if (dgAgencias.SelectedRows.Count == 0) return;

            // Hallar el código de la agencia
            String codigoAgencia = dgAgencias.SelectedRows[0].Cells[0].Value.ToString();

            // Mostrar los inmuebles
            MostrarInmueblesEnDataGrid(inmuebleController.ListarPorAgencia(codigoAgencia));
        }

    }
}
