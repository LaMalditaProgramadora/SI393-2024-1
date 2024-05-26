using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Presentacion
{
    /// <summary>
    /// Lógica de interacción para WindowEmpleado.xaml
    /// </summary>
    public partial class WindowEmpleado : Window
    {
        private NEmpleado nEmpleado = new NEmpleado();
        private EEmpleado empleadoSeleccionado = null;

        public WindowEmpleado()
        {
            InitializeComponent();
            MostrarEmpleados(nEmpleado.ListarTodo());
        }

        private void MostrarEmpleados(List<EEmpleado> empleados)
        {
            dgEmpleados.ItemsSource = null;
            dgEmpleados.ItemsSource = empleados;
        }

        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            if (tbDni.Text == "" || tbNombre.Text == "" || cbPuesto.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            EEmpleado empleado = new EEmpleado()
            {
                Dni = tbDni.Text,
                Nombre = tbNombre.Text,
                Puesto = cbPuesto.Text,
                Reuniones = new List<EReunion>()
            };

            bool registrado = nEmpleado.Registrar(empleado);
            if (!registrado)
            {
                MessageBox.Show("Ingrese otro DNI");
                return;
            }

            MostrarEmpleados(nEmpleado.ListarTodo());
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            if (empleadoSeleccionado == null)
            {
                MessageBox.Show("Seleccione un empleado");
                return;
            }

            String dni = empleadoSeleccionado.Dni;
            nEmpleado.Eliminar(dni);

            MostrarEmpleados(nEmpleado.ListarTodo());
        }

        private void bnOrdenarPorSueldo_Click(object sender, RoutedEventArgs e)
        {
            MostrarEmpleados(nEmpleado.OrdenarPorSueldo());
        }

        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            MostrarEmpleados(nEmpleado.ListarTodo());
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void dgEmpleados_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            empleadoSeleccionado = dgEmpleados.SelectedItem as EEmpleado;
        }

        private void btnVerReuniones_Click(object sender, RoutedEventArgs e)
        {
            if (empleadoSeleccionado == null)
            {
                MessageBox.Show("Seleccione un empleado");
                return;
            }

            String dni = empleadoSeleccionado.Dni;
            WindowReunion window = new WindowReunion(dni);
            window.Show();
        }
    }
}
