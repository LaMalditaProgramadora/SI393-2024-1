using Lab08.entities;
using Lab08.repositories;
using System;
using System.Collections.Generic;

namespace Lab08.services
{
    class InmuebleService
    {
        private InmuebleRepository inmuebleRepository = new InmuebleRepository();

        public bool Registrar(String codigoAgencia, Inmueble inmueble)
        {
            if (inmuebleRepository.Existe(inmueble.Codigo))
            {
                return false;
            }
            else
            {
                inmuebleRepository.Registrar(codigoAgencia, inmueble);
                return true;
            }
        }

        public List<Inmueble> ListarTodo(String codigoAgencia)
        {
            return inmuebleRepository.ListarTodo(codigoAgencia);
        }

        public List<Inmueble> ListarPorAgenciaVenta(String codigoAgencia)
        {
            return inmuebleRepository.ListarPorAgenciaVenta(codigoAgencia);
        }

        public double MontoTotalAlquilerInmuebles()
        {
            return inmuebleRepository.MontoTotalAlquilerInmuebles();
        }
    }
}
