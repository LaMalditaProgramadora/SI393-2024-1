using System.Drawing;
using System.Windows.Forms;

namespace Lab12
{
    partial class FormPrincipal
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
            this.btnVerDoctores = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVerDoctores
            // 
            this.btnVerDoctores.Location = new System.Drawing.Point(123, 58);
            this.btnVerDoctores.Name = "btnVerDoctores";
            this.btnVerDoctores.Size = new System.Drawing.Size(112, 25);
            this.btnVerDoctores.TabIndex = 0;
            this.btnVerDoctores.Text = "Ver Doctores";
            this.btnVerDoctores.UseVisualStyleBackColor = true;
            this.btnVerDoctores.Click += new System.EventHandler(this.btnVerDoctores_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(123, 103);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(112, 25);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 192);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnVerDoctores);
            this.Name = "FormPrincipal";
            this.Text = "Menú";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnVerDoctores;
        private Button btnSalir;
    }
}