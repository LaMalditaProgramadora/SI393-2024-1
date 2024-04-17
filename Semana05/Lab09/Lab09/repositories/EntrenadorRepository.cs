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

        public void Registrar(Entrenador entrenador)
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
                entrenadores.Where(e => e.Pokemons.Exists(p => p.Nombre.Contains(nombrePokemon))).ToList();
            return entrenadoresTemp;
        }

        public List<Entrenador> ListarPorMenorCantidadPokemon()
        {
            List<Entrenador> entrenadoresTemp = new List<Entrenador>();
            int menorCantidadPokemons = 999;

            foreach (Entrenador entrenador in entrenadores)
            {
                List<Pokemon> pokemons = entrenador.Pokemons;
                int cantPokemon = pokemons.Count;

                if (cantPokemon < menorCantidadPokemons)
                {
                    menorCantidadPokemons = cantPokemon;
                    entrenadoresTemp.Clear();
                    entrenadoresTemp.Add(entrenador);
                }
                else if (cantPokemon == menorCantidadPokemons)
                {
                    entrenadoresTemp.Add(entrenador);
                }
            }
            return entrenadoresTemp;
        }

        public List<Entrenador> ListarPorMaxPuntosSaludPokemon()
        {
            List<Entrenador> entrenadoresTemp = new List<Entrenador>();
            int maxPuntosSaludTotal = 0;

            foreach (Entrenador entrenador in entrenadores)
            {
                List<Pokemon> pokemons = entrenador.Pokemons;

                if (pokemons.Count != 0)
                {
                    int maxPuntosSaludParaEntrenador = pokemons.Max(p => p.PuntosSalud);

                    if (maxPuntosSaludParaEntrenador > maxPuntosSaludTotal)
                    {
                        maxPuntosSaludTotal = maxPuntosSaludParaEntrenador;
                        entrenadoresTemp.Clear();
                        entrenadoresTemp.Add(entrenador);
                    }
                    else if (maxPuntosSaludParaEntrenador == maxPuntosSaludTotal)
                    {
                        entrenadoresTemp.Add(entrenador);
                    }
                }
            }
            return entrenadoresTemp;
        }
    }
}
