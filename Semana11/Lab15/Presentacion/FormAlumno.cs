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
    public partial class FormAlumno : Form
    {
        private NAlumno nAlumno = new NAlumno();

        public FormAlumno()
        {
            InitializeComponent();
            // Mostrar en datagrid
            MostrarAlumnos(nAlumno.ListarTodo());
        }

        private void MostrarAlumnos(List<Alumno> alumnos)
        {
            dgAlumnos.DataSource = null;
            if (alumnos.Count == 0)
            {
                return;
            }
            else
            {
                dgAlumnos.DataSource = alumnos;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validación de campos vacíos
            if (tbCodigo.Text == "" || tbNombre.Text == "" || tbPromedioTA.Text == "" || tbPC2.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // Validación de campos numéricos
            Decimal promedioTA = 0;
            Decimal pc2 = 0;
            try
            {
                promedioTA = Decimal.Parse(tbPromedioTA.Text);
                pc2 = Decimal.Parse(tbPC2.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingrese los campos numéricos correctamente");
                return;
            }

            // Creación del objeto
            Alumno alumno = new Alumno()
            {
                Codigo = tbCodigo.Text,
                NombreCompleto = tbNombre.Text,
                PromedioTA = promedioTA,
                PC2 = pc2
            };

            // Registrar el objeto
            String mensaje = nAlumno.Registrar(alumno);
            MessageBox.Show(mensaje);

            // Mostrar en datagrid
            MostrarAlumnos(nAlumno.ListarTodo());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Validación de selección
            if (dgAlumnos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un alumno");
                return;
            }

            int id = int.Parse(dgAlumnos.SelectedRows[0].Cells[0].Value.ToString());
            // Eliminar por id
            String mensaje = nAlumno.Eliminar(id);
            MessageBox.Show(mensaje);

            // Mostrar en datagrid
            MostrarAlumnos(nAlumno.ListarTodo());
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
