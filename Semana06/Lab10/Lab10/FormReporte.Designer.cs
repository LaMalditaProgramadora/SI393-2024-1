
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
            this.dgRutas = new System.Windows.Forms.DataGridView();
            this.dgBuses = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBuscarRutasPorConductorBus = new System.Windows.Forms.Button();
            this.btnBuscarBusesConMenosRutas = new System.Windows.Forms.Button();
            this.btnBuscarBusesConRutasMasLargas = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbConductor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgRutas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBuses)).BeginInit();
            this.SuspendLayout();
            // 
            // dgRutas
            // 
            this.dgRutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRutas.Location = new System.Drawing.Point(425, 250);
            this.dgRutas.Margin = new System.Windows.Forms.Padding(4);
            this.dgRutas.Name = "dgRutas";
            this.dgRutas.RowHeadersWidth = 51;
            this.dgRutas.Size = new System.Drawing.Size(424, 198);
            this.dgRutas.TabIndex = 28;
            // 
            // dgBuses
            // 
            this.dgBuses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBuses.Location = new System.Drawing.Point(425, 26);
            this.dgBuses.Margin = new System.Windows.Forms.Padding(4);
            this.dgBuses.Name = "dgBuses";
            this.dgBuses.RowHeadersWidth = 51;
            this.dgBuses.Size = new System.Drawing.Size(424, 198);
            this.dgBuses.TabIndex = 27;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(142, 423);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(85, 25);
            this.btnSalir.TabIndex = 26;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBuscarRutasPorConductorBus
            // 
            this.btnBuscarRutasPorConductorBus.Location = new System.Drawing.Point(33, 327);
            this.btnBuscarRutasPorConductorBus.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarRutasPorConductorBus.Name = "btnBuscarRutasPorConductorBus";
            this.btnBuscarRutasPorConductorBus.Size = new System.Drawing.Size(304, 25);
            this.btnBuscarRutasPorConductorBus.TabIndex = 25;
            this.btnBuscarRutasPorConductorBus.Text = "Buscar Rutas por Conductor de Bus";
            this.btnBuscarRutasPorConductorBus.UseVisualStyleBackColor = true;
            this.btnBuscarRutasPorConductorBus.Click += new System.EventHandler(this.btnBuscarRutasPorConductorBus_Click);
            // 
            // btnBuscarBusesConMenosRutas
            // 
            this.btnBuscarBusesConMenosRutas.Location = new System.Drawing.Point(33, 137);
            this.btnBuscarBusesConMenosRutas.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarBusesConMenosRutas.Name = "btnBuscarBusesConMenosRutas";
            this.btnBuscarBusesConMenosRutas.Size = new System.Drawing.Size(304, 25);
            this.btnBuscarBusesConMenosRutas.TabIndex = 24;
            this.btnBuscarBusesConMenosRutas.Text = "Buscar Buses con Menos Rutas";
            this.btnBuscarBusesConMenosRutas.UseVisualStyleBackColor = true;
            this.btnBuscarBusesConMenosRutas.Click += new System.EventHandler(this.btnBuscarBusesConMenosRutas_Click);
            // 
            // btnBuscarBusesConRutasMasLargas
            // 
            this.btnBuscarBusesConRutasMasLargas.Location = new System.Drawing.Point(33, 106);
            this.btnBuscarBusesConRutasMasLargas.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarBusesConRutasMasLargas.Name = "btnBuscarBusesConRutasMasLargas";
            this.btnBuscarBusesConRutasMasLargas.Size = new System.Drawing.Size(304, 25);
            this.btnBuscarBusesConRutasMasLargas.TabIndex = 23;
            this.btnBuscarBusesConRutasMasLargas.Text = "Buscar Buses con Rutas más Largas";
            this.btnBuscarBusesConRutasMasLargas.UseVisualStyleBackColor = true;
            this.btnBuscarBusesConRutasMasLargas.Click += new System.EventHandler(this.btnBuscarBusesConRutasMasLargas_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 283);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Conductor:";
            // 
            // tbConductor
            // 
            this.tbConductor.Location = new System.Drawing.Point(115, 279);
            this.tbConductor.Margin = new System.Windows.Forms.Padding(4);
            this.tbConductor.Name = "tbConductor";
            this.tbConductor.Size = new System.Drawing.Size(220, 22);
            this.tbConductor.TabIndex = 21;
            // 
            // FormReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 479);
            this.Controls.Add(this.dgRutas);
            this.Controls.Add(this.dgBuses);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBuscarRutasPorConductorBus);
            this.Controls.Add(this.btnBuscarBusesConMenosRutas);
            this.Controls.Add(this.btnBuscarBusesConRutasMasLargas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbConductor);
            this.Name = "FormReporte";
            this.Text = "Reporte";
            ((System.ComponentModel.ISupportInitialize)(this.dgRutas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBuses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgRutas;
        private System.Windows.Forms.DataGridView dgBuses;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnBuscarRutasPorConductorBus;
        private System.Windows.Forms.Button btnBuscarBusesConMenosRutas;
        private System.Windows.Forms.Button btnBuscarBusesConRutasMasLargas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbConductor;
    }
}