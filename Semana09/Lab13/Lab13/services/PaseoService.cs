using Lab13.entities;
using Lab13.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13.services
{
    class PaseoService
    {
        private PaseoRepository paseoRepository = new PaseoRepository();

        public bool Registrar(String DNI, Paseo paseo)
        {
            if (paseoRepository.Existe(paseo.CodigoPerro, paseo.Fecha, paseo.Turno))
            {
                return false;
            }
            else
            {
                paseoRepository.Registrar(DNI, paseo);
                return true;
            }
        }

        public List<Paseo> ListarTodo(String DNI)
        {
            return paseoRepository.ListarTodo(DNI);
        }

        public double ObtenerMontoPorPaseadorYFecha(String DNI, DateTime fecha)
        {
            return paseoRepository.ObtenerMontoPorPaseadorYFecha(DNI, fecha);
        }

        public int ObtenerCantidadPaseosPorPaseadorYTamañoGrande(String DNI)
        {
            return paseoRepository.ObtenerCantidadPaseosPorPaseadorYTamañoGrande(DNI);
        }
    }
}
