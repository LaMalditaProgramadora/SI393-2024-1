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
            // Mostrar
            MostrarAgencias(agenciaService.ListarTodo());
        }

        private void MostrarAgencias(List<Agencia> agencias)
        {
            dgAgencias.DataSource = null;
            if (agencias.Count == 0)
            {
                return;
            }
            else
            {
                dgAgencias.DataSource = agencias;
            }
        }

        private void btnAgregarAgencia_Click(object sender, EventArgs e)
        {
            // Validación
            if (tbCodigo.Text == "" || tbDireccion.Text == "" || tbCiudad.Text == "" || tbTelefono.Text == "")
            {
                MessageBox.Show("ingrese todos los campos");
                return;
            }

            // Creación del objeto
            Agencia agencia = new Agencia()
            {
                Codigo = tbCodigo.Text,
                Direccion = tbDireccion.Text,
                Ciudad = tbCiudad.Text,
                Telefono = tbTelefono.Text,
                // Importante
                Inmuebles = new List<Inmueble>()
            };

            // Registrar
            bool registrado = agenciaService.Registrar(agencia);
            if (!registrado)
            {
                MessageBox.Show("Ingrese otro código");
                return;
            }

            // Mostrar
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
