using Lab09.entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab09.repositories
{
    internal class EntrenadorRepository
    {
        private static List<Entrenador> entrenadores = new List<Entrenador>();

        public bool Existe(String codigo)
        {
            return entrenadores.Exists(en => en.Codigo.Equals(codigo));
        }

        public void Registrar(Entrenador entrenador)
        {
            entrenadores.Add(entrenador);
        }

        public static List<Entrenador> ListarTodo()
        {
            return entrenadores;
        }

        public List<Entrenador> ListarPorRegion(String region)
        {
            return entrenadores.Where(e => e.Region.Equals(region)).ToList();
        }

        public List<Entrenador> ListarPorNombrePokemon(String nombrePokemon)
        {
            return entrenadores.Where(e => e.Pokemons.Exists(p => p.Nombre.Contains(nombrePokemon))).ToList();
        }

        public List<Entrenador> ListarPorMenorCantidadPokemon()
        {
            List<Entrenador> entrenadoresTemp = new List<Entrenador>();
            int menorCantidadPokemons = 9999;

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
