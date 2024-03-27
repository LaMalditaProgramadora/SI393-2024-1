
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
            this.dgInmuebles = new System.Windows.Forms.DataGridView();
            this.cbInmuebleCondicion = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
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
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgInmuebles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgInmuebles
            // 
            this.dgInmuebles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInmuebles.Location = new System.Drawing.Point(408, 18);
            this.dgInmuebles.Name = "dgInmuebles";
            this.dgInmuebles.Size = new System.Drawing.Size(412, 239);
            this.dgInmuebles.TabIndex = 56;
            // 
            // cbInmuebleCondicion
            // 
            this.cbInmuebleCondicion.FormattingEnabled = true;
            this.cbInmuebleCondicion.Items.AddRange(new object[] {
            "Venta",
            "Alquiler"});
            this.cbInmuebleCondicion.Location = new System.Drawing.Point(128, 156);
            this.cbInmuebleCondicion.Name = "cbInmuebleCondicion";
            this.cbInmuebleCondicion.Size = new System.Drawing.Size(209, 21);
            this.cbInmuebleCondicion.TabIndex = 54;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(67, 186);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(269, 20);
            this.btnRegistrar.TabIndex = 53;
            this.btnRegistrar.Text = "Agregar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(67, 159);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 52;
            this.label11.Text = "Condicion:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "Precio:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "Superficie:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(67, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 49;
            this.label8.Text = "Dirección:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(79, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 48;
            this.label9.Text = "Código:";
            // 
            // tbInmueblePrecio
            // 
            this.tbInmueblePrecio.Location = new System.Drawing.Point(128, 131);
            this.tbInmueblePrecio.Name = "tbInmueblePrecio";
            this.tbInmueblePrecio.Size = new System.Drawing.Size(209, 20);
            this.tbInmueblePrecio.TabIndex = 47;
            // 
            // tbInmuebleSuperficie
            // 
            this.tbInmuebleSuperficie.Location = new System.Drawing.Point(128, 106);
            this.tbInmuebleSuperficie.Name = "tbInmuebleSuperficie";
            this.tbInmuebleSuperficie.Size = new System.Drawing.Size(209, 20);
            this.tbInmuebleSuperficie.TabIndex = 46;
            // 
            // tbInmuebleDireccion
            // 
            this.tbInmuebleDireccion.Location = new System.Drawing.Point(128, 81);
            this.tbInmuebleDireccion.Name = "tbInmuebleDireccion";
            this.tbInmuebleDireccion.Size = new System.Drawing.Size(209, 20);
            this.tbInmuebleDireccion.TabIndex = 45;
            // 
            // tbInmuebleCodigo
            // 
            this.tbInmuebleCodigo.Location = new System.Drawing.Point(128, 56);
            this.tbInmuebleCodigo.Name = "tbInmuebleCodigo";
            this.tbInmuebleCodigo.Size = new System.Drawing.Size(209, 20);
            this.tbInmuebleCodigo.TabIndex = 44;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(178, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 15);
            this.label10.TabIndex = 43;
            this.label10.Text = "INMUEBLE";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox2.Location = new System.Drawing.Point(22, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(361, 239);
            this.pictureBox2.TabIndex = 42;
            this.pictureBox2.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(67, 212);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(269, 20);
            this.btnSalir.TabIndex = 57;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormInmueble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 277);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgInmuebles);
            this.Controls.Add(this.cbInmuebleCondicion);
            this.Controls.Add(this.btnRegistrar);
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
            this.Name = "FormInmueble";
            this.Text = "Inmuebles";
            ((System.ComponentModel.ISupportInitialize)(this.dgInmuebles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgInmuebles;
        private System.Windows.Forms.ComboBox cbInmuebleCondicion;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbInmueblePrecio;
        private System.Windows.Forms.TextBox tbInmuebleSuperficie;
        private System.Windows.Forms.TextBox tbInmuebleDireccion;
        private System.Windows.Forms.TextBox tbInmuebleCodigo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnSalir;
    }
}