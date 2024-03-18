using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05.entities
{
    internal class Electrodomestico
    {
        public Electrodomestico() { }
        public String Codigo { get; set; }
        public String Nombre { get; set; }
        public int Stock { get; set; }
        public double Precio { get; set; }
    }
}
