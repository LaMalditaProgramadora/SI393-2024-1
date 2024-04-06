using Lab08.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08.repositories
{
    class AgenciaRepository
    {
        private static List<Agencia> agencias = new List<Agencia>();

        public bool Existe(String codigo)
        {
            return agencias.Exists(a => a.Codigo.Equals(codigo));
        }

        public void Registrar(Agencia agencia)
        {
            agencias.Add(agencia);
        }

        public static List<Agencia> ListarTodo()
        {
            return agencias;
        }

        public List<Agencia> ListarMayorCantidadInmueblesVenta()
        {
            int maxInmueblesVentaGeneral = 0;
            foreach (Agencia agencia in agencias)
            {
                List<Inmueble> inmuebles = agencia.Inmuebles.Where(i => i.Condicion.Equals("Venta")).ToList();
                int inmueblesVentaEnAgencia = inmuebles.ToList().Count;
                if (inmueblesVentaEnAgencia > maxInmueblesVentaGeneral)
                {
                    maxInmueblesVentaGeneral = inmueblesVentaEnAgencia;
                }
            }

            return agencias.Where(a => a.Inmuebles.Count == maxInmueblesVentaGeneral).ToList();
        }

        public List<Agencia> ListarMayorSuperficieInmueblesAlquiler()
        {
            double maxSuperficieAlquilerGeneral = 0;
            foreach (Agencia agencia in agencias)
            {
                List<Inmueble> inmuebles = agencia.Inmuebles.Where(i => i.Condicion.Equals("Alquiler")).ToList();
                if (inmuebles.Count != 0)
                {
                    double maxSuperficieAlquilerEnAgencia = inmuebles.Max(i => i.Superficie);
                    if (maxSuperficieAlquilerEnAgencia > maxSuperficieAlquilerGeneral)
                    {
                        maxSuperficieAlquilerGeneral = maxSuperficieAlquilerEnAgencia;
                    }
                }
            }
            return agencias.Where(a => a.Inmuebles.Exists(i => i.Superficie == maxSuperficieAlquilerGeneral)).ToList();
        }
    }
}
