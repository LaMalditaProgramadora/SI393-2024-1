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
    public partial class FormAlbum : Form
    {
        private AlbumService albumService = new AlbumService();

        public FormAlbum()
        {
            InitializeComponent();
            // Mostrar
            MostrarAlbumes(albumService.ListarTodo());
        }

        private void MostrarAlbumes(List<Album> albumes)
        {
            dgAlbumes.DataSource = null;

            if (albumes.Count == 0)
            {
                return;
            }
            else
            {
                dgAlbumes.DataSource = albumes;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validación de campos
            if (tbCodigo.Text == "" || tbNombre.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // Creamos el álbum
            Album album = new Album()
            {
                Codigo = tbCodigo.Text,
                Nombre = tbNombre.Text,
                // Importante
                Heroes = new List<Heroe>()
            };

            // Registrar
            bool registrado = albumService.Registrar(album);
            if (!registrado)
            {
                MessageBox.Show("Código ya existe");
                return;
            }

            // Mostrar
            MostrarAlbumes(albumService.ListarTodo());
        }

        private void btnVerHeroes_Click(object sender, EventArgs e)
        {
            // Validación de selección
            if (dgAlbumes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un registro");
                return;
            }

            String codigoAlbum = dgAlbumes.SelectedRows[0].Cells[0].Value.ToString();
            FormHeroe form = new FormHeroe(codigoAlbum);
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
