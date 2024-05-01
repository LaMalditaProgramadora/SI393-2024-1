using Lab12.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12.repositories
{
    class ReporteRepository
    {
        public List<Reporte> ListarEspecialidadesConMasDoctores()
        {
            List<Doctor> doctores = DoctorRepository.ListarTodo();
            List<Reporte> reportes = doctores.GroupBy(d => d.Especialidad)
                .Select(
                    r => new Reporte() {
                        Especialidad = r.Key,
                        Cantidad = r.Count()
                    }
                ).ToList();

            if (reportes.Count == 0) return new List<Reporte>();

            int cantMaxDoctores = reportes.Max(r => r.Cantidad);
            reportes = reportes.Where(r => r.Cantidad == cantMaxDoctores).ToList();
            return reportes;
        }
    }
}
