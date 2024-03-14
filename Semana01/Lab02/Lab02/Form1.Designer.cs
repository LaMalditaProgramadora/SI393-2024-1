namespace Lab02
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbMinutosTardanza = new System.Windows.Forms.TextBox();
            this.tbLlamadasAtencion = new System.Windows.Forms.TextBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.dgEmpleados = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinutosTardanza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LlamadasAtencion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Categoría:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Minutos Tardanza:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Llamadas de Atención:";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(89, 29);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(135, 20);
            this.tbNombre.TabIndex = 4;
            // 
            // tbMinutosTardanza
            // 
            this.tbMinutosTardanza.Location = new System.Drawing.Point(383, 26);
            this.tbMinutosTardanza.Name = "tbMinutosTardanza";
            this.tbMinutosTardanza.Size = new System.Drawing.Size(135, 20);
            this.tbMinutosTardanza.TabIndex = 5;
            // 
            // tbLlamadasAtencion
            // 
            this.tbLlamadasAtencion.Location = new System.Drawing.Point(383, 52);
            this.tbLlamadasAtencion.Name = "tbLlamadasAtencion";
            this.tbLlamadasAtencion.Size = new System.Drawing.Size(135, 20);
            this.tbLlamadasAtencion.TabIndex = 6;
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cbCategoria.Location = new System.Drawing.Point(89, 55);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(135, 21);
            this.cbCategoria.TabIndex = 7;
            // 
            // dgEmpleados
            // 
            this.dgEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Categoria,
            this.MinutosTardanza,
            this.LlamadasAtencion,
            this.Pago});
            this.dgEmpleados.Location = new System.Drawing.Point(29, 127);
            this.dgEmpleados.Name = "dgEmpleados";
            this.dgEmpleados.Size = new System.Drawing.Size(594, 207);
            this.dgEmpleados.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(383, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(423, 353);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(13, 13);
            this.lblTotal.TabIndex = 10;
            this.lblTotal.Text = "0";
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(29, 93);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(125, 23);
            this.btnProcesar.TabIndex = 11;
            this.btnProcesar.Text = "Procesar Empleado";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            // 
            // MinutosTardanza
            // 
            this.MinutosTardanza.HeaderText = "MinutosTardanza";
            this.MinutosTardanza.Name = "MinutosTardanza";
            // 
            // LlamadasAtencion
            // 
            this.LlamadasAtencion.HeaderText = "LlamadasAtencion";
            this.LlamadasAtencion.Name = "LlamadasAtencion";
            // 
            // Pago
            // 
            this.Pago.HeaderText = "Pago";
            this.Pago.Name = "Pago";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 395);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgEmpleados);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.tbLlamadasAtencion);
            this.Controls.Add(this.tbMinutosTardanza);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Empleados";
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbMinutosTardanza;
        private System.Windows.Forms.TextBox tbLlamadasAtencion;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.DataGridView dgEmpleados;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinutosTardanza;
        private System.Windows.Forms.DataGridViewTextBoxColumn LlamadasAtencion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pago;
    }
}

