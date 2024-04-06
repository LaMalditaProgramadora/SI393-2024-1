using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08.entities
{
    class Inmueble
    {
        public Inmueble() { }
        public String Codigo { get; set; }
        public String Direccion { get; set; }
        public double Superficie { get; set; }
        public double Precio { get; set; }
        public String Condicion { get; set; }
    }
}
