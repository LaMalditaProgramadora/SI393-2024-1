using Lab06.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06.repositories
{
    internal class AlbumRepository
    {
        private static List<Album> albumes = new List<Album>();

        public bool Existe(String codigo)
        {
            return albumes.Exists(a => a.Codigo.Equals(codigo));
        }

        public void Registrar(Album album)
        {
            albumes.Add(album);
        }

        public static List<Album> ListarTodo()
        {
            return albumes;
        }

        public List<Album> ListarAlbumesConMasHeroes()
        {
            int mayorCantHeroes = 0;

            if (albumes.Count == 0)
            {
                mayorCantHeroes = 0;
            }
            else
            {
                mayorCantHeroes = albumes.Max(a => a.Heroes.Count);
            }

            // Buscar los álbumes
            return albumes.Where(a => a.Heroes.Count == mayorCantHeroes).ToList();
        }

        public List<Album> BuscarAlbumesQueTenganHeroe(String codigoHeroe)
        {
            return albumes.Where(a => a.Heroes.Exists(h => h.Codigo.Equals(codigoHeroe))).ToList();
        }
    }
}
