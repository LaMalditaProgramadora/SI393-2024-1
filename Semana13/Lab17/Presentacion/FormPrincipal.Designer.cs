
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
            this.btnVerDesarrolladores = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVerDesarrolladores
            // 
            this.btnVerDesarrolladores.Location = new System.Drawing.Point(80, 51);
            this.btnVerDesarrolladores.Name = "btnVerDesarrolladores";
            this.btnVerDesarrolladores.Size = new System.Drawing.Size(145, 23);
            this.btnVerDesarrolladores.TabIndex = 0;
            this.btnVerDesarrolladores.Text = "Ver Desarrolladores";
            this.btnVerDesarrolladores.UseVisualStyleBackColor = true;
            this.btnVerDesarrolladores.Click += new System.EventHandler(this.btnVerDesarrolladores_Click);
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(80, 80);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(145, 23);
            this.Salir.TabIndex = 1;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 171);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.btnVerDesarrolladores);
            this.Name = "FormPrincipal";
            this.Text = "Menú";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVerDesarrolladores;
        private System.Windows.Forms.Button Salir;
    }
}

