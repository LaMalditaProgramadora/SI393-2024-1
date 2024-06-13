using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DVideojuego
    {
        public String Registrar(Videojuego videojuego)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Videojuego.Add(videojuego);
                    context.SaveChanges();
                }
                return "Registrado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Modificar(Videojuego videojuego)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Videojuego videojuegoTemp = context.Videojuego.Find(videojuego.Id_Videojuego);
                    videojuegoTemp.Titulo = videojuego.Titulo;
                    videojuegoTemp.Valoracion = videojuego.Valoracion;
                    context.SaveChanges();
                }
                return "Modificado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Eliminar(int id_Videojuego)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Videojuego videojuegoTemp = context.Videojuego.Find(id_Videojuego);
                    context.Videojuego.Remove(videojuegoTemp);
                    context.SaveChanges();
                }
                return "Eliminado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Videojuego> ListarTodo(int id_desarrollador)
        {
            List<Videojuego> videojuegos = new List<Videojuego>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    // Solución error en DatagriView
                    context.Configuration.LazyLoadingEnabled = false;
                    videojuegos = context.Videojuego.Where(v => v.Id_Desarrollador == id_desarrollador).ToList();
                }
                return videojuegos;
            }
            catch (Exception ex)
            {
                return videojuegos;
            }
        }

        public Decimal ObtenerMayorValoracionPorDesarrollador(int id_desarrollador)
        {
            Decimal mayorValoracion = 0;
            try
            {
                using (var context = new BDEFEntities())
                {
                    mayorValoracion = context.Videojuego.Where(v => v.Id_Desarrollador == id_desarrollador).Max(v => v.Valoracion).Value;
                }
                return mayorValoracion;
            }
            catch (Exception ex)
            {
                return mayorValoracion;
            }
        }

        public List<Videojuego> BuscarPorNombreDesarrollador(String nombre)
        {
            List<Videojuego> videojuegos = new List<Videojuego>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    // Solución error en DatagriView
                    context.Configuration.LazyLoadingEnabled = false;
                    videojuegos = context.Videojuego.Where(v => v.Desarrollador.Nombre.Contains(nombre)).ToList();
                }
                return videojuegos;
            }
            catch (Exception ex)
            {
                return videojuegos;
            }
        }
    }
}
