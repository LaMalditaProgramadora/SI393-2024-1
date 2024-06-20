using Datos;
using System;
using System.Collections.Generic;

namespace Negocio
{
    public class NLibro
    {
        private DLibro dLibro = new DLibro();

        public String Registrar(Libro libro)
        {
            libro.Eliminado = false;
            return dLibro.Registrar(libro);
        }

        public String Modificar(Libro libro)
        {
            return dLibro.Modificar(libro);
        }

        // Eliminado Lógico
        public String Eliminar(int libroId)
        {
            return dLibro.Eliminar(libroId);
        }

        public List<Libro> ListarTodo()
        {
            return dLibro.ListarTodo();
        }

        public List<Libro> BuscarLibrosConAutoresConMasDe5AñosDeExp()
        {
            return dLibro.BuscarLibrosConAutoresConMasDe5AñosDeExp();
        }

        public List<Libro> BuscarLibrosPorNombreDeEditorial(String nombreEditorial)
        {
            return dLibro.BuscarLibrosPorNombreDeEditorial(nombreEditorial);
        }

        public double ObtenerPromedioDeNroPaginasDeLibrosDelGeneroTerror()
        {
            return dLibro.ObtenerPromedioDeNroPaginasDeLibrosDelGeneroTerror();
        }
    }
}
