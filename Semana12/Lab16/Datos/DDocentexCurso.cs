using System;
using System.Collections.Generic;
using System.Linq;

namespace Datos
{
    public class DDocentexCurso
    {
        public String Asignar(DocentexCurso docentexCurso)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.DocentexCurso.Add(docentexCurso);
                    context.SaveChanges();
                }
                return "Asignado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public String Desasignar(int docente_id, int id_curso)
        {
            try
            {
                using (var context = new BDEFEntities())
                {
                    DocentexCurso docentexCursoTemp = context.DocentexCurso.Find(docente_id, id_curso);
                    context.DocentexCurso.Remove(docentexCursoTemp);
                    context.SaveChanges();
                }
                return "Desasignado correctamente";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<DocentexCurso> ListarTodo()
        {
            List<DocentexCurso> docentexCursos = new List<DocentexCurso>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    docentexCursos = context.DocentexCurso.ToList();
                }
                return docentexCursos;
            }
            catch (Exception ex)
            {
                return docentexCursos;
            }
        }

        public List<DocentexCurso> BuscarPorIdDocente(int docente_id)
        {
            List<DocentexCurso> docentexCursos = new List<DocentexCurso>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    docentexCursos = context.DocentexCurso.Where(dc => dc.Docente_id.Equals(docente_id)).ToList();
                }
                return docentexCursos;
            }
            catch (Exception ex)
            {
                return docentexCursos;
            }
        }

        public List<DocentexCurso> BuscarPorIdCurso(int id_curso)
        {
            List<DocentexCurso> docentexCursos = new List<DocentexCurso>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    docentexCursos = context.DocentexCurso.Where(dc => dc.Id_curso.Equals(id_curso)).ToList();
                }
                return docentexCursos;
            }
            catch (Exception ex)
            {
                return docentexCursos;
            }
        }
    }
}
