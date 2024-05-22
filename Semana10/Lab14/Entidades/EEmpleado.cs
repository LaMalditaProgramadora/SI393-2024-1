using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EEmpleado
    {
        public EEmpleado() { }
        public String Dni { get; set; }
        public String Nombre { get; set; }
        public String Puesto { get; set; }
        public double Sueldo { get; set; }
        public List<EReunion> Reuniones { get; set; }
    }
}
