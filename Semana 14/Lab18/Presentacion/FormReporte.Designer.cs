
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBuscarLibrosPorNombreDeEditorial = new System.Windows.Forms.Button();
            this.dgLibros = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNombreEditorial = new System.Windows.Forms.TextBox();
            this.btnBuscarLibrosConAutoresConMasDe5AñosDeExp = new System.Windows.Forms.Button();
            this.btnObtenerPromedioDeNroPaginasDeLibrosDelGeneroTerror = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgLibros)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(15, 238);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(248, 26);
            this.btnSalir.TabIndex = 23;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBuscarLibrosPorNombreDeEditorial
            // 
            this.btnBuscarLibrosPorNombreDeEditorial.Location = new System.Drawing.Point(12, 38);
            this.btnBuscarLibrosPorNombreDeEditorial.Name = "btnBuscarLibrosPorNombreDeEditorial";
            this.btnBuscarLibrosPorNombreDeEditorial.Size = new System.Drawing.Size(251, 41);
            this.btnBuscarLibrosPorNombreDeEditorial.TabIndex = 19;
            this.btnBuscarLibrosPorNombreDeEditorial.Text = "Buscar Libros Por Nombre De Editorial";
            this.btnBuscarLibrosPorNombreDeEditorial.UseVisualStyleBackColor = true;
            this.btnBuscarLibrosPorNombreDeEditorial.Click += new System.EventHandler(this.btnBuscarLibrosPorNombreDeEditorial_Click);
            // 
            // dgLibros
            // 
            this.dgLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLibros.Location = new System.Drawing.Point(283, 12);
            this.dgLibros.Name = "dgLibros";
            this.dgLibros.Size = new System.Drawing.Size(505, 252);
            this.dgLibros.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nombre Editorial:";
            // 
            // tbNombreEditorial
            // 
            this.tbNombreEditorial.Location = new System.Drawing.Point(105, 12);
            this.tbNombreEditorial.Name = "tbNombreEditorial";
            this.tbNombreEditorial.Size = new System.Drawing.Size(161, 20);
            this.tbNombreEditorial.TabIndex = 12;
            // 
            // btnBuscarLibrosConAutoresConMasDe5AñosDeExp
            // 
            this.btnBuscarLibrosConAutoresConMasDe5AñosDeExp.Location = new System.Drawing.Point(15, 85);
            this.btnBuscarLibrosConAutoresConMasDe5AñosDeExp.Name = "btnBuscarLibrosConAutoresConMasDe5AñosDeExp";
            this.btnBuscarLibrosConAutoresConMasDe5AñosDeExp.Size = new System.Drawing.Size(251, 41);
            this.btnBuscarLibrosConAutoresConMasDe5AñosDeExp.TabIndex = 24;
            this.btnBuscarLibrosConAutoresConMasDe5AñosDeExp.Text = "Buscar Libros Con Autores Con Más De 5 Años De Experiencia";
            this.btnBuscarLibrosConAutoresConMasDe5AñosDeExp.UseVisualStyleBackColor = true;
            this.btnBuscarLibrosConAutoresConMasDe5AñosDeExp.Click += new System.EventHandler(this.btnBuscarLibrosConAutoresConMasDe5AñosDeExp_Click);
            // 
            // btnObtenerPromedioDeNroPaginasDeLibrosDelGeneroTerror
            // 
            this.btnObtenerPromedioDeNroPaginasDeLibrosDelGeneroTerror.Location = new System.Drawing.Point(12, 132);
            this.btnObtenerPromedioDeNroPaginasDeLibrosDelGeneroTerror.Name = "btnObtenerPromedioDeNroPaginasDeLibrosDelGeneroTerror";
            this.btnObtenerPromedioDeNroPaginasDeLibrosDelGeneroTerror.Size = new System.Drawing.Size(251, 41);
            this.btnObtenerPromedioDeNroPaginasDeLibrosDelGeneroTerror.TabIndex = 25;
            this.btnObtenerPromedioDeNroPaginasDeLibrosDelGeneroTerror.Text = "Obtener Promedio De Número De Páginas De Libros Del Género Terror";
            this.btnObtenerPromedioDeNroPaginasDeLibrosDelGeneroTerror.UseVisualStyleBackColor = true;
            this.btnObtenerPromedioDeNroPaginasDeLibrosDelGeneroTerror.Click += new System.EventHandler(this.btnObtenerPromedioDeNroPaginasDeLibrosDelGeneroTerror_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Promedio:";
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Location = new System.Drawing.Point(72, 187);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(13, 13);
            this.lblPromedio.TabIndex = 27;
            this.lblPromedio.Text = "0";
            // 
            // FormReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 277);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnObtenerPromedioDeNroPaginasDeLibrosDelGeneroTerror);
            this.Controls.Add(this.btnBuscarLibrosConAutoresConMasDe5AñosDeExp);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBuscarLibrosPorNombreDeEditorial);
            this.Controls.Add(this.dgLibros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNombreEditorial);
            this.Name = "FormReporte";
            this.Text = "Reportes";
            ((System.ComponentModel.ISupportInitialize)(this.dgLibros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnBuscarLibrosPorNombreDeEditorial;
        private System.Windows.Forms.DataGridView dgLibros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNombreEditorial;
        private System.Windows.Forms.Button btnBuscarLibrosConAutoresConMasDe5AñosDeExp;
        private System.Windows.Forms.Button btnObtenerPromedioDeNroPaginasDeLibrosDelGeneroTerror;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPromedio;
    }
}