using Lab10.entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab10.repositories
{
    class RutaRepository
    {
        public bool Existe(String codigo)
        {
            List<Bus> buses = BusRepository.ListarTodo();
            return buses.Exists(b => b.Rutas.Exists(r => r.Codigo.Equals(codigo)));
        }

        public void Registrar(String matricula, Ruta ruta)
        {
            List<Bus> buses = BusRepository.ListarTodo();
            Bus bus = buses.Find(b => b.Matricula.Equals(matricula));
            bus.Rutas.Add(ruta);
        }

        public List<Ruta> ListarTodo(String matricula)
        {
            List<Bus> buses = BusRepository.ListarTodo();
            Bus bus = buses.Find(b => b.Matricula.Equals(matricula));
            return bus.Rutas;
        }

        public List<Ruta> ListarRutasPorConductorBus(String conductor)
        {
            List<Bus> buses = BusRepository.ListarTodo();
            buses = buses.Where(b => b.Conductor.Equals(conductor)).ToList();

            List<Ruta> rutasTemp = new List<Ruta>();

            foreach (Bus bus in buses)
            {
                rutasTemp.AddRange(bus.Rutas);
            }
            return rutasTemp;
        }
    }
}
