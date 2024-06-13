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
    public partial class FormVideojuego : Form
    {
        private int id_desarrollador;
        private NVideojuego nVideojuego = new NVideojuego();

        public FormVideojuego(int id_desarrollador)
        {
            InitializeComponent();
            this.id_desarrollador = id_desarrollador;
            MostrarVideojuegos(nVideojuego.ListarTodo(id_desarrollador));
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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (tbTitulo.Text == "" || tbValoracion.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            Decimal valoracion = 0;
            try
            {
                valoracion = Decimal.Parse(tbValoracion.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingrese los campso correctamente");
                return;
            }

            Videojuego videojuego = new Videojuego()
            {
                Titulo = tbTitulo.Text,
                Valoracion = valoracion,
                // Setear el FK
                Id_Desarrollador = id_desarrollador
            };

            String mensaje = nVideojuego.Registrar(videojuego);
            MessageBox.Show(mensaje);

            MostrarVideojuegos(nVideojuego.ListarTodo(id_desarrollador));
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (tbTitulo.Text == "" || tbValoracion.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            if (dgVideojuegos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione registro a modificar");
                return;
            }

            Decimal valoracion = 0;
            try
            {
                valoracion = Decimal.Parse(tbValoracion.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingrese los campso correctamente");
                return;
            }

            int id_videojuego = int.Parse(dgVideojuegos.SelectedRows[0].Cells[0].Value.ToString());

            Videojuego videojuego = new Videojuego()
            {
                Id_Videojuego = id_videojuego,
                Titulo = tbTitulo.Text,
                Valoracion = valoracion
            };

            String mensaje = nVideojuego.Modificar(videojuego);
            MessageBox.Show(mensaje);

            MostrarVideojuegos(nVideojuego.ListarTodo(id_desarrollador));
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgVideojuegos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione registro a eliminar");
                return;
            }

            int id_videojuego = int.Parse(dgVideojuegos.SelectedRows[0].Cells[0].Value.ToString());

            String mensaje = nVideojuego.Eliminar(id_videojuego);
            MessageBox.Show(mensaje);

            MostrarVideojuegos(nVideojuego.ListarTodo(id_desarrollador));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
