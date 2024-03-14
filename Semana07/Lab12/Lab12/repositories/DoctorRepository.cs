using Lab12.entities;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Drawing;

namespace Lab12.repositories
{
    internal class DoctorRepository
    {
        private static List<Doctor> doctores = new List<Doctor>();

        public DoctorRepository() { }

        public bool Existe(String NroColegiatura)
        {
            return doctores.Exists(doctor => doctor.NroColegiatura.Equals(NroColegiatura));
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
            int maxEdad = doctores.Max(
                    // if
                    d => d.Pacientes.Count == 0
                    // primera opción (Si el doctor no tiene pacientes)
                    ? 0
                    // segunda opción (Aquí hallamos la máxima edad)
                    : d.Pacientes.Max(p => p.Edad));

            // Buscar los doctores con los pacientes con más edad
            doctoresTemp = doctores.Where(d => d.Pacientes.Exists(p => p.Edad == maxEdad)).ToList();
            return doctoresTemp;
        }

        public List<Doctor> ListarDoctoresConMenosPacientes()
        {
            List<Doctor> doctoresTemp = new List<Doctor>();
            int menorCantPacientes =
                    // if
                    doctores.Count == 0
                    // primera opción (Si no hay doctores)
                    ? 0
                    // segunda opción (Aquí hallamos la menor cantidad de pacientes)
                    : doctores.Min(d => d.Pacientes.Count);

            // Buscar los doctores con los pacientes con más edad
            doctoresTemp = doctores.Where(d => d.Pacientes.Count == menorCantPacientes).ToList();
            return doctoresTemp;
        }
    }
}
