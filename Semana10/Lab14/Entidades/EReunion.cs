using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EReunion
    {
        public EReunion() { }
        public DateTime Fecha { get; set; }
        public String Turno { get; set; }
        public String Asunto { get; set; }
    }
}
