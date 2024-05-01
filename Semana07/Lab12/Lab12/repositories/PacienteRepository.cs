using Lab12.entities;
using System.Collections.Generic;
using System;
using System.Linq;

namespace Lab12.repositories
{
    internal class PacienteRepository
    {
        public bool Existe(String dni)
        {
            List<Doctor> doctores = DoctorRepository.ListarTodo();
            return doctores.Exists(d => d.Pacientes.Exists(p => p.Dni.Equals(dni)));
        }

        public void Registrar(String nroColegiatura, Paciente paciente)
        {
            List<Doctor> doctores = DoctorRepository.ListarTodo();
            Doctor doctor = doctores.Find(en => en.NroColegiatura.Equals(nroColegiatura));
            doctor.Pacientes.Add(paciente);
        }

        public List<Paciente> ListarTodo(String nroColegiatura)
        {
            List<Doctor> doctores = DoctorRepository.ListarTodo();
            Doctor doctor = doctores.Find(en => en.NroColegiatura.Equals(nroColegiatura));
            return doctor.Pacientes;
        }

        public List<Paciente> ListarPacientesPorEspecialidadDoctor(String especialidad)
        {
            List<Doctor> doctores = DoctorRepository.ListarTodo();
            doctores = doctores.Where(d => d.Especialidad.Equals(especialidad)).ToList();
            List<Paciente> pacientesTemp = new List<Paciente>();

            foreach (Doctor doctor in doctores)
            {
                pacientesTemp.AddRange(doctor.Pacientes);
            }
            return pacientesTemp;
        }
    }
}
