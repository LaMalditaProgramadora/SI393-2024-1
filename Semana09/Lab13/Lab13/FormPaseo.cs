using Lab13.entities;
using Lab13.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab13
{
    public partial class FormPaseo : Form
    {
        private String DNI;
        private PaseoService paseoService = new PaseoService();

        public FormPaseo(String DNI)
        {
            InitializeComponent();
            this.DNI = DNI;
            MostrarPaseos(paseoService.ListarTodo(DNI));
        }

        private void MostrarPaseos(List<Paseo> paseos)
        {
            dgPaseos.DataSource = null;
            if (paseos.Count == 0)
            {
                return;
            }
            else
            {
                dgPaseos.DataSource = paseos;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (tbCodigoPerro.Text == "" || tbNombrePerro.Text == "" || cbTamañoPerro.Text == "" || cbObjetivoPaseo.Text == "" ||
                tbPrecio.Text == "" || dtpFecha.Text == "" || cbTurno.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            Paseo paseo = new Paseo()
            {
                CodigoPerro = tbCodigoPerro.Text,
                NombrePerro = tbNombrePerro.Text,
                TamañoPerro = cbTamañoPerro.Text,
                ObjetivoPaseo = cbObjetivoPaseo.Text,
                PrecioCobrado = double.Parse(tbPrecio.Text),
                Fecha = dtpFecha.Value.Date,
                Turno = cbTurno.Text
            };

            bool registrado = paseoService.Registrar(DNI, paseo);
            if (!registrado)
            {
                MessageBox.Show("Ingrese otro Código de Perro, Fecha o Turno");
                return;
            }

            MostrarPaseos(paseoService.ListarTodo(DNI));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
