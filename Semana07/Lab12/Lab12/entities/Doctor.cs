using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12.entities
{
    internal class Doctor
    {
        public Doctor() { }
        public String NroColegiatura { get; set; }
        public String NombreCompleto { get; set; }
        public String Especialidad { get; set; }
        public List<Paciente> Pacientes { get; set; }
    }
}
