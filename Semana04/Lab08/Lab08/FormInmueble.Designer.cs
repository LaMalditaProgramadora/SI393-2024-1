
namespace Lab08
{
    partial class FormInmueble
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
            this.cbCondicion = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.tbSuperficie = new System.Windows.Forms.TextBox();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dgInmuebles = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgInmuebles)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(38, 203);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(269, 20);
            this.btnSalir.TabIndex = 70;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // cbCondicion
            // 
            this.cbCondicion.FormattingEnabled = true;
            this.cbCondicion.Items.AddRange(new object[] {
            "Venta",
            "Alquiler"});
            this.cbCondicion.Location = new System.Drawing.Point(99, 147);
            this.cbCondicion.Name = "cbCondicion";
            this.cbCondicion.Size = new System.Drawing.Size(209, 21);
            this.cbCondicion.TabIndex = 69;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(38, 177);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(269, 20);
            this.btnRegistrar.TabIndex = 68;
            this.btnRegistrar.Text = "Agregar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(38, 150);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 67;
            this.label11.Text = "Condicion:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 66;
            this.label6.Text = "Precio:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 65;
            this.label7.Text = "Superficie:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 64;
            this.label8.Text = "Dirección:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(50, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 63;
            this.label9.Text = "Código:";
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(99, 122);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(209, 20);
            this.tbPrecio.TabIndex = 62;
            // 
            // tbSuperficie
            // 
            this.tbSuperficie.Location = new System.Drawing.Point(99, 97);
            this.tbSuperficie.Name = "tbSuperficie";
            this.tbSuperficie.Size = new System.Drawing.Size(209, 20);
            this.tbSuperficie.TabIndex = 61;
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(99, 72);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(209, 20);
            this.tbDireccion.TabIndex = 60;
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(99, 47);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(209, 20);
            this.tbCodigo.TabIndex = 59;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(149, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 15);
            this.label10.TabIndex = 58;
            this.label10.Text = "INMUEBLE";
            // 
            // dgInmuebles
            // 
            this.dgInmuebles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInmuebles.Location = new System.Drawing.Point(345, 22);
            this.dgInmuebles.Name = "dgInmuebles";
            this.dgInmuebles.Size = new System.Drawing.Size(419, 201);
            this.dgInmuebles.TabIndex = 71;
            // 
            // FormInmueble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 242);
            this.Controls.Add(this.dgInmuebles);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.cbCondicion);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbPrecio);
            this.Controls.Add(this.tbSuperficie);
            this.Controls.Add(this.tbDireccion);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.label10);
            this.Name = "FormInmueble";
            this.Text = "Inmuebles";
            ((System.ComponentModel.ISupportInitialize)(this.dgInmuebles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox cbCondicion;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.TextBox tbSuperficie;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgInmuebles;
    }
}