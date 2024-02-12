using System.Drawing;
using System.Windows.Forms;

namespace Lab06
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAlbumCodigo = new System.Windows.Forms.TextBox();
            this.tbAlbumNombre = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblAlbumMasHeroes = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblHeroeMenorPoder = new System.Windows.Forms.Label();
            this.lblHeroeMayorPoder = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbHeroeCodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbHeroeCaracteristicas = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbHeroeNombre = new System.Windows.Forms.TextBox();
            this.btnLimpiarHeroes = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbHeroePoder = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRegistrarHeroe = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLimpiarAlbum = new System.Windows.Forms.Button();
            this.btnRegistrarAlbum = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgAlbumes = new System.Windows.Forms.DataGridView();
            this.dgHeroes = new System.Windows.Forms.DataGridView();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAlbumes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgHeroes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(99, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ÁLBUM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre:";
            // 
            // tbAlbumCodigo
            // 
            this.tbAlbumCodigo.Location = new System.Drawing.Point(76, 54);
            this.tbAlbumCodigo.Name = "tbAlbumCodigo";
            this.tbAlbumCodigo.Size = new System.Drawing.Size(133, 20);
            this.tbAlbumCodigo.TabIndex = 3;
            // 
            // tbAlbumNombre
            // 
            this.tbAlbumNombre.Location = new System.Drawing.Point(76, 84);
            this.tbAlbumNombre.Name = "tbAlbumNombre";
            this.tbAlbumNombre.Size = new System.Drawing.Size(133, 20);
            this.tbAlbumNombre.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Álbum con más héroes:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Héroe con menor poder:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Héroe con mayor poder:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblAlbumMasHeroes);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(10, 387);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(219, 76);
            this.panel3.TabIndex = 19;
            // 
            // lblAlbumMasHeroes
            // 
            this.lblAlbumMasHeroes.AutoSize = true;
            this.lblAlbumMasHeroes.Location = new System.Drawing.Point(15, 45);
            this.lblAlbumMasHeroes.Name = "lblAlbumMasHeroes";
            this.lblAlbumMasHeroes.Size = new System.Drawing.Size(10, 13);
            this.lblAlbumMasHeroes.TabIndex = 21;
            this.lblAlbumMasHeroes.Text = "-";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblHeroeMenorPoder);
            this.panel4.Controls.Add(this.lblHeroeMayorPoder);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Location = new System.Drawing.Point(243, 387);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(453, 76);
            this.panel4.TabIndex = 20;
            // 
            // lblHeroeMenorPoder
            // 
            this.lblHeroeMenorPoder.AutoSize = true;
            this.lblHeroeMenorPoder.Location = new System.Drawing.Point(147, 45);
            this.lblHeroeMenorPoder.Name = "lblHeroeMenorPoder";
            this.lblHeroeMenorPoder.Size = new System.Drawing.Size(10, 13);
            this.lblHeroeMenorPoder.TabIndex = 21;
            this.lblHeroeMenorPoder.Text = "-";
            // 
            // lblHeroeMayorPoder
            // 
            this.lblHeroeMayorPoder.AutoSize = true;
            this.lblHeroeMayorPoder.Location = new System.Drawing.Point(147, 20);
            this.lblHeroeMayorPoder.Name = "lblHeroeMayorPoder";
            this.lblHeroeMayorPoder.Size = new System.Drawing.Size(10, 13);
            this.lblHeroeMayorPoder.TabIndex = 19;
            this.lblHeroeMayorPoder.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Características:";
            // 
            // tbHeroeCodigo
            // 
            this.tbHeroeCodigo.Location = new System.Drawing.Point(99, 42);
            this.tbHeroeCodigo.Name = "tbHeroeCodigo";
            this.tbHeroeCodigo.Size = new System.Drawing.Size(133, 20);
            this.tbHeroeCodigo.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Código:";
            // 
            // tbHeroeCaracteristicas
            // 
            this.tbHeroeCaracteristicas.Location = new System.Drawing.Point(99, 72);
            this.tbHeroeCaracteristicas.Name = "tbHeroeCaracteristicas";
            this.tbHeroeCaracteristicas.Size = new System.Drawing.Size(133, 20);
            this.tbHeroeCaracteristicas.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(257, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Poder:";
            // 
            // tbHeroeNombre
            // 
            this.tbHeroeNombre.Location = new System.Drawing.Point(301, 42);
            this.tbHeroeNombre.Name = "tbHeroeNombre";
            this.tbHeroeNombre.Size = new System.Drawing.Size(133, 20);
            this.tbHeroeNombre.TabIndex = 13;
            // 
            // btnLimpiarHeroes
            // 
            this.btnLimpiarHeroes.Location = new System.Drawing.Point(228, 111);
            this.btnLimpiarHeroes.Name = "btnLimpiarHeroes";
            this.btnLimpiarHeroes.Size = new System.Drawing.Size(64, 20);
            this.btnLimpiarHeroes.TabIndex = 16;
            this.btnLimpiarHeroes.Text = "Limpiar";
            this.btnLimpiarHeroes.UseVisualStyleBackColor = true;
            this.btnLimpiarHeroes.Click += new System.EventHandler(this.btnLimpiarHeroes_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(248, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Nombre:";
            // 
            // tbHeroePoder
            // 
            this.tbHeroePoder.Location = new System.Drawing.Point(301, 72);
            this.tbHeroePoder.Name = "tbHeroePoder";
            this.tbHeroePoder.Size = new System.Drawing.Size(133, 20);
            this.tbHeroePoder.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(210, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "HÉROE";
            // 
            // btnRegistrarHeroe
            // 
            this.btnRegistrarHeroe.Location = new System.Drawing.Point(159, 111);
            this.btnRegistrarHeroe.Name = "btnRegistrarHeroe";
            this.btnRegistrarHeroe.Size = new System.Drawing.Size(64, 20);
            this.btnRegistrarHeroe.TabIndex = 17;
            this.btnRegistrarHeroe.Text = "Registrar";
            this.btnRegistrarHeroe.UseVisualStyleBackColor = true;
            this.btnRegistrarHeroe.Click += new System.EventHandler(this.btnRegistrarHeroe_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnRegistrarHeroe);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.tbHeroePoder);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btnLimpiarHeroes);
            this.panel2.Controls.Add(this.tbHeroeNombre);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.tbHeroeCaracteristicas);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.tbHeroeCodigo);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(243, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(453, 146);
            this.panel2.TabIndex = 11;
            // 
            // btnLimpiarAlbum
            // 
            this.btnLimpiarAlbum.Location = new System.Drawing.Point(115, 111);
            this.btnLimpiarAlbum.Name = "btnLimpiarAlbum";
            this.btnLimpiarAlbum.Size = new System.Drawing.Size(64, 20);
            this.btnLimpiarAlbum.TabIndex = 15;
            this.btnLimpiarAlbum.Text = "Limpiar";
            this.btnLimpiarAlbum.UseVisualStyleBackColor = true;
            this.btnLimpiarAlbum.Click += new System.EventHandler(this.btnLimpiarAlbum_Click);
            // 
            // btnRegistrarAlbum
            // 
            this.btnRegistrarAlbum.Location = new System.Drawing.Point(45, 111);
            this.btnRegistrarAlbum.Name = "btnRegistrarAlbum";
            this.btnRegistrarAlbum.Size = new System.Drawing.Size(64, 20);
            this.btnRegistrarAlbum.TabIndex = 17;
            this.btnRegistrarAlbum.Text = "Registrar";
            this.btnRegistrarAlbum.UseVisualStyleBackColor = true;
            this.btnRegistrarAlbum.Click += new System.EventHandler(this.btnRegistrarAlbum_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRegistrarAlbum);
            this.panel1.Controls.Add(this.btnLimpiarAlbum);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 146);
            this.panel1.TabIndex = 5;
            // 
            // dgAlbumes
            // 
            this.dgAlbumes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAlbumes.Location = new System.Drawing.Point(10, 172);
            this.dgAlbumes.Name = "dgAlbumes";
            this.dgAlbumes.Size = new System.Drawing.Size(219, 196);
            this.dgAlbumes.TabIndex = 21;
            this.dgAlbumes.SelectionChanged += new System.EventHandler(this.dgAlbumes_SelectionChanged);
            // 
            // dgHeroes
            // 
            this.dgHeroes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHeroes.Location = new System.Drawing.Point(243, 172);
            this.dgHeroes.Name = "dgHeroes";
            this.dgHeroes.Size = new System.Drawing.Size(453, 196);
            this.dgHeroes.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 489);
            this.Controls.Add(this.dgHeroes);
            this.Controls.Add(this.dgAlbumes);
            this.Controls.Add(this.tbAlbumNombre);
            this.Controls.Add(this.tbAlbumCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Name = "Form1";
            this.Text = "Álbumes y Héroes";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAlbumes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgHeroes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbAlbumCodigo;
        private TextBox tbAlbumNombre;
        private Label label10;
        private Label label11;
        private Label label12;
        private Panel panel3;
        private Label lblAlbumMasHeroes;
        private Panel panel4;
        private Label lblHeroeMenorPoder;
        private Label lblHeroeMayorPoder;
        private Label label4;
        private TextBox tbHeroeCodigo;
        private Label label5;
        private TextBox tbHeroeCaracteristicas;
        private Label label8;
        private TextBox tbHeroeNombre;
        private Button btnLimpiarHeroes;
        private Label label7;
        private TextBox tbHeroePoder;
        private Label label6;
        private Button btnRegistrarHeroe;
        private Panel panel2;
        private Button btnLimpiarAlbum;
        private Button btnRegistrarAlbum;
        private Panel panel1;
        private DataGridView dgAlbumes;
        private DataGridView dgHeroes;
    }
}