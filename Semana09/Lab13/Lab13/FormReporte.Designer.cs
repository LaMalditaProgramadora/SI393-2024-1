
namespace Lab13
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
            this.btnObtenerCantidadPaseosPorObjetivo = new System.Windows.Forms.Button();
            this.btnObtenerMontoPorTamañoPerros = new System.Windows.Forms.Button();
            this.dgReportesCantidad = new System.Windows.Forms.DataGridView();
            this.dgReportesMonto = new System.Windows.Forms.DataGridView();
            this.btnObtenerMontoPorPaseadorYFecha = new System.Windows.Forms.Button();
            this.btnObtenerCantidadPaseosPorPaseadorYTamañoGrande = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDNI = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgReportesCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgReportesMonto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnObtenerCantidadPaseosPorObjetivo
            // 
            this.btnObtenerCantidadPaseosPorObjetivo.Location = new System.Drawing.Point(12, 14);
            this.btnObtenerCantidadPaseosPorObjetivo.Name = "btnObtenerCantidadPaseosPorObjetivo";
            this.btnObtenerCantidadPaseosPorObjetivo.Size = new System.Drawing.Size(240, 37);
            this.btnObtenerCantidadPaseosPorObjetivo.TabIndex = 32;
            this.btnObtenerCantidadPaseosPorObjetivo.Text = "Obtener cantidad de paseos realizados por objetivo del paseo";
            this.btnObtenerCantidadPaseosPorObjetivo.UseVisualStyleBackColor = true;
            this.btnObtenerCantidadPaseosPorObjetivo.Click += new System.EventHandler(this.btnObtenerCantidadPaseosPorObjetivo_Click);
            // 
            // btnObtenerMontoPorTamañoPerros
            // 
            this.btnObtenerMontoPorTamañoPerros.Location = new System.Drawing.Point(268, 14);
            this.btnObtenerMontoPorTamañoPerros.Name = "btnObtenerMontoPorTamañoPerros";
            this.btnObtenerMontoPorTamañoPerros.Size = new System.Drawing.Size(240, 37);
            this.btnObtenerMontoPorTamañoPerros.TabIndex = 33;
            this.btnObtenerMontoPorTamañoPerros.Text = "Obtener monto recaudado por tamaño de los perros";
            this.btnObtenerMontoPorTamañoPerros.UseVisualStyleBackColor = true;
            this.btnObtenerMontoPorTamañoPerros.Click += new System.EventHandler(this.btnObtenerMontoPorTamañoPerros_Click);
            // 
            // dgReportesCantidad
            // 
            this.dgReportesCantidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReportesCantidad.Location = new System.Drawing.Point(12, 57);
            this.dgReportesCantidad.Name = "dgReportesCantidad";
            this.dgReportesCantidad.Size = new System.Drawing.Size(240, 173);
            this.dgReportesCantidad.TabIndex = 34;
            // 
            // dgReportesMonto
            // 
            this.dgReportesMonto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReportesMonto.Location = new System.Drawing.Point(268, 57);
            this.dgReportesMonto.Name = "dgReportesMonto";
            this.dgReportesMonto.Size = new System.Drawing.Size(240, 173);
            this.dgReportesMonto.TabIndex = 35;
            // 
            // btnObtenerMontoPorPaseadorYFecha
            // 
            this.btnObtenerMontoPorPaseadorYFecha.Location = new System.Drawing.Point(531, 85);
            this.btnObtenerMontoPorPaseadorYFecha.Name = "btnObtenerMontoPorPaseadorYFecha";
            this.btnObtenerMontoPorPaseadorYFecha.Size = new System.Drawing.Size(240, 37);
            this.btnObtenerMontoPorPaseadorYFecha.TabIndex = 36;
            this.btnObtenerMontoPorPaseadorYFecha.Text = "Obtener monto recaudado dado un paseador y una fecha específica";
            this.btnObtenerMontoPorPaseadorYFecha.UseVisualStyleBackColor = true;
            this.btnObtenerMontoPorPaseadorYFecha.Click += new System.EventHandler(this.btnObtenerMontoPorPaseadorYFecha_Click);
            // 
            // btnObtenerCantidadPaseosPorPaseadorYTamañoGrande
            // 
            this.btnObtenerCantidadPaseosPorPaseadorYTamañoGrande.Location = new System.Drawing.Point(531, 170);
            this.btnObtenerCantidadPaseosPorPaseadorYTamañoGrande.Name = "btnObtenerCantidadPaseosPorPaseadorYTamañoGrande";
            this.btnObtenerCantidadPaseosPorPaseadorYTamañoGrande.Size = new System.Drawing.Size(240, 37);
            this.btnObtenerCantidadPaseosPorPaseadorYTamañoGrande.TabIndex = 37;
            this.btnObtenerCantidadPaseosPorPaseadorYTamañoGrande.Text = "Obtener cantidad de paseos realizados dado un paseador para perros de tamaño gran" +
    "de";
            this.btnObtenerCantidadPaseosPorPaseadorYTamañoGrande.UseVisualStyleBackColor = true;
            this.btnObtenerCantidadPaseosPorPaseadorYTamañoGrande.Click += new System.EventHandler(this.btnObtenerCantidadPaseosPorPaseadorYTamañoGrande_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(528, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Monto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(528, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Cantidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(528, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "DNI:";
            // 
            // tbDNI
            // 
            this.tbDNI.Location = new System.Drawing.Point(563, 14);
            this.tbDNI.Name = "tbDNI";
            this.tbDNI.Size = new System.Drawing.Size(208, 20);
            this.tbDNI.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(528, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(574, 57);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(197, 20);
            this.dtpFecha.TabIndex = 42;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(574, 132);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(13, 13);
            this.lblMonto.TabIndex = 44;
            this.lblMonto.Text = "0";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(586, 217);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(13, 13);
            this.lblCantidad.TabIndex = 45;
            this.lblCantidad.Text = "0";
            // 
            // FormReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 245);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbDNI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnObtenerCantidadPaseosPorPaseadorYTamañoGrande);
            this.Controls.Add(this.btnObtenerMontoPorPaseadorYFecha);
            this.Controls.Add(this.dgReportesMonto);
            this.Controls.Add(this.dgReportesCantidad);
            this.Controls.Add(this.btnObtenerMontoPorTamañoPerros);
            this.Controls.Add(this.btnObtenerCantidadPaseosPorObjetivo);
            this.Name = "FormReporte";
            this.Text = "Reportes";
            ((System.ComponentModel.ISupportInitialize)(this.dgReportesCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgReportesMonto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnObtenerCantidadPaseosPorObjetivo;
        private System.Windows.Forms.Button btnObtenerMontoPorTamañoPerros;
        private System.Windows.Forms.DataGridView dgReportesCantidad;
        private System.Windows.Forms.DataGridView dgReportesMonto;
        private System.Windows.Forms.Button btnObtenerMontoPorPaseadorYFecha;
        private System.Windows.Forms.Button btnObtenerCantidadPaseosPorPaseadorYTamañoGrande;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDNI;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblCantidad;
    }
}