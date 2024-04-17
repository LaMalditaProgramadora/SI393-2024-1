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
        private PokemonService pokemonService = new PokemonService();

        public FormReporte()
        {
            InitializeComponent();
        }

        private void MostrarEntrenadores(List<Entrenador> entrenadores)
        {
            dgEntrenadores.DataSource = null;

            if (entrenadores.Count == 0)
            {
                return;
            }
            else
            {
                dgEntrenadores.DataSource = entrenadores;
                lblTotalEntrenadores.Text = entrenadores.Count.ToString();
            }
        }

        private void MostrarPokemons(List<Pokemon> pokemons)
        {
            dgPokemons.DataSource = null;

            if (pokemons.Count == 0)
            {
                return;
            }
            else
            {
                dgPokemons.DataSource = pokemons;
                lblTotalPokemons.Text = pokemons.Count.ToString();
            }
        }

        private void btnBuscarPorNombrePokemon_Click(object sender, EventArgs e)
        {
            // Validación de campos
            if (tbNombre.Text == "")
            {
                MessageBox.Show("Ingrese el nombre");
                return;
            }

            String nombre = tbNombre.Text;
            // Listar
            MostrarEntrenadores(entrenadorService.ListarPorNombrePokemon(nombre));
        }

        private void btnBuscarPorRegion_Click(object sender, EventArgs e)
        {
            // Validación de campos
            if (cbRegion.Text == "")
            {
                MessageBox.Show("Ingrese la región");
                return;
            }

            String region = cbRegion.Text;
            // Listar
            MostrarEntrenadores(entrenadorService.ListarPorRegion(region));
        }

        private void btnBuscarPorMenorCantPokemon_Click(object sender, EventArgs e)
        {
            // Listar
            MostrarEntrenadores(entrenadorService.ListarPorMenorCantidadPokemon());
        }

        private void btnBuscarPorRangoEdadEntrenadores_Click(object sender, EventArgs e)
        {
            // Validación de campos
            if (tbEdadMin.Text == "" || tbEdadMax.Text == "")
            {
                MessageBox.Show("Ingrese el rango de edad");
                return;
            }

            int edadMin = int.Parse(tbEdadMin.Text);
            int edadMax = int.Parse(tbEdadMax.Text);
            // Listar
            MostrarPokemons(pokemonService.BuscarPorEdadEntrenadores(edadMin, edadMax));
        }

        private void btnBuscarLegendarios_Click(object sender, EventArgs e)
        {
            MostrarPokemons(pokemonService.BuscarLegendarios());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
