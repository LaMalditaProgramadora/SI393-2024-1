using Lab07.entities;
using Lab07.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07.services
{
    class AlumnoService
    {
        private AlumnoRepository alumnoRepository = new AlumnoRepository();

        public bool Registrar(Alumno alumno)
        {
            if (alumnoRepository.Existe(alumno.Codigo))
            {
                return false;
            }
            else
            {
                alumnoRepository.Registrar(alumno);
                return true;
            }
        }

        public List<Alumno> ListarTodo()
        {
            return AlumnoRepository.ListarTodo();
        }

        public void Eliminar(String codigo)
        {
            alumnoRepository.Eliminar(codigo);
        }
    }
}
