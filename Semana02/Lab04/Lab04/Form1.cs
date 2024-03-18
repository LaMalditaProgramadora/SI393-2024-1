using Lab04.controllers;
using Lab04.entities;
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
        private AlumnoController alumnoController = new AlumnoController();

        public Form1()
        {
            InitializeComponent();
        }

        private void MostrarAlumnosEnDataGrid(Alumno[] alumnos)
        {
            dgAlumnos.DataSource = null;
            dgAlumnos.DataSource = alumnos;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validaciones
            if (tbCodigo.Text == "" || tbNombre.Text == "" || tbPromedio.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // Crear el objeto
            Alumno alumno = new Alumno()
            {
                Codigo = tbCodigo.Text,
                Nombre = tbNombre.Text,
                Promedio = double.Parse(tbPromedio.Text)
            };

            // Registrar
            alumnoController.Registrar(alumno);

            // Mostrar
            MostrarAlumnosEnDataGrid(alumnoController.ListarTodo());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Validación
            if (dgAlumnos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione registro a eliminar");
                return;
            }

            // Obtener el código de la fila seleccionada
            String codigo = dgAlumnos.SelectedRows[0].Cells[0].Value.ToString();

            // Eliminamos
            alumnoController.Eliminar(codigo);

            // Mostrar
            MostrarAlumnosEnDataGrid(alumnoController.ListarTodo());
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            // Mostrar
            MostrarAlumnosEnDataGrid(alumnoController.Ordenar());
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Validación
            if (tbBuscar.Text == "")
            {
                MessageBox.Show("Ingrese código a buscar");
                return;
            }

            String codigo = tbBuscar.Text;

            // Mostrar
            MostrarAlumnosEnDataGrid(alumnoController.BuscarPorCodigo(codigo));
        }
    }
}
