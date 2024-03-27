
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
            this.dgAgencias = new System.Windows.Forms.DataGridView();
            this.btnVerInmuebles = new System.Windows.Forms.Button();
            this.btnAgregarAgencia = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAgenciaTelefono = new System.Windows.Forms.TextBox();
            this.tbAgenciaCiudad = new System.Windows.Forms.TextBox();
            this.tbAgenciaDireccion = new System.Windows.Forms.TextBox();
            this.tbAgenciaCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgAgencias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgAgencias
            // 
            this.dgAgencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAgencias.Location = new System.Drawing.Point(284, 12);
            this.dgAgencias.Name = "dgAgencias";
            this.dgAgencias.Size = new System.Drawing.Size(400, 258);
            this.dgAgencias.TabIndex = 53;
            // 
            // btnVerInmuebles
            // 
            this.btnVerInmuebles.Location = new System.Drawing.Point(29, 181);
            this.btnVerInmuebles.Name = "btnVerInmuebles";
            this.btnVerInmuebles.Size = new System.Drawing.Size(216, 20);
            this.btnVerInmuebles.TabIndex = 52;
            this.btnVerInmuebles.Text = "Ver Inmuebles";
            this.btnVerInmuebles.UseVisualStyleBackColor = true;
            this.btnVerInmuebles.Click += new System.EventHandler(this.btnVerInmuebles_Click);
            // 
            // btnAgregarAgencia
            // 
            this.btnAgregarAgencia.Location = new System.Drawing.Point(29, 155);
            this.btnAgregarAgencia.Name = "btnAgregarAgencia";
            this.btnAgregarAgencia.Size = new System.Drawing.Size(216, 20);
            this.btnAgregarAgencia.TabIndex = 51;
            this.btnAgregarAgencia.Text = "Agregar";
            this.btnAgregarAgencia.UseVisualStyleBackColor = true;
            this.btnAgregarAgencia.Click += new System.EventHandler(this.btnAgregarAgencia_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Teléfono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "Ciudad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Dirección:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Código:";
            // 
            // tbAgenciaTelefono
            // 
            this.tbAgenciaTelefono.Location = new System.Drawing.Point(86, 125);
            this.tbAgenciaTelefono.Name = "tbAgenciaTelefono";
            this.tbAgenciaTelefono.Size = new System.Drawing.Size(160, 20);
            this.tbAgenciaTelefono.TabIndex = 46;
            // 
            // tbAgenciaCiudad
            // 
            this.tbAgenciaCiudad.Location = new System.Drawing.Point(86, 100);
            this.tbAgenciaCiudad.Name = "tbAgenciaCiudad";
            this.tbAgenciaCiudad.Size = new System.Drawing.Size(160, 20);
            this.tbAgenciaCiudad.TabIndex = 45;
            // 
            // tbAgenciaDireccion
            // 
            this.tbAgenciaDireccion.Location = new System.Drawing.Point(86, 75);
            this.tbAgenciaDireccion.Name = "tbAgenciaDireccion";
            this.tbAgenciaDireccion.Size = new System.Drawing.Size(160, 20);
            this.tbAgenciaDireccion.TabIndex = 44;
            // 
            // tbAgenciaCodigo
            // 
            this.tbAgenciaCodigo.Location = new System.Drawing.Point(86, 50);
            this.tbAgenciaCodigo.Name = "tbAgenciaCodigo";
            this.tbAgenciaCodigo.Size = new System.Drawing.Size(160, 20);
            this.tbAgenciaCodigo.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(113, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 42;
            this.label1.Text = "AGENCIA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 258);
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // btnReportes
            // 
            this.btnReportes.Location = new System.Drawing.Point(29, 207);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(216, 20);
            this.btnReportes.TabIndex = 54;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(28, 233);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(216, 20);
            this.btnSalir.TabIndex = 55;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormAgencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 287);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnReportes);
            this.Controls.Add(this.dgAgencias);
            this.Controls.Add(this.btnVerInmuebles);
            this.Controls.Add(this.btnAgregarAgencia);
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
            this.Name = "FormAgencia";
            this.Text = "FormAgencia";
            ((System.ComponentModel.ISupportInitialize)(this.dgAgencias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgAgencias;
        private System.Windows.Forms.Button btnVerInmuebles;
        private System.Windows.Forms.Button btnAgregarAgencia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAgenciaTelefono;
        private System.Windows.Forms.TextBox tbAgenciaCiudad;
        private System.Windows.Forms.TextBox tbAgenciaDireccion;
        private System.Windows.Forms.TextBox tbAgenciaCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnSalir;
    }
}