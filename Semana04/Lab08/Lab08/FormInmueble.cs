using Lab08.entities;
using Lab08.services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab08
{
    public partial class FormInmueble : Form
    {
        private InmuebleService inmuebleService = new InmuebleService();
        private String codigoAgencia;

        public FormInmueble(String codigoAgencia)
        {
            InitializeComponent();
            this.codigoAgencia = codigoAgencia;
            MostrarInmuebles(inmuebleService.ListarTodoPorAgencia(codigoAgencia));
        }

        private void MostrarInmuebles(List<Inmueble> inmuebles)
        {
            dgInmuebles.DataSource = null;
            if (inmuebles.Count == 0)
            {
                return;
            }
            dgInmuebles.DataSource = inmuebles;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
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
            bool registrado = inmuebleService.Registrar(codigoAgencia, inmueble);
            if (!registrado)
            {
                MessageBox.Show("Ingrese otro código");
                return;
            }

            // Mostrar en DataGrid
            MostrarInmuebles(inmuebleService.ListarTodoPorAgencia(codigoAgencia));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
