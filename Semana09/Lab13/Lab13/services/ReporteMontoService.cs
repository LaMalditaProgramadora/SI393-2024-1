using Lab13.entities;
using Lab13.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13.services
{
    class ReporteMontoService
    {
        private ReporteMontoRepository reporteMontoRepository = new ReporteMontoRepository();

        public List<ReporteMonto> ListarMontoPorTamañoPerros()
        {
            return reporteMontoRepository.ListarMontoPorTamañoPerros();
        }
    }
}
