using Lab13.entities;
using Lab13.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13.services
{
    class PaseadorService
    {
        private PaseadorRepository paseadorRepository = new PaseadorRepository();

        public bool Registrar(Paseador paseador)
        {
            if (paseadorRepository.Existe(paseador.DNI))
            {
                return false;
            }
            else
            {
                paseadorRepository.Registrar(paseador);
                return true;
            }
        }

        public List<Paseador> ListarTodo()
        {
            return PaseadorRepository.ListarTodo();
        }
    }
}
