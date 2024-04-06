using Lab08.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08.repositories
{
    class InmuebleRepository
    {
        public bool Existe(String codigoInmueble)
        {
            List<Agencia> agencias = AgenciaRepository.ListarTodo();
            return agencias.Exists(a => a.Inmuebles.Exists(i => i.Codigo.Equals(codigoInmueble)));
        }

        public void Registrar(String codigoAgencia, Inmueble inmueble)
        {
            List<Agencia> agencias = AgenciaRepository.ListarTodo();
            Agencia agencia = agencias.Find(a => a.Codigo.Equals(codigoAgencia));

            agencia.Inmuebles.Add(inmueble);
        }

        public List<Inmueble> ListarTodo(String codigoAgencia)
        {
            List<Agencia> agencias = AgenciaRepository.ListarTodo();
            Agencia agencia = agencias.Find(a => a.Codigo.Equals(codigoAgencia));
            return agencia.Inmuebles;
        }

        public List<Inmueble> ListarPorAgenciaVenta(String codigoAgencia)
        {
            List<Agencia> agencias = AgenciaRepository.ListarTodo();
            Agencia agencia = agencias.Find(a => a.Codigo.Equals(codigoAgencia));
            return agencia.Inmuebles.Where(i => i.Condicion.Equals("Venta")).ToList();
        }

        public double MontoTotalAlquilerInmuebles()
        {
            List<Agencia> agencias = AgenciaRepository.ListarTodo();
            double monto = 0;
            foreach (Agencia agencia in agencias)
            {
                foreach (Inmueble inmueble in agencia.Inmuebles)
                {
                    if (inmueble.Condicion.Equals("Alquiler"))
                    {
                        monto += inmueble.Precio;
                    }
                }
            }
            return monto;
        }
    }
}
