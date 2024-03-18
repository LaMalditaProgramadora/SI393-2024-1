using Lab03.controllers;
using Lab03.entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03
{
    public partial class Form1 : Form
    {
        private AtencionController atencionController = new AtencionController();

        public Form1()
        {
            InitializeComponent();
        }

        private void MostrarEnDataGrid(Atencion[] atenciones)
        {
            dgAtenciones.DataSource = null;
            dgAtenciones.DataSource = atenciones;

            lblTotalServicio1.Text = atencionController.ObtenerTotalServicio1().ToString();
            lblTotalServicio2.Text = atencionController.ObtenerTotalServicio2().ToString();
            lblTotalServicio3.Text = atencionController.ObtenerTotalServicio3().ToString();
            lblPromedioServicio1.Text = atencionController.ObtenerPromedioLavado().ToString();
            lblServicioMenorDemanda.Text = atencionController.ObtenerServicioMenorDemanda().ToString();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validación de campos
            if (cbTipoAuto.Text == "" || cbTipoServicio.Text == "")
            {
                MessageBox.Show("ingrese todos los campos");
                return;
            }

            // Crear la atención
            Atencion atencion = new Atencion()
            {
                TipoAuto = cbTipoAuto.Text,
                TipoServicio = cbTipoServicio.Text
            };

            // Registrar en el arreglo
            atencionController.Registrar(atencion);

            // Mostramos
            MostrarEnDataGrid(atencionController.ListarTodo());
        }
    }
}
