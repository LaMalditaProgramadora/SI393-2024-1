using Lab13.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13.repositories
{
    class PaseoRepository
    {
        public bool Existe(String codigoPerro, DateTime fecha, String turno)
        {
            List<Paseador> paseadores = PaseadorRepository.ListarTodo();
            // Un perro puede tener varios paseos, pero en diferentes turnos y fecha 
            return paseadores.Exists(pa => pa.Paseos.Exists(p => p.CodigoPerro.Equals(codigoPerro) && p.Fecha.Equals(fecha) && p.Turno.Equals(turno)));
        }

        public void Registrar(String DNI, Paseo paseo)
        {
            List<Paseador> paseadores = PaseadorRepository.ListarTodo();
            Paseador paseador = paseadores.Find(pa => pa.DNI.Equals(DNI));
            paseador.Paseos.Add(paseo);
        }

        public List<Paseo> ListarTodo(String DNI)
        {
            List<Paseador> paseadores = PaseadorRepository.ListarTodo();
            Paseador paseador = paseadores.Find(pa => pa.DNI.Equals(DNI));
            return paseador.Paseos;
        }

        public double ObtenerMontoPorPaseadorYFecha(String DNI, DateTime fecha)
        {
            List<Paseador> paseadores = PaseadorRepository.ListarTodo();
            Paseador paseador = paseadores.Find(pa => pa.DNI.Equals(DNI));
            if (paseador == null) return 0;
            List<Paseo> paseos = paseador.Paseos;

            paseos = paseos.Where(pa => pa.Fecha.Equals(fecha)).ToList();
            double monto = paseos.Sum(pa => pa.PrecioCobrado);
            return monto;
        }

        public int ObtenerCantidadPaseosPorPaseadorYTamañoGrande(String DNI)
        {
            List<Paseador> paseadores = PaseadorRepository.ListarTodo();
            Paseador paseador = paseadores.Find(pa => pa.DNI.Equals(DNI));
            if (paseador == null) return 0;
            List<Paseo> paseos = paseador.Paseos;

            paseos = paseos.Where(pa => pa.TamañoPerro.Equals("Grande")).ToList();
            int cantidad = paseos.Count;
            return cantidad;
        }
    }
}
