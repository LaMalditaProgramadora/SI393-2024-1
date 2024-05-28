using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NAlumno
    {
        private DAlumno dAlumno = new DAlumno();

        public String Registrar(Alumno alumno)
        {
            alumno.NotaFinalPC2 = alumno.PromedioTA * (decimal)0.2 + alumno.PC2 * (decimal)0.8;
            alumno.Estado = "A";
            return dAlumno.Registrar(alumno);
        }

        public String Modificar(Alumno alumno)
        {
            alumno.NotaFinalPC2 = alumno.PromedioTA * (decimal)0.2 + alumno.PC2 * (decimal)0.8;
            return dAlumno.Modificar(alumno);
        }

        public String Eliminar(int id)
        {
            return dAlumno.Eliminar(id);
            //return dAlumno.EliminarLogico(id);
        }

        public List<Alumno> ListarTodo()
        {
            return dAlumno.ListarTodo();
            //return dAlumno.ListarTodoActivo();
        }

        public List<Alumno> OrdenarPorNotaFinalPC2()
        {
            return dAlumno.OrdenarPorNotaFinalPC2();
        }

        public List<Alumno> BuscarPorNombre(String nombre)
        {
            return dAlumno.BuscarPorNombre(nombre);
        }
    }
}
