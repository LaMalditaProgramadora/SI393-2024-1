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
        private EmpleadoController emplController = new EmpleadoController();

        public Form1()
        {
            InitializeComponent();
        }

        private void MostrarNuevoEmpleado(Empleado empl)
        {
            dgEmpleados.Rows.Add(empl.Nombre, empl.Categoria, empl.MinutosTardanza, empl.LlamadasAtencion, empl.Pago);
            labelTotal.Text = (int.Parse(labelTotal.Text) + 1).ToString();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validar campos

            if (textBoxNombre.Text == "" || comboBoxCategoria.Text == ""
                || textBoxMinutosTardanza.Text == "" || textBoxLlamadasAtencion.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            // Creando al empleado
            Empleado empl = new Empleado();
            empl.Nombre = textBoxNombre.Text;
            empl.Categoria = comboBoxCategoria.Text;
            empl.MinutosTardanza = int.Parse(textBoxMinutosTardanza.Text);
            empl.LlamadasAtencion = int.Parse(textBoxLlamadasAtencion.Text);

            // Procesamos el pago del nuevo empleado
            empl = emplController.ProcesarEmpleado(empl);

            // Agregar todo al Datagrid
            MostrarNuevoEmpleado(empl);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
