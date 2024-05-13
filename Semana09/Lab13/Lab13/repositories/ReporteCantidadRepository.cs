using Lab13.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13.repositories
{
    class ReporteCantidadRepository
    {
        public List<ReporteCantidad> ListarCantidadPorObjetivoPaseo()
        {
            List<Paseador> paseadores = PaseadorRepository.ListarTodo();

            // Opción 1
            /*
            List<Paseo> paseos = new List<Paseo>();
            foreach (Paseador paseador in paseadores)
            {
                paseos.AddRange(paseador.Paseos);
            }
            */

            // Opción 2
            List<Paseo> paseos = paseadores.SelectMany(p => p.Paseos).ToList();

            List<ReporteCantidad> reportes = paseos.GroupBy(p => p.ObjetivoPaseo)
                .Select(
                    r => new ReporteCantidad()
                    {
                        ObjetivoPaseo = r.Key,
                        Cantidad = r.Count()
                    }
                ).ToList();

            return reportes;
        }
    }
}
