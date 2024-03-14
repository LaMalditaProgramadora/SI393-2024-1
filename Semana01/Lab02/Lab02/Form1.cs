using Lab02.controllers;
using Lab02.entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Form1 : Form
    {
        private EmpleadoController empleadoController = new EmpleadoController();

        public Form1()
        {
            InitializeComponent();
        }

        private void MostrarNuevoEmpleado(Empleado empleado)
        {
            dgEmpleados.Rows.Add(empleado.Nombre, empleado.Categoria, empleado.MinutosTardanza, empleado.LlamadasAtencion, empleado.Pago);
            lblTotal.Text = (int.Parse(lblTotal.Text) + 1).ToString();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            // Validación de campos
            if (tbNombre.Text == "" || cbCategoria.Text == "" || tbMinutosTardanza.Text == "" || tbLlamadasAtencion.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // Crear el empleado
            Empleado empleado = new Empleado()
            {
                Nombre = tbNombre.Text,
                Categoria = cbCategoria.Text,
                MinutosTardanza = int.Parse(tbMinutosTardanza.Text),
                LlamadasAtencion = int.Parse(tbLlamadasAtencion.Text)
            };

            // Procesar el empleado
            empleado = empleadoController.ProcesarEmpleado(empleado);

            // Agregarlo en el datagrid
            MostrarNuevoEmpleado(empleado);
        }
    }
}
