using System;
using System.Collections.Generic;

namespace Lab06
{
    internal class HeroeController
    {
        public List<Heroe> ListarporAlbum(String codigoAlbum)
        {
            // Traemos los todos los álbumes
            List<Album> albumes = AlbumController.Listar();
            // Buscamos el álbum con el código correcto
            Album albumSeleccionado = albumes.Find(elemento => elemento.Codigo.Equals(codigoAlbum));
            // Hallamos la lista de héroes del álbum
            return albumSeleccionado.Heroes;
        }

        public bool Registrar(String codigoAlbum, Heroe heroe)
        {
            // Traemos los todos los álbumes
            List<Album> albumes = AlbumController.Listar();
            // Buscamos el álbum con el código correcto
            Album albumSeleccionado = albumes.Find(elemento => elemento.Codigo.Equals(codigoAlbum));
            // Hallamos la lista de héroes del álbum
            List<Heroe> heroes = albumSeleccionado.Heroes;

            // Verificación de código
            bool existe = heroes.Exists(elemento => elemento.Codigo.Equals(heroe.Codigo));
            if (existe)
            {
                return false;
            }
            else
            {
                heroes.Add(heroe);
                return true;
            }

        }
    }
}
