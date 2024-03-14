using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02.entities
{
    internal class Empleado
    {
        public Empleado() { }
        public String Nombre { get; set; }
        public String Categoria { get; set; }
        public int MinutosTardanza { get; set; }
        public int LlamadasAtencion { get; set; }
        public double Pago { get; set; }
    }
}
