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
    public partial class FormRuta : Form
    {
        private RutaService rutaService = new RutaService();
        private String matricula;

        public FormRuta(String matricula)
        {
            InitializeComponent();
            this.matricula = matricula;
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
            MostrarRutasEnDataGrid(rutaService.ListarTodo(matricula));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
