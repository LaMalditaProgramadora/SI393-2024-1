using Lab12.entities;
using Lab12.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab12
{
    public partial class FormReporte : Form
    {
        private DoctorService doctorService = new DoctorService();
        private PacienteService pacienteService = new PacienteService();

        public FormReporte()
        {
            InitializeComponent();
        }

        private void MostrarDoctoresEnDataGrid(List<Doctor> doctores)
        {
            if (doctores.Count == 0)
            {
                dgDoctores.DataSource = null;
                return;
            }
            dgDoctores.DataSource = null;
            dgDoctores.DataSource = doctores;
        }

        private void MostrarPacientesEnDataGrid(List<Paciente> pacientes)
        {
            if (pacientes.Count == 0)
            {
                dgPacientes.DataSource = null;
                return;
            }
            dgPacientes.DataSource = null;
            dgPacientes.DataSource = pacientes;
        }

        private void btnBuscarDoctoresConPacientesConMayorEdad_Click(object sender, EventArgs e)
        {
            MostrarDoctoresEnDataGrid(doctorService.ListarDoctoresConPacientesConMasEdad());
        }

        private void btnBuscarDoctoresConMenosPacientes_Click(object sender, EventArgs e)
        {
            MostrarDoctoresEnDataGrid(doctorService.ListarDoctoresConMenosPacientes());
        }

        private void btnBuscarPacientesPorEspecialidadDelDoctor_Click(object sender, EventArgs e)
        {
            // Validación de campos
            if (tbEspecialidad.Text == "")
            {
                MessageBox.Show("Ingrese especialidad");
                return;
            }

            MostrarPacientesEnDataGrid(pacienteService.ListarPacientesPorEspecialidadDoctor(tbEspecialidad.Text));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
