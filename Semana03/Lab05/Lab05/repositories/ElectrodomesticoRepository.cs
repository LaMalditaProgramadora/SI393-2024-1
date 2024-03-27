using Lab05.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05.repositories
{
    class ElectrodomesticoRepository
    {
        private static List<Electrodomestico> electrodomesticos = new List<Electrodomestico>();

        public bool Existe(String codigo)
        {
            return electrodomesticos.Exists(a => a.Codigo.Equals(codigo));
        }

        public void Registrar(Electrodomestico electrodomestico)
        {
            electrodomesticos.Add(electrodomestico);
        }

        public static List<Electrodomestico> ListarTodo()
        {
            return electrodomesticos;
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
