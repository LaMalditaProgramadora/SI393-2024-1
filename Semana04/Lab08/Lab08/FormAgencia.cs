using Lab08.entities;
using Lab08.services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab08
{
    public partial class FormAgencia : Form
    {
        private AgenciaService agenciaService = new AgenciaService();

        public FormAgencia()
        {
            InitializeComponent();
            MostrarAgencias(agenciaService.ListarTodo());
        }

        private void MostrarAgencias(List<Agencia> agencias)
        {
            if (agencias.Count == 0)
            {
                dgAgencias.DataSource = null;
                return;
            }
            dgAgencias.DataSource = null;
            dgAgencias.DataSource = agencias;
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
            bool registrado = agenciaService.Registrar(agencia);
            if (!registrado)
            {
                MessageBox.Show("Ingrese otro código");
                return;
            }

            // Mostrar en el DataGrid
            MostrarAgencias(agenciaService.ListarTodo());
        }

        private void btnVerInmuebles_Click(object sender, EventArgs e)
        {
            // Validación
            if (dgAgencias.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una agencia");
                return;
            }

            // Hallar el código de la agencia
            String codigoAgencia = dgAgencias.SelectedRows[0].Cells[0].Value.ToString();

            FormInmueble form = new FormInmueble(codigoAgencia);
            form.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            FormReporte form = new FormReporte();
            form.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
