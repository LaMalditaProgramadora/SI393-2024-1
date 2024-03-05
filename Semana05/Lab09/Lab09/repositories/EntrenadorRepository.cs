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
            List<Entrenador> entrenadoresTemp = new List<Entrenador>();
            foreach (Entrenador en in entrenadores)
            {
                bool existe = en.Pokemons.Exists(po => po.Nombre.Equals(nombrePokemon));
                if (existe)
                {
                    entrenadoresTemp.Add(en);
                }
            }

            if (entrenadoresTemp != null)
            {
                return entrenadoresTemp;
            }
            else
            {
                return new List<Entrenador>();
            }
        }

        public List<Entrenador> ListarPorMenorCantidadPokemon()
        {
            List<Entrenador> entrenadoresTemp = new List<Entrenador>();
            int minPokemons = 6;
            foreach (Entrenador en in entrenadores)
            {
                if (en.Pokemons.Count < minPokemons)
                {
                    minPokemons = en.Pokemons.Count;
                    entrenadoresTemp.Clear();
                    entrenadoresTemp.Add(en);
                }
                else if (en.Pokemons.Count == minPokemons)
                {
                    entrenadoresTemp.Add(en);
                }
            }

            if (entrenadoresTemp != null)
            {
                return entrenadoresTemp;
            }
            else
            {
                return new List<Entrenador>();
            }
        }
    }
}
