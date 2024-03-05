using Lab10.entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab10.repositories
{
    internal class BusRepository
    {
        private static List<Bus> buses = new List<Bus>();

        public BusRepository() { }

        public bool Existe(String matricula)
        {
            return buses.Exists(bus => bus.Matricula.Equals(matricula));
        }

        public void Registrar(Bus bus)
        {
            buses.Add(bus);
        }

        public static List<Bus> ListarTodo()
        {
            return buses;
        }

        public List<Bus> ListarBusesConRutasMasLargas()
        {
            List<Bus> busesTemp = new List<Bus>();
            if (buses.Count != 0)
            {
                double maxKilometros = buses.Max(
                    // if
                    b => b.Rutas.Count == 0
                    // primera opción
                    ? 0
                    // segunda opción
                    : b.Rutas.Max(r => r.Kilometros));

                // Buscar los buses con la ruta más larga (kilómetros)
                busesTemp = buses.Where(b => b.Rutas.Exists(r => r.Kilometros == maxKilometros)).ToList();
            }
            return busesTemp;
        }

        public List<Bus> ListarBusesConMenosRutas()
        {
            List<Bus> busesTemp = new List<Bus>();
            if (buses.Count != 0)
            {
                int menorCantRutas =
                    // if
                    buses.Count == 0
                    // primera opción
                    ? 0
                    // segunda opción
                    : buses.Min(b => b.Rutas.Count);

                // Buscar los buses menos rutas
                busesTemp = buses.Where(b => b.Rutas.Count == menorCantRutas).ToList();
            }
            return busesTemp;
        }
    }
}
