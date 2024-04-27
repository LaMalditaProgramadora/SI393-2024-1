using Lab10.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10.repositories
{
    class BusRepository
    {
        private static List<Bus> buses = new List<Bus>();

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
            double rutaMasLargaTotal = 0;

            foreach (Bus bus in buses)
            {
                List<Ruta> rutas = bus.Rutas;
                if (rutas.Count != 0)
                {
                    double rutaMasLargaEnBus = rutas.Max(r => r.Kilometros);

                    if (rutaMasLargaEnBus > rutaMasLargaTotal)
                    {
                        rutaMasLargaTotal = rutaMasLargaEnBus;
                        busesTemp.Clear();
                        busesTemp.Add(bus);
                    }
                    else if (rutaMasLargaEnBus == rutaMasLargaTotal)
                    {
                        busesTemp.Add(bus);
                    }
                }
            }
            return busesTemp;
        }

        public List<Bus> ListarBusesConMenosRutas()
        {
            List<Bus> busesTemp = new List<Bus>();
            int menorCantRutasTotal = 99999999;

            foreach (Bus bus in buses)
            {
                List<Ruta> rutas = bus.Rutas;
                int cantRutasEnBus = rutas.Count;

                if (cantRutasEnBus < menorCantRutasTotal)
                {
                    cantRutasEnBus = menorCantRutasTotal;
                    busesTemp.Clear();
                    busesTemp.Add(bus);
                }
                else if (cantRutasEnBus == menorCantRutasTotal)
                {
                    busesTemp.Add(bus);
                }
            }
            return busesTemp;
        }
    }
}
