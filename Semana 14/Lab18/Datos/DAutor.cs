using System;
using System.Collections.Generic;
using System.Linq;

namespace Datos
{
    public class DAutor
    {
        public List<Autor> ListarTodo()
        {
            List<Autor> autores = new List<Autor>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    autores = context.Autor.Where(a => a.Eliminado == false).ToList();
                }
                return autores;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return autores;
            }
        }
    }
}
