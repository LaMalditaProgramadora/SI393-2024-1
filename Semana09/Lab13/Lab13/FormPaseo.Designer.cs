
namespace Lab13
{
    partial class FormPaseo
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
            this.dgPaseos = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.tbNombrePerro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCodigoPerro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTamañoPerro = new System.Windows.Forms.ComboBox();
            this.cbObjetivoPaseo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cbTurno = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgPaseos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPaseos
            // 
            this.dgPaseos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPaseos.Location = new System.Drawing.Point(12, 161);
            this.dgPaseos.Name = "dgPaseos";
            this.dgPaseos.Size = new System.Drawing.Size(485, 270);
            this.dgPaseos.TabIndex = 25;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(93, 118);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 24;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(12, 118);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 21;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(310, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Turno:";
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(354, 44);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(143, 20);
            this.tbPrecio.TabIndex = 18;
            // 
            // tbNombrePerro
            // 
            this.tbNombrePerro.Location = new System.Drawing.Point(95, 41);
            this.tbNombrePerro.Name = "tbNombrePerro";
            this.tbNombrePerro.Size = new System.Drawing.Size(143, 20);
            this.tbNombrePerro.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Precio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nombre Perro:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Código Perro:";
            // 
            // tbCodigoPerro
            // 
            this.tbCodigoPerro.Location = new System.Drawing.Point(95, 15);
            this.tbCodigoPerro.Name = "tbCodigoPerro";
            this.tbCodigoPerro.Size = new System.Drawing.Size(143, 20);
            this.tbCodigoPerro.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Tamaño Perro:";
            // 
            // cbTamañoPerro
            // 
            this.cbTamañoPerro.FormattingEnabled = true;
            this.cbTamañoPerro.Items.AddRange(new object[] {
            "Grande",
            "Mediano",
            "Pequeño"});
            this.cbTamañoPerro.Location = new System.Drawing.Point(95, 67);
            this.cbTamañoPerro.Name = "cbTamañoPerro";
            this.cbTamañoPerro.Size = new System.Drawing.Size(143, 21);
            this.cbTamañoPerro.TabIndex = 27;
            // 
            // cbObjetivoPaseo
            // 
            this.cbObjetivoPaseo.FormattingEnabled = true;
            this.cbObjetivoPaseo.Items.AddRange(new object[] {
            "Socialización",
            "Desgaste Físico",
            "Obediencia"});
            this.cbObjetivoPaseo.Location = new System.Drawing.Point(354, 14);
            this.cbObjetivoPaseo.Name = "cbObjetivoPaseo";
            this.cbObjetivoPaseo.Size = new System.Drawing.Size(143, 21);
            this.cbObjetivoPaseo.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(266, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Objetivo Paseo:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(354, 70);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(143, 20);
            this.dtpFecha.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(308, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Fecha:";
            // 
            // cbTurno
            // 
            this.cbTurno.FormattingEnabled = true;
            this.cbTurno.Items.AddRange(new object[] {
            "7am-8am",
            "9am-10am",
            "4pm-5pm",
            "7pm-8pm"});
            this.cbTurno.Location = new System.Drawing.Point(354, 96);
            this.cbTurno.Name = "cbTurno";
            this.cbTurno.Size = new System.Drawing.Size(143, 21);
            this.cbTurno.TabIndex = 32;
            // 
            // FormPaseo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 450);
            this.Controls.Add(this.cbTurno);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbObjetivoPaseo);
            this.Controls.Add(this.cbTamañoPerro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgPaseos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbPrecio);
            this.Controls.Add(this.tbNombrePerro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCodigoPerro);
            this.Name = "FormPaseo";
            this.Text = "Paseos";
            ((System.ComponentModel.ISupportInitialize)(this.dgPaseos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgPaseos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.TextBox tbNombrePerro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCodigoPerro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbTamañoPerro;
        private System.Windows.Forms.ComboBox cbObjetivoPaseo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbTurno;
    }
}