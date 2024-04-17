using Lab09.entities;
using Lab09.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09.services
{
    internal class PokemonService
    {
        private PokemonRepository pokemonRepository = new PokemonRepository();

        public bool Registrar(String codigoEntrenador, Pokemon pokemon)
        {
            if (!pokemonRepository.Existe(pokemon.Codigo))
            {
                pokemonRepository.Registrar(codigoEntrenador, pokemon);
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Pokemon> ListarTodoPorEntrenador(String codigoEntrenador)
        {
            return pokemonRepository.ListarTodo(codigoEntrenador);
        }

        public List<Pokemon> BuscarLegendarios()
        {
            return pokemonRepository.BuscarLegendarios();
        }

        public List<Pokemon> BuscarPorEdadEntrenadores(int edadMin, int edadMax)
        {
            return pokemonRepository.BuscarPorEdadEntrenadores(edadMin, edadMax);
        }
    }
}
