using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Lab06
{
    public partial class Form1 : Form
    {
        private AlbumController albController = new AlbumController();
        private HeroeController heroeController = new HeroeController();

        public Form1()
        {
            InitializeComponent();
        }

        private void MostrarAlbumesEnDataGrid(List<Album> albumes)
        {
            dgAlbumes.DataSource = null;
            if (albumes.Count == 0)
            {
                lblAlbumMasHeroes.Text = "-";
                return;
            }
            else
            {
                dgAlbumes.DataSource = albumes;

                // Obtener el álbum con más héroes
                int maxHeroes = albumes.Max(alb => alb.Heroes.Count);
                Album albumMasHeroes = albumes.Find(alb => alb.Heroes.Count == maxHeroes);
                if (albumMasHeroes != null) lblAlbumMasHeroes.Text = albumMasHeroes.Nombre;
            }

        }

        private void MostrarHeroesEnDataGrid(List<Heroe> heroes)
        {
            dgHeroes.DataSource = null;
            if (heroes.Count == 0)
            {
                lblHeroeMayorPoder.Text = "-";
                lblHeroeMenorPoder.Text = "-";
                return;
            }
            else
            {
                dgHeroes.DataSource = heroes;

                // Héroe con mayor y menor poder
                double mayorPoder = heroes.Max(her => her.Poder);
                Heroe heroeMayorPoder = heroes.Find(her => her.Poder == mayorPoder);
                lblHeroeMayorPoder.Text = heroeMayorPoder.Nombre;

                double menorPoder = heroes.Min(her => her.Poder);
                Heroe heroeMenorPoder = heroes.Find(her => her.Poder == menorPoder);
                lblHeroeMenorPoder.Text = heroeMenorPoder.Nombre;
            }
        }

        private void btnRegistrarAlbum_Click(object sender, EventArgs e)
        {
            // Validación
            if (tbAlbumCodigo.Text == "" || tbAlbumNombre.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos del álbum");
                return;
            }

            // Creando el objeto
            Album album = new Album()
            {
                Codigo = tbAlbumCodigo.Text,
                Nombre = tbAlbumNombre.Text,
                Heroes = new List<Heroe>()
            };

            // Registrar
            bool registrado = albController.Registrar(album);
            if (!registrado)
            {
                MessageBox.Show("Ingrese otro código");
                return;
            }

            // Mostrar en data grid
            MostrarAlbumesEnDataGrid(AlbumController.Listar());
        }

        private void btnLimpiarAlbum_Click(object sender, EventArgs e)
        {
            // Mostrar en data grid
            MostrarAlbumesEnDataGrid(AlbumController.Listar());
        }

        private void btnRegistrarHeroe_Click(object sender, EventArgs e)
        {
            // Validación
            if (dgAlbumes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione álbum");
                return;
            }
            if (tbHeroeCodigo.Text == "" || tbHeroeNombre.Text == "" ||
                tbHeroeCaracteristicas.Text == "" || tbHeroePoder.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos del héroe");
                return;
            }

            // Crear el objeto
            Heroe heroe = new Heroe()
            {
                Codigo = tbHeroeCodigo.Text,
                Nombre = tbHeroeNombre.Text,
                Caracteristicas = tbHeroeCaracteristicas.Text,
                Poder = double.Parse(tbHeroePoder.Text)
            };

            // Registrar
            String codigoAlbum = dgAlbumes.SelectedRows[0].Cells[0].Value.ToString();
            bool registrado = heroeController.Registrar(codigoAlbum, heroe);
            if (!registrado)
            {
                MessageBox.Show("Ingrese otro código");
                return;
            }

            // Mostrar en data grid
            MostrarHeroesEnDataGrid(heroeController.ListarporAlbum(codigoAlbum));
        }

        private void btnLimpiarHeroes_Click(object sender, EventArgs e)
        {
            // Mostrar en data grid
            MostrarHeroesEnDataGrid(new List<Heroe>());
        }

        private void dgAlbumes_SelectionChanged(object sender, EventArgs e)
        {
            // Validación
            if (dgAlbumes.SelectedRows.Count == 0) return;

            // Hallar el código del álbum
            String codigoAlbum = dgAlbumes.SelectedRows[0].Cells[0].Value.ToString();


            // Mostrar los héroes
            MostrarHeroesEnDataGrid(heroeController.ListarporAlbum(codigoAlbum));
        }
    }
}
