using System.Collections.Generic;

namespace Lab06
{
    internal class AlbumController
    {
        private static List<Album> albumes = new List<Album>();

        public static List<Album> Listar()
        {
            return albumes;
        }

        public bool Registrar(Album album)
        {
            // Verificación de código
            bool existe = albumes.Exists(alb => alb.Codigo.Equals(album.Codigo));
            if (existe)
            {
                return false;
            }
            else
            {
                albumes.Add(album);
                return true;
            }
        }
    }
}
