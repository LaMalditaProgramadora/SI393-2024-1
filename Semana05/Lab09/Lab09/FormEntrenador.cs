﻿using Lab09.entities;
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
    public partial class FormEntrenador : Form
    {
        private EntrenadorService entrenadorService = new EntrenadorService();

        public FormEntrenador()
        {
            InitializeComponent();
            MostrarEntrenadoresEnDataGrid(entrenadorService.ListarTodo());
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
            lblTotalEntrenadores.Text = entrenadores.Count.ToString();
        }

        private void btnRegistrarEntrenador_Click(object sender, EventArgs e)
        {
            // Validación de campos
            if (tbCodigo.Text == "" || tbNombre.Text == "" || tbEdad.Text == "" || cbRegion.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // Crear el objeto
            Entrenador entrenador = new Entrenador()
            {
                Codigo = tbCodigo.Text,
                Nombre = tbNombre.Text,
                Edad = int.Parse(tbEdad.Text),
                Region = cbRegion.Text,
                Pokemons = new List<Pokemon>()
            };

            // Insertar
            bool insertado = entrenadorService.Insertar(entrenador);
            if (!insertado)
            {
                MessageBox.Show("El código ya existe");
                return;
            }

            // Actualizar ListView
            MostrarEntrenadoresEnDataGrid(entrenadorService.ListarTodo());
        }

        private void btnVerPokemon_Click(object sender, EventArgs e)
        {
            // Validar selección
            if (dgEntrenadores.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un entrenador");
                return;
            }

            String codigoEntrenador = dgEntrenadores.SelectedRows[0].Cells[0].Value.ToString();
            // Abrir formulario de Pokémon enviando el código del entrenador
            FormPokemon form = new FormPokemon(codigoEntrenador);
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
