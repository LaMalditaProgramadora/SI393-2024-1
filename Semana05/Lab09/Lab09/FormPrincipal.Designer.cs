using System.Drawing;
using System.Windows.Forms;

namespace Lab09
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRegistrarEntrenador = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(351, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnRegistrarEntrenador
            // 
            this.btnRegistrarEntrenador.Location = new System.Drawing.Point(117, 177);
            this.btnRegistrarEntrenador.Name = "btnRegistrarEntrenador";
            this.btnRegistrarEntrenador.Size = new System.Drawing.Size(117, 33);
            this.btnRegistrarEntrenador.TabIndex = 1;
            this.btnRegistrarEntrenador.Text = "Ver Entrenador";
            this.btnRegistrarEntrenador.UseVisualStyleBackColor = true;
            this.btnRegistrarEntrenador.Click += new System.EventHandler(this.btnRegistrarEntrenador_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(117, 219);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(117, 33);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(350, 274);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistrarEntrenador);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormPrincipal";
            this.Text = "Liga Pokémon";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnRegistrarEntrenador;
        private Button btnSalir;
    }
}