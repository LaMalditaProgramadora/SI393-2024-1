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
    public partial class FormPaseador : Form
    {
        private PaseadorService paseadorService = new PaseadorService();

        public FormPaseador()
        {
            InitializeComponent();
            MostrarPaseadores(paseadorService.ListarTodo());
        }

        private void MostrarPaseadores(List<Paseador> paseadores)
        {
            dgPaseadores.DataSource = null;
            if (paseadores.Count == 0)
            {
                return;
            }
            else
            {
                dgPaseadores.DataSource = paseadores;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (tbDNI.Text == "" || tbNombre.Text == "" || tbCelular.Text == "" || tbAñosExp.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos");
                return;
            }

            Paseador paseador = new Paseador()
            {
                DNI = tbDNI.Text,
                Nombre = tbNombre.Text,
                Celular = tbCelular.Text,
                AñosExperiencia = int.Parse(tbAñosExp.Text),
                Paseos = new List<Paseo>()
            };

            bool registrado = paseadorService.Registrar(paseador);
            if (!registrado)
            {
                MessageBox.Show("Ingrese otro DNI");
                return;
            }

            MostrarPaseadores(paseadorService.ListarTodo());
        }

        private void btnVerPaseos_Click(object sender, EventArgs e)
        {
            if (dgPaseadores.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione paseador");
                return;
            }

            String DNI = dgPaseadores.SelectedRows[0].Cells[0].Value.ToString();

            FormPaseo form = new FormPaseo(DNI);
            form.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            FormReporte form = new FormReporte();
            form.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
