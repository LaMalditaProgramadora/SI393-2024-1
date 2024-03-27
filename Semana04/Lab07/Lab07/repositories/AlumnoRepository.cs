using Lab07.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07.repositories
{
    class AlumnoRepository
    {
        private static List<Alumno> alumnos = new List<Alumno>();

        public bool Existe(String codigo)
        {
            return alumnos.Exists(a => a.Codigo.Equals(codigo));
        }

        public void Registrar(Alumno alumno)
        {
            alumnos.Add(alumno);
        }

        public static List<Alumno> ListarTodo()
        {
            return alumnos;
        }

        public void Eliminar(String codigo)
        {
            alumnos.RemoveAll(alumno => alumno.Codigo.Equals(codigo));
        }
    }
}
