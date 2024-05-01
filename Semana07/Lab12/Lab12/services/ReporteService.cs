using Lab12.entities;
using Lab12.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12.services
{
    class ReporteService
    {
        private ReporteRepository reporteRepository = new ReporteRepository();

        public List<Reporte> ListarEspecialidadesConMasDoctores()
        {
            return reporteRepository.ListarEspecialidadesConMasDoctores();
        }
    }
}
