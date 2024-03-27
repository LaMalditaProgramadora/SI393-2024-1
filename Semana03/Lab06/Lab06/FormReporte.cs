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
    public partial class FormReporte : Form
    {
        private AlbumService albumService = new AlbumService();
        private HeroeService heroeService = new HeroeService();

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

        public FormReporte()
        {
            InitializeComponent();
        }

        private void btnObtenerAlbumMasHeroes_Click(object sender, EventArgs e)
        {
            MostrarAlbumes(albumService.ListarAlbumesConMasHeroes());
        }

        private void btnListarAlbumesSegunHeroe_Click(object sender, EventArgs e)
        {
            // Validacíón
            if (tbCodigoHeroe.Text == "")
            {
                MessageBox.Show("Ingrese código");
                return;
            }

            String codigoHeroe = tbCodigoHeroe.Text;

            MostrarAlbumes(albumService.BuscarAlbumesQueTenganHeroe(codigoHeroe));
        }

        private void btnObtenerHeroesMenorPoder_Click(object sender, EventArgs e)
        {
            // Validacíón
            if (tbCodigoAlbum.Text == "")
            {
                MessageBox.Show("Ingrese código");
                return;
            }

            String codigoAlbum = tbCodigoAlbum.Text;

            MostrarHeroes(heroeService.ListarHeroesMenorPoder(codigoAlbum));
        }

        private void btnObtenerHeroesMayorPoder_Click(object sender, EventArgs e)
        {
            if (tbCodigoAlbum.Text == "")
            {
                MessageBox.Show("Ingrese código");
                return;
            }

            String codigoAlbum = tbCodigoAlbum.Text;

            MostrarHeroes(heroeService.ListarHeroesMayorPoder(codigoAlbum));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
