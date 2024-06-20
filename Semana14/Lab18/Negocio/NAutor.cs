using Datos;
using System.Collections.Generic;

namespace Negocio
{
    public class NAutor
    {
        private DAutor dAutor = new DAutor();

        public List<Autor> ListarTodo()
        {
            return dAutor.ListarTodo();
        }
    }
}
