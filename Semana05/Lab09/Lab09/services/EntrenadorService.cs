using Lab09.entities;
using Lab09.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09.services
{
    internal class EntrenadorService
    {
        private EntrenadorRepository entrenadorRepository = new EntrenadorRepository();

        public bool Insertar(Entrenador en)
        {
            if (!entrenadorRepository.Existe(en.Codigo))
            {
                entrenadorRepository.Insertar(en);
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Entrenador> ListarTodo()
        {
            return EntrenadorRepository.ListarTodo();
        }

        public List<Entrenador> ListarPorRegion(String region)
        {
            return entrenadorRepository.ListarPorRegion(region);
        }

        public List<Entrenador> ListarPorNombrePokemon(String nombrePokemon)
        {
            return entrenadorRepository.ListarPorNombrePokemon(nombrePokemon);
        }
        public List<Entrenador> ListarPorMenorCantidadPokemon()
        {
            return entrenadorRepository.ListarPorMenorCantidadPokemon();
        }
    }
}
