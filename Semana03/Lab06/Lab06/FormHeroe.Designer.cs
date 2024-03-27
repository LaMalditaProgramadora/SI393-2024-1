namespace Lab06
{
    partial class FormHeroe
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbCaracteristicas = new System.Windows.Forms.TextBox();
            this.tbPoder = new System.Windows.Forms.TextBox();
            this.dgHeroes = new System.Windows.Forms.DataGridView();
            this.btnRegistar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgHeroes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Características:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Poder:";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Location = new System.Drawing.Point(110, 25);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(162, 20);
            this.tbCodigo.TabIndex = 4;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(110, 51);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(162, 20);
            this.tbNombre.TabIndex = 5;
            // 
            // tbCaracteristicas
            // 
            this.tbCaracteristicas.Location = new System.Drawing.Point(110, 77);
            this.tbCaracteristicas.Name = "tbCaracteristicas";
            this.tbCaracteristicas.Size = new System.Drawing.Size(162, 20);
            this.tbCaracteristicas.TabIndex = 6;
            // 
            // tbPoder
            // 
            this.tbPoder.Location = new System.Drawing.Point(110, 103);
            this.tbPoder.Name = "tbPoder";
            this.tbPoder.Size = new System.Drawing.Size(162, 20);
            this.tbPoder.TabIndex = 7;
            // 
            // dgHeroes
            // 
            this.dgHeroes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHeroes.Location = new System.Drawing.Point(26, 180);
            this.dgHeroes.Name = "dgHeroes";
            this.dgHeroes.Size = new System.Drawing.Size(433, 222);
            this.dgHeroes.TabIndex = 8;
            // 
            // btnRegistar
            // 
            this.btnRegistar.Location = new System.Drawing.Point(26, 144);
            this.btnRegistar.Name = "btnRegistar";
            this.btnRegistar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistar.TabIndex = 9;
            this.btnRegistar.Text = "Registrar";
            this.btnRegistar.UseVisualStyleBackColor = true;
            this.btnRegistar.Click += new System.EventHandler(this.btnRegistar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(107, 144);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormHeroe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 426);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistar);
            this.Controls.Add(this.dgHeroes);
            this.Controls.Add(this.tbPoder);
            this.Controls.Add(this.tbCaracteristicas);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormHeroe";
            this.Text = "Héroes";
            ((System.ComponentModel.ISupportInitialize)(this.dgHeroes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbCaracteristicas;
        private System.Windows.Forms.TextBox tbPoder;
        private System.Windows.Forms.DataGridView dgHeroes;
        private System.Windows.Forms.Button btnRegistar;
        private System.Windows.Forms.Button btnSalir;
    }
}