using Lab04.entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04.controllers
{
    internal class AlumnoController
    {
        private Alumno[] alumnos = new Alumno[100];
        private int cont = 0;

        public Alumno[] ListarTodo()
        {
            return alumnos;
        }

        public void Registrar(Alumno alumno)
        {
            alumnos[cont] = alumno;
            cont++;
        }

        public void Eliminar(String codigo)
        {
            int pos = Array.FindIndex(alumnos, alumno => alumno.Codigo.Equals(codigo));

            // Lógica de eliminación
            for(int i = 0; i < cont ; i++)
            {
                if (i >= pos)
                {
                    alumnos[i] = alumnos[i + 1];
                }
            }
            cont--;
        }

        public Alumno[] BuscarPorCodigo(String codigo)
        {
            return Array.FindAll(alumnos, alumno => alumno != null && alumno.Codigo.Contains(codigo));
        }

        private class MetodoComparacion : IComparer
        {
            int IComparer.Compare(object x, object y)
            {
                // Validar nulos
                if (x == null || y == null)
                {
                    return 1;
                }

                double promedio1 = ((Alumno)x).Promedio;
                double promedio2 = ((Alumno)y).Promedio;

                if (promedio1 < promedio2) return 1;
                else return -1;
            }
        }

        public Alumno[] Ordenar()
        {
            Array.Sort(alumnos, 0, cont, new MetodoComparacion());
            return alumnos;
        }
    }
}
