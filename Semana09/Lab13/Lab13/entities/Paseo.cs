using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13.entities
{
    class Paseo
    {
        public Paseo() { }
        public String CodigoPerro { get; set; }
        public String NombrePerro { get; set; }
        public String TamañoPerro { get; set; }
        public String ObjetivoPaseo { get; set; }
        public double PrecioCobrado { get; set; }
        public DateTime Fecha { get; set; }
        public String Turno { get; set; }
    }
}
