using Lab06.entities;
using Lab06.repositories;
using System.Collections.Generic;
using System;

namespace Lab06.services
{
    internal class AlbumService
    {
        private AlbumRepository albumRepository = new AlbumRepository();

        public bool Registrar(Album album)
        {
            if (albumRepository.Existe(album.Codigo))
            {
                return false;
            }
            else
            {
                albumRepository.Registrar(album);
                return true;
            }
        }

        public List<Album> ListarTodo()
        {
            return AlbumRepository.ListarTodo();
        }

        public List<Album> ListarAlbumesConMasHeroes()
        {
            return albumRepository.ListarAlbumesConMasHeroes();
        }

        public List<Album> BuscarAlbumesQueTenganHeroe(String codigoHeroe)
        {
            return albumRepository.BuscarAlbumesQueTenganHeroe(codigoHeroe);
        }
    }
}
