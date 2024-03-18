using Lab05.entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab05.controllers
{
    internal class ElectrodomesticoController
    {
        private List<Electrodomestico> electrodomesticos = new List<Electrodomestico>();

        public List<Electrodomestico> ListarTodo()
        {
            return electrodomesticos;
        }

        public bool Registrar(Electrodomestico electrodomestico)
        {
            // Verificación si el código ya está registrado
            bool existe = electrodomesticos.Exists(ele => ele.Codigo.Equals(electrodomestico.Codigo));
            if (existe)
            {
                return false;
            }
            else
            {
                electrodomesticos.Add(electrodomestico);
                return true;
            }
        }

        public void Eliminar(String codigo)
        {
            electrodomesticos.RemoveAll(ele => ele.Codigo.Equals(codigo));
        }

        public void EliminarTodo()
        {
            electrodomesticos.Clear();
        }

        public List<Electrodomestico> BuscarPorNombre(String nombre)
        {
            return electrodomesticos.Where(elec => elec.Nombre.Contains(nombre)).ToList();
            //return electrodomesticos.FindAll(elec => elec.Nombre.Contains(nombre));
        }

        public List<Electrodomestico> OrdenarPorPrecio()
        {
            return electrodomesticos.OrderBy(elec => elec.Precio).ToList();
        }
    }
}
