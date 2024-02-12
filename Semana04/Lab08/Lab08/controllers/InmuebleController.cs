using Lab08.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08.controllers
{
    internal class InmuebleController
    {
        public List<Inmueble> ListarPorAgencia(String codigoAgencia)
        {
            // Traemos los todas las agencias
            List<Agencia> agencias = AgenciaController.Listar();
            // Buscamos la agencia con el código correcto
            Agencia agenciaSeleccionada = agencias.Find(elemento => elemento.Codigo.Equals(codigoAgencia));
            if (agenciaSeleccionada == null) return new List<Inmueble>();

            // Hallamos la lista de inmuebles de la agencia
            return agenciaSeleccionada.Inmuebles;
        }
        public List<Inmueble> ListarPorAgenciaVenta(String codigoAgencia)
        {
            // Traemos los todas las agencias
            List<Agencia> agencias = AgenciaController.Listar();
            // Buscamos la agencia con el código correcto
            Agencia agenciaSeleccionada = agencias.Find(elemento => elemento.Codigo.Equals(codigoAgencia));
            if (agenciaSeleccionada == null) return new List<Inmueble>();
            // Hallamos la lista de inmuebles en venta de la agencia
            List<Inmueble> inmuebles = agenciaSeleccionada.Inmuebles.FindAll(i => i.Condicion.Equals("Venta"));

            return inmuebles;
        }

        public bool Registrar(String codigoAgencia, Inmueble inmueble)
        {
            // Traemos los todos las agencias
            List<Agencia> agencias = AgenciaController.Listar();
            // Buscamos la agencia con el código correcto
            Agencia agenciaSeleccionada = agencias.Find(elemento => elemento.Codigo.Equals(codigoAgencia));
            if (agenciaSeleccionada == null) return false;

            // Hallamos la lista de inmuebles de la agencia
            List<Inmueble> inmuebles = agenciaSeleccionada.Inmuebles;

            // Verificación de código
            bool existe = inmuebles.Exists(elemento => elemento.Codigo.Equals(inmueble.Codigo));
            if (existe)
            {
                return false;
            }
            else
            {
                inmuebles.Add(inmueble);
                return true;
            }
        }
    }
}
