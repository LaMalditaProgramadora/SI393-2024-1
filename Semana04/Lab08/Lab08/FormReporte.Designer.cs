
namespace Lab08
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
            this.dgInmuebles = new System.Windows.Forms.DataGridView();
            this.dgAgencias = new System.Windows.Forms.DataGridView();
            this.lblMontoTotalAlquilerInmuebles = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnAgenciasMayorCantidadInmueblesVenta = new System.Windows.Forms.Button();
            this.btnAgenciasAlquilerInmueblesMayorSuperficie = new System.Windows.Forms.Button();
            this.btnBuscarVenta = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnBuscarAlquiler = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgInmuebles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAgencias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // dgInmuebles
            // 
            this.dgInmuebles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInmuebles.Location = new System.Drawing.Point(282, 200);
            this.dgInmuebles.Name = "dgInmuebles";
            this.dgInmuebles.Size = new System.Drawing.Size(418, 160);
            this.dgInmuebles.TabIndex = 52;
            // 
            // dgAgencias
            // 
            this.dgAgencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAgencias.Location = new System.Drawing.Point(282, 12);
            this.dgAgencias.Name = "dgAgencias";
            this.dgAgencias.Size = new System.Drawing.Size(418, 167);
            this.dgAgencias.TabIndex = 51;
            // 
            // lblMontoTotalAlquilerInmuebles
            // 
            this.lblMontoTotalAlquilerInmuebles.AutoSize = true;
            this.lblMontoTotalAlquilerInmuebles.Location = new System.Drawing.Point(131, 327);
            this.lblMontoTotalAlquilerInmuebles.Name = "lblMontoTotalAlquilerInmuebles";
            this.lblMontoTotalAlquilerInmuebles.Size = new System.Drawing.Size(13, 13);
            this.lblMontoTotalAlquilerInmuebles.TabIndex = 50;
            this.lblMontoTotalAlquilerInmuebles.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(26, 327);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 13);
            this.label12.TabIndex = 49;
            this.label12.Text = "Monto total alquiler:";
            // 
            // btnAgenciasMayorCantidadInmueblesVenta
            // 
            this.btnAgenciasMayorCantidadInmueblesVenta.Location = new System.Drawing.Point(29, 65);
            this.btnAgenciasMayorCantidadInmueblesVenta.Name = "btnAgenciasMayorCantidadInmueblesVenta";
            this.btnAgenciasMayorCantidadInmueblesVenta.Size = new System.Drawing.Size(216, 37);
            this.btnAgenciasMayorCantidadInmueblesVenta.TabIndex = 48;
            this.btnAgenciasMayorCantidadInmueblesVenta.Text = "Buscar las tienen más inmuebles en venta";
            this.btnAgenciasMayorCantidadInmueblesVenta.UseVisualStyleBackColor = true;
            this.btnAgenciasMayorCantidadInmueblesVenta.Click += new System.EventHandler(this.btnAgenciasMayorCantidadInmueblesVenta_Click);
            // 
            // btnAgenciasAlquilerInmueblesMayorSuperficie
            // 
            this.btnAgenciasAlquilerInmueblesMayorSuperficie.Location = new System.Drawing.Point(29, 23);
            this.btnAgenciasAlquilerInmueblesMayorSuperficie.Name = "btnAgenciasAlquilerInmueblesMayorSuperficie";
            this.btnAgenciasAlquilerInmueblesMayorSuperficie.Size = new System.Drawing.Size(216, 37);
            this.btnAgenciasAlquilerInmueblesMayorSuperficie.TabIndex = 47;
            this.btnAgenciasAlquilerInmueblesMayorSuperficie.Text = "Buscar las que alquilan inmuebles con mayor superficie";
            this.btnAgenciasAlquilerInmueblesMayorSuperficie.UseVisualStyleBackColor = true;
            this.btnAgenciasAlquilerInmueblesMayorSuperficie.Click += new System.EventHandler(this.btnAgenciasAlquilerInmueblesMayorSuperficie_Click);
            // 
            // btnBuscarVenta
            // 
            this.btnBuscarVenta.Location = new System.Drawing.Point(29, 261);
            this.btnBuscarVenta.Name = "btnBuscarVenta";
            this.btnBuscarVenta.Size = new System.Drawing.Size(216, 20);
            this.btnBuscarVenta.TabIndex = 46;
            this.btnBuscarVenta.Text = "Buscar Inmuebles en Venta";
            this.btnBuscarVenta.UseVisualStyleBackColor = true;
            this.btnBuscarVenta.Click += new System.EventHandler(this.btnBuscarVenta_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(26, 213);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 13);
            this.label13.TabIndex = 45;
            this.label13.Text = "Buscar por agencia:";
            // 
            // tbBuscar
            // 
            this.tbBuscar.Location = new System.Drawing.Point(29, 235);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(216, 20);
            this.tbBuscar.TabIndex = 44;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox4.Location = new System.Drawing.Point(12, 200);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(251, 160);
            this.pictureBox4.TabIndex = 43;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox3.Location = new System.Drawing.Point(12, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(251, 107);
            this.pictureBox3.TabIndex = 42;
            this.pictureBox3.TabStop = false;
            // 
            // btnBuscarAlquiler
            // 
            this.btnBuscarAlquiler.Location = new System.Drawing.Point(29, 287);
            this.btnBuscarAlquiler.Name = "btnBuscarAlquiler";
            this.btnBuscarAlquiler.Size = new System.Drawing.Size(216, 20);
            this.btnBuscarAlquiler.TabIndex = 53;
            this.btnBuscarAlquiler.Text = "Buscar Inmuebles en Alquiler";
            this.btnBuscarAlquiler.UseVisualStyleBackColor = true;
            this.btnBuscarAlquiler.Click += new System.EventHandler(this.btnBuscarAlquiler_Click);
            // 
            // FormReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 384);
            this.Controls.Add(this.btnBuscarAlquiler);
            this.Controls.Add(this.dgInmuebles);
            this.Controls.Add(this.dgAgencias);
            this.Controls.Add(this.lblMontoTotalAlquilerInmuebles);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnAgenciasMayorCantidadInmueblesVenta);
            this.Controls.Add(this.btnAgenciasAlquilerInmueblesMayorSuperficie);
            this.Controls.Add(this.btnBuscarVenta);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tbBuscar);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Name = "FormReporte";
            this.Text = "Reportes";
            ((System.ComponentModel.ISupportInitialize)(this.dgInmuebles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAgencias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgInmuebles;
        private System.Windows.Forms.DataGridView dgAgencias;
        private System.Windows.Forms.Label lblMontoTotalAlquilerInmuebles;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnAgenciasMayorCantidadInmueblesVenta;
        private System.Windows.Forms.Button btnAgenciasAlquilerInmueblesMayorSuperficie;
        private System.Windows.Forms.Button btnBuscarVenta;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnBuscarAlquiler;
    }
}