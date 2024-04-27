using Lab10.entities;
using Lab10.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10.services
{
    class RutaService
    {
        private RutaRepository rutaRepository = new RutaRepository();

        public bool Registrar(String matricula, Ruta ruta)
        {
            if (rutaRepository.Existe(ruta.Codigo))
            {
                return false;
            }
            else
            {
                rutaRepository.Registrar(matricula, ruta);
                return true;
            }
        }

        public List<Ruta> ListarTodo(String matricula)
        {
            return rutaRepository.ListarTodo(matricula);
        }

        public List<Ruta> ListarRutasPorConductorBus(String conductor)
        {
            return rutaRepository.ListarRutasPorConductorBus(conductor);
        }
    }
}
