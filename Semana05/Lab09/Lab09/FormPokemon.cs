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
    public partial class FormPokemon : Form
    {
        private PokemonService pokemonService = new PokemonService();
        private String codigoEntrenador;

        public FormPokemon(String codigoEntrenador)
        {
            InitializeComponent();
            this.codigoEntrenador = codigoEntrenador;
            MostrarPokemons(pokemonService.ListarTodoPorEntrenador(codigoEntrenador));
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
                lblTotalPsPokemon.Text = pokemons.Sum(p => p.PuntosSalud).ToString();
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validación de campos
            if (tbCodigo.Text == "" || tbNombre.Text == "" || tbApodo.Text == "" || cbTipo.Text == "" || tbPs.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // Validar si tiene más de 6 pokémos
            if (pokemonService.ListarTodoPorEntrenador(codigoEntrenador).Count == 6)
            {
                MessageBox.Show("No se puede agregar más de 6 pokémons");
                return;
            }

            // Crear el objeto
            Pokemon pokemon = new Pokemon()
            {
                Codigo = tbCodigo.Text,
                Nombre = tbNombre.Text,
                Apodo = tbApodo.Text,
                Tipo = cbTipo.Text,
                PuntosSalud = int.Parse(tbPs.Text),
                Legendario = chBEsLegendario.Checked
            };

            // Registramos
            bool registrado = pokemonService.Registrar(codigoEntrenador, pokemon);
            if (!registrado)
            {
                MessageBox.Show("El código ya existe");
                return;
            }

            // Actualizar ListView
            MostrarPokemons(pokemonService.ListarTodoPorEntrenador(codigoEntrenador));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
