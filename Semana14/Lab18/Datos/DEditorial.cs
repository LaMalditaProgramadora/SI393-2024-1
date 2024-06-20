using System;
using System.Collections.Generic;
using System.Linq;

namespace Datos
{
    public class DEditorial
    {
        public List<Editorial> ListarTodo()
        {
            List<Editorial> editoriales = new List<Editorial>();
            try
            {
                using (var context = new BDEFEntities())
                {
                    context.Configuration.LazyLoadingEnabled = false;
                    editoriales = context.Editorial.Where(e => e.Eliminado == false).ToList();
                }
                return editoriales;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return editoriales;
            }
        }
    }
}
