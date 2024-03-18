using Lab05.controllers;
using Lab05.entities;
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

        private ElectrodomesticoController eleController = new ElectrodomesticoController();

        public Form1()
        {
            InitializeComponent();
        }

        private void MostrarElectrodomesticosEnDataGrid(List<Electrodomestico> electrodomesticos)
        {
            dgElectrodomesticos.DataSource = null;

            if (electrodomesticos.Count == 0)
            {
                lblTotalRegistros.Text = "0";
                lblTotalStock.Text = "0";
                return;
            }
            else
            {

                dgElectrodomesticos.DataSource = electrodomesticos;

                // Total de registros
                lblTotalRegistros.Text = electrodomesticos.Count.ToString();

                // Total en stock
                int stockTotal = 0;
                for (int i = 0; i < electrodomesticos.Count; i++)
                {
                    stockTotal += electrodomesticos[i].Stock;
                }

                //electrodomesticos.ForEach(elec => stockTotal += elec.Stock);

                lblTotalStock.Text = stockTotal.ToString();
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validación
            if (tbCodigo.Text == "" || tbNombre.Text == "" || tbPrecio.Text == "" || tbStock.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // Creamos el objeto
            Electrodomestico electrodomestico = new Electrodomestico()
            {
                Codigo = tbCodigo.Text,
                Nombre = tbNombre.Text,
                Precio = double.Parse(tbPrecio.Text),
                Stock = int.Parse(tbStock.Text)
            };

            // Registramos
            bool registrado = eleController.Registrar(electrodomestico);

            if (!registrado)
            {
                MessageBox.Show("Código ya registrado");
                return;
            }

            // Mostramos en Datagrid
            MostrarElectrodomesticosEnDataGrid(eleController.ListarTodo());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Validación
            if (dgElectrodomesticos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione registro a eliminar");
                return;
            }

            String codigo = dgElectrodomesticos.SelectedRows[0].Cells[0].Value.ToString();

            // Eliminamos
            eleController.Eliminar(codigo);

            // Mostramos en Datagrid
            MostrarElectrodomesticosEnDataGrid(eleController.ListarTodo());
        }

        private void btnEliminarTodo_Click(object sender, EventArgs e)
        {
            // Eliminamos
            eleController.EliminarTodo();

            // Mostramos en Datagrid
            MostrarElectrodomesticosEnDataGrid(eleController.ListarTodo());
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            // Ordenamos y Mostramos en Datagrid
            MostrarElectrodomesticosEnDataGrid(eleController.OrdenarPorPrecio());
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Validación
            if (tbBuscar.Text == "")
            {
                MessageBox.Show("Ingrese nombre a buscar");
                return;
            }

            String nombre = tbBuscar.Text;
            // Buscamos y Mostramos en Datagrid
            MostrarElectrodomesticosEnDataGrid(eleController.BuscarPorNombre(nombre));
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Mostramos en Datagrid
            MostrarElectrodomesticosEnDataGrid(eleController.ListarTodo());

            tbBuscar.Text = "";
            tbNombre.Text = "";
            tbCodigo.Text = "";
            tbPrecio.Text = "";
            tbStock.Text = "";
        }
    }
}
