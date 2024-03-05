using System.Drawing;
using System.Windows.Forms;

namespace Lab10
{
    partial class FormBus
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
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnVerRutas = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tbMatricula = new System.Windows.Forms.TextBox();
            this.tbConductor = new System.Windows.Forms.TextBox();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgBuses = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgBuses)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(123, 114);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(64, 20);
            this.btnRegistrar.TabIndex = 0;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnVerRutas
            // 
            this.btnVerRutas.Location = new System.Drawing.Point(123, 139);
            this.btnVerRutas.Name = "btnVerRutas";
            this.btnVerRutas.Size = new System.Drawing.Size(64, 20);
            this.btnVerRutas.TabIndex = 1;
            this.btnVerRutas.Text = "Ver Rutas";
            this.btnVerRutas.UseVisualStyleBackColor = true;
            this.btnVerRutas.Click += new System.EventHandler(this.btnVerRutas_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.Location = new System.Drawing.Point(123, 164);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(64, 20);
            this.btnReportes.TabIndex = 2;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(123, 189);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(64, 20);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tbMatricula
            // 
            this.tbMatricula.Location = new System.Drawing.Point(84, 23);
            this.tbMatricula.Name = "tbMatricula";
            this.tbMatricula.Size = new System.Drawing.Size(166, 20);
            this.tbMatricula.TabIndex = 5;
            // 
            // tbConductor
            // 
            this.tbConductor.Location = new System.Drawing.Point(84, 73);
            this.tbConductor.Name = "tbConductor";
            this.tbConductor.Size = new System.Drawing.Size(166, 20);
            this.tbConductor.TabIndex = 6;
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Tipo 1",
            "Tipo 2"});
            this.cbTipo.Location = new System.Drawing.Point(84, 48);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(166, 21);
            this.cbTipo.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Matrícula:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tipo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Conductor:";
            // 
            // dgBuses
            // 
            this.dgBuses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBuses.Location = new System.Drawing.Point(290, 23);
            this.dgBuses.Name = "dgBuses";
            this.dgBuses.Size = new System.Drawing.Size(339, 201);
            this.dgBuses.TabIndex = 11;
            // 
            // FormBus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 246);
            this.Controls.Add(this.dgBuses);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.tbConductor);
            this.Controls.Add(this.tbMatricula);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnReportes);
            this.Controls.Add(this.btnVerRutas);
            this.Controls.Add(this.btnRegistrar);
            this.Name = "FormBus";
            this.Text = "Buses";
            ((System.ComponentModel.ISupportInitialize)(this.dgBuses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnRegistrar;
        private Button btnVerRutas;
        private Button btnReportes;
        private Button btnSalir;
        private TextBox tbMatricula;
        private TextBox tbConductor;
        private ComboBox cbTipo;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dgBuses;
    }
}