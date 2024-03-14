﻿using Lab12.entities;
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
using System.Windows.Forms.Design;

namespace Lab12
{
    public partial class FormDoctor : Form
    {
        private DoctorService doctorService = new DoctorService();

        public FormDoctor()
        {
            InitializeComponent();
            MostrarDoctoresEnDataGrid(doctorService.ListarTodo());
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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validación de campos
            if (tbNroColegiatura.Text == "" || tbNombreCompleto.Text == "" || tbEspecialidad.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // Creación del objeto
            Doctor doctor = new Doctor()
            {
                NroColegiatura = tbNroColegiatura.Text,
                NombreCompleto = tbNombreCompleto.Text,
                Especialidad = tbEspecialidad.Text,
                // ¡Importante!
                Pacientes = new List<Paciente>()
            };

            // Registro de doctor
            bool registrado = doctorService.Registrar(doctor);
            if (!registrado)
            {
                MessageBox.Show("Ingrese un Número de Colegiatura diferente");
                return;
            }

            // Mostrar en el ListView
            MostrarDoctoresEnDataGrid(doctorService.ListarTodo());
        }

        private void btnVerPacientes_Click(object sender, EventArgs e)
        {
            if (dgDoctores.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione doctor");
                return;
            }

            String nroColegiatura = dgDoctores.SelectedRows[0].Cells[0].Value.ToString();

            FormPaciente formPaciente = new FormPaciente(nroColegiatura);
            formPaciente.Show();
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
