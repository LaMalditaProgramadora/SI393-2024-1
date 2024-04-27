using Lab10.entities;
using Lab10.services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab10
{
    public partial class FormRuta : Form
    {
        String matricula;
        private RutaService rutaService = new RutaService();

        public FormRuta(String matricula)
        {
            InitializeComponent();
            this.matricula = matricula;
            // Mostrar en el ListView
            MostrarRutas(rutaService.ListarTodo(matricula));
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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validación de campos
            if (tbCodigo.Text == "" || tbOrigen.Text == "" || tbDestino.Text == "" || tbKilometros.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // Creación del objeto
            Ruta ruta = new Ruta()
            {
                Codigo = tbCodigo.Text,
                Origen = tbOrigen.Text,
                Destino = tbDestino.Text,
                Kilometros = double.Parse(tbKilometros.Text)
            };

            // Registro de ruta
            bool registrado = rutaService.Registrar(matricula, ruta);
            if (!registrado)
            {
                MessageBox.Show("Ingrese un código diferente");
                return;
            }

            // Mostrar en el ListView
            MostrarRutas(rutaService.ListarTodo(matricula));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
