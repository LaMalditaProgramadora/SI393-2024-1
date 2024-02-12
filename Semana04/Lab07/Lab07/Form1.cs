using Lab07.controllers;
using Lab07.entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab07
{
    public partial class Form1 : Form
    {
        private AlumnoController alumnoController = new AlumnoController();

        public Form1()
        {
            InitializeComponent();
        }

        private void MostrarAlumnosEnDataGrid(List<Alumno> alumnos)
        {
            if (alumnos.Count == 0) return;
            dgAlumnos.DataSource = null;
            dgAlumnos.DataSource = alumnos;
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            // Validación de campos
            if (textBoxCodigo.Text == "" || textBoxNombre.Text == "" ||
                textBoxDni.Text == "" || textBoxEdad.Text == "")
            {
                MessageBox.Show("Ingrese campos");
                return;
            }

            // Creación del objeto
            Alumno alumno = new Alumno()
            {
                Codigo = textBoxCodigo.Text,
                Nombre = textBoxNombre.Text,
                Dni = textBoxDni.Text,
                Edad = int.Parse(textBoxEdad.Text)
            };

            // Agrega a la lista
            bool registrado = alumnoController.Registrar(alumno);
            if (!registrado)
            {
                MessageBox.Show("Ingrese otro código");
                return;
            }

            // Mostrar en ListView
            MostrarAlumnosEnDataGrid(AlumnoController.Listar());
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            // Validación de selección
            if (dgAlumnos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione alumno");
                return;
            }

            // Eliminar todos los seleccionados
            foreach (DataGridViewRow fila in dgAlumnos.SelectedRows)
            {
                String codigo = fila.Cells[0].Value.ToString();
                alumnoController.Eliminar(codigo);
            }

            // Mostrar en ListView
            MostrarAlumnosEnDataGrid(AlumnoController.Listar());
        }
    }
}
