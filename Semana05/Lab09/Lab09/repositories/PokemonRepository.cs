using Lab09.entities;
using System;
using System.Collections.Generic;

namespace Lab09.repositories
{
    internal class PokemonRepository
    {
        public bool Existe(String codigoPokemon)
        {
            foreach (Entrenador en in EntrenadorRepository.ListarTodo())
            {
                bool existe = en.Pokemons.Exists(po => po.Codigo.Equals(codigoPokemon));
                if (existe) return true;
            }
            return false;
        }

        public void Insertar(String codigoEntrenador, Pokemon pokemon)
        {
            Entrenador entrenadorEncontrado =
                EntrenadorRepository.ListarTodo().Find(en => en.Codigo.Equals(codigoEntrenador));
            if (entrenadorEncontrado != null)
            {
                entrenadorEncontrado.Pokemons.Add(pokemon);
            }
        }

        public List<Pokemon> ListarTodo(String codigoEntrenador)
        {
            Entrenador entrenadorEncontrado =
                    EntrenadorRepository.ListarTodo().Find(en => en.Codigo.Equals(codigoEntrenador));
            if (entrenadorEncontrado != null)
            {
                return entrenadorEncontrado.Pokemons;
            }
            else
            {
                return new List<Pokemon>();
            }
        }
    }
}
