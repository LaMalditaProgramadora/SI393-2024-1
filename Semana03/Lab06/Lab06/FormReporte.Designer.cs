namespace Lab06
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
            this.dgAlbumes = new System.Windows.Forms.DataGridView();
            this.dgHeroes = new System.Windows.Forms.DataGridView();
            this.btnObtenerAlbumMasHeroes = new System.Windows.Forms.Button();
            this.btnListarAlbumesSegunHeroe = new System.Windows.Forms.Button();
            this.tbCodigoHeroe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnObtenerHeroesMenorPoder = new System.Windows.Forms.Button();
            this.btnObtenerHeroesMayorPoder = new System.Windows.Forms.Button();
            this.tbCodigoAlbum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgAlbumes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgHeroes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgAlbumes
            // 
            this.dgAlbumes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAlbumes.Location = new System.Drawing.Point(373, 33);
            this.dgAlbumes.Name = "dgAlbumes";
            this.dgAlbumes.Size = new System.Drawing.Size(382, 227);
            this.dgAlbumes.TabIndex = 6;
            // 
            // dgHeroes
            // 
            this.dgHeroes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHeroes.Location = new System.Drawing.Point(373, 284);
            this.dgHeroes.Name = "dgHeroes";
            this.dgHeroes.Size = new System.Drawing.Size(382, 222);
            this.dgHeroes.TabIndex = 9;
            // 
            // btnObtenerAlbumMasHeroes
            // 
            this.btnObtenerAlbumMasHeroes.Location = new System.Drawing.Point(41, 33);
            this.btnObtenerAlbumMasHeroes.Name = "btnObtenerAlbumMasHeroes";
            this.btnObtenerAlbumMasHeroes.Size = new System.Drawing.Size(200, 23);
            this.btnObtenerAlbumMasHeroes.TabIndex = 10;
            this.btnObtenerAlbumMasHeroes.Text = "Obtener álbum con más héroes";
            this.btnObtenerAlbumMasHeroes.UseVisualStyleBackColor = true;
            this.btnObtenerAlbumMasHeroes.Click += new System.EventHandler(this.btnObtenerAlbumMasHeroes_Click);
            // 
            // btnListarAlbumesSegunHeroe
            // 
            this.btnListarAlbumesSegunHeroe.Location = new System.Drawing.Point(41, 129);
            this.btnListarAlbumesSegunHeroe.Name = "btnListarAlbumesSegunHeroe";
            this.btnListarAlbumesSegunHeroe.Size = new System.Drawing.Size(200, 23);
            this.btnListarAlbumesSegunHeroe.TabIndex = 11;
            this.btnListarAlbumesSegunHeroe.Text = "Listar álbumes según héroe";
            this.btnListarAlbumesSegunHeroe.UseVisualStyleBackColor = true;
            this.btnListarAlbumesSegunHeroe.Click += new System.EventHandler(this.btnListarAlbumesSegunHeroe_Click);
            // 
            // tbCodigoHeroe
            // 
            this.tbCodigoHeroe.Location = new System.Drawing.Point(135, 93);
            this.tbCodigoHeroe.Name = "tbCodigoHeroe";
            this.tbCodigoHeroe.Size = new System.Drawing.Size(177, 20);
            this.tbCodigoHeroe.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Código de héroe:";
            // 
            // btnObtenerHeroesMenorPoder
            // 
            this.btnObtenerHeroesMenorPoder.Location = new System.Drawing.Point(41, 379);
            this.btnObtenerHeroesMenorPoder.Name = "btnObtenerHeroesMenorPoder";
            this.btnObtenerHeroesMenorPoder.Size = new System.Drawing.Size(200, 23);
            this.btnObtenerHeroesMenorPoder.TabIndex = 14;
            this.btnObtenerHeroesMenorPoder.Text = "Obtener héroes con menor poder";
            this.btnObtenerHeroesMenorPoder.UseVisualStyleBackColor = true;
            this.btnObtenerHeroesMenorPoder.Click += new System.EventHandler(this.btnObtenerHeroesMenorPoder_Click);
            // 
            // btnObtenerHeroesMayorPoder
            // 
            this.btnObtenerHeroesMayorPoder.Location = new System.Drawing.Point(41, 408);
            this.btnObtenerHeroesMayorPoder.Name = "btnObtenerHeroesMayorPoder";
            this.btnObtenerHeroesMayorPoder.Size = new System.Drawing.Size(200, 23);
            this.btnObtenerHeroesMayorPoder.TabIndex = 15;
            this.btnObtenerHeroesMayorPoder.Text = "Obtener héroes con mayor poder";
            this.btnObtenerHeroesMayorPoder.UseVisualStyleBackColor = true;
            this.btnObtenerHeroesMayorPoder.Click += new System.EventHandler(this.btnObtenerHeroesMayorPoder_Click);
            // 
            // tbCodigoAlbum
            // 
            this.tbCodigoAlbum.Location = new System.Drawing.Point(138, 338);
            this.tbCodigoAlbum.Name = "tbCodigoAlbum";
            this.tbCodigoAlbum.Size = new System.Drawing.Size(174, 20);
            this.tbCodigoAlbum.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Código del álbum:";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(41, 483);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 18;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCodigoAlbum);
            this.Controls.Add(this.btnObtenerHeroesMayorPoder);
            this.Controls.Add(this.btnObtenerHeroesMenorPoder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCodigoHeroe);
            this.Controls.Add(this.btnListarAlbumesSegunHeroe);
            this.Controls.Add(this.btnObtenerAlbumMasHeroes);
            this.Controls.Add(this.dgHeroes);
            this.Controls.Add(this.dgAlbumes);
            this.Name = "FormReporte";
            this.Text = "Reporte";
            ((System.ComponentModel.ISupportInitialize)(this.dgAlbumes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgHeroes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgAlbumes;
        private System.Windows.Forms.DataGridView dgHeroes;
        private System.Windows.Forms.Button btnObtenerAlbumMasHeroes;
        private System.Windows.Forms.Button btnListarAlbumesSegunHeroe;
        private System.Windows.Forms.TextBox tbCodigoHeroe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnObtenerHeroesMenorPoder;
        private System.Windows.Forms.Button btnObtenerHeroesMayorPoder;
        private System.Windows.Forms.TextBox tbCodigoAlbum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalir;
    }
}