
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.btnBuscarAlumnosPorNombre = new System.Windows.Forms.Button();
            this.btnOrdenarAlumnosPorNotaFinalPC2 = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgAlumnos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nombre:";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(76, 17);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(157, 20);
            this.tbNombre.TabIndex = 9;
            // 
            // btnBuscarAlumnosPorNombre
            // 
            this.btnBuscarAlumnosPorNombre.Location = new System.Drawing.Point(26, 65);
            this.btnBuscarAlumnosPorNombre.Name = "btnBuscarAlumnosPorNombre";
            this.btnBuscarAlumnosPorNombre.Size = new System.Drawing.Size(207, 23);
            this.btnBuscarAlumnosPorNombre.TabIndex = 12;
            this.btnBuscarAlumnosPorNombre.Text = "Buscar alumnos por nombre";
            this.btnBuscarAlumnosPorNombre.UseVisualStyleBackColor = true;
            this.btnBuscarAlumnosPorNombre.Click += new System.EventHandler(this.btnBuscarAlumnosPorNombre_Click);
            // 
            // btnOrdenarAlumnosPorNotaFinalPC2
            // 
            this.btnOrdenarAlumnosPorNotaFinalPC2.Location = new System.Drawing.Point(26, 94);
            this.btnOrdenarAlumnosPorNotaFinalPC2.Name = "btnOrdenarAlumnosPorNotaFinalPC2";
            this.btnOrdenarAlumnosPorNotaFinalPC2.Size = new System.Drawing.Size(207, 23);
            this.btnOrdenarAlumnosPorNotaFinalPC2.TabIndex = 13;
            this.btnOrdenarAlumnosPorNotaFinalPC2.Text = "Ordenar alumnos por nota final PC2";
            this.btnOrdenarAlumnosPorNotaFinalPC2.UseVisualStyleBackColor = true;
            this.btnOrdenarAlumnosPorNotaFinalPC2.Click += new System.EventHandler(this.btnOrdenarAlumnosPorNotaFinalPC2_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(26, 229);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(207, 23);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgAlumnos
            // 
            this.dgAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAlumnos.Location = new System.Drawing.Point(262, 17);
            this.dgAlumnos.Name = "dgAlumnos";
            this.dgAlumnos.Size = new System.Drawing.Size(504, 235);
            this.dgAlumnos.TabIndex = 15;
            // 
            // FormReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 272);
            this.Controls.Add(this.dgAlumnos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnOrdenarAlumnosPorNotaFinalPC2);
            this.Controls.Add(this.btnBuscarAlumnosPorNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNombre);
            this.Name = "FormReporte";
            this.Text = "FormReporte";
            ((System.ComponentModel.ISupportInitialize)(this.dgAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Button btnBuscarAlumnosPorNombre;
        private System.Windows.Forms.Button btnOrdenarAlumnosPorNotaFinalPC2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgAlumnos;
    }
}