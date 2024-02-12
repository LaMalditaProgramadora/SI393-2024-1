using System.Drawing;
using System.Windows.Forms;

namespace Lab08
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAgenciaCodigo = new System.Windows.Forms.TextBox();
            this.tbAgenciaDireccion = new System.Windows.Forms.TextBox();
            this.tbAgenciaCiudad = new System.Windows.Forms.TextBox();
            this.tbAgenciaTelefono = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbInmueblePrecio = new System.Windows.Forms.TextBox();
            this.tbInmuebleSuperficie = new System.Windows.Forms.TextBox();
            this.tbInmuebleDireccion = new System.Windows.Forms.TextBox();
            this.tbInmuebleCodigo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAgregarAgencia = new System.Windows.Forms.Button();
            this.btnAgregarInmueble = new System.Windows.Forms.Button();
            this.btnAgenciasAlquilerInmueblesMayorSuperficie = new System.Windows.Forms.Button();
            this.btnAgenciasMayorCantidadInmueblesVenta = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.lblMontoTotalAlquilerInmuebles = new System.Windows.Forms.Label();
            this.cbInmuebleCondicion = new System.Windows.Forms.ComboBox();
            this.btnLimpiarAgencia = new System.Windows.Forms.Button();
            this.btnLimpiarInmueble = new System.Windows.Forms.Button();
            this.dgAgencias = new System.Windows.Forms.DataGridView();
            this.dgInmuebles = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAgencias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgInmuebles)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(18, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 202);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(119, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "AGENCIA";
            // 
            // tbAgenciaCodigo
            // 
            this.tbAgenciaCodigo.Location = new System.Drawing.Point(92, 48);
            this.tbAgenciaCodigo.Name = "tbAgenciaCodigo";
            this.tbAgenciaCodigo.Size = new System.Drawing.Size(160, 20);
            this.tbAgenciaCodigo.TabIndex = 2;
            // 
            // tbAgenciaDireccion
            // 
            this.tbAgenciaDireccion.Location = new System.Drawing.Point(92, 73);
            this.tbAgenciaDireccion.Name = "tbAgenciaDireccion";
            this.tbAgenciaDireccion.Size = new System.Drawing.Size(160, 20);
            this.tbAgenciaDireccion.TabIndex = 3;
            // 
            // tbAgenciaCiudad
            // 
            this.tbAgenciaCiudad.Location = new System.Drawing.Point(92, 98);
            this.tbAgenciaCiudad.Name = "tbAgenciaCiudad";
            this.tbAgenciaCiudad.Size = new System.Drawing.Size(160, 20);
            this.tbAgenciaCiudad.TabIndex = 4;
            // 
            // tbAgenciaTelefono
            // 
            this.tbAgenciaTelefono.Location = new System.Drawing.Point(92, 123);
            this.tbAgenciaTelefono.Name = "tbAgenciaTelefono";
            this.tbAgenciaTelefono.Size = new System.Drawing.Size(160, 20);
            this.tbAgenciaTelefono.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Código:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Dirección:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ciudad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Teléfono:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(345, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Precio:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(328, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Superficie:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(330, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Dirección:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(342, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Código:";
            // 
            // tbInmueblePrecio
            // 
            this.tbInmueblePrecio.Location = new System.Drawing.Point(391, 123);
            this.tbInmueblePrecio.Name = "tbInmueblePrecio";
            this.tbInmueblePrecio.Size = new System.Drawing.Size(209, 20);
            this.tbInmueblePrecio.TabIndex = 15;
            // 
            // tbInmuebleSuperficie
            // 
            this.tbInmuebleSuperficie.Location = new System.Drawing.Point(391, 98);
            this.tbInmuebleSuperficie.Name = "tbInmuebleSuperficie";
            this.tbInmuebleSuperficie.Size = new System.Drawing.Size(209, 20);
            this.tbInmuebleSuperficie.TabIndex = 14;
            // 
            // tbInmuebleDireccion
            // 
            this.tbInmuebleDireccion.Location = new System.Drawing.Point(391, 73);
            this.tbInmuebleDireccion.Name = "tbInmuebleDireccion";
            this.tbInmuebleDireccion.Size = new System.Drawing.Size(209, 20);
            this.tbInmuebleDireccion.TabIndex = 13;
            // 
            // tbInmuebleCodigo
            // 
            this.tbInmuebleCodigo.Location = new System.Drawing.Point(391, 48);
            this.tbInmuebleCodigo.Name = "tbInmuebleCodigo";
            this.tbInmuebleCodigo.Size = new System.Drawing.Size(209, 20);
            this.tbInmuebleCodigo.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(441, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 15);
            this.label10.TabIndex = 11;
            this.label10.Text = "INMUEBLE";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox2.Location = new System.Drawing.Point(285, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(361, 227);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(330, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Condicion:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox3.Location = new System.Drawing.Point(18, 432);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(251, 107);
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox4.Location = new System.Drawing.Point(285, 473);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(361, 65);
            this.pictureBox4.TabIndex = 27;
            this.pictureBox4.TabStop = false;
            // 
            // tbBuscar
            // 
            this.tbBuscar.Location = new System.Drawing.Point(401, 485);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(150, 20);
            this.tbBuscar.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(293, 488);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Buscar por agencia:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(555, 484);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(74, 20);
            this.btnBuscar.TabIndex = 30;
            this.btnBuscar.Text = "Buscar Venta";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAgregarAgencia
            // 
            this.btnAgregarAgencia.Location = new System.Drawing.Point(35, 153);
            this.btnAgregarAgencia.Name = "btnAgregarAgencia";
            this.btnAgregarAgencia.Size = new System.Drawing.Size(216, 20);
            this.btnAgregarAgencia.TabIndex = 31;
            this.btnAgregarAgencia.Text = "Agregar";
            this.btnAgregarAgencia.UseVisualStyleBackColor = true;
            this.btnAgregarAgencia.Click += new System.EventHandler(this.btnAgregarAgencia_Click);
            // 
            // btnAgregarInmueble
            // 
            this.btnAgregarInmueble.Location = new System.Drawing.Point(330, 178);
            this.btnAgregarInmueble.Name = "btnAgregarInmueble";
            this.btnAgregarInmueble.Size = new System.Drawing.Size(269, 20);
            this.btnAgregarInmueble.TabIndex = 32;
            this.btnAgregarInmueble.Text = "Agregar";
            this.btnAgregarInmueble.UseVisualStyleBackColor = true;
            this.btnAgregarInmueble.Click += new System.EventHandler(this.btnAgregarInmueble_Click);
            // 
            // btnAgenciasAlquilerInmueblesMayorSuperficie
            // 
            this.btnAgenciasAlquilerInmueblesMayorSuperficie.Location = new System.Drawing.Point(35, 443);
            this.btnAgenciasAlquilerInmueblesMayorSuperficie.Name = "btnAgenciasAlquilerInmueblesMayorSuperficie";
            this.btnAgenciasAlquilerInmueblesMayorSuperficie.Size = new System.Drawing.Size(216, 37);
            this.btnAgenciasAlquilerInmueblesMayorSuperficie.TabIndex = 33;
            this.btnAgenciasAlquilerInmueblesMayorSuperficie.Text = "Buscar las que alquilan inmuebles con mayor superficie";
            this.btnAgenciasAlquilerInmueblesMayorSuperficie.UseVisualStyleBackColor = true;
            this.btnAgenciasAlquilerInmueblesMayorSuperficie.Click += new System.EventHandler(this.btnAgenciasAlquilerInmueblesMayorSuperficie_Click);
            // 
            // btnAgenciasMayorCantidadInmueblesVenta
            // 
            this.btnAgenciasMayorCantidadInmueblesVenta.Location = new System.Drawing.Point(35, 485);
            this.btnAgenciasMayorCantidadInmueblesVenta.Name = "btnAgenciasMayorCantidadInmueblesVenta";
            this.btnAgenciasMayorCantidadInmueblesVenta.Size = new System.Drawing.Size(216, 37);
            this.btnAgenciasMayorCantidadInmueblesVenta.TabIndex = 34;
            this.btnAgenciasMayorCantidadInmueblesVenta.Text = "Buscar las tienen más inmuebles en venta";
            this.btnAgenciasMayorCantidadInmueblesVenta.UseVisualStyleBackColor = true;
            this.btnAgenciasMayorCantidadInmueblesVenta.Click += new System.EventHandler(this.btnAgenciasMayorCantidadInmueblesVenta_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(296, 509);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "Monto total alquiler:";
            // 
            // lblMontoTotalAlquilerInmuebles
            // 
            this.lblMontoTotalAlquilerInmuebles.AutoSize = true;
            this.lblMontoTotalAlquilerInmuebles.Location = new System.Drawing.Point(401, 509);
            this.lblMontoTotalAlquilerInmuebles.Name = "lblMontoTotalAlquilerInmuebles";
            this.lblMontoTotalAlquilerInmuebles.Size = new System.Drawing.Size(13, 13);
            this.lblMontoTotalAlquilerInmuebles.TabIndex = 36;
            this.lblMontoTotalAlquilerInmuebles.Text = "0";
            // 
            // cbInmuebleCondicion
            // 
            this.cbInmuebleCondicion.FormattingEnabled = true;
            this.cbInmuebleCondicion.Items.AddRange(new object[] {
            "Venta",
            "Alquiler"});
            this.cbInmuebleCondicion.Location = new System.Drawing.Point(391, 148);
            this.cbInmuebleCondicion.Name = "cbInmuebleCondicion";
            this.cbInmuebleCondicion.Size = new System.Drawing.Size(209, 21);
            this.cbInmuebleCondicion.TabIndex = 37;
            // 
            // btnLimpiarAgencia
            // 
            this.btnLimpiarAgencia.Location = new System.Drawing.Point(35, 179);
            this.btnLimpiarAgencia.Name = "btnLimpiarAgencia";
            this.btnLimpiarAgencia.Size = new System.Drawing.Size(216, 20);
            this.btnLimpiarAgencia.TabIndex = 38;
            this.btnLimpiarAgencia.Text = "Limpiar";
            this.btnLimpiarAgencia.UseVisualStyleBackColor = true;
            this.btnLimpiarAgencia.Click += new System.EventHandler(this.btnLimpiarAgencia_Click);
            // 
            // btnLimpiarInmueble
            // 
            this.btnLimpiarInmueble.Location = new System.Drawing.Point(330, 203);
            this.btnLimpiarInmueble.Name = "btnLimpiarInmueble";
            this.btnLimpiarInmueble.Size = new System.Drawing.Size(269, 20);
            this.btnLimpiarInmueble.TabIndex = 39;
            this.btnLimpiarInmueble.Text = "Limpiar";
            this.btnLimpiarInmueble.UseVisualStyleBackColor = true;
            this.btnLimpiarInmueble.Click += new System.EventHandler(this.btnLimpiarInmueble_Click);
            // 
            // dgAgencias
            // 
            this.dgAgencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAgencias.Location = new System.Drawing.Point(18, 229);
            this.dgAgencias.Name = "dgAgencias";
            this.dgAgencias.Size = new System.Drawing.Size(251, 182);
            this.dgAgencias.TabIndex = 40;
            this.dgAgencias.SelectionChanged += new System.EventHandler(this.dgAgencias_SelectionChanged);
            // 
            // dgInmuebles
            // 
            this.dgInmuebles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInmuebles.Location = new System.Drawing.Point(285, 256);
            this.dgInmuebles.Name = "dgInmuebles";
            this.dgInmuebles.Size = new System.Drawing.Size(361, 194);
            this.dgInmuebles.TabIndex = 41;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 557);
            this.Controls.Add(this.dgInmuebles);
            this.Controls.Add(this.dgAgencias);
            this.Controls.Add(this.btnLimpiarInmueble);
            this.Controls.Add(this.btnLimpiarAgencia);
            this.Controls.Add(this.cbInmuebleCondicion);
            this.Controls.Add(this.lblMontoTotalAlquilerInmuebles);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnAgenciasMayorCantidadInmueblesVenta);
            this.Controls.Add(this.btnAgenciasAlquilerInmueblesMayorSuperficie);
            this.Controls.Add(this.btnAgregarInmueble);
            this.Controls.Add(this.btnAgregarAgencia);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tbBuscar);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbInmueblePrecio);
            this.Controls.Add(this.tbInmuebleSuperficie);
            this.Controls.Add(this.tbInmuebleDireccion);
            this.Controls.Add(this.tbInmuebleCodigo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbAgenciaTelefono);
            this.Controls.Add(this.tbAgenciaCiudad);
            this.Controls.Add(this.tbAgenciaDireccion);
            this.Controls.Add(this.tbAgenciaCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Agencias e Inmuebles";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAgencias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgInmuebles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox tbAgenciaCodigo;
        private TextBox tbAgenciaDireccion;
        private TextBox tbAgenciaCiudad;
        private TextBox tbAgenciaTelefono;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox tbInmueblePrecio;
        private TextBox tbInmuebleSuperficie;
        private TextBox tbInmuebleDireccion;
        private TextBox tbInmuebleCodigo;
        private Label label10;
        private PictureBox pictureBox2;
        private Label label11;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private TextBox tbBuscar;
        private Label label13;
        private Button btnBuscar;
        private Button btnAgregarAgencia;
        private Button btnAgregarInmueble;
        private Button btnAgenciasAlquilerInmueblesMayorSuperficie;
        private Button btnAgenciasMayorCantidadInmueblesVenta;
        private Label label12;
        private Label lblMontoTotalAlquilerInmuebles;
        private ComboBox cbInmuebleCondicion;
        private Button btnLimpiarAgencia;
        private Button btnLimpiarInmueble;
        private DataGridView dgAgencias;
        private DataGridView dgInmuebles;
    }
}

