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
        private AtencionController atenController = new AtencionController();

        public Form1()
        {
            InitializeComponent();
        }

        private void MostrarEnDataGrid(Atencion[] atenciones)
        {
            dgAtenciones.DataSource = null;
            dgAtenciones.DataSource = atenciones;

            labelPromedioLavado.Text = atenController.ObtenerPromedioLavado().ToString();
            labelTotalServicio1.Text = atenController.ObtenerTotalServicio1().ToString();
            labelTotalServicio2.Text = atenController.ObtenerTotalServicio2().ToString();
            labelTotalServicio3.Text = atenController.ObtenerTotalServicio3().ToString();
            labelServicioMinimaDemanda.Text = atenController.ServicioMenorDemanda();
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            // Validar campos
            if (comboBoxTipoAuto.Text == "" || comboBoxTipoServicio.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // Creación de la atención
            Atencion atencion = new Atencion();
            atencion.TipoAuto = comboBoxTipoAuto.Text;
            atencion.TipoServicio = comboBoxTipoServicio.Text;

            // Registrar en el arreglo
            atenController.Registrar(atencion);

            // Mostrar en el datagrid
            MostrarEnDataGrid(atenController.ObtenerTodo());
        }
    }
}
