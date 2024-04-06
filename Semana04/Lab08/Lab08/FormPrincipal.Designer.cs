
namespace Lab08
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
            this.btnVerAgencias = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVerAgencias
            // 
            this.btnVerAgencias.Location = new System.Drawing.Point(83, 32);
            this.btnVerAgencias.Name = "btnVerAgencias";
            this.btnVerAgencias.Size = new System.Drawing.Size(107, 23);
            this.btnVerAgencias.TabIndex = 0;
            this.btnVerAgencias.Text = "Ver Agencias";
            this.btnVerAgencias.UseVisualStyleBackColor = true;
            this.btnVerAgencias.Click += new System.EventHandler(this.btnVerAgencias_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(83, 96);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(107, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 161);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnVerAgencias);
            this.Name = "FormPrincipal";
            this.Text = "Menú";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVerAgencias;
        private System.Windows.Forms.Button btnSalir;
    }
}