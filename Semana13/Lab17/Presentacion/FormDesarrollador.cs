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
    public partial class FormDesarrollador : Form
    {
        private NDesarrollador nDesarrollador = new NDesarrollador();

        public FormDesarrollador()
        {
            InitializeComponent();
            MostrarDesarrolladores(nDesarrollador.ListarTodo());
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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            Desarrollador desarrollador = new Desarrollador()
            {
                Nombre = tbNombre.Text
            };

            String mensaje = nDesarrollador.Registrar(desarrollador);
            MessageBox.Show(mensaje);

            MostrarDesarrolladores(nDesarrollador.ListarTodo());
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            if (dgDesarrolladores.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione registro a modificar");
                return;
            }

            int id_desarrollador = int.Parse(dgDesarrolladores.SelectedRows[0].Cells[0].Value.ToString());

            Desarrollador desarrollador = new Desarrollador()
            {
                Id_Desarrollador = id_desarrollador,
                Nombre = tbNombre.Text
            };

            String mensaje = nDesarrollador.Modificar(desarrollador);
            MessageBox.Show(mensaje);

            MostrarDesarrolladores(nDesarrollador.ListarTodo());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (dgDesarrolladores.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione registro a eliminar");
                return;
            }

            int id_desarrollador = int.Parse(dgDesarrolladores.SelectedRows[0].Cells[0].Value.ToString());

            String mensaje = nDesarrollador.Eliminar(id_desarrollador);
            MessageBox.Show(mensaje);

            MostrarDesarrolladores(nDesarrollador.ListarTodo());
        }

        private void btnVerVideojuegos_Click(object sender, EventArgs e)
        {
            if (dgDesarrolladores.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione registro a eliminar");
                return;
            }

            int id_desarrollador = int.Parse(dgDesarrolladores.SelectedRows[0].Cells[0].Value.ToString());

            FormVideojuego form = new FormVideojuego(id_desarrollador);
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
