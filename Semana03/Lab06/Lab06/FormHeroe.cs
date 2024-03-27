using Lab06.entities;
using Lab06.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab06
{
    public partial class FormHeroe : Form
    {
        private HeroeService heroeService = new HeroeService();

        private String codigoAlbum;

        public FormHeroe(String codigoAlbum)
        {
            this.codigoAlbum = codigoAlbum;
            InitializeComponent();
            // Mostramos
            MostrarHeroes(heroeService.ListarTodo(codigoAlbum));
        }

        private void MostrarHeroes(List<Heroe> heroes)
        {
            dgHeroes.DataSource = null;

            if (heroes.Count == 0)
            {
                return;
            }
            else
            {
                dgHeroes.DataSource = heroes;
            }
        }

        private void btnRegistar_Click(object sender, EventArgs e)
        {
            // Validación de campos
            if (tbCodigo.Text == "" || tbNombre.Text == "" || tbCaracteristicas.Text == "" || tbPoder.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // Creamos el objeto
            Heroe heroe = new Heroe()
            {
                Codigo = tbCodigo.Text,
                Nombre = tbNombre.Text,
                Caracteristicas = tbCaracteristicas.Text,
                Poder = double.Parse(tbPoder.Text)
            };

            // Registramos
            heroeService.Registrar(codigoAlbum, heroe);

            // Mostramos
            MostrarHeroes(heroeService.ListarTodo(codigoAlbum));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
