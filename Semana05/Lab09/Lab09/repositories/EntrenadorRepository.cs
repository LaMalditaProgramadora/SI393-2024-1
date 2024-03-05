using Lab09.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09.repositories
{
    internal class EntrenadorRepository
    {
        private static List<Entrenador> entrenadores = new List<Entrenador>();

        public EntrenadorRepository() { }

        public void Insertar(Entrenador entrenador)
        {
            entrenadores.Add(entrenador);
        }

        public static List<Entrenador> ListarTodo()
        {
            return entrenadores;
        }

        public bool Existe(String codigo)
        {
            return entrenadores.Exists(en => en.Codigo.Equals(codigo));
        }

        public List<Entrenador> ListarPorRegion(String region)
        {
            return entrenadores.FindAll(en => en.Region.Equals(region));
        }

        public List<Entrenador> ListarPorNombrePokemon(String nombrePokemon)
        {
            List<Entrenador> entrenadoresTemp =
                entrenadores.Where(e => e.Pokemons.Any(p => p.Nombre.Equals(nombrePokemon))).ToList();
            return entrenadoresTemp;
        }

        public List<Entrenador> ListarPorMenorCantidadPokemon()
        {
            int menorCantidadPokemons =
                entrenadores.Count == 0
                ? 0
                : entrenadores.Min(e => e.Pokemons.Count);

            List<Entrenador> entrenadoresTemp =
               entrenadores.Where(e => e.Pokemons.Count == menorCantidadPokemons).ToList();
            return entrenadoresTemp;
        }
    }
}
