using System.Drawing;
using System.Windows.Forms;

namespace Lab09
{
    partial class FormPokemon
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbApodo = new System.Windows.Forms.TextBox();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.lblTotalPsPokemon = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tbPs = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chBEsLegendario = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotalPokemons = new System.Windows.Forms.Label();
            this.dgPokemons = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPokemons)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.Location = new System.Drawing.Point(487, 235);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(227, 57);
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Location = new System.Drawing.Point(15, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 302);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(73, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Registrar Pokémon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(43, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Código:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(35, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(45, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Apodo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(57, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "Tipo:";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(97, 52);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(165, 20);
            this.tbCodigo.TabIndex = 20;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(97, 78);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(165, 20);
            this.tbNombre.TabIndex = 21;
            // 
            // tbApodo
            // 
            this.tbApodo.Location = new System.Drawing.Point(97, 104);
            this.tbApodo.Name = "tbApodo";
            this.tbApodo.Size = new System.Drawing.Size(165, 20);
            this.tbApodo.TabIndex = 22;
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Acero",
            "Agua",
            "Bicho",
            "Dragón",
            "Eléctrico",
            "Fantasma",
            "Fuego",
            "Hada",
            "Hielo",
            "Lucha",
            "Normal",
            "Planta",
            "Psíquico",
            "Roca",
            "Siniestro",
            "Tierra",
            "Veneno",
            "Volador"});
            this.cbTipo.Location = new System.Drawing.Point(97, 130);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(165, 21);
            this.cbTipo.TabIndex = 23;
            // 
            // lblTotalPsPokemon
            // 
            this.lblTotalPsPokemon.AutoSize = true;
            this.lblTotalPsPokemon.Location = new System.Drawing.Point(667, 265);
            this.lblTotalPsPokemon.Name = "lblTotalPsPokemon";
            this.lblTotalPsPokemon.Size = new System.Drawing.Size(13, 13);
            this.lblTotalPsPokemon.TabIndex = 35;
            this.lblTotalPsPokemon.Text = "0";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(77, 221);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(117, 33);
            this.btnRegistrar.TabIndex = 25;
            this.btnRegistrar.Text = "Registrar Pokémon";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(77, 259);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(117, 33);
            this.btnSalir.TabIndex = 27;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tbPs
            // 
            this.tbPs.Location = new System.Drawing.Point(97, 157);
            this.tbPs.Name = "tbPs";
            this.tbPs.Size = new System.Drawing.Size(165, 20);
            this.tbPs.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(67, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 15);
            this.label6.TabIndex = 29;
            this.label6.Text = "PS:";
            // 
            // chBEsLegendario
            // 
            this.chBEsLegendario.AutoSize = true;
            this.chBEsLegendario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.chBEsLegendario.Location = new System.Drawing.Point(78, 190);
            this.chBEsLegendario.Name = "chBEsLegendario";
            this.chBEsLegendario.Size = new System.Drawing.Size(99, 19);
            this.chBEsLegendario.TabIndex = 30;
            this.chBEsLegendario.Text = "Es legendario";
            this.chBEsLegendario.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(546, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 15);
            this.label7.TabIndex = 31;
            this.label7.Text = "Total de pokémons:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(512, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 15);
            this.label8.TabIndex = 32;
            this.label8.Text = "Total de PS de pokémons:";
            // 
            // lblTotalPokemons
            // 
            this.lblTotalPokemons.AutoSize = true;
            this.lblTotalPokemons.Location = new System.Drawing.Point(667, 243);
            this.lblTotalPokemons.Name = "lblTotalPokemons";
            this.lblTotalPokemons.Size = new System.Drawing.Size(13, 13);
            this.lblTotalPokemons.TabIndex = 33;
            this.lblTotalPokemons.Text = "0";
            // 
            // dgPokemons
            // 
            this.dgPokemons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPokemons.Location = new System.Drawing.Point(308, 7);
            this.dgPokemons.Name = "dgPokemons";
            this.dgPokemons.Size = new System.Drawing.Size(406, 211);
            this.dgPokemons.TabIndex = 37;
            // 
            // FormPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(729, 319);
            this.Controls.Add(this.dgPokemons);
            this.Controls.Add(this.lblTotalPsPokemon);
            this.Controls.Add(this.lblTotalPokemons);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chBEsLegendario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbPs);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.tbApodo);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "FormPokemon";
            this.Text = "Pokémon";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPokemons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tbCodigo;
        private TextBox tbNombre;
        private TextBox tbApodo;
        private ComboBox cbTipo;
        private Label lblTotalPsPokemon;
        private Button btnRegistrar;
        private Button btnSalir;
        private TextBox tbPs;
        private Label label6;
        private CheckBox chBEsLegendario;
        private Label label7;
        private Label label8;
        private Label lblTotalPokemons;
        private Button btnReportes;
        private ComboBox dbRegion;
        private TextBox textBox1;
        private DataGridView dgPokemons;
    }
}