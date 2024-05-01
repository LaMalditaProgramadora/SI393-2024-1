using System.Drawing;
using System.Windows.Forms;

namespace Lab12
{
    partial class FormReporte
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.tbEspecialidad = new System.Windows.Forms.TextBox();
            this.btnBuscarDoctoresConPacientesConMayorEdad = new System.Windows.Forms.Button();
            this.btnBuscarDoctoresConMenosPacientes = new System.Windows.Forms.Button();
            this.btnBuscarPacientesPorEspecialidadDelDoctor = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgPacientes = new System.Windows.Forms.DataGridView();
            this.dgDoctores = new System.Windows.Forms.DataGridView();
            this.btnBuscarEspecialidadesConMasDoctores = new System.Windows.Forms.Button();
            this.dgReportes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgPacientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDoctores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgReportes)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(328, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Especialidad:";
            // 
            // tbEspecialidad
            // 
            this.tbEspecialidad.Location = new System.Drawing.Point(402, 23);
            this.tbEspecialidad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbEspecialidad.Name = "tbEspecialidad";
            this.tbEspecialidad.Size = new System.Drawing.Size(195, 20);
            this.tbEspecialidad.TabIndex = 12;
            // 
            // btnBuscarDoctoresConPacientesConMayorEdad
            // 
            this.btnBuscarDoctoresConPacientesConMayorEdad.Location = new System.Drawing.Point(20, 26);
            this.btnBuscarDoctoresConPacientesConMayorEdad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscarDoctoresConPacientesConMayorEdad.Name = "btnBuscarDoctoresConPacientesConMayorEdad";
            this.btnBuscarDoctoresConPacientesConMayorEdad.Size = new System.Drawing.Size(266, 20);
            this.btnBuscarDoctoresConPacientesConMayorEdad.TabIndex = 15;
            this.btnBuscarDoctoresConPacientesConMayorEdad.Text = "Buscar Doctores con Pacientes con mayor edad";
            this.btnBuscarDoctoresConPacientesConMayorEdad.UseVisualStyleBackColor = true;
            this.btnBuscarDoctoresConPacientesConMayorEdad.Click += new System.EventHandler(this.btnBuscarDoctoresConPacientesConMayorEdad_Click);
            // 
            // btnBuscarDoctoresConMenosPacientes
            // 
            this.btnBuscarDoctoresConMenosPacientes.Location = new System.Drawing.Point(20, 51);
            this.btnBuscarDoctoresConMenosPacientes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscarDoctoresConMenosPacientes.Name = "btnBuscarDoctoresConMenosPacientes";
            this.btnBuscarDoctoresConMenosPacientes.Size = new System.Drawing.Size(266, 20);
            this.btnBuscarDoctoresConMenosPacientes.TabIndex = 16;
            this.btnBuscarDoctoresConMenosPacientes.Text = "Buscar Doctores con Menos Pacientes";
            this.btnBuscarDoctoresConMenosPacientes.UseVisualStyleBackColor = true;
            this.btnBuscarDoctoresConMenosPacientes.Click += new System.EventHandler(this.btnBuscarDoctoresConMenosPacientes_Click);
            // 
            // btnBuscarPacientesPorEspecialidadDelDoctor
            // 
            this.btnBuscarPacientesPorEspecialidadDelDoctor.Location = new System.Drawing.Point(331, 51);
            this.btnBuscarPacientesPorEspecialidadDelDoctor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscarPacientesPorEspecialidadDelDoctor.Name = "btnBuscarPacientesPorEspecialidadDelDoctor";
            this.btnBuscarPacientesPorEspecialidadDelDoctor.Size = new System.Drawing.Size(266, 20);
            this.btnBuscarPacientesPorEspecialidadDelDoctor.TabIndex = 17;
            this.btnBuscarPacientesPorEspecialidadDelDoctor.Text = "Buscar Pacientes por Especialidad del Doctor";
            this.btnBuscarPacientesPorEspecialidadDelDoctor.UseVisualStyleBackColor = true;
            this.btnBuscarPacientesPorEspecialidadDelDoctor.Click += new System.EventHandler(this.btnBuscarPacientesPorEspecialidadDelDoctor_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(428, 282);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(64, 20);
            this.btnSalir.TabIndex = 18;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgPacientes
            // 
            this.dgPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPacientes.Location = new System.Drawing.Point(331, 101);
            this.dgPacientes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgPacientes.Name = "dgPacientes";
            this.dgPacientes.RowTemplate.Height = 24;
            this.dgPacientes.Size = new System.Drawing.Size(266, 159);
            this.dgPacientes.TabIndex = 19;
            // 
            // dgDoctores
            // 
            this.dgDoctores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDoctores.Location = new System.Drawing.Point(20, 101);
            this.dgDoctores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgDoctores.Name = "dgDoctores";
            this.dgDoctores.RowTemplate.Height = 24;
            this.dgDoctores.Size = new System.Drawing.Size(266, 159);
            this.dgDoctores.TabIndex = 20;
            // 
            // btnBuscarEspecialidadesConMasDoctores
            // 
            this.btnBuscarEspecialidadesConMasDoctores.Location = new System.Drawing.Point(643, 51);
            this.btnBuscarEspecialidadesConMasDoctores.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarEspecialidadesConMasDoctores.Name = "btnBuscarEspecialidadesConMasDoctores";
            this.btnBuscarEspecialidadesConMasDoctores.Size = new System.Drawing.Size(266, 20);
            this.btnBuscarEspecialidadesConMasDoctores.TabIndex = 21;
            this.btnBuscarEspecialidadesConMasDoctores.Text = "Buscar Especialidades con más Doctores";
            this.btnBuscarEspecialidadesConMasDoctores.UseVisualStyleBackColor = true;
            this.btnBuscarEspecialidadesConMasDoctores.Click += new System.EventHandler(this.btnBuscarEspecialidadesConMasDoctores_Click);
            // 
            // dgReportes
            // 
            this.dgReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReportes.Location = new System.Drawing.Point(643, 101);
            this.dgReportes.Margin = new System.Windows.Forms.Padding(2);
            this.dgReportes.Name = "dgReportes";
            this.dgReportes.RowTemplate.Height = 24;
            this.dgReportes.Size = new System.Drawing.Size(266, 159);
            this.dgReportes.TabIndex = 22;
            // 
            // FormReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 319);
            this.Controls.Add(this.dgReportes);
            this.Controls.Add(this.btnBuscarEspecialidadesConMasDoctores);
            this.Controls.Add(this.dgDoctores);
            this.Controls.Add(this.dgPacientes);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBuscarPacientesPorEspecialidadDelDoctor);
            this.Controls.Add(this.btnBuscarDoctoresConMenosPacientes);
            this.Controls.Add(this.btnBuscarDoctoresConPacientesConMayorEdad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbEspecialidad);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormReporte";
            this.Text = "Reportes";
            ((System.ComponentModel.ISupportInitialize)(this.dgPacientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDoctores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgReportes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label3;
        private TextBox tbEspecialidad;
        private Button btnBuscarDoctoresConPacientesConMayorEdad;
        private Button btnBuscarDoctoresConMenosPacientes;
        private Button btnBuscarPacientesPorEspecialidadDelDoctor;
        private Button btnSalir;
        private DataGridView dgPacientes;
        private DataGridView dgDoctores;
        private Button btnBuscarEspecialidadesConMasDoctores;
        private DataGridView dgReportes;
    }
}