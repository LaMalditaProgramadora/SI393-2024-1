using Lab12.entities;
using Lab12.services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab12
{
    public partial class FormPaciente : Form
    {
        private PacienteService pacienteService = new PacienteService();
        private String nroColegiatura;

        public FormPaciente(String nroColegiatura)
        {
            InitializeComponent();
            this.nroColegiatura = nroColegiatura;
            MostrarPacientes(pacienteService.ListarTodo(nroColegiatura));
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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validación de campos
            if (tbDni.Text == "" || tbNombreCompleto.Text == "" || tbEdad.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // Creación del objeto
            Paciente paciente = new Paciente()
            {
                Dni = tbDni.Text,
                NombreCompleto = tbNombreCompleto.Text,
                Edad = int.Parse(tbEdad.Text)
            };

            // Registro de paciente
            bool registrado = pacienteService.Registrar(nroColegiatura, paciente);
            if (!registrado)
            {
                MessageBox.Show("Ingrese un dni diferente");
                return;
            }

            // Mostrar
            MostrarPacientes(pacienteService.ListarTodo(nroColegiatura));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
