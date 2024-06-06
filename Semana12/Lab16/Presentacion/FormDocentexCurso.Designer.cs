
namespace Presentacion
{
    partial class FormDocentexCurso
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
            this.cbDocente = new System.Windows.Forms.ComboBox();
            this.cbCurso = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSemestre = new System.Windows.Forms.TextBox();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.btnDesasignar = new System.Windows.Forms.Button();
            this.btnBuscarPorDocente = new System.Windows.Forms.Button();
            this.btnBuscarPorCurso = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgDocentexCursos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgDocentexCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // cbDocente
            // 
            this.cbDocente.FormattingEnabled = true;
            this.cbDocente.Location = new System.Drawing.Point(80, 12);
            this.cbDocente.Name = "cbDocente";
            this.cbDocente.Size = new System.Drawing.Size(148, 21);
            this.cbDocente.TabIndex = 0;
            // 
            // cbCurso
            // 
            this.cbCurso.FormattingEnabled = true;
            this.cbCurso.Location = new System.Drawing.Point(80, 39);
            this.cbCurso.Name = "cbCurso";
            this.cbCurso.Size = new System.Drawing.Size(148, 21);
            this.cbCurso.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Docente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Curso:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Semestre:";
            // 
            // tbSemestre
            // 
            this.tbSemestre.Location = new System.Drawing.Point(82, 70);
            this.tbSemestre.Name = "tbSemestre";
            this.tbSemestre.Size = new System.Drawing.Size(146, 20);
            this.tbSemestre.TabIndex = 5;
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(55, 116);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(149, 23);
            this.btnAsignar.TabIndex = 6;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // btnDesasignar
            // 
            this.btnDesasignar.Location = new System.Drawing.Point(55, 145);
            this.btnDesasignar.Name = "btnDesasignar";
            this.btnDesasignar.Size = new System.Drawing.Size(149, 23);
            this.btnDesasignar.TabIndex = 7;
            this.btnDesasignar.Text = "Desasignar";
            this.btnDesasignar.UseVisualStyleBackColor = true;
            this.btnDesasignar.Click += new System.EventHandler(this.btnDesasignar_Click);
            // 
            // btnBuscarPorDocente
            // 
            this.btnBuscarPorDocente.Location = new System.Drawing.Point(55, 174);
            this.btnBuscarPorDocente.Name = "btnBuscarPorDocente";
            this.btnBuscarPorDocente.Size = new System.Drawing.Size(149, 23);
            this.btnBuscarPorDocente.TabIndex = 8;
            this.btnBuscarPorDocente.Text = "Buscar por Docente";
            this.btnBuscarPorDocente.UseVisualStyleBackColor = true;
            this.btnBuscarPorDocente.Click += new System.EventHandler(this.btnBuscarPorDocente_Click);
            // 
            // btnBuscarPorCurso
            // 
            this.btnBuscarPorCurso.Location = new System.Drawing.Point(55, 203);
            this.btnBuscarPorCurso.Name = "btnBuscarPorCurso";
            this.btnBuscarPorCurso.Size = new System.Drawing.Size(149, 23);
            this.btnBuscarPorCurso.TabIndex = 9;
            this.btnBuscarPorCurso.Text = "Buscar por Curso";
            this.btnBuscarPorCurso.UseVisualStyleBackColor = true;
            this.btnBuscarPorCurso.Click += new System.EventHandler(this.btnBuscarPorCurso_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(55, 232);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(149, 23);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgDocentexCursos
            // 
            this.dgDocentexCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDocentexCursos.Location = new System.Drawing.Point(248, 12);
            this.dgDocentexCursos.Name = "dgDocentexCursos";
            this.dgDocentexCursos.Size = new System.Drawing.Size(540, 243);
            this.dgDocentexCursos.TabIndex = 11;
            // 
            // FormDocentexCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 269);
            this.Controls.Add(this.dgDocentexCursos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBuscarPorCurso);
            this.Controls.Add(this.btnBuscarPorDocente);
            this.Controls.Add(this.btnDesasignar);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.tbSemestre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCurso);
            this.Controls.Add(this.cbDocente);
            this.Name = "FormDocentexCurso";
            this.Text = "Asignar";
            ((System.ComponentModel.ISupportInitialize)(this.dgDocentexCursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDocente;
        private System.Windows.Forms.ComboBox cbCurso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSemestre;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.Button btnDesasignar;
        private System.Windows.Forms.Button btnBuscarPorDocente;
        private System.Windows.Forms.Button btnBuscarPorCurso;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgDocentexCursos;
    }
}