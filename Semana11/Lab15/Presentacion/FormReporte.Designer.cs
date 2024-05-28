
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
            this.dgAlumnos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.btnOrdenarPorNotaFinalPC2 = new System.Windows.Forms.Button();
            this.btnBuscarPorNombre = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgAlumnos
            // 
            this.dgAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAlumnos.Location = new System.Drawing.Point(245, 12);
            this.dgAlumnos.Name = "dgAlumnos";
            this.dgAlumnos.Size = new System.Drawing.Size(518, 229);
            this.dgAlumnos.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nombre:";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(70, 12);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(149, 20);
            this.tbNombre.TabIndex = 13;
            // 
            // btnOrdenarPorNotaFinalPC2
            // 
            this.btnOrdenarPorNotaFinalPC2.Location = new System.Drawing.Point(20, 98);
            this.btnOrdenarPorNotaFinalPC2.Name = "btnOrdenarPorNotaFinalPC2";
            this.btnOrdenarPorNotaFinalPC2.Size = new System.Drawing.Size(199, 23);
            this.btnOrdenarPorNotaFinalPC2.TabIndex = 16;
            this.btnOrdenarPorNotaFinalPC2.Text = "Ordenar por nota final PC2";
            this.btnOrdenarPorNotaFinalPC2.UseVisualStyleBackColor = true;
            this.btnOrdenarPorNotaFinalPC2.Click += new System.EventHandler(this.btnOrdenarPorNotaFinalPC2_Click);
            // 
            // btnBuscarPorNombre
            // 
            this.btnBuscarPorNombre.Location = new System.Drawing.Point(20, 49);
            this.btnBuscarPorNombre.Name = "btnBuscarPorNombre";
            this.btnBuscarPorNombre.Size = new System.Drawing.Size(199, 23);
            this.btnBuscarPorNombre.TabIndex = 17;
            this.btnBuscarPorNombre.Text = "Buscar por nombre";
            this.btnBuscarPorNombre.UseVisualStyleBackColor = true;
            this.btnBuscarPorNombre.Click += new System.EventHandler(this.btnBuscarPorNombre_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(84, 218);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 18;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 253);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBuscarPorNombre);
            this.Controls.Add(this.btnOrdenarPorNotaFinalPC2);
            this.Controls.Add(this.dgAlumnos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNombre);
            this.Name = "FormReporte";
            this.Text = "Reportes";
            ((System.ComponentModel.ISupportInitialize)(this.dgAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgAlumnos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Button btnOrdenarPorNotaFinalPC2;
        private System.Windows.Forms.Button btnBuscarPorNombre;
        private System.Windows.Forms.Button btnSalir;
    }
}