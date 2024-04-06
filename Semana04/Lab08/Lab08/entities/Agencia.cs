using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08.entities
{
    class Agencia
    {
        public Agencia() { }
        public String Codigo { get; set; }
        public String Direccion { get; set; }
        public String Ciudad { get; set; }
        public String Telefono { get; set; }
        public List<Inmueble> Inmuebles { get; set; }
    }
}
