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
            if (pokemonRepository.Existe(pokemon.Codigo))
            {
                return false;
            }
            else
            {
                pokemonRepository.Registrar(codigoEntrenador, pokemon);
                return true;
            }
        }

        public List<Pokemon> ListarTodoPorEntrenador(String codigoEntrenador)
        {
            return pokemonRepository.ListarTodo(codigoEntrenador);
        }

        public List<Pokemon> ListarLegendarios()
        {
            return pokemonRepository.ListarLegendarios();
        }

        public List<Pokemon> ListarPorEdadEntrenadores(int edadMin, int edadMax)
        {
            return pokemonRepository.ListarPorEdadEntrenadores(edadMin, edadMax);
        }
    }
}
