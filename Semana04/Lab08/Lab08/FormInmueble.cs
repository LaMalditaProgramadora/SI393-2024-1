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
    public partial class FormInmueble : Form
    {
        private String codigoAgencia;
        private InmuebleService inmuebleService = new InmuebleService();

        public FormInmueble(String codigoAgencia)
        {
            InitializeComponent();
            this.codigoAgencia = codigoAgencia;
            // Mostrar
            MostrarInmuebles(inmuebleService.ListarTodo(codigoAgencia));
        }

        private void MostrarInmuebles(List<Inmueble> inmuebles)
        {
            dgInmuebles.DataSource = null;
            if (inmuebles.Count == 0)
            {
                return;
            }
            else
            {
                dgInmuebles.DataSource = inmuebles;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validación de campos
            if (tbCodigo.Text == "" || tbDireccion.Text == "" || tbSuperficie.Text == "" || tbPrecio.Text == "" || cbCondicion.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // Creación del objeto
            Inmueble inmueble = new Inmueble()
            {
                Codigo = tbCodigo.Text,
                Direccion = tbDireccion.Text,
                Superficie = double.Parse(tbSuperficie.Text),
                Precio = double.Parse(tbPrecio.Text),
                Condicion = cbCondicion.Text
            };

            // Registrar
            bool registrado = inmuebleService.Registrar(codigoAgencia, inmueble);
            if (!registrado)
            {
                MessageBox.Show("Ingrese otro código");
                return;
            }

            // Mostrar
            MostrarInmuebles(inmuebleService.ListarTodo(codigoAgencia));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
