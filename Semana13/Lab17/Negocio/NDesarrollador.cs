using Datos;
using System;
using System.Collections.Generic;

namespace Negocio
{
    public class NDesarrollador
    {
        private DDesarrollador dDesarrollador = new DDesarrollador();

        public String Registrar(Desarrollador desarrollador)
        {
            return dDesarrollador.Registrar(desarrollador);
        }

        public String Modificar(Desarrollador desarrollador)
        {
            return dDesarrollador.Modificar(desarrollador);
        }

        public String Eliminar(int id_Desarrollador)
        {
            return dDesarrollador.Eliminar(id_Desarrollador);
        }

        public List<Desarrollador> ListarTodo()
        {
            return dDesarrollador.ListarTodo();
        }

        public List<Desarrollador> BuscarPorVideojuegosQueTenganValoracionMenorA50()
        {
            return dDesarrollador.BuscarPorVideojuegosQueTenganValoracionMenorA50();
        }
    }
}
