using Lab08.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08.repositores
{
    class InmuebleRepository
    {
        public bool Existe(String codigoAgencia, String codigoInmueble)
        {
            // Traemos los todos las agencias
            List<Agencia> agencias = AgenciaRepository.ListarTodo();
            // Buscamos la agencia con el código correcto
            Agencia agenciaSeleccionada = agencias.Find(a => a.Codigo.Equals(codigoAgencia));

            return agenciaSeleccionada.Inmuebles.Exists(i => i.Codigo.Equals(codigoInmueble));
        }

        public void Registrar(String codigoAgencia, Inmueble inmueble)
        {
            // Traemos los todos las agencias
            List<Agencia> agencias = AgenciaRepository.ListarTodo();
            // Buscamos la agencia con el código correcto
            Agencia agenciaSeleccionada = agencias.Find(elemento => elemento.Codigo.Equals(codigoAgencia));

            // Hallamos la lista de inmuebles de la agencia
            List<Inmueble> inmuebles = agenciaSeleccionada.Inmuebles;

            inmuebles.Add(inmueble);
        }

        public List<Inmueble> ListarTodoPorAgencia(String codigoAgencia)
        {
            // Traemos los todas las agencias
            List<Agencia> agencias = AgenciaRepository.ListarTodo();
            // Buscamos la agencia con el código correcto
            Agencia agenciaSeleccionada = agencias.Find(elemento => elemento.Codigo.Equals(codigoAgencia));

            // Hallamos la lista de inmuebles de la agencia
            return agenciaSeleccionada.Inmuebles;
        }
        public List<Inmueble> ListarPorAgenciaVenta(String codigoAgencia)
        {
            // Traemos los todas las agencias
            List<Agencia> agencias = AgenciaRepository.ListarTodo();
            // Buscamos la agencia con el código correcto
            Agencia agenciaSeleccionada = agencias.Find(elemento => elemento.Codigo.Equals(codigoAgencia));

            // Hallamos la lista de inmuebles en venta de la agencia
            return agenciaSeleccionada.Inmuebles.FindAll(i => i.Condicion.Equals("Venta"));
        }

        public List<Inmueble> ListarPorAgenciaAlquiler(String codigoAgencia)
        {
            // Traemos los todas las agencias
            List<Agencia> agencias = AgenciaRepository.ListarTodo();
            // Buscamos la agencia con el código correcto
            Agencia agenciaSeleccionada = agencias.Find(elemento => elemento.Codigo.Equals(codigoAgencia));

            // Hallamos la lista de inmuebles en venta de la agencia
            return agenciaSeleccionada.Inmuebles.FindAll(i => i.Condicion.Equals("Alquiler"));
        }
    }
}
