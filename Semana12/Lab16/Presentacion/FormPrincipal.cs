using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnVerDocentes_Click(object sender, EventArgs e)
        {
            FormDocente form = new FormDocente();
            form.Show();
        }

        private void btnVerCursos_Click(object sender, EventArgs e)
        {
            FormCurso form = new FormCurso();
            form.Show();
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            FormDocentexCurso form = new FormDocentexCurso();
            form.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
