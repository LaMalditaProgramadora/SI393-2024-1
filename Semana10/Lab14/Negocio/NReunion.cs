using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NReunion
    {
        private DReunion dReunion = new DReunion();

        public bool Registrar(String dni, EReunion reunion)
        {
            if (dReunion.Existe(dni, reunion.Fecha, reunion.Turno))
            {
                return false;
            }
            else
            {
                dReunion.Registrar(dni, reunion);
                return true;
            }
        }

        public List<EReunion> ListarTodo(String dni)
        {
            return dReunion.ListarTodo(dni);
        }
    }
}
