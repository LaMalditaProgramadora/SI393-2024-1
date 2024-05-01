using Lab12.entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab12.repositories
{
    internal class DoctorRepository
    {
        private static List<Doctor> doctores = new List<Doctor>();

        public bool Existe(String nroColegiatura)
        {
            return doctores.Exists(doctor => doctor.NroColegiatura.Equals(nroColegiatura));
        }

        public void Registrar(Doctor doctor)
        {
            doctores.Add(doctor);
        }

        public static List<Doctor> ListarTodo()
        {
            return doctores;
        }

        public List<Doctor> ListarDoctoresConPacientesConMasEdad()
        {
            List<Doctor> doctoresTemp = new List<Doctor>();
            int mayorEdadPacienteTotal = int.MinValue;
            foreach (Doctor doctor in doctores)
            {
                List<Paciente> pacientes = doctor.Pacientes;
                if (pacientes.Count != 0)
                {
                    int mayorEdadPacientePorDoctor = pacientes.Max(pa => pa.Edad);
                    if (mayorEdadPacientePorDoctor > mayorEdadPacienteTotal)
                    {
                        mayorEdadPacienteTotal = mayorEdadPacientePorDoctor;
                        doctoresTemp.Clear();
                        doctoresTemp.Add(doctor);
                    }
                    else if (mayorEdadPacientePorDoctor == mayorEdadPacienteTotal)
                    {
                        doctoresTemp.Add(doctor);
                    }
                }
            }
            return doctoresTemp;
        }

        public List<Doctor> ListarDoctoresConMenosPacientes()
        {
            List<Doctor> doctoresTemp = new List<Doctor>();
            int menorCantidadPacientesTotal = int.MaxValue;
            foreach (Doctor doctor in doctores)
            {
                List<Paciente> pacientes = doctor.Pacientes;
                int cantidadPacientesPorDoctor = pacientes.Count;
                if (cantidadPacientesPorDoctor < menorCantidadPacientesTotal)
                {
                    menorCantidadPacientesTotal = cantidadPacientesPorDoctor;
                    doctoresTemp.Clear();
                    doctoresTemp.Add(doctor);
                }
                else if (cantidadPacientesPorDoctor == menorCantidadPacientesTotal)
                {
                    doctoresTemp.Add(doctor);
                }
            }
            return doctoresTemp;
        }
    }
}
