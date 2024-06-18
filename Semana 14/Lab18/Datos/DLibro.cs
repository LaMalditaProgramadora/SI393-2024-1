using System;
using System.Collections.Generic;
using System.Linq;

namespace Datos
{
    public class DLibro
    {
        public String Registrar(Libro libro)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Libro.Add(libro);
                    context.SaveChanges();
                }
                return "Registrado correctamente";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return ex.Message;
            }
        }

        public String Modificar(Libro libro)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Libro libroTemp = context.Libro.Find(libro.LibroId);
                    libroTemp.Titulo = libro.Titulo;
                    libroTemp.Genero = libro.Genero;
                    libroTemp.NroPaginas = libro.NroPaginas;
                    context.SaveChanges();
                }
                return "Modificado correctamente";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return ex.Message;
            }
        }

        // Eliminado Lógico
        public String Eliminar(int libroId)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Libro libroTemp = context.Libro.Find(libroId);
                    libroTemp.Eliminado = true;
                    context.SaveChanges();
                }
                return "Eliminado correctamente";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return ex.Message;
            }
        }

        public List<Libro> ListarTodo()
        {
            List<Libro> libros = new List<Libro>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    libros = context.Libro.Where(l =>
                        l.Eliminado == false &&
                        l.Autor.Eliminado == false &&
                        l.Editorial.Eliminado == false).ToList();
                }
                return libros;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return libros;
            }
        }

        public List<Libro> BuscarLibrosConAutoresConMasDe5AñosDeExp()
        {
            List<Libro> libros = new List<Libro>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    libros = context.Libro.Where(l =>
                        l.Eliminado == false &&
                        l.Autor.Eliminado == false &&
                        l.Editorial.Eliminado == false &&
                        l.Autor.AniosExperiencia > 5).ToList();
                }
                return libros;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return libros;
            }
        }

        public List<Libro> BuscarLibrosPorNombreDeEditorial(String nombreEditorial)
        {
            List<Libro> libros = new List<Libro>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    libros = context.Libro.Where(l =>
                        l.Eliminado == false &&
                        l.Autor.Eliminado == false &&
                        l.Editorial.Eliminado == false &&
                        l.Editorial.Nombre.Contains(nombreEditorial)).ToList();
                }
                return libros;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return libros;
            }
        }

        public double ObtenerPromedioDeNroPaginasDeLibrosDelGeneroTerror()
        {
            double promedio = 0;
            try
            {
                using (var context = new BDEFEntities())
                {
                    promedio = context.Libro.Where(l =>
                        l.Eliminado == false &&
                        l.Autor.Eliminado == false &&
                        l.Editorial.Eliminado == false &&
                        l.Genero.Equals("Terror")).Average(l => l.NroPaginas);
                }
                return promedio;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return promedio;
            }
        }
    }
}
