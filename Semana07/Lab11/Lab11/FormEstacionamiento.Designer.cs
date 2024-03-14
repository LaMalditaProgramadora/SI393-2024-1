using System.Drawing;
using System.Windows.Forms;

namespace Lab11
{
    partial class FormEstacionamiento
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
            this.tbMatriculaIngreso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDueñoIngreso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbMatriculaSalida = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonIngreso = new System.Windows.Forms.Button();
            this.buttonSalida = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewEstacionamiento = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tbMatriculaIngreso
            // 
            this.tbMatriculaIngreso.Location = new System.Drawing.Point(87, 47);
            this.tbMatriculaIngreso.Name = "tbMatriculaIngreso";
            this.tbMatriculaIngreso.Size = new System.Drawing.Size(133, 20);
            this.tbMatriculaIngreso.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(31, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Matrícula:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(17, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 132);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(107, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingreso";
            // 
            // tbDueñoIngreso
            // 
            this.tbDueñoIngreso.Location = new System.Drawing.Point(87, 72);
            this.tbDueñoIngreso.Name = "tbDueñoIngreso";
            this.tbDueñoIngreso.Size = new System.Drawing.Size(133, 20);
            this.tbDueñoIngreso.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(44, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dueño:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(357, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Salida";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(279, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Matrícula:";
            // 
            // tbMatriculaSalida
            // 
            this.tbMatriculaSalida.Location = new System.Drawing.Point(335, 47);
            this.tbMatriculaSalida.Name = "tbMatriculaSalida";
            this.tbMatriculaSalida.Size = new System.Drawing.Size(133, 20);
            this.tbMatriculaSalida.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox2.Location = new System.Drawing.Point(265, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(223, 102);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // buttonIngreso
            // 
            this.buttonIngreso.Location = new System.Drawing.Point(99, 109);
            this.buttonIngreso.Name = "buttonIngreso";
            this.buttonIngreso.Size = new System.Drawing.Size(64, 20);
            this.buttonIngreso.TabIndex = 10;
            this.buttonIngreso.Text = "Ingresar";
            this.buttonIngreso.UseVisualStyleBackColor = true;
            this.buttonIngreso.Click += new System.EventHandler(this.buttonIngreso_Click);
            // 
            // buttonSalida
            // 
            this.buttonSalida.Location = new System.Drawing.Point(345, 84);
            this.buttonSalida.Name = "buttonSalida";
            this.buttonSalida.Size = new System.Drawing.Size(64, 20);
            this.buttonSalida.TabIndex = 11;
            this.buttonSalida.Text = "Salir";
            this.buttonSalida.UseVisualStyleBackColor = true;
            this.buttonSalida.Click += new System.EventHandler(this.buttonSalida_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Matrícula";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Dueño";
            this.columnHeader2.Width = 250;
            // 
            // listViewEstacionamiento
            // 
            this.listViewEstacionamiento.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewEstacionamiento.HideSelection = false;
            this.listViewEstacionamiento.Location = new System.Drawing.Point(17, 162);
            this.listViewEstacionamiento.Name = "listViewEstacionamiento";
            this.listViewEstacionamiento.Size = new System.Drawing.Size(471, 208);
            this.listViewEstacionamiento.TabIndex = 12;
            this.listViewEstacionamiento.UseCompatibleStateImageBehavior = false;
            this.listViewEstacionamiento.View = System.Windows.Forms.View.Details;
            // 
            // FormEstacionamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 390);
            this.Controls.Add(this.listViewEstacionamiento);
            this.Controls.Add(this.buttonSalida);
            this.Controls.Add(this.buttonIngreso);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbMatriculaSalida);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbDueñoIngreso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMatriculaIngreso);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormEstacionamiento";
            this.Text = "FormEstacionamiento";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbMatriculaIngreso;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox tbDueñoIngreso;
        private Label label3;
        private Label label5;
        private Label label6;
        private TextBox tbMatriculaSalida;
        private PictureBox pictureBox2;
        private Button buttonIngreso;
        private Button buttonSalida;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ListView listViewEstacionamiento;
    }
}