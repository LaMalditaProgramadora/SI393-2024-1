using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormReporte : Form
    {
        private NLibro nLibro = new NLibro();

        public FormReporte()
        {
            InitializeComponent();
        }

        private void MostrarLibros(List<Libro> libros)
        {
            dgLibros.DataSource = null;
            if (libros.Count == 0)
            {
                return;
            }
            else
            {
                dgLibros.DataSource = libros;
                dgLibros.Columns["Autor"].Visible = false;
                dgLibros.Columns["Editorial"].Visible = false;
                dgLibros.Columns["Eliminado"].Visible = false;
            }
        }

        private void btnBuscarLibrosPorNombreDeEditorial_Click(object sender, EventArgs e)
        {
            // Validación de campo vacío
            if (tbNombreEditorial.Text == "")
            {
                MessageBox.Show("Ingrese el campo correspondiente");
                return;
            }

            String nombreEditorial = tbNombreEditorial.Text;
            MostrarLibros(nLibro.BuscarLibrosPorNombreDeEditorial(nombreEditorial));
        }

        private void btnBuscarLibrosConAutoresConMasDe5AñosDeExp_Click(object sender, EventArgs e)
        {
            MostrarLibros(nLibro.BuscarLibrosConAutoresConMasDe5AñosDeExp());
        }

        private void btnObtenerPromedioDeNroPaginasDeLibrosDelGeneroTerror_Click(object sender, EventArgs e)
        {
            double promedio = nLibro.ObtenerPromedioDeNroPaginasDeLibrosDelGeneroTerror();
            lblPromedio.Text = promedio.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
