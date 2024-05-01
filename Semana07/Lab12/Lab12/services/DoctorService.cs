using Lab12.entities;
using Lab12.repositories;
using System.Collections.Generic;

namespace Lab12.services
{
    internal class DoctorService
    {
        private DoctorRepository doctorRepository = new DoctorRepository();

        public bool Registrar(Doctor doctor)
        {
            if (doctorRepository.Existe(doctor.NroColegiatura))
            {
                return false;
            }
            else
            {
                doctorRepository.Registrar(doctor);
                return true;
            }
        }

        public List<Doctor> ListarTodo()
        {
            return DoctorRepository.ListarTodo();
        }

        public List<Doctor> ListarDoctoresConPacientesConMasEdad()
        {
            return doctorRepository.ListarDoctoresConPacientesConMasEdad();
        }

        public List<Doctor> ListarDoctoresConMenosPacientes()
        {
            return doctorRepository.ListarDoctoresConMenosPacientes();
        }
    }
}
