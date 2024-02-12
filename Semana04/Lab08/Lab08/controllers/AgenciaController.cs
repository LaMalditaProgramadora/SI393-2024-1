using Lab08.entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab08.controllers
{
    internal class AgenciaController
    {
        private static List<Agencia> agencias = new List<Agencia>();

        public static List<Agencia> Listar()
        {
            return agencias;
        }

        public bool Registrar(Agencia agencia)
        {
            // Verificación de código
            bool existe = agencias.Exists(alb => alb.Codigo.Equals(agencia.Codigo));
            if (existe)
            {
                return false;
            }
            else
            {
                agencias.Add(agencia);
                return true;
            }
        }

        public List<Agencia> ListarMayorCantidadInmueblesVenta()
        {
            // Buscar las agencias que tengan la mayor cantidad de inmuebles a la venta
            List<Agencia> agenciasTemp = new List<Agencia>();
            if (agencias.Count != 0)
            {
                // Búsqueda de agencias que tienen inmuebles en venta
                agenciasTemp = agencias.Where(a => a.Inmuebles.Exists(i => i.Condicion.Equals("Venta"))).ToList();
                // Si agenciasTemp está vacío, la máxima cantidad será 0 (para evitar un Exception)
                int maxCantidadInmueblesVenta =
                    // if
                    agenciasTemp.Count == 0
                    // primera opción
                    ? 0
                    // segunda opción
                    : agenciasTemp.Max(a => a.Inmuebles.Count);

                // Buscar las agencias con la mayor cantidad de inmuebles encontrada previamente
                agenciasTemp = agenciasTemp.Where(a => a.Inmuebles.Count == maxCantidadInmueblesVenta).ToList();
            }
            return agenciasTemp;
        }

        public List<Agencia> ListarMayorSuperficieInmueblesAlquiler()
        {
            // Buscar las agencias que tengan la mayor cantidad de inmuebles a la venta
            List<Agencia> agenciasTemp = new List<Agencia>();
            if (agencias.Count != 0)
            {
                // Búsqueda de agencias que tienen inmuebles en alquiler
                agenciasTemp = agencias.Where(a => a.Inmuebles.Exists(i => i.Condicion.Equals("Alquiler"))).ToList();
                if (agenciasTemp.Count == 0) return agenciasTemp;

                // Si agenciasTemp está vacío, la máxima superficie será 0 (para evitar un Exception)
                double maxSuperFicieInmueblesAlquiler = agenciasTemp.Max(
                    // if
                    a => a.Inmuebles.Count == 0
                    // primera opción
                    ? 0
                    // segunda opción
                    : a.Inmuebles.Max(i => i.Superficie));

                // Buscar las agencias con la máxima superficie encontrada previamente
                agenciasTemp = agenciasTemp.Where(a => a.Inmuebles.Exists(i => i.Superficie == maxSuperFicieInmueblesAlquiler)).ToList();
            }
            return agenciasTemp;
        }

        public List<Agencia> BuscarPorCodigo(String codigo)
        {
            // Buscar la agencia por su código
            List<Agencia> agenciasTemp = agencias.FindAll(agencia => agencia.Codigo.Equals(codigo));
            return agenciasTemp;
        }
    }
}
