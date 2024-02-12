using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04
{
    public partial class Form1 : Form
    {
        private AlumnoController alumController = new AlumnoController();

        public Form1()
        {
            InitializeComponent();
        }

        private void MostrarEnDataGrid(Alumno[] alumnos)
        {
            dgAlumnos.DataSource = null;
            dgAlumnos.DataSource = alumnos;
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            // Validación
            if (textBoxCodigo.Text == "" || textBoxNombre.Text == "" || textBoxPromedio.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // Crear el objeto
            Alumno alumno = new Alumno();
            alumno.Codigo = textBoxCodigo.Text;
            alumno.Nombre = textBoxNombre.Text;
            alumno.Promedio = double.Parse(textBoxPromedio.Text);

            // Registrar el objeto
            alumController.Registrar(alumno);

            // Mostrar en DataGrid
            MostrarEnDataGrid(alumController.ObtenerTodo());
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            // Validación
            if (dgAlumnos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione registro a eliminar");
                return;
            }

            // Obtener código de la fila
            String codigo = dgAlumnos.SelectedRows[0].Cells[0].Value.ToString();

            // Eliminar el objeto
            alumController.EliminarPorCodigo(codigo);

            // Mostrar en DataGrid
            MostrarEnDataGrid(alumController.ObtenerTodo());
        }

        private void buttonOrdenar_Click(object sender, EventArgs e)
        {
            // Mostrar en DataGrid
            MostrarEnDataGrid(alumController.Ordenar());
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            // Validación
            if (textBoxBusqueda.Text == "")
            {
                MessageBox.Show("Inserte código a buscar");
                return;
            }

            // Obtener código
            String codigo = textBoxBusqueda.Text;

            // Mostrar en DataGrid
            MostrarEnDataGrid(alumController.BuscarPorCodigo(codigo));
        }
    }
}
