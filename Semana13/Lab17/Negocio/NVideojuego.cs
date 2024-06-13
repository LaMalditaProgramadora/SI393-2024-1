using Datos;
using System;
using System.Collections.Generic;

namespace Negocio
{
    public class NVideojuego
    {
        private DVideojuego dVideojuego = new DVideojuego();

        public String Registrar(Videojuego videojuego)
        {
            return dVideojuego.Registrar(videojuego);
        }

        public String Modificar(Videojuego videojuego)
        {
            return dVideojuego.Modificar(videojuego);
        }

        public String Eliminar(int id_Videojuego)
        {
            return dVideojuego.Eliminar(id_Videojuego);
        }

        public List<Videojuego> ListarTodo(int id_desarrollador)
        {
            return dVideojuego.ListarTodo(id_desarrollador);
        }

        public Decimal ObtenerMayorValoracionPorDesarrollador(int id_desarrollador)
        {
            return dVideojuego.ObtenerMayorValoracionPorDesarrollador(id_desarrollador);
        }

        public List<Videojuego> BuscarPorNombreDesarrollador(String nombre)
        {
            return dVideojuego.BuscarPorNombreDesarrollador(nombre);
        }
    }
}
