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
    public partial class FormDocentexCurso : Form
    {
        private NDocentexCurso nDocentexCurso = new NDocentexCurso();
        private NDocente nDocente = new NDocente();
        private NCurso nCurso = new NCurso();

        public FormDocentexCurso()
        {
            InitializeComponent();
            MostrarDocentes(nDocente.ListarTodo());
            MostrarCursos(nCurso.ListarTodo());
            MostrarDocentexCursos(nDocentexCurso.ListarTodo());
        }

        private void MostrarDocentes(List<Docente> docentes)
        {
            cbDocente.DataSource = null;
            if (docentes.Count == 0)
            {
                return;
            }
            else
            {
                cbDocente.DataSource = docentes;
                cbDocente.ValueMember = "Id_docente";
                cbDocente.DisplayMember = "Nombre";
            }
        }

        private void MostrarCursos(List<Curso> cursos)
        {
            cbCurso.DataSource = null;
            if (cursos.Count == 0)
            {
                return;
            }
            else
            {
                cbCurso.DataSource = cursos;
                cbCurso.ValueMember = "Id_curso";
                cbCurso.DisplayMember = "Nombrecurso";
            }
        }

        private void MostrarDocentexCursos(List<DocentexCurso> docentexCursos)
        {
            dgDocentexCursos.DataSource = null;
            if (docentexCursos.Count == 0)
            {
                return;
            }
            else
            {
                dgDocentexCursos.DataSource = docentexCursos;
            }
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            if (cbDocente.Text == "" || cbCurso.Text == "" || tbSemestre.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            int docente_id = int.Parse(cbDocente.SelectedValue.ToString());
            int id_curso = int.Parse(cbCurso.SelectedValue.ToString());

            DocentexCurso docentexCurso = new DocentexCurso()
            {
                Docente_id = docente_id,
                Id_curso = id_curso,
                Semestre = tbSemestre.Text
            };

            String mensaje = nDocentexCurso.Asignar(docentexCurso);
            MessageBox.Show(mensaje);

            MostrarDocentexCursos(nDocentexCurso.ListarTodo());
        }

        private void btnDesasignar_Click(object sender, EventArgs e)
        {
            if (dgDocentexCursos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una asignación");
                return;
            }

            int docente_id = int.Parse(dgDocentexCursos.SelectedRows[0].Cells[0].Value.ToString());
            int id_curso = int.Parse(dgDocentexCursos.SelectedRows[0].Cells[1].Value.ToString());

            String mensaje = nDocentexCurso.Desasignar(docente_id, id_curso);
            MessageBox.Show(mensaje);

            MostrarDocentexCursos(nDocentexCurso.ListarTodo());
        }

        private void btnBuscarPorDocente_Click(object sender, EventArgs e)
        {
            if (cbDocente.Text == "")
            {
                MessageBox.Show("Seleccione docente");
                return;
            }

            int docente_id = int.Parse(cbDocente.SelectedValue.ToString());
            MostrarDocentexCursos(nDocentexCurso.BuscarPorIdDocente(docente_id));
        }

        private void btnBuscarPorCurso_Click(object sender, EventArgs e)
        {
            if (cbCurso.Text == "")
            {
                MessageBox.Show("Seleccione curso");
                return;
            }

            int id_curso = int.Parse(cbCurso.SelectedValue.ToString());
            MostrarDocentexCursos(nDocentexCurso.BuscarPorIdCurso(id_curso));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
