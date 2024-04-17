using System.Drawing;
using System.Windows.Forms;

namespace Lab09
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
            this.btnBuscarPorMenorCantPokemon = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBuscarPorRegion = new System.Windows.Forms.Button();
            this.btnBuscarPorNombrePokemon = new System.Windows.Forms.Button();
            this.cbRegion = new System.Windows.Forms.ComboBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgEntrenadores = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotalEntrenadores = new System.Windows.Forms.Label();
            this.btnBuscarPorMaxPSPokemon = new System.Windows.Forms.Button();
            this.btnBuscarLegendarios = new System.Windows.Forms.Button();
            this.dgPokemons = new System.Windows.Forms.DataGridView();
            this.lblTotalPokemons = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscarPorRangoEdadEntrenadores = new System.Windows.Forms.Button();
            this.tbEdadMin = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.tbEdadMax = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEntrenadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPokemons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscarPorMenorCantPokemon
            // 
            this.btnBuscarPorMenorCantPokemon.Location = new System.Drawing.Point(29, 163);
            this.btnBuscarPorMenorCantPokemon.Name = "btnBuscarPorMenorCantPokemon";
            this.btnBuscarPorMenorCantPokemon.Size = new System.Drawing.Size(230, 23);
            this.btnBuscarPorMenorCantPokemon.TabIndex = 77;
            this.btnBuscarPorMenorCantPokemon.Text = "Buscar por menor cantidad de pokémons";
            this.btnBuscarPorMenorCantPokemon.UseVisualStyleBackColor = true;
            this.btnBuscarPorMenorCantPokemon.Click += new System.EventHandler(this.btnBuscarPorMenorCantPokemon_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(29, 439);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(230, 23);
            this.btnSalir.TabIndex = 72;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBuscarPorRegion
            // 
            this.btnBuscarPorRegion.Location = new System.Drawing.Point(29, 134);
            this.btnBuscarPorRegion.Name = "btnBuscarPorRegion";
            this.btnBuscarPorRegion.Size = new System.Drawing.Size(230, 23);
            this.btnBuscarPorRegion.TabIndex = 71;
            this.btnBuscarPorRegion.Text = "Buscar por región";
            this.btnBuscarPorRegion.UseVisualStyleBackColor = true;
            this.btnBuscarPorRegion.Click += new System.EventHandler(this.btnBuscarPorRegion_Click);
            // 
            // btnBuscarPorNombrePokemon
            // 
            this.btnBuscarPorNombrePokemon.Location = new System.Drawing.Point(29, 78);
            this.btnBuscarPorNombrePokemon.Name = "btnBuscarPorNombrePokemon";
            this.btnBuscarPorNombrePokemon.Size = new System.Drawing.Size(230, 23);
            this.btnBuscarPorNombrePokemon.TabIndex = 70;
            this.btnBuscarPorNombrePokemon.Text = "Buscar por nombre del pokémon";
            this.btnBuscarPorNombrePokemon.UseVisualStyleBackColor = true;
            this.btnBuscarPorNombrePokemon.Click += new System.EventHandler(this.btnBuscarPorNombrePokemon_Click);
            // 
            // cbRegion
            // 
            this.cbRegion.FormattingEnabled = true;
            this.cbRegion.Items.AddRange(new object[] {
            "Kanto",
            "Johto",
            "Hoenn",
            "Sinnoh",
            "Teselia/Unova",
            "Kalos",
            "Alola",
            "Galar",
            "Paldea"});
            this.cbRegion.Location = new System.Drawing.Point(94, 107);
            this.cbRegion.Name = "cbRegion";
            this.cbRegion.Size = new System.Drawing.Size(165, 21);
            this.cbRegion.TabIndex = 69;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(94, 52);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(165, 20);
            this.tbNombre.TabIndex = 67;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(39, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 65;
            this.label5.Text = "Región:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(32, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 63;
            this.label3.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(57, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 21);
            this.label1.TabIndex = 61;
            this.label1.Text = "Reportes Entrenador";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Código";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nombre";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Apodo";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Región";
            this.columnHeader4.Width = 100;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Location = new System.Drawing.Point(12, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 223);
            this.pictureBox1.TabIndex = 75;
            this.pictureBox1.TabStop = false;
            // 
            // dgEntrenadores
            // 
            this.dgEntrenadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEntrenadores.Location = new System.Drawing.Point(301, 7);
            this.dgEntrenadores.Name = "dgEntrenadores";
            this.dgEntrenadores.Size = new System.Drawing.Size(570, 179);
            this.dgEntrenadores.TabIndex = 78;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.Location = new System.Drawing.Point(640, 198);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(231, 32);
            this.pictureBox2.TabIndex = 76;
            this.pictureBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(688, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 15);
            this.label7.TabIndex = 73;
            this.label7.Text = "Total de entrenadores:";
            // 
            // lblTotalEntrenadores
            // 
            this.lblTotalEntrenadores.AutoSize = true;
            this.lblTotalEntrenadores.Location = new System.Drawing.Point(826, 206);
            this.lblTotalEntrenadores.Name = "lblTotalEntrenadores";
            this.lblTotalEntrenadores.Size = new System.Drawing.Size(13, 13);
            this.lblTotalEntrenadores.TabIndex = 74;
            this.lblTotalEntrenadores.Text = "0";
            // 
            // btnBuscarPorMaxPSPokemon
            // 
            this.btnBuscarPorMaxPSPokemon.Location = new System.Drawing.Point(29, 192);
            this.btnBuscarPorMaxPSPokemon.Name = "btnBuscarPorMaxPSPokemon";
            this.btnBuscarPorMaxPSPokemon.Size = new System.Drawing.Size(230, 23);
            this.btnBuscarPorMaxPSPokemon.TabIndex = 79;
            this.btnBuscarPorMaxPSPokemon.Text = "Buscar por máx PS de pokémons";
            this.btnBuscarPorMaxPSPokemon.UseVisualStyleBackColor = true;
            // 
            // btnBuscarLegendarios
            // 
            this.btnBuscarLegendarios.Location = new System.Drawing.Point(29, 371);
            this.btnBuscarLegendarios.Name = "btnBuscarLegendarios";
            this.btnBuscarLegendarios.Size = new System.Drawing.Size(230, 23);
            this.btnBuscarLegendarios.TabIndex = 93;
            this.btnBuscarLegendarios.Text = "BuscarLegendarios";
            this.btnBuscarLegendarios.UseVisualStyleBackColor = true;
            this.btnBuscarLegendarios.Click += new System.EventHandler(this.btnBuscarLegendarios_Click);
            // 
            // dgPokemons
            // 
            this.dgPokemons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPokemons.Location = new System.Drawing.Point(301, 245);
            this.dgPokemons.Name = "dgPokemons";
            this.dgPokemons.Size = new System.Drawing.Size(570, 179);
            this.dgPokemons.TabIndex = 92;
            // 
            // lblTotalPokemons
            // 
            this.lblTotalPokemons.AutoSize = true;
            this.lblTotalPokemons.Location = new System.Drawing.Point(826, 444);
            this.lblTotalPokemons.Name = "lblTotalPokemons";
            this.lblTotalPokemons.Size = new System.Drawing.Size(13, 13);
            this.lblTotalPokemons.TabIndex = 88;
            this.lblTotalPokemons.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(705, 442);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 15);
            this.label4.TabIndex = 87;
            this.label4.Text = "Total de pokémons:";
            // 
            // btnBuscarPorRangoEdadEntrenadores
            // 
            this.btnBuscarPorRangoEdadEntrenadores.Location = new System.Drawing.Point(29, 342);
            this.btnBuscarPorRangoEdadEntrenadores.Name = "btnBuscarPorRangoEdadEntrenadores";
            this.btnBuscarPorRangoEdadEntrenadores.Size = new System.Drawing.Size(230, 23);
            this.btnBuscarPorRangoEdadEntrenadores.TabIndex = 85;
            this.btnBuscarPorRangoEdadEntrenadores.Text = "Buscar por rango de edad de entrenadores";
            this.btnBuscarPorRangoEdadEntrenadores.UseVisualStyleBackColor = true;
            this.btnBuscarPorRangoEdadEntrenadores.Click += new System.EventHandler(this.btnBuscarPorRangoEdadEntrenadores_Click);
            // 
            // tbEdadMin
            // 
            this.tbEdadMin.Location = new System.Drawing.Point(94, 290);
            this.tbEdadMin.Name = "tbEdadMin";
            this.tbEdadMin.Size = new System.Drawing.Size(165, 20);
            this.tbEdadMin.TabIndex = 83;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(28, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 15);
            this.label8.TabIndex = 81;
            this.label8.Text = "Edad Min:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(57, 257);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 21);
            this.label9.TabIndex = 80;
            this.label9.Text = "Reportes Pokémon";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox3.Location = new System.Drawing.Point(12, 245);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(275, 179);
            this.pictureBox3.TabIndex = 89;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox4.Location = new System.Drawing.Point(640, 436);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(231, 32);
            this.pictureBox4.TabIndex = 90;
            this.pictureBox4.TabStop = false;
            // 
            // tbEdadMax
            // 
            this.tbEdadMax.Location = new System.Drawing.Point(94, 316);
            this.tbEdadMax.Name = "tbEdadMax";
            this.tbEdadMax.Size = new System.Drawing.Size(165, 20);
            this.tbEdadMax.TabIndex = 95;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(25, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
            this.label6.TabIndex = 94;
            this.label6.Text = "Edad Max:";
            // 
            // FormReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(890, 482);
            this.Controls.Add(this.tbEdadMax);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnBuscarLegendarios);
            this.Controls.Add(this.dgPokemons);
            this.Controls.Add(this.lblTotalPokemons);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBuscarPorRangoEdadEntrenadores);
            this.Controls.Add(this.tbEdadMin);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btnBuscarPorMaxPSPokemon);
            this.Controls.Add(this.dgEntrenadores);
            this.Controls.Add(this.btnBuscarPorMenorCantPokemon);
            this.Controls.Add(this.lblTotalEntrenadores);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBuscarPorRegion);
            this.Controls.Add(this.btnBuscarPorNombrePokemon);
            this.Controls.Add(this.cbRegion);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "FormReporte";
            this.Text = "Reportes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEntrenadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPokemons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnBuscarPorMenorCantPokemon;
        private Button btnSalir;
        private Button btnBuscarPorRegion;
        private Button btnBuscarPorNombrePokemon;
        private ComboBox cbRegion;
        private TextBox tbNombre;
        private Label label5;
        private Label label3;
        private Label label1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private PictureBox pictureBox1;
        private DataGridView dgEntrenadores;
        private PictureBox pictureBox2;
        private Label label7;
        private Label lblTotalEntrenadores;
        private Button btnBuscarPorMaxPSPokemon;
        private Button btnBuscarLegendarios;
        private DataGridView dgPokemons;
        private Label lblTotalPokemons;
        private Label label4;
        private Button btnBuscarPorRangoEdadEntrenadores;
        private TextBox tbEdadMin;
        private Label label8;
        private Label label9;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private TextBox tbEdadMax;
        private Label label6;
    }
}