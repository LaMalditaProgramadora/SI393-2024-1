using Lab11.controllers;
using Lab11.entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab11
{
    public partial class FormEstacionamiento : Form
    {
        private CarroController carroController = new CarroController();

        public FormEstacionamiento()
        {
            InitializeComponent();
        }

        void MostrarCarrosEnListView(Queue<Carro> cola)
        {
            int contador = 0;
            listViewEstacionamiento.Items.Clear();
            foreach (Carro carro in cola)
            {
                // Agregar fila al ListView
                ListViewItem fila = new ListViewItem(carro.Matricula);
                fila.SubItems.Add(carro.Dueño);

                // Colorear los que están en el estacionamiento
                if (contador < 5)
                {
                    fila.BackColor = Color.Aquamarine;
                    contador++;
                }

                listViewEstacionamiento.Items.Add(fila);
            }
        }

        private void buttonIngreso_Click(object sender, EventArgs e)
        {
            if (carroController.ObtenerCola().Count < 5)
            {
                MessageBox.Show("Se agregará al estacionamiento");
            }
            else
            {
                MessageBox.Show("Se agregará a la cola del estacionamiento");
            }

            // Creación de objeto
            Carro carro = new Carro()
            {
                Matricula = tbMatriculaIngreso.Text,
                Dueño = tbDueñoIngreso.Text
            };

            // Ingresar a la cola
            carroController.Ingresar(carro);

            // Mostrar en el ListView
            MostrarCarrosEnListView(carroController.ObtenerCola());
        }

        private void buttonSalida_Click(object sender, EventArgs e)
        {
            // Obtener matrícula
            String matricula = tbMatriculaSalida.Text;

            int movimientos = carroController.Salir(matricula);
            MessageBox.Show("Se realizaron " + movimientos.ToString() + " movimientos");

            // Mostrar en ListView
            MostrarCarrosEnListView(carroController.ObtenerCola());
        }

    }
}
