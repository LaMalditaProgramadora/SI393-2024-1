using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormDocente : Form
    {
        private NDocente nDocente = new NDocente();

        public FormDocente()
        {
            InitializeComponent();
            MostrarDocentes(nDocente.ListarTodo());
        }

        private void MostrarDocentes(List<Docente> docentes)
        {
            dgDocentes.DataSource = null;
            if (docentes.Count == 0)
            {
                return;
            }
            else
            {
                dgDocentes.DataSource = docentes;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text == "" || tbApellido.Text == "" || tbEscuela.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            Docente docente = new Docente()
            {
                Nombre = tbNombre.Text,
                Apellido = tbApellido.Text,
                Escuela = tbEscuela.Text,
            };

            String mensaje = nDocente.Registrar(docente);
            MessageBox.Show(mensaje);

            MostrarDocentes(nDocente.ListarTodo());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgDocentes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un docente");
                return;
            }

            int id_docente = int.Parse(dgDocentes.SelectedRows[0].Cells[0].Value.ToString());
            String mensaje = nDocente.Eliminar(id_docente);
            MessageBox.Show(mensaje);

            MostrarDocentes(nDocente.ListarTodo());
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgDocentes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un docente");
                return;
            }

            if (tbNombre.Text == "" || tbApellido.Text == "" || tbEscuela.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            int id_docente = int.Parse(dgDocentes.SelectedRows[0].Cells[0].Value.ToString());
            Docente docente = new Docente()
            {
                // Aquí
                Id_docente = id_docente,
                Nombre = tbNombre.Text,
                Apellido = tbApellido.Text,
                Escuela = tbEscuela.Text
            };

            String mensaje = nDocente.Modificar(docente);
            MessageBox.Show(mensaje);

            MostrarDocentes(nDocente.ListarTodo());
        }

        private void btnBuscarPorEscuela_Click(object sender, EventArgs e)
        {
            if (tbEscuela.Text == "")
            {
                MessageBox.Show("Ingrese escuela");
                return;
            }

            String escuela = tbEscuela.Text;
            MostrarDocentes(nDocente.BuscarPorEscuela(escuela));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
