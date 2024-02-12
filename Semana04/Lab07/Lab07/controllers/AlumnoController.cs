using Lab07.entities;
using System;
using System.Collections.Generic;

namespace Lab07.controllers
{
    internal class AlumnoController
    {
        private static List<Alumno> alumnos = new List<Alumno>();

        public static List<Alumno> Listar()
        {
            return alumnos;
        }

        public bool Registrar(Alumno alumno)
        {
            // Verificación de código
            bool existe = alumnos.Exists(alb => alb.Codigo.Equals(alumno.Codigo));
            if (existe)
            {
                return false;
            }
            else
            {
                alumnos.Add(alumno);
                return true;
            }
        }

        public void Eliminar(String codigo)
        {
            alumnos.RemoveAll(alumno => alumno.Codigo.Equals(codigo));
        }

    }
}
