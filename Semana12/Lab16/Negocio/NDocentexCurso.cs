using Datos;
using System;
using System.Collections.Generic;

namespace Negocio
{
    public class NDocentexCurso
    {
        private DDocentexCurso dDocentexCurso = new DDocentexCurso();

        public String Asignar(DocentexCurso docentexCurso)
        {
            return dDocentexCurso.Asignar(docentexCurso);
        }

        public String Desasignar(int docente_id, int id_curso)
        {
            return dDocentexCurso.Desasignar(docente_id, id_curso);
        }

        public List<DocentexCurso> ListarTodo()
        {
            return dDocentexCurso.ListarTodo();
        }

        public List<DocentexCurso> BuscarPorIdDocente(int docente_id)
        {
            return dDocentexCurso.BuscarPorIdDocente(docente_id);
        }

        public List<DocentexCurso> BuscarPorIdCurso(int id_curso)
        {
            return dDocentexCurso.BuscarPorIdCurso(id_curso);
        }
    }
}
