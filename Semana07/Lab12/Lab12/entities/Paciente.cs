using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12.entities
{
    internal class Paciente
    {
        public Paciente() { }
        public String Dni { get; set; }
        public String NombreCompleto { get; set; }
        public int Edad { get; set; }
    }
}
