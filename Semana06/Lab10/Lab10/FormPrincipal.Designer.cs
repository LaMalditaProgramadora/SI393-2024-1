using System.Drawing;
using System.Windows.Forms;

namespace Lab10
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
            this.btnVerBuses = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVerBuses
            // 
            this.btnVerBuses.Location = new System.Drawing.Point(109, 49);
            this.btnVerBuses.Name = "btnVerBuses";
            this.btnVerBuses.Size = new System.Drawing.Size(64, 20);
            this.btnVerBuses.TabIndex = 0;
            this.btnVerBuses.Text = "Ver Buses";
            this.btnVerBuses.UseVisualStyleBackColor = true;
            this.btnVerBuses.Click += new System.EventHandler(this.btnVerBuses_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(109, 84);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(64, 20);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 156);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnVerBuses);
            this.Name = "FormPrincipal";
            this.Text = "Menú";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnVerBuses;
        private Button btnSalir;
    }
}