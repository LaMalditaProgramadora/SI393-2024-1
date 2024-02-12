using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05
{
    public partial class Form1 : Form
    {
        private ElectrodomesticoController electController = new ElectrodomesticoController();

        public Form1()
        {
            InitializeComponent();
        }
        private void MostrarEnDataGrid(List<Electrodomestico> electrodomesticos)
        {
            if (electrodomesticos.Count == 0) return;

            dgElectrodomesticos.DataSource = null;
            dgElectrodomesticos.DataSource = electrodomesticos;

            // Halar total de la lista
            labelTotalRegistros.Text = electrodomesticos.Count.ToString();

            // Halar stock de la lista
            int stockTotal = 0;
            electrodomesticos.ForEach(elec => stockTotal += elec.Stock);
            labelTotalStock.Text = stockTotal.ToString();
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            // Validación
            if (textBoxCodigo.Text == "" || textBoxNombre.Text == ""
                || numericUpDownStock.Text == "" || textBoxPrecio.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // Creamos el objeto
            Electrodomestico elec = new Electrodomestico()
            {
                Codigo = textBoxCodigo.Text,
                Nombre = textBoxNombre.Text,
                Stock = (int)numericUpDownStock.Value,
                Precio = double.Parse(textBoxPrecio.Text)
            };


            // Registramos
            bool registrado = electController.Registrar(elec);
            if (!registrado)
            {
                MessageBox.Show("Código ya registrado");
                return;
            }

            // Actualizamos en el data grid
            MostrarEnDataGrid(electController.Listar());

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            // Validación
            if (dgElectrodomesticos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione electrodoméstico a eliminar");
                return;
            }

            String codigo = dgElectrodomesticos.SelectedRows[0].Cells[0].Value.ToString();

            // Eliminamos
            electController.Eliminar(codigo);

            // Actualizamos en el data grid
            MostrarEnDataGrid(electController.Listar());
        }

        private void buttonEliminarTodo_Click(object sender, EventArgs e)
        {
            // Eliminamos
            electController.EliminarTodo();

            // Actualizamos en el data grid
            MostrarEnDataGrid(electController.Listar());
        }

        private void buttonOrdenar_Click(object sender, EventArgs e)
        {
            // Ordenamos y actualizamos en el data grid
            MostrarEnDataGrid(electController.OrdenarPorPrecio());
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            String nombre = textBoxBusqueda.Text;
            // Validación
            if (nombre == "")
            {
                MessageBox.Show("Ingrese nombre de electrodoméstico");
                return;
            }

            // Buscamos y actualizamos en el data grid
            MostrarEnDataGrid(electController.BuscarPorNombre(nombre));
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiamos el cuadro de b�squeda
            textBoxBusqueda.Text = "";
            // Actualizamos en el data grid
            MostrarEnDataGrid(electController.Listar());
        }
    }
}
