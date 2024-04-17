using Lab09.entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab09.repositories
{
    internal class PokemonRepository
    {
        public bool Existe(String codigoPokemon)
        {
            List<Entrenador> entrenadores = EntrenadorRepository.ListarTodo();
            return entrenadores.Exists(e => e.Pokemons.Exists(p => p.Codigo.Equals(codigoPokemon)));
        }

        public void Registrar(String codigoEntrenador, Pokemon pokemon)
        {
            List<Entrenador> entrenadores = EntrenadorRepository.ListarTodo();
            Entrenador entrenador = entrenadores.Find(en => en.Codigo.Equals(codigoEntrenador));

            entrenador.Pokemons.Add(pokemon);
        }

        public List<Pokemon> ListarTodo(String codigoEntrenador)
        {
            List<Entrenador> entrenadores = EntrenadorRepository.ListarTodo();
            Entrenador entrenador = entrenadores.Find(en => en.Codigo.Equals(codigoEntrenador));

            return entrenador.Pokemons;
        }

        public List<Pokemon> ListarLegendarios()
        {
            List<Entrenador> entrenadores = EntrenadorRepository.ListarTodo();
            List<Pokemon> pokemonsTemp = new List<Pokemon>();

            foreach(Entrenador entrenador in entrenadores)
            {
                List<Pokemon> pokemons = entrenador.Pokemons;
                pokemons = pokemons.Where(p => p.Legendario == true).ToList();
                pokemonsTemp.AddRange(pokemons);
            }
            return pokemonsTemp;
        }

        public List<Pokemon> ListarPorEdadEntrenadores(int edadMin, int edadMax)
        {
            List<Entrenador> entrenadores = EntrenadorRepository.ListarTodo();
            List<Pokemon> pokemonsTemp = new List<Pokemon>();
            entrenadores = entrenadores.Where(e => e.Edad >= edadMin && e.Edad <= edadMax).ToList();

            foreach (Entrenador entrenador in entrenadores)
            {
                List<Pokemon> pokemons = entrenador.Pokemons;
                pokemonsTemp.AddRange(pokemons);
            }
            return pokemonsTemp;
        }
    }
}
