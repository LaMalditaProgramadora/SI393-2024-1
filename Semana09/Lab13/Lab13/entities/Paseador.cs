using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13.entities
{
    class Paseador
    {
        public Paseador() { }
        public String DNI { get; set; }
        public String Nombre { get; set; }
        public String Celular { get; set; }
        public int AñosExperiencia { get; set; }
        public List<Paseo> Paseos { get; set; }
    }
}
