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
    public partial class FormCurso : Form
    {
        private NCurso nCurso = new NCurso();


        public FormCurso()
        {
            InitializeComponent();
            MostrarCursos(nCurso.ListarTodo());
        }

        private void MostrarCursos(List<Curso> cursos)
        {
            dgCursos.DataSource = null;
            if (cursos.Count == 0)
            {
                return;
            }
            else
            {
                dgCursos.DataSource = cursos;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            Curso curso = new Curso()
            {
                Nombrecurso = tbNombre.Text,
            };

            String mensaje = nCurso.Registrar(curso);
            MessageBox.Show(mensaje);

            MostrarCursos(nCurso.ListarTodo());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgCursos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un curso");
                return;
            }

            int id_curso = int.Parse(dgCursos.SelectedRows[0].Cells[0].Value.ToString());
            String mensaje = nCurso.Eliminar(id_curso);
            MessageBox.Show(mensaje);

            MostrarCursos(nCurso.ListarTodo());
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgCursos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un curso");
                return;
            }

            if (tbNombre.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            int id_curso = int.Parse(dgCursos.SelectedRows[0].Cells[0].Value.ToString());
            Curso curso = new Curso()
            {
                // Aquí
                Id_curso = id_curso,
                Nombrecurso = tbNombre.Text,
            };

            String mensaje = nCurso.Modificar(curso);
            MessageBox.Show(mensaje);

            MostrarCursos(nCurso.ListarTodo());
        }

        private void btnBuscarPorNombrecurso_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text == "")
            {
                MessageBox.Show("Ingrese escuela");
                return;
            }

            String nombrecurso = tbNombre.Text;
            MostrarCursos(nCurso.BuscarPorNombrecurso(nombrecurso));

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
