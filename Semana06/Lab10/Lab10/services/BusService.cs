using Lab10.entities;
using Lab10.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10.services
{
    class BusService
    {
        private BusRepository busRepository = new BusRepository();

        public bool Registrar(Bus bus)
        {
            if (busRepository.Existe(bus.Matricula))
            {
                return false;
            }
            else
            {
                busRepository.Registrar(bus);
                return true;
            }
        }

        public List<Bus> ListarTodo()
        {
            return BusRepository.ListarTodo();
        }

        public List<Bus> ListarBusesConRutasMasLargas()
        {
            return busRepository.ListarBusesConRutasMasLargas();
        }

        public List<Bus> ListarBusesConMenosRutas()
        {
            return busRepository.ListarBusesConMenosRutas();
        }
    }
}
