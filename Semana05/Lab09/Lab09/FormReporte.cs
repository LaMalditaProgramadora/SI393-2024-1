using Lab09.entities;
using Lab09.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab09
{
    public partial class FormReporte : Form
    {
        private EntrenadorService entrenadorService = new EntrenadorService();

        public FormReporte()
        {
            InitializeComponent();
        }

        private void MostrarEntrenadoresEnDataGrid(List<Entrenador> entrenadores)
        {
            if (entrenadores.Count == 0)
            {
                dgEntrenadores.DataSource = null;
                return;
            }
            dgEntrenadores.DataSource = null;
            dgEntrenadores.DataSource = entrenadores;
        }

        private void btnBuscarPorNombrePokemon_Click(object sender, EventArgs e)
        {
            // Validación de campos
            if (tbNombre.Text == "")
            {
                MessageBox.Show("Ingrese el nombre");
                return;
            }

            // Listar
            MostrarEntrenadoresEnDataGrid(entrenadorService.ListarPorNombrePokemon(tbNombre.Text));
        }

        private void btnBuscarPorRegion_Click(object sender, EventArgs e)
        {
            // Validación de campos
            if (cbRegion.Text == "")
            {
                MessageBox.Show("Ingrese la región");
                return;
            }

            // Listar
            MostrarEntrenadoresEnDataGrid(entrenadorService.ListarPorRegion(cbRegion.Text));
        }

        private void btnBuscarPorMenorCantPokemon_Click(object sender, EventArgs e)
        {
            // Listar
            MostrarEntrenadoresEnDataGrid(entrenadorService.ListarPorMenorCantidadPokemon());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
