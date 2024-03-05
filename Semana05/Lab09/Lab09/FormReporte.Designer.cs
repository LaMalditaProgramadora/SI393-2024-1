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
            this.lblTotalEntrenadores = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dgEntrenadores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEntrenadores)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscarPorMenorCantPokemon
            // 
            this.btnBuscarPorMenorCantPokemon.Location = new System.Drawing.Point(29, 227);
            this.btnBuscarPorMenorCantPokemon.Name = "btnBuscarPorMenorCantPokemon";
            this.btnBuscarPorMenorCantPokemon.Size = new System.Drawing.Size(230, 33);
            this.btnBuscarPorMenorCantPokemon.TabIndex = 77;
            this.btnBuscarPorMenorCantPokemon.Text = "Buscar por menor cantidad de pokémons";
            this.btnBuscarPorMenorCantPokemon.UseVisualStyleBackColor = true;
            this.btnBuscarPorMenorCantPokemon.Click += new System.EventHandler(this.btnBuscarPorMenorCantPokemon_Click);
            // 
            // lblTotalEntrenadores
            // 
            this.lblTotalEntrenadores.AutoSize = true;
            this.lblTotalEntrenadores.Location = new System.Drawing.Point(531, 304);
            this.lblTotalEntrenadores.Name = "lblTotalEntrenadores";
            this.lblTotalEntrenadores.Size = new System.Drawing.Size(13, 13);
            this.lblTotalEntrenadores.TabIndex = 74;
            this.lblTotalEntrenadores.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(393, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 15);
            this.label7.TabIndex = 73;
            this.label7.Text = "Total de entrenadores:";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(29, 266);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(230, 33);
            this.btnSalir.TabIndex = 72;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBuscarPorRegion
            // 
            this.btnBuscarPorRegion.Location = new System.Drawing.Point(29, 176);
            this.btnBuscarPorRegion.Name = "btnBuscarPorRegion";
            this.btnBuscarPorRegion.Size = new System.Drawing.Size(230, 33);
            this.btnBuscarPorRegion.TabIndex = 71;
            this.btnBuscarPorRegion.Text = "Buscar por región";
            this.btnBuscarPorRegion.UseVisualStyleBackColor = true;
            this.btnBuscarPorRegion.Click += new System.EventHandler(this.btnBuscarPorRegion_Click);
            // 
            // btnBuscarPorNombrePokemon
            // 
            this.btnBuscarPorNombrePokemon.Location = new System.Drawing.Point(29, 89);
            this.btnBuscarPorNombrePokemon.Name = "btnBuscarPorNombrePokemon";
            this.btnBuscarPorNombrePokemon.Size = new System.Drawing.Size(230, 33);
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
            this.cbRegion.Location = new System.Drawing.Point(94, 149);
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
            this.label5.Location = new System.Drawing.Point(39, 151);
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
            this.pictureBox1.Location = new System.Drawing.Point(6, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 321);
            this.pictureBox1.TabIndex = 75;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.Location = new System.Drawing.Point(345, 296);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(231, 32);
            this.pictureBox2.TabIndex = 76;
            this.pictureBox2.TabStop = false;
            // 
            // dgEntrenadores
            // 
            this.dgEntrenadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEntrenadores.Location = new System.Drawing.Point(301, 7);
            this.dgEntrenadores.Name = "dgEntrenadores";
            this.dgEntrenadores.Size = new System.Drawing.Size(275, 267);
            this.dgEntrenadores.TabIndex = 78;
            // 
            // FormReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(597, 343);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEntrenadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnBuscarPorMenorCantPokemon;
        private Label lblTotalEntrenadores;
        private Label label7;
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
        private PictureBox pictureBox2;
        private DataGridView dgEntrenadores;
    }
}