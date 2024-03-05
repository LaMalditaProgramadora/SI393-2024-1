using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Drawing;

namespace Lab10
{
    partial class FormRuta
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
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.tbOrigen = new System.Windows.Forms.TextBox();
            this.tbDestino = new System.Windows.Forms.TextBox();
            this.tbKilometros = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgRutas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgRutas)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(85, 22);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(141, 20);
            this.tbCodigo.TabIndex = 0;
            // 
            // tbOrigen
            // 
            this.tbOrigen.Location = new System.Drawing.Point(85, 47);
            this.tbOrigen.Name = "tbOrigen";
            this.tbOrigen.Size = new System.Drawing.Size(141, 20);
            this.tbOrigen.TabIndex = 1;
            // 
            // tbDestino
            // 
            this.tbDestino.Location = new System.Drawing.Point(85, 72);
            this.tbDestino.Name = "tbDestino";
            this.tbDestino.Size = new System.Drawing.Size(141, 20);
            this.tbDestino.TabIndex = 2;
            // 
            // tbKilometros
            // 
            this.tbKilometros.Location = new System.Drawing.Point(85, 97);
            this.tbKilometros.Name = "tbKilometros";
            this.tbKilometros.Size = new System.Drawing.Size(141, 20);
            this.tbKilometros.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Origen:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Destino:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kilómetros:";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(93, 140);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(64, 20);
            this.btnRegistrar.TabIndex = 9;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(93, 166);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(64, 20);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgRutas
            // 
            this.dgRutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRutas.Location = new System.Drawing.Point(262, 22);
            this.dgRutas.Name = "dgRutas";
            this.dgRutas.Size = new System.Drawing.Size(393, 186);
            this.dgRutas.TabIndex = 11;
            // 
            // FormRuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 235);
            this.Controls.Add(this.dgRutas);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbKilometros);
            this.Controls.Add(this.tbDestino);
            this.Controls.Add(this.tbOrigen);
            this.Controls.Add(this.tbCodigo);
            this.Name = "FormRuta";
            this.Text = "Rutas";
            ((System.ComponentModel.ISupportInitialize)(this.dgRutas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbCodigo;
        private TextBox tbOrigen;
        private TextBox tbDestino;
        private TextBox tbKilometros;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dgvRutas;
        private Button btnRegistrar;
        private Button btnSalir;
        private DataGridView dgRutas;
    }
}