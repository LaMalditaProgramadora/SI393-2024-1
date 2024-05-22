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
    /// Lógica de interacción para WindowPrincipal.xaml
    /// </summary>
    public partial class WindowPrincipal : Window
    {
        public WindowPrincipal()
        {
            InitializeComponent();
        }

        private void btnVerEmpleados_Click(object sender, RoutedEventArgs e)
        {
            WindowEmpleado window = new WindowEmpleado();
            window.Show();
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
