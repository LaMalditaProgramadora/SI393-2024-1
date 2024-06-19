using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormLibro : Form
    {
        private NAutor nAutor = new NAutor();
        private NEditorial nEditorial = new NEditorial();
        private NLibro nLibro = new NLibro();

        public FormLibro()
        {
            InitializeComponent();
            MostrarAutores(nAutor.ListarTodo());
            MostrarEditoriales(nEditorial.ListarTodo());
            MostrarLibros(nLibro.ListarTodo());
        }

        private void MostrarAutores(List<Autor> autores)
        {
            cbAutor.DataSource = null;
            if (autores.Count == 0)
            {
                return;
            }
            else
            {
                cbAutor.DataSource = autores;
                cbAutor.ValueMember = "AutorId";
                cbAutor.DisplayMember = "NombreCompleto";
            }
        }

        private void MostrarEditoriales(List<Editorial> editoriales)
        {
            cbEditorial.DataSource = null;
            if (editoriales.Count == 0)
            {
                return;
            }
            else
            {
                cbEditorial.DataSource = editoriales;
                cbEditorial.ValueMember = "EditorialId";
                cbEditorial.DisplayMember = "Nombre";
            }
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

        private void LimpiarCampos()
        {
            tbTitulo.Text = "";
            tbNroPaginas.Text = "";
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validación de campos vacíos
            if (cbAutor.Text == "" || cbEditorial.Text == "" || tbTitulo.Text == "" || cbGenero.Text == "" || tbNroPaginas.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // Validación entrada numérica
            int nroPaginas = 0;
            try
            {
                nroPaginas = int.Parse(tbNroPaginas.Text.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Ingrese los campos correctamente");
                return;
            }

            int autorId = int.Parse(cbAutor.SelectedValue.ToString());
            int editorialId = int.Parse(cbEditorial.SelectedValue.ToString());
            Libro libro = new Libro()
            {
                AutorId = autorId,
                EditorialId = editorialId,
                Titulo = tbTitulo.Text,
                Genero = cbGenero.Text,
                NroPaginas = nroPaginas
            };

            String mensaje = nLibro.Registrar(libro);
            MessageBox.Show(mensaje);

            LimpiarCampos();
            MostrarLibros(nLibro.ListarTodo());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Validacion de selección
            if (dgLibros.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione registro a eliminar");
                return;
            }

            int libroId = int.Parse(dgLibros.SelectedRows[0].Cells["LibroId"].Value.ToString());

            // Diálogo de confirmación
            DialogResult dialog = MessageBox.Show("¿Está seguro de eliminar el libro con LibroId: " + libroId, "", MessageBoxButtons.YesNo);

            if (dialog.Equals(DialogResult.Yes))
            {
                String mensaje = nLibro.Eliminar(libroId);
                MessageBox.Show(mensaje);

                MostrarLibros(nLibro.ListarTodo());
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Validación de campos vacíos
            if (cbAutor.Text == "" || cbEditorial.Text == "" || tbTitulo.Text == "" || cbGenero.Text == "" || tbNroPaginas.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // Validación entrada numérica
            int nroPaginas = 0;
            try
            {
                nroPaginas = int.Parse(tbNroPaginas.Text.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Ingrese los campos correctamente");
                return;
            }

            // Validacion de selección
            if (dgLibros.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione registro a modificar");
                return;
            }

            int libroId = int.Parse(dgLibros.SelectedRows[0].Cells["LibroId"].Value.ToString());
            Libro libro = new Libro()
            {
                LibroId = libroId,
                Titulo = tbTitulo.Text,
                Genero = cbGenero.Text,
                NroPaginas = nroPaginas
            };

            String mensaje = nLibro.Modificar(libro);
            MessageBox.Show(mensaje);

            LimpiarCampos();
            MostrarLibros(nLibro.ListarTodo());
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

        private void dgLibros_SelectionChanged(object sender, EventArgs e)
        {
            // Validación de selección
            if (dgLibros.SelectedRows.Count == 0)
            {
                return;
            }

            cbAutor.SelectedValue = dgLibros.SelectedRows[0].Cells["AutorId"].Value;
            cbEditorial.SelectedValue = dgLibros.SelectedRows[0].Cells["EditorialId"].Value;
            tbTitulo.Text = dgLibros.SelectedRows[0].Cells["Titulo"].Value.ToString();
            cbGenero.Text = dgLibros.SelectedRows[0].Cells["Genero"].Value.ToString();
            tbNroPaginas.Text = dgLibros.SelectedRows[0].Cells["NroPaginas"].Value.ToString();
        }
    }
}
