using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10.entities
{
    class Bus
    {
        public Bus() { }
        public String Matricula { get; set; }
        public String Tipo { get; set; }
        public String Conductor { get; set; }
        public List<Ruta> Rutas { get; set; }
    }
}
