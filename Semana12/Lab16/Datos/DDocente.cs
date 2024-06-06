using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DDocente
    {
        public String Registrar(Docente docente)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Docente.Add(docente);
                    context.SaveChanges();
                }
                return "Registrado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Modificar(Docente docente)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Docente docenteTemp = context.Docente.Find(docente.Id_docente);
                    docenteTemp.Nombre = docente.Nombre;
                    docenteTemp.Apellido = docente.Apellido;
                    docenteTemp.Escuela = docente.Escuela;
                    context.SaveChanges();
                }
                return "Modificado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Eliminar(int id_docente)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Docente docenteTemp = context.Docente.Find(id_docente);
                    context.Docente.Remove(docenteTemp);
                    context.SaveChanges();
                }
                return "Eliminado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Docente> ListarTodo()
        {
            List<Docente> docentes = new List<Docente>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    docentes = context.Docente.ToList();
                }
                return docentes;
            }
            catch (Exception ex)
            {
                return docentes;
            }
        }

        public List<Docente> BuscarPorEscuela(String escuela)
        {
            List<Docente> docentes = new List<Docente>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    docentes = context.Docente.Where(d => d.Escuela.Contains(escuela)).ToList();
                }
                return docentes;
            }
            catch (Exception ex)
            {
                return docentes;
            }
        }
    }
}
