using Lab02.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02.controllers
{
    internal class EmpleadoController
    {
        public Empleado ProcesarEmpleado(Empleado empleado)
        {
            // Definir el pago base
            switch (empleado.Categoria)
            {
                case "A": empleado.Pago = 2500; break;
                case "B": empleado.Pago = 1500; break;
                case "C": empleado.Pago = 1000; break;
                case "D": empleado.Pago = 900; break;
            }

            // Aumento/Descuento
            if (empleado.MinutosTardanza == 0 && empleado.LlamadasAtencion == 0)
            {
                empleado.Pago *= 1.15;
            }
            else
            {
                double descMinutosTardanza = empleado.MinutosTardanza * 5;
                double descLlamadasAtencion = empleado.LlamadasAtencion * 10;
                empleado.Pago = empleado.Pago - descMinutosTardanza - descLlamadasAtencion;
            }
            return empleado;
        }
    }
}
