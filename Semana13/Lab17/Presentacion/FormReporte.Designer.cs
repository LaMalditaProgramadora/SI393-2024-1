
namespace Presentacion
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
            this.dgDesarrolladores = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbIdDesarrollador = new System.Windows.Forms.TextBox();
            this.dgVideojuegos = new System.Windows.Forms.DataGridView();
            this.btnBuscarDesarrolladoresConVideojuegosConValoracionMenorA50 = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBuscarVideojuegosPorNombreDelDesarrollador = new System.Windows.Forms.Button();
            this.btnObtenerMayorValoracionPorDesarrollador = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMayorValoracion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgDesarrolladores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVideojuegos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgDesarrolladores
            // 
            this.dgDesarrolladores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDesarrolladores.Location = new System.Drawing.Point(270, 12);
            this.dgDesarrolladores.Name = "dgDesarrolladores";
            this.dgDesarrolladores.Size = new System.Drawing.Size(507, 184);
            this.dgDesarrolladores.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre:";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(81, 224);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(173, 20);
            this.tbNombre.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "IdDesarrollador:";
            // 
            // tbIdDesarrollador
            // 
            this.tbIdDesarrollador.Location = new System.Drawing.Point(115, 336);
            this.tbIdDesarrollador.Name = "tbIdDesarrollador";
            this.tbIdDesarrollador.Size = new System.Drawing.Size(139, 20);
            this.tbIdDesarrollador.TabIndex = 12;
            // 
            // dgVideojuegos
            // 
            this.dgVideojuegos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVideojuegos.Location = new System.Drawing.Point(270, 224);
            this.dgVideojuegos.Name = "dgVideojuegos";
            this.dgVideojuegos.Size = new System.Drawing.Size(507, 213);
            this.dgVideojuegos.TabIndex = 18;
            // 
            // btnBuscarDesarrolladoresConVideojuegosConValoracionMenorA50
            // 
            this.btnBuscarDesarrolladoresConVideojuegosConValoracionMenorA50.Location = new System.Drawing.Point(21, 40);
            this.btnBuscarDesarrolladoresConVideojuegosConValoracionMenorA50.Name = "btnBuscarDesarrolladoresConVideojuegosConValoracionMenorA50";
            this.btnBuscarDesarrolladoresConVideojuegosConValoracionMenorA50.Size = new System.Drawing.Size(233, 41);
            this.btnBuscarDesarrolladoresConVideojuegosConValoracionMenorA50.TabIndex = 19;
            this.btnBuscarDesarrolladoresConVideojuegosConValoracionMenorA50.Text = "Buscar Desarrolladores con Videojuegos con Valoración menor a 50";
            this.btnBuscarDesarrolladoresConVideojuegosConValoracionMenorA50.UseVisualStyleBackColor = true;
            this.btnBuscarDesarrolladoresConVideojuegosConValoracionMenorA50.Click += new System.EventHandler(this.btnBuscarDesarrolladoresConVideojuegosConValoracionMenorA50_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(21, 87);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(233, 23);
            this.btnSalir.TabIndex = 20;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBuscarVideojuegosPorNombreDelDesarrollador
            // 
            this.btnBuscarVideojuegosPorNombreDelDesarrollador.Location = new System.Drawing.Point(21, 250);
            this.btnBuscarVideojuegosPorNombreDelDesarrollador.Name = "btnBuscarVideojuegosPorNombreDelDesarrollador";
            this.btnBuscarVideojuegosPorNombreDelDesarrollador.Size = new System.Drawing.Size(233, 38);
            this.btnBuscarVideojuegosPorNombreDelDesarrollador.TabIndex = 21;
            this.btnBuscarVideojuegosPorNombreDelDesarrollador.Text = "Buscar Videojuegos por Nombre del Desarrollador";
            this.btnBuscarVideojuegosPorNombreDelDesarrollador.UseVisualStyleBackColor = true;
            this.btnBuscarVideojuegosPorNombreDelDesarrollador.Click += new System.EventHandler(this.btnBuscarVideojuegosPorNombreDelDesarrollador_Click);
            // 
            // btnObtenerMayorValoracionPorDesarrollador
            // 
            this.btnObtenerMayorValoracionPorDesarrollador.Location = new System.Drawing.Point(21, 362);
            this.btnObtenerMayorValoracionPorDesarrollador.Name = "btnObtenerMayorValoracionPorDesarrollador";
            this.btnObtenerMayorValoracionPorDesarrollador.Size = new System.Drawing.Size(233, 38);
            this.btnObtenerMayorValoracionPorDesarrollador.TabIndex = 22;
            this.btnObtenerMayorValoracionPorDesarrollador.Text = "Obtener mayor Valoración de Videojuego por Desarrollador";
            this.btnObtenerMayorValoracionPorDesarrollador.UseVisualStyleBackColor = true;
            this.btnObtenerMayorValoracionPorDesarrollador.Click += new System.EventHandler(this.btnObtenerMayorValoracionPorDesarrollador_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 411);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Mayor Valoración:";
            // 
            // lblMayorValoracion
            // 
            this.lblMayorValoracion.AutoSize = true;
            this.lblMayorValoracion.Location = new System.Drawing.Point(126, 411);
            this.lblMayorValoracion.Name = "lblMayorValoracion";
            this.lblMayorValoracion.Size = new System.Drawing.Size(13, 13);
            this.lblMayorValoracion.TabIndex = 24;
            this.lblMayorValoracion.Text = "0";
            // 
            // FormReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.lblMayorValoracion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnObtenerMayorValoracionPorDesarrollador);
            this.Controls.Add(this.btnBuscarVideojuegosPorNombreDelDesarrollador);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBuscarDesarrolladoresConVideojuegosConValoracionMenorA50);
            this.Controls.Add(this.dgVideojuegos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbIdDesarrollador);
            this.Controls.Add(this.dgDesarrolladores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNombre);
            this.Name = "FormReporte";
            this.Text = "FormReporte";
            ((System.ComponentModel.ISupportInitialize)(this.dgDesarrolladores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVideojuegos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgDesarrolladores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbIdDesarrollador;
        private System.Windows.Forms.DataGridView dgVideojuegos;
        private System.Windows.Forms.Button btnBuscarDesarrolladoresConVideojuegosConValoracionMenorA50;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnBuscarVideojuegosPorNombreDelDesarrollador;
        private System.Windows.Forms.Button btnObtenerMayorValoracionPorDesarrollador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMayorValoracion;
    }
}