using Lab13.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13.repositories
{
    class ReporteMontoRepository
    {
        public List<ReporteMonto> ListarMontoPorTamañoPerros()
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

            List<ReporteMonto> reportes = paseos.GroupBy(p => p.TamañoPerro)
                .Select(
                    r => new ReporteMonto()
                    {
                        TamañoPerro = r.Key,
                        Monto = r.Sum(p => p.PrecioCobrado)
                    }
                ).ToList();

            return reportes;
        }
    }
}
