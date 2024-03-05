using System.Drawing;
using System.Windows.Forms;

namespace Lab10
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
            this.label3 = new System.Windows.Forms.Label();
            this.tbConductor = new System.Windows.Forms.TextBox();
            this.btnBuscarBusesConRutasMasLargas = new System.Windows.Forms.Button();
            this.btnBuscarBusesConMenosRutas = new System.Windows.Forms.Button();
            this.btnBuscarRutasPorConductorBus = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgBuses = new System.Windows.Forms.DataGridView();
            this.dgRutas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgBuses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRutas)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Conductor:";
            // 
            // tbConductor
            // 
            this.tbConductor.Location = new System.Drawing.Point(82, 218);
            this.tbConductor.Name = "tbConductor";
            this.tbConductor.Size = new System.Drawing.Size(166, 20);
            this.tbConductor.TabIndex = 12;
            // 
            // btnBuscarBusesConRutasMasLargas
            // 
            this.btnBuscarBusesConRutasMasLargas.Location = new System.Drawing.Point(20, 77);
            this.btnBuscarBusesConRutasMasLargas.Name = "btnBuscarBusesConRutasMasLargas";
            this.btnBuscarBusesConRutasMasLargas.Size = new System.Drawing.Size(228, 20);
            this.btnBuscarBusesConRutasMasLargas.TabIndex = 15;
            this.btnBuscarBusesConRutasMasLargas.Text = "Buscar Buses con Rutas más Largas";
            this.btnBuscarBusesConRutasMasLargas.UseVisualStyleBackColor = true;
            this.btnBuscarBusesConRutasMasLargas.Click += new System.EventHandler(this.btnBuscarBusesConRutasMasLargas_Click);
            // 
            // btnBuscarBusesConMenosRutas
            // 
            this.btnBuscarBusesConMenosRutas.Location = new System.Drawing.Point(20, 102);
            this.btnBuscarBusesConMenosRutas.Name = "btnBuscarBusesConMenosRutas";
            this.btnBuscarBusesConMenosRutas.Size = new System.Drawing.Size(228, 20);
            this.btnBuscarBusesConMenosRutas.TabIndex = 16;
            this.btnBuscarBusesConMenosRutas.Text = "Buscar Buses con Menos Rutas";
            this.btnBuscarBusesConMenosRutas.UseVisualStyleBackColor = true;
            this.btnBuscarBusesConMenosRutas.Click += new System.EventHandler(this.btnBuscarBusesConMenosRutas_Click);
            // 
            // btnBuscarRutasPorConductorBus
            // 
            this.btnBuscarRutasPorConductorBus.Location = new System.Drawing.Point(20, 257);
            this.btnBuscarRutasPorConductorBus.Name = "btnBuscarRutasPorConductorBus";
            this.btnBuscarRutasPorConductorBus.Size = new System.Drawing.Size(228, 20);
            this.btnBuscarRutasPorConductorBus.TabIndex = 17;
            this.btnBuscarRutasPorConductorBus.Text = "Buscar Rutas por Conductor de Bus";
            this.btnBuscarRutasPorConductorBus.UseVisualStyleBackColor = true;
            this.btnBuscarRutasPorConductorBus.Click += new System.EventHandler(this.btnBuscarRutasPorConductorBus_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(102, 335);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(64, 20);
            this.btnSalir.TabIndex = 18;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgBuses
            // 
            this.dgBuses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBuses.Location = new System.Drawing.Point(314, 12);
            this.dgBuses.Name = "dgBuses";
            this.dgBuses.Size = new System.Drawing.Size(318, 161);
            this.dgBuses.TabIndex = 19;
            // 
            // dgRutas
            // 
            this.dgRutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRutas.Location = new System.Drawing.Point(314, 194);
            this.dgRutas.Name = "dgRutas";
            this.dgRutas.Size = new System.Drawing.Size(318, 161);
            this.dgRutas.TabIndex = 20;
            // 
            // FormReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 390);
            this.Controls.Add(this.dgRutas);
            this.Controls.Add(this.dgBuses);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBuscarRutasPorConductorBus);
            this.Controls.Add(this.btnBuscarBusesConMenosRutas);
            this.Controls.Add(this.btnBuscarBusesConRutasMasLargas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbConductor);
            this.Name = "FormReporte";
            this.Text = "Reportes";
            ((System.ComponentModel.ISupportInitialize)(this.dgBuses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRutas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label3;
        private TextBox tbConductor;
        private Button btnBuscarBusesConRutasMasLargas;
        private Button btnBuscarBusesConMenosRutas;
        private Button btnBuscarRutasPorConductorBus;
        private Button btnSalir;
        private DataGridView dgBuses;
        private DataGridView dgRutas;
    }
}