using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DDesarrollador
    {
        public String Registrar(Desarrollador desarrollador)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Desarrollador.Add(desarrollador);
                    context.SaveChanges();
                }
                return "Registrado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Modificar(Desarrollador desarrollador)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Desarrollador desarrolladorTemp = context.Desarrollador.Find(desarrollador.Id_Desarrollador);
                    desarrolladorTemp.Nombre = desarrollador.Nombre;
                    context.SaveChanges();
                }
                return "Modificado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Eliminar(int id_Desarrollador)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Desarrollador desarrolladorTemp = context.Desarrollador.Find(id_Desarrollador);
                    context.Desarrollador.Remove(desarrolladorTemp);
                    context.SaveChanges();
                }
                return "Eliminado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Desarrollador> ListarTodo()
        {
            List<Desarrollador> desarrolladores = new List<Desarrollador>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    // Solución error en DatagriView
                    context.Configuration.LazyLoadingEnabled = false;
                    desarrolladores = context.Desarrollador.ToList();
                }
                return desarrolladores;
            }
            catch (Exception ex)
            {
                return desarrolladores;
            }
        }

        public List<Desarrollador> BuscarPorVideojuegosQueTenganValoracionMenorA50()
        {
            List<Desarrollador> desarrolladores = new List<Desarrollador>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    // Solución error en DatagriView
                    context.Configuration.LazyLoadingEnabled = false;
                    desarrolladores = context.Desarrollador.Where(d => d.Videojuego.Any(v => v.Valoracion < 50)).ToList();
                }
                return desarrolladores;
            }
            catch (Exception ex)
            {
                return desarrolladores;
            }
        }
    }
}
