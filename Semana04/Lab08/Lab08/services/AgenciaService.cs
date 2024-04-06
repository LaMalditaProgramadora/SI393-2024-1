using Lab08.entities;
using Lab08.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08.services
{
    class AgenciaService
    {
        private AgenciaRepository agenciaRepository = new AgenciaRepository();

        public bool Registrar(Agencia agencia)
        {
            if (agenciaRepository.Existe(agencia.Codigo))
            {
                return false;
            }
            else
            {
                agenciaRepository.Registrar(agencia);
                return true;
            }
        }

        public List<Agencia> ListarTodo()
        {
            return AgenciaRepository.ListarTodo();
        }

        public List<Agencia> ListarMayorCantidadInmueblesVenta()
        {
            return agenciaRepository.ListarMayorCantidadInmueblesVenta();
        }

        public List<Agencia> ListarMayorSuperficieInmueblesAlquiler()
        {
            return agenciaRepository.ListarMayorSuperficieInmueblesAlquiler();
        }
    }
}
