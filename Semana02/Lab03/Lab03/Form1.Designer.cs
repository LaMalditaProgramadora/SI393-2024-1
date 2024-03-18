namespace Lab03
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
            this.cbTipoAuto = new System.Windows.Forms.ComboBox();
            this.cbTipoServicio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.dgAtenciones = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotalServicio1 = new System.Windows.Forms.Label();
            this.lblTotalServicio2 = new System.Windows.Forms.Label();
            this.lblTotalServicio3 = new System.Windows.Forms.Label();
            this.lblPromedioServicio1 = new System.Windows.Forms.Label();
            this.lblServicioMenorDemanda = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgAtenciones)).BeginInit();
            this.SuspendLayout();
            // 
            // cbTipoAuto
            // 
            this.cbTipoAuto.FormattingEnabled = true;
            this.cbTipoAuto.Items.AddRange(new object[] {
            "A",
            "C"});
            this.cbTipoAuto.Location = new System.Drawing.Point(112, 24);
            this.cbTipoAuto.Name = "cbTipoAuto";
            this.cbTipoAuto.Size = new System.Drawing.Size(165, 21);
            this.cbTipoAuto.TabIndex = 0;
            // 
            // cbTipoServicio
            // 
            this.cbTipoServicio.FormattingEnabled = true;
            this.cbTipoServicio.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbTipoServicio.Location = new System.Drawing.Point(112, 53);
            this.cbTipoServicio.Name = "cbTipoServicio";
            this.cbTipoServicio.Size = new System.Drawing.Size(165, 21);
            this.cbTipoServicio.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tipo Auto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo Servicio:";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(125, 92);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 4;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // dgAtenciones
            // 
            this.dgAtenciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAtenciones.Location = new System.Drawing.Point(26, 131);
            this.dgAtenciones.Name = "dgAtenciones";
            this.dgAtenciones.Size = new System.Drawing.Size(283, 156);
            this.dgAtenciones.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total Servicio 1 - Lavado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total Servicio 2 - Encerado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Total Servicio 3 - Silicona:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 389);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Promedio Servicio 1 - Lavado:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 416);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Servicio Menor Demanda:";
            // 
            // lblTotalServicio1
            // 
            this.lblTotalServicio1.AutoSize = true;
            this.lblTotalServicio1.Location = new System.Drawing.Point(182, 314);
            this.lblTotalServicio1.Name = "lblTotalServicio1";
            this.lblTotalServicio1.Size = new System.Drawing.Size(13, 13);
            this.lblTotalServicio1.TabIndex = 11;
            this.lblTotalServicio1.Text = "0";
            // 
            // lblTotalServicio2
            // 
            this.lblTotalServicio2.AutoSize = true;
            this.lblTotalServicio2.Location = new System.Drawing.Point(182, 339);
            this.lblTotalServicio2.Name = "lblTotalServicio2";
            this.lblTotalServicio2.Size = new System.Drawing.Size(13, 13);
            this.lblTotalServicio2.TabIndex = 12;
            this.lblTotalServicio2.Text = "0";
            // 
            // lblTotalServicio3
            // 
            this.lblTotalServicio3.AutoSize = true;
            this.lblTotalServicio3.Location = new System.Drawing.Point(182, 365);
            this.lblTotalServicio3.Name = "lblTotalServicio3";
            this.lblTotalServicio3.Size = new System.Drawing.Size(13, 13);
            this.lblTotalServicio3.TabIndex = 13;
            this.lblTotalServicio3.Text = "0";
            // 
            // lblPromedioServicio1
            // 
            this.lblPromedioServicio1.AutoSize = true;
            this.lblPromedioServicio1.Location = new System.Drawing.Point(182, 389);
            this.lblPromedioServicio1.Name = "lblPromedioServicio1";
            this.lblPromedioServicio1.Size = new System.Drawing.Size(13, 13);
            this.lblPromedioServicio1.TabIndex = 14;
            this.lblPromedioServicio1.Text = "0";
            // 
            // lblServicioMenorDemanda
            // 
            this.lblServicioMenorDemanda.AutoSize = true;
            this.lblServicioMenorDemanda.Location = new System.Drawing.Point(182, 416);
            this.lblServicioMenorDemanda.Name = "lblServicioMenorDemanda";
            this.lblServicioMenorDemanda.Size = new System.Drawing.Size(10, 13);
            this.lblServicioMenorDemanda.TabIndex = 15;
            this.lblServicioMenorDemanda.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 451);
            this.Controls.Add(this.lblServicioMenorDemanda);
            this.Controls.Add(this.lblPromedioServicio1);
            this.Controls.Add(this.lblTotalServicio3);
            this.Controls.Add(this.lblTotalServicio2);
            this.Controls.Add(this.lblTotalServicio1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgAtenciones);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTipoServicio);
            this.Controls.Add(this.cbTipoAuto);
            this.Name = "Form1";
            this.Text = "Atenciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgAtenciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTipoAuto;
        private System.Windows.Forms.ComboBox cbTipoServicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DataGridView dgAtenciones;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTotalServicio1;
        private System.Windows.Forms.Label lblTotalServicio2;
        private System.Windows.Forms.Label lblTotalServicio3;
        private System.Windows.Forms.Label lblPromedioServicio1;
        private System.Windows.Forms.Label lblServicioMenorDemanda;
    }
}

