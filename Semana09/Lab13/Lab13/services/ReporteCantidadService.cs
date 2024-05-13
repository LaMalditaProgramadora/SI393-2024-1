using Lab13.entities;
using Lab13.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13.services
{
    class ReporteCantidadService
    {
        private ReporteCantidadRepository reporteCantidadRepository = new ReporteCantidadRepository();

        public List<ReporteCantidad> ListarCantidadPorObjetivoPaseo()
        {
            return reporteCantidadRepository.ListarCantidadPorObjetivoPaseo();
        }
    }
}
