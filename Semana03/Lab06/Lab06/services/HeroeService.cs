using Lab06.entities;
using Lab06.repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab06.services
{
    internal class HeroeService
    {
        private HeroeRepository heroeRepository = new HeroeRepository();

        public bool Registrar(String codigoAlbum, Heroe heroe)
        {
            if (heroeRepository.Existe(codigoAlbum, heroe.Codigo))
            {
                return false;
            }
            else
            {
                heroeRepository.Registrar(codigoAlbum, heroe);
                return true;
            }
        }

        public List<Heroe> ListarTodo(String codigoAlbum)
        {
            return heroeRepository.ListarTodo(codigoAlbum);
        }

        public List<Heroe> ListarHeroesMayorPoder(String codigoAlbum)
        {
            return heroeRepository.ListarHeroesMayorPoder(codigoAlbum);
        }

        public List<Heroe> ListarHeroesMenorPoder(String codigoAlbum)
        {
            return heroeRepository.ListarHeroesMenorPoder(codigoAlbum);
        }
    }
}
