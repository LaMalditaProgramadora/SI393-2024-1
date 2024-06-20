using Datos;
using System.Collections.Generic;

namespace Negocio
{
    public class NEditorial
    {
        private DEditorial dEditorial = new DEditorial();

        public List<Editorial> ListarTodo()
        {
            return dEditorial.ListarTodo();
        }
    }
}
