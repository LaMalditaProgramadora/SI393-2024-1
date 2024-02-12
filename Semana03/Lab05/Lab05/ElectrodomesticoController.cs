using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05
{
    internal class ElectrodomesticoController
    {
        private List<Electrodomestico> electrodomesticos = new List<Electrodomestico>();

        public List<Electrodomestico> Listar()
        {
            return electrodomesticos;
        }

        public bool Registrar(Electrodomestico elec)
        {
            // Verificamos si el código ya está registrado
            bool existe = electrodomesticos.Exists(ele => ele.Codigo.Equals(elec.Codigo));
            if (existe)
            {
                return false;
            }
            else
            {
                // Agregar electrodoméstico a la lista
                electrodomesticos.Add(elec);
                return true;
            }
        }

        public void Eliminar(String codigo)
        {
            electrodomesticos.RemoveAll(elec => elec.Codigo.Equals(codigo));
        }

        public void EliminarTodo()
        {
            electrodomesticos.Clear();
        }

        public List<Electrodomestico> BuscarPorNombre(String nombre)
        {
            return electrodomesticos.FindAll(elec => elec.Nombre.Contains(nombre));
        }

        public List<Electrodomestico> OrdenarPorPrecio()
        {
            return electrodomesticos.OrderBy(elec => elec.Precio).ToList();
        }

    }
}
