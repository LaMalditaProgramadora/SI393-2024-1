using Lab05.entities;
using Lab05.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05.services
{
    class ElectrodomesticoService
    {
        private ElectrodomesticoRepository electrodomesticoRepository = new ElectrodomesticoRepository();

        public bool Registrar(Electrodomestico electrodomestico)
        {
            if (electrodomesticoRepository.Existe(electrodomestico.Codigo))
            {
                return false;
            }
            else
            {
                electrodomesticoRepository.Registrar(electrodomestico);
                return true;
            }
        }

        public List<Electrodomestico> ListarTodo()
        {
            return ElectrodomesticoRepository.ListarTodo();
        }

        public void Eliminar(String codigo)
        {
            electrodomesticoRepository.Eliminar(codigo);
        }

        public void EliminarTodo()
        {
            electrodomesticoRepository.EliminarTodo();
        }

        public List<Electrodomestico> BuscarPorNombre(String nombre)
        {
            return electrodomesticoRepository.BuscarPorNombre(nombre);
        }

        public List<Electrodomestico> OrdenarPorPrecio()
        {
            return electrodomesticoRepository.OrdenarPorPrecio();
        }
    }
}
