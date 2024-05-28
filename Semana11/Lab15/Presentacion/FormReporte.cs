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
    public partial class FormReporte : Form
    {
        private NAlumno nAlumno = new NAlumno();

        public FormReporte()
        {
            InitializeComponent();
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

        private void btnBuscarPorNombre_Click(object sender, EventArgs e)
        {
            // Validación de campos
            if (tbNombre.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            String nombre = tbNombre.Text;
            MostrarAlumnos(nAlumno.BuscarPorNombre(nombre));
        }

        private void btnOrdenarPorNotaFinalPC2_Click(object sender, EventArgs e)
        {
            MostrarAlumnos(nAlumno.OrdenarPorNotaFinalPC2());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
