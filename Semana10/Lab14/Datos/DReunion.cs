using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DReunion
    {
        public bool Existe(String dni, DateTime fecha, String turno)
        {
            List<EEmpleado> empleados = DEmpleado.ListarTodo();
            return empleados.Exists(e => e.Reuniones.Exists(r => e.Dni.Equals(dni) && r.Fecha.Equals(fecha) && r.Turno.Equals(turno)));
        }

        public void Registrar(String dni, EReunion reunion)
        {
            List<EEmpleado> empleados = DEmpleado.ListarTodo();
            EEmpleado empleado = empleados.Find(e => e.Dni.Equals(dni));
            empleado.Reuniones.Add(reunion);
        }

        public List<EReunion> ListarTodo(String dni)
        {
            List<EEmpleado> empleados = DEmpleado.ListarTodo();
            EEmpleado empleado = empleados.Find(e => e.Dni.Equals(dni));
            return empleado.Reuniones;
        }
    }
}
