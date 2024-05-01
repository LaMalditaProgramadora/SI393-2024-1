using Lab12.entities;
using Lab12.services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab12
{
    public partial class FormReporte : Form
    {
        private DoctorService doctorService = new DoctorService();
        private PacienteService pacienteService = new PacienteService();
        private ReporteService reporteService = new ReporteService();

        public FormReporte()
        {
            InitializeComponent();
        }

        private void MostrarDoctores(List<Doctor> doctores)
        {
            dgDoctores.DataSource = null;
            if (doctores.Count == 0)
            {
                return;
            }
            else
            {
                dgDoctores.DataSource = doctores;
            }
        }

        private void MostrarPacientes(List<Paciente> pacientes)
        {
            dgPacientes.DataSource = null;
            if (pacientes.Count == 0)
            {
                return;
            }
            else
            {
                dgPacientes.DataSource = pacientes;
            }
        }

        private void MostrarReportes(List<Reporte> reportes)
        {
            dgReportes.DataSource = null;
            if (reportes.Count == 0)
            {
                return;
            }
            else
            {
                dgReportes.DataSource = reportes;
            }
        }

        private void btnBuscarDoctoresConPacientesConMayorEdad_Click(object sender, EventArgs e)
        {
            MostrarDoctores(doctorService.ListarDoctoresConPacientesConMasEdad());
        }

        private void btnBuscarDoctoresConMenosPacientes_Click(object sender, EventArgs e)
        {
            MostrarDoctores(doctorService.ListarDoctoresConMenosPacientes());
        }

        private void btnBuscarPacientesPorEspecialidadDelDoctor_Click(object sender, EventArgs e)
        {
            // Validación de campos
            if (tbEspecialidad.Text == "")
            {
                MessageBox.Show("Ingrese especialidad");
                return;
            }

            MostrarPacientes(pacienteService.ListarPacientesPorEspecialidadDoctor(tbEspecialidad.Text));
        }

        private void btnBuscarEspecialidadesConMasDoctores_Click(object sender, EventArgs e)
        {
            MostrarReportes(reporteService.ListarEspecialidadesConMasDoctores());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
