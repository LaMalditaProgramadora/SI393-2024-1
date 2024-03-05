using Lab10.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10.repositories
{
    internal class RutaRepository
    {
        public RutaRepository() { }

        public bool Existe(String codigo)
        {
            List<Bus> buses = BusRepository.ListarTodo();
            foreach (Bus bus in buses)
            {
                bool existe = bus.Rutas.Exists(ruta => ruta.Codigo.Equals(codigo));
                if (existe)
                {
                    return true;
                }
            }
            return false;
        }

        public void Registrar(String matricula, Ruta ruta)
        {
            List<Bus> buses = BusRepository.ListarTodo();

            // Buscar el bus por la matrícula seleccionada
            Bus bus = buses.Find(b => b.Matricula.Equals(matricula));
            if (bus != null)
            {
                bus.Rutas.Add(ruta);
            }
        }

        public List<Ruta> ListarTodo(String matricula)
        {
            List<Bus> buses = BusRepository.ListarTodo();

            // Buscar el bus por la matrícula seleccionada
            Bus bus = buses.Find(b => b.Matricula.Equals(matricula));
            if (bus != null)
            {
                return bus.Rutas;
            }
            else
            {
                return new List<Ruta>();
            }
        }

        public List<Ruta> ListarRutasPorConductorBus(String conductor)
        {
            List<Bus> buses = BusRepository.ListarTodo();
            List<Bus> busesTemp = buses.Where(b => b.Conductor.Equals(conductor)).ToList();
            List<Ruta> rutasTemp = new List<Ruta>();

            // Recorre todos los buses con el nombre del conductor
            foreach (Bus bus in busesTemp)
            {
                rutasTemp.AddRange(bus.Rutas);
            }
            return rutasTemp;
        }
    }
}
