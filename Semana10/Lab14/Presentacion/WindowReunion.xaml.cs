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
    /// Lógica de interacción para WindowReunion.xaml
    /// </summary>
    public partial class WindowReunion : Window
    {
        private String dni;
        private NReunion nReunion = new NReunion();

        public WindowReunion(String dni)
        {
            InitializeComponent();
            this.dni = dni;
            MostrarReuniones(nReunion.ListarTodo(dni));
        }

        private void MostrarReuniones(List<EReunion> reuniones)
        {
            dgReuniones.ItemsSource = null;
            dgReuniones.ItemsSource = reuniones;
        }

        private void btnRegistrar_Click(object sender, RoutedEventArgs e)
        {
            if (dpFecha.Text == "" || cbTurno.Text == "" || tbAsunto.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            EReunion reunion = new EReunion()
            {
                Fecha = dpFecha.SelectedDate.Value.Date,
                Turno = cbTurno.Text,
                Asunto = tbAsunto.Text
            };

            bool registrado = nReunion.Registrar(dni, reunion);
            if (!registrado)
            {
                MessageBox.Show("Selecciones otro empleado ingrese otra fecha o turno");
                return;
            }

            MostrarReuniones(nReunion.ListarTodo(dni));
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
