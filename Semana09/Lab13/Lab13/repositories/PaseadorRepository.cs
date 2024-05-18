using Lab13.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13.repositories
{
    class PaseadorRepository
    {
        private static List<Paseador> paseadores = new List<Paseador>();

        public bool Existe(String DNI)
        {
            return paseadores.Exists(p => p.DNI.Equals(DNI));
        }

        public void Registrar(Paseador paseador)
        {
            paseadores.Add(paseador);
        }

        public static List<Paseador> ListarTodo()
        {
            return paseadores;
        }

    }
}
