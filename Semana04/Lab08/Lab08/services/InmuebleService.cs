using Lab08.entities;
using Lab08.repositores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08.services
{
    class InmuebleService
    {
        private InmuebleRepository inmuebleRepository = new InmuebleRepository();

        public bool Registrar(String codigoAgencia, Inmueble inmueble)
        {
            if (inmuebleRepository.Existe(codigoAgencia, inmueble.Codigo))
            {
                return false;
            }
            else
            {
                inmuebleRepository.Registrar(codigoAgencia, inmueble);
                return true;
            }
        }

        public List<Inmueble> ListarTodoPorAgencia(String codigoAgencia)
        {
            return inmuebleRepository.ListarTodoPorAgencia(codigoAgencia);
        }

        public List<Inmueble> ListarPorAgenciaVenta(String codigoAgencia)
        {
            return inmuebleRepository.ListarPorAgenciaVenta(codigoAgencia);
        }

        public List<Inmueble> ListarPorAgenciaAlquiler(String codigoAgencia)
        {
            return inmuebleRepository.ListarPorAgenciaAlquiler(codigoAgencia);
        }
    }
}
