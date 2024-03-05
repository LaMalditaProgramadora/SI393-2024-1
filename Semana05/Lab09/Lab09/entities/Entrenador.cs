using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09.entities
{
    internal class Entrenador
    {
        public Entrenador() { }
        public String Codigo { get; set; }
        public String Nombre { get; set; }
        public int Edad { get; set; }
        public String Region { get; set; }
        public List<Pokemon> Pokemons { get; set; }
    }
}
