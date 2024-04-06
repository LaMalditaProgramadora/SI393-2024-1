using Lab08.entities;
using System;
using System.Collections.Generic;
using System.Linq;

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
            List<Agencia> agenciasTemp = new List<Agencia>();
            int maxInmueblesVentaGeneral = 0;

            foreach (Agencia agencia in agencias)
            {
                // int inmueblesVentaEnAgencia = agencia.Inmuebles.Where(i => i.Condicion.Equals("Venta")).ToList().Count();
                // He separado este código en dos variables para que se pueda ver mejor
                // Primero encuentro los inmuebles
                List<Inmueble> inmuebles = agencia.Inmuebles.Where(i => i.Condicion.Equals("Venta")).ToList();
                // Y luego los cuento
                int inmueblesVentaEnAgencia = inmuebles.Count;

                if (inmueblesVentaEnAgencia > maxInmueblesVentaGeneral)
                {
                    maxInmueblesVentaGeneral = inmueblesVentaEnAgencia;
                    agenciasTemp.Clear();
                    agenciasTemp.Add(agencia);
                }
                else if (inmueblesVentaEnAgencia == maxInmueblesVentaGeneral)
                {
                    agenciasTemp.Add(agencia);
                }
            }

            return agenciasTemp;
        }

        public List<Agencia> ListarMayorSuperficieInmueblesAlquiler()
        {
            List<Agencia> agenciasTemp = new List<Agencia>();
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
                        agenciasTemp.Clear();
                        agenciasTemp.Add(agencia);
                    }
                    else if (maxSuperficieAlquilerEnAgencia == maxSuperficieAlquilerGeneral)
                    {
                        agenciasTemp.Add(agencia);
                    }
                }
            }
            return agenciasTemp;
        }
    }
}
