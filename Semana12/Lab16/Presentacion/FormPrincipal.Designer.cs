
namespace Presentacion
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnVerDocentes = new System.Windows.Forms.Button();
            this.btnVerCursos = new System.Windows.Forms.Button();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVerDocentes
            // 
            this.btnVerDocentes.Location = new System.Drawing.Point(98, 60);
            this.btnVerDocentes.Name = "btnVerDocentes";
            this.btnVerDocentes.Size = new System.Drawing.Size(119, 23);
            this.btnVerDocentes.TabIndex = 0;
            this.btnVerDocentes.Text = "Ver Docentes";
            this.btnVerDocentes.UseVisualStyleBackColor = true;
            this.btnVerDocentes.Click += new System.EventHandler(this.btnVerDocentes_Click);
            // 
            // btnVerCursos
            // 
            this.btnVerCursos.Location = new System.Drawing.Point(98, 89);
            this.btnVerCursos.Name = "btnVerCursos";
            this.btnVerCursos.Size = new System.Drawing.Size(119, 23);
            this.btnVerCursos.TabIndex = 1;
            this.btnVerCursos.Text = "Ver Cursos";
            this.btnVerCursos.UseVisualStyleBackColor = true;
            this.btnVerCursos.Click += new System.EventHandler(this.btnVerCursos_Click);
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(98, 118);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(119, 23);
            this.btnAsignar.TabIndex = 2;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(98, 147);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(119, 23);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 225);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.btnVerCursos);
            this.Controls.Add(this.btnVerDocentes);
            this.Name = "FormPrincipal";
            this.Text = "Menú";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVerDocentes;
        private System.Windows.Forms.Button btnVerCursos;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.Button btnSalir;
    }
}

