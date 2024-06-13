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
        private NDesarrollador nDesarrollador = new NDesarrollador();
        private NVideojuego nVideojuego = new NVideojuego();

        public FormReporte()
        {
            InitializeComponent();
        }

        private void MostrarDesarrolladores(List<Desarrollador> desarrolladores)
        {
            dgDesarrolladores.DataSource = null;
            if (desarrolladores.Count == 0)
            {
                return;
            }
            else
            {
                dgDesarrolladores.DataSource = desarrolladores;
            }
        }

        private void MostrarVideojuegos(List<Videojuego> videojuegos)
        {
            dgVideojuegos.DataSource = null;
            if (videojuegos.Count == 0)
            {
                return;
            }
            else
            {
                dgVideojuegos.DataSource = videojuegos;
            }
        }


        private void btnBuscarDesarrolladoresConVideojuegosConValoracionMenorA50_Click(object sender, EventArgs e)
        {
            MostrarDesarrolladores(nDesarrollador.BuscarPorVideojuegosQueTenganValoracionMenorA50());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarVideojuegosPorNombreDelDesarrollador_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text == "")
            {
                MessageBox.Show("Ingrese nombre");
                return;
            }

            String nombre = tbNombre.Text;
            MostrarVideojuegos(nVideojuego.BuscarPorNombreDesarrollador(nombre));
        }

        private void btnObtenerMayorValoracionPorDesarrollador_Click(object sender, EventArgs e)
        {
            if (tbIdDesarrollador.Text == "")
            {
                MessageBox.Show("Ingrese Id Desarrollador");
                return;
            }

            int id_desarrollador = int.Parse(tbIdDesarrollador.Text);
            Decimal mayorValoracion = nVideojuego.ObtenerMayorValoracionPorDesarrollador(id_desarrollador);
            lblMayorValoracion.Text = mayorValoracion.ToString();
        }
    }
}
