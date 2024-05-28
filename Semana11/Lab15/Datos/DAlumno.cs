using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DAlumno
    {
        public String Registrar(Alumno alumno)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Alumno.Add(alumno);
                    context.SaveChanges();
                }
                return "Registrado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Modificar(Alumno alumno)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Alumno alumnoTemp = context.Alumno.Find(alumno.Id);
                    alumnoTemp.NombreCompleto = alumno.NombreCompleto;
                    alumnoTemp.PromedioTA = alumno.PromedioTA;
                    alumnoTemp.PC2 = alumno.PC2;
                    alumnoTemp.NotaFinalPC2 = alumno.NotaFinalPC2;
                    context.SaveChanges();
                }
                return "Modificado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        // Eliminar Físico
        public String Eliminar(int id)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Alumno alumnoTemp = context.Alumno.Find(id);
                    context.Alumno.Remove(alumnoTemp);
                    context.SaveChanges();
                }
                return "Eliminado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        // Eliminar Lógico
        public String EliminarLogico(int id)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    Alumno alumnoTemp = context.Alumno.Find(id);
                    alumnoTemp.Estado = "I";
                    context.SaveChanges();
                }
                return "Eliminado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Alumno> ListarTodo()
        {
            List<Alumno> alumnos = new List<Alumno>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    alumnos = context.Alumno.ToList();
                }
                return alumnos;
            }
            catch (Exception ex)
            {
                return alumnos;
            }
        }

        public List<Alumno> ListarTodoActivo()
        {
            List<Alumno> alumnos = new List<Alumno>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    alumnos = context.Alumno.Where(a => a.Estado.Equals("A")).ToList();
                }
                return alumnos;
            }
            catch (Exception ex)
            {
                return alumnos;
            }
        }

        public List<Alumno> OrdenarPorNotaFinalPC2()
        {
            List<Alumno> alumnos = new List<Alumno>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    alumnos = context.Alumno.OrderBy(a => a.NotaFinalPC2).ToList();
                }
                return alumnos;
            }
            catch (Exception ex)
            {
                return alumnos;
            }
        }


        public List<Alumno> BuscarPorNombre(String nombre)
        {
            List<Alumno> alumnos = new List<Alumno>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    alumnos = context.Alumno.Where(a => a.NombreCompleto.Contains(nombre)).ToList();
                }
                return alumnos;
            }
            catch (Exception ex)
            {
                return alumnos;
            }
        }
    }
}
