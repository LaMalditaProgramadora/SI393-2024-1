
namespace Lab08
{
    partial class FormAgencia
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
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnVerInmuebles = new System.Windows.Forms.Button();
            this.btnAgregarAgencia = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.tbCiudad = new System.Windows.Forms.TextBox();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgAgencias = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgAgencias)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(25, 229);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(216, 20);
            this.btnSalir.TabIndex = 68;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.Location = new System.Drawing.Point(26, 203);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(216, 20);
            this.btnReportes.TabIndex = 67;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnVerInmuebles
            // 
            this.btnVerInmuebles.Location = new System.Drawing.Point(26, 177);
            this.btnVerInmuebles.Name = "btnVerInmuebles";
            this.btnVerInmuebles.Size = new System.Drawing.Size(216, 20);
            this.btnVerInmuebles.TabIndex = 66;
            this.btnVerInmuebles.Text = "Ver Inmuebles";
            this.btnVerInmuebles.UseVisualStyleBackColor = true;
            this.btnVerInmuebles.Click += new System.EventHandler(this.btnVerInmuebles_Click);
            // 
            // btnAgregarAgencia
            // 
            this.btnAgregarAgencia.Location = new System.Drawing.Point(26, 151);
            this.btnAgregarAgencia.Name = "btnAgregarAgencia";
            this.btnAgregarAgencia.Size = new System.Drawing.Size(216, 20);
            this.btnAgregarAgencia.TabIndex = 65;
            this.btnAgregarAgencia.Text = "Agregar";
            this.btnAgregarAgencia.UseVisualStyleBackColor = true;
            this.btnAgregarAgencia.Click += new System.EventHandler(this.btnAgregarAgencia_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 64;
            this.label5.Text = "Teléfono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 63;
            this.label4.Text = "Ciudad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 62;
            this.label3.Text = "Dirección:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 61;
            this.label2.Text = "Código:";
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(83, 121);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(160, 20);
            this.tbTelefono.TabIndex = 60;
            // 
            // tbCiudad
            // 
            this.tbCiudad.Location = new System.Drawing.Point(83, 96);
            this.tbCiudad.Name = "tbCiudad";
            this.tbCiudad.Size = new System.Drawing.Size(160, 20);
            this.tbCiudad.TabIndex = 59;
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(83, 71);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(160, 20);
            this.tbDireccion.TabIndex = 58;
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(83, 46);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(160, 20);
            this.tbCodigo.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(110, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 56;
            this.label1.Text = "AGENCIA";
            // 
            // dgAgencias
            // 
            this.dgAgencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAgencias.Location = new System.Drawing.Point(283, 21);
            this.dgAgencias.Name = "dgAgencias";
            this.dgAgencias.Size = new System.Drawing.Size(484, 228);
            this.dgAgencias.TabIndex = 69;
            // 
            // FormAgencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 280);
            this.Controls.Add(this.dgAgencias);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnReportes);
            this.Controls.Add(this.btnVerInmuebles);
            this.Controls.Add(this.btnAgregarAgencia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbTelefono);
            this.Controls.Add(this.tbCiudad);
            this.Controls.Add(this.tbDireccion);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.label1);
            this.Name = "FormAgencia";
            this.Text = "Agencias";
            ((System.ComponentModel.ISupportInitialize)(this.dgAgencias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnVerInmuebles;
        private System.Windows.Forms.Button btnAgregarAgencia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.TextBox tbCiudad;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgAgencias;
    }
}