using Lab06.entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab06.repositories
{
    internal class HeroeRepository
    {
        public bool Existe(String codigoAlbum, String codigoHeroe)
        {
            List<Album> albumes = AlbumRepository.ListarTodo();
            // Encontrar el álbum
            Album album = albumes.Find(a => a.Codigo.Equals(codigoAlbum));
            return album.Heroes.Exists(h => h.Codigo.Equals(codigoHeroe));
        }

        public void Registrar(String codigoAlbum, Heroe heroe)
        {
            List<Album> albumes = AlbumRepository.ListarTodo();
            // Encontrar el álbum
            Album album = albumes.Find(a => a.Codigo.Equals(codigoAlbum));
            album.Heroes.Add(heroe);
        }

        public List<Heroe> ListarTodo(String codigoAlbum)
        {
            List<Album> albumes = AlbumRepository.ListarTodo();
            // Encontrar el álbum
            Album album = albumes.Find(a => a.Codigo.Equals(codigoAlbum));
            return album.Heroes;
        }

        public List<Heroe> ListarHeroesMayorPoder(String codigoAlbum)
        {
            List<Album> albumes = AlbumRepository.ListarTodo();
            // Encontrar el álbum
            Album album = albumes.Find(a => a.Codigo.Equals(codigoAlbum));

            if (album.Heroes.Count == 0) return new List<Heroe>();

            double mayorPoder = album.Heroes.Max(h => h.Poder);
            return album.Heroes.Where(h => h.Poder == mayorPoder).ToList();
        }

        public List<Heroe> ListarHeroesMenorPoder(String codigoAlbum)
        {
            List<Album> albumes = AlbumRepository.ListarTodo();

            // Encontrar el álbum
            Album album = albumes.Find(a => a.Codigo.Equals(codigoAlbum));

            if (album.Heroes.Count == 0) return new List<Heroe>();

            double menorPoder = album.Heroes.Min(h => h.Poder);
            return album.Heroes.Where(h => h.Poder == menorPoder).ToList();
        }
    }
}
