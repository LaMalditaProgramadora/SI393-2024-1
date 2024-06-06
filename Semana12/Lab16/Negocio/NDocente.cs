using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NDocente
    {
        private DDocente dDocente = new DDocente();

        public String Registrar(Docente docente)
        {
            return dDocente.Registrar(docente);
        }

        public String Modificar(Docente docente)
        {
            return dDocente.Modificar(docente);
        }

        public String Eliminar(int id_docente)
        {
            return dDocente.Eliminar(id_docente);
        }

        public List<Docente> ListarTodo()
        {
            return dDocente.ListarTodo();
        }

        public List<Docente> BuscarPorEscuela(String nombredocente)
        {
            return dDocente.BuscarPorEscuela(nombredocente);
        }
    }
}
