using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NEmpleado
    {
        private DEmpleado dEmpleado = new DEmpleado();

        public bool Registrar(EEmpleado empleado)
        {
            if (dEmpleado.Existe(empleado.Dni))
            {
                return false;
            }
            else
            {
                // Lógica de Negocio
                switch (empleado.Puesto)
                {
                    case "Auxiliar": empleado.Sueldo = 2000; break;
                    case "Asistente": empleado.Sueldo = 3000; break;
                    case "Administrador": empleado.Sueldo = 5000; break;
                    default: empleado.Sueldo = 2000; break;
                }

                dEmpleado.Registrar(empleado);
                return true;
            }
        }

        public List<EEmpleado> ListarTodo()
        {
            return DEmpleado.ListarTodo();
        }

        public void Eliminar(String dni)
        {
            dEmpleado.Eliminar(dni);
        }

        public List<EEmpleado> OrdenarPorSueldo()
        {
            return dEmpleado.OrdenarPorSueldo();
        }
    }
}
