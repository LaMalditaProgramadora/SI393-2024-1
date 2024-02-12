using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    internal class EmpleadoController
    {
        public EmpleadoController() { }

        public Empleado ProcesarEmpleado(Empleado empl)
        {
            // Definir el pago base
            switch (empl.Categoria)
            {
                case "A": empl.Pago = 2500; break;
                case "B": empl.Pago = 1500; break;
                case "C": empl.Pago = 1000; break;
                case "D": empl.Pago = 900; break;
            }

            // Aumento/Descuento
            if (empl.MinutosTardanza == 0 && empl.LlamadasAtencion == 0)
            {
                empl.Pago = empl.Pago * 1.15;
            }
            else
            {
                double descMinutosTardanza = empl.MinutosTardanza * 5;
                double descLlamadasAtencion = empl.LlamadasAtencion * 10;
                empl.Pago = empl.Pago - descMinutosTardanza - descLlamadasAtencion;
            }

            return empl;
        }
    }
}
