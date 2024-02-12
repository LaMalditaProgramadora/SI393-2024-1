using System.Drawing;
using System.Windows.Forms;

namespace Lab03
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
            this.buttonRegistrar = new System.Windows.Forms.Button();
            this.comboBoxTipoAuto = new System.Windows.Forms.ComboBox();
            this.comboBoxTipoServicio = new System.Windows.Forms.ComboBox();
            this.labelServicioMinimaDemanda = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelTotalServicio1 = new System.Windows.Forms.Label();
            this.labelTotalServicio2 = new System.Windows.Forms.Label();
            this.labelTotalServicio3 = new System.Windows.Forms.Label();
            this.labelPromedioLavado = new System.Windows.Forms.Label();
            this.dgAtenciones = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgAtenciones)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TIPO AUTO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "TIPO SERVICIO:";
            // 
            // buttonRegistrar
            // 
            this.buttonRegistrar.Location = new System.Drawing.Point(28, 58);
            this.buttonRegistrar.Name = "buttonRegistrar";
            this.buttonRegistrar.Size = new System.Drawing.Size(64, 20);
            this.buttonRegistrar.TabIndex = 2;
            this.buttonRegistrar.Text = "Registrar";
            this.buttonRegistrar.UseVisualStyleBackColor = true;
            this.buttonRegistrar.Click += new System.EventHandler(this.buttonRegistrar_Click);
            // 
            // comboBoxTipoAuto
            // 
            this.comboBoxTipoAuto.FormattingEnabled = true;
            this.comboBoxTipoAuto.Items.AddRange(new object[] {
            "A",
            "C"});
            this.comboBoxTipoAuto.Location = new System.Drawing.Point(95, 17);
            this.comboBoxTipoAuto.Name = "comboBoxTipoAuto";
            this.comboBoxTipoAuto.Size = new System.Drawing.Size(104, 21);
            this.comboBoxTipoAuto.TabIndex = 4;
            // 
            // comboBoxTipoServicio
            // 
            this.comboBoxTipoServicio.FormattingEnabled = true;
            this.comboBoxTipoServicio.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBoxTipoServicio.Location = new System.Drawing.Point(398, 16);
            this.comboBoxTipoServicio.Name = "comboBoxTipoServicio";
            this.comboBoxTipoServicio.Size = new System.Drawing.Size(104, 21);
            this.comboBoxTipoServicio.TabIndex = 5;
            // 
            // labelServicioMinimaDemanda
            // 
            this.labelServicioMinimaDemanda.AutoSize = true;
            this.labelServicioMinimaDemanda.Location = new System.Drawing.Point(533, 248);
            this.labelServicioMinimaDemanda.Name = "labelServicioMinimaDemanda";
            this.labelServicioMinimaDemanda.Size = new System.Drawing.Size(10, 13);
            this.labelServicioMinimaDemanda.TabIndex = 7;
            this.labelServicioMinimaDemanda.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "TOTAL SERVICIO 1:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "TOTAL SERVICIO 2:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "TOTAL SERVICIO 3:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(368, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "SERVICIO MÍNIMA DEMANDA:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(370, 277);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "MONTO LAVADO PROMEDIO:";
            // 
            // labelTotalServicio1
            // 
            this.labelTotalServicio1.AutoSize = true;
            this.labelTotalServicio1.Location = new System.Drawing.Point(138, 248);
            this.labelTotalServicio1.Name = "labelTotalServicio1";
            this.labelTotalServicio1.Size = new System.Drawing.Size(13, 13);
            this.labelTotalServicio1.TabIndex = 13;
            this.labelTotalServicio1.Text = "0";
            // 
            // labelTotalServicio2
            // 
            this.labelTotalServicio2.AutoSize = true;
            this.labelTotalServicio2.Location = new System.Drawing.Point(138, 277);
            this.labelTotalServicio2.Name = "labelTotalServicio2";
            this.labelTotalServicio2.Size = new System.Drawing.Size(13, 13);
            this.labelTotalServicio2.TabIndex = 14;
            this.labelTotalServicio2.Text = "0";
            // 
            // labelTotalServicio3
            // 
            this.labelTotalServicio3.AutoSize = true;
            this.labelTotalServicio3.Location = new System.Drawing.Point(138, 305);
            this.labelTotalServicio3.Name = "labelTotalServicio3";
            this.labelTotalServicio3.Size = new System.Drawing.Size(13, 13);
            this.labelTotalServicio3.TabIndex = 15;
            this.labelTotalServicio3.Text = "0";
            // 
            // labelPromedioLavado
            // 
            this.labelPromedioLavado.AutoSize = true;
            this.labelPromedioLavado.Location = new System.Drawing.Point(533, 277);
            this.labelPromedioLavado.Name = "labelPromedioLavado";
            this.labelPromedioLavado.Size = new System.Drawing.Size(13, 13);
            this.labelPromedioLavado.TabIndex = 16;
            this.labelPromedioLavado.Text = "0";
            // 
            // dgAtenciones
            // 
            this.dgAtenciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAtenciones.Location = new System.Drawing.Point(28, 95);
            this.dgAtenciones.Name = "dgAtenciones";
            this.dgAtenciones.Size = new System.Drawing.Size(613, 126);
            this.dgAtenciones.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 350);
            this.Controls.Add(this.dgAtenciones);
            this.Controls.Add(this.labelPromedioLavado);
            this.Controls.Add(this.labelTotalServicio3);
            this.Controls.Add(this.labelTotalServicio2);
            this.Controls.Add(this.labelTotalServicio1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelServicioMinimaDemanda);
            this.Controls.Add(this.comboBoxTipoServicio);
            this.Controls.Add(this.comboBoxTipoAuto);
            this.Controls.Add(this.buttonRegistrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Atenciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgAtenciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Button buttonRegistrar;
        private ComboBox comboBoxTipoAuto;
        private ComboBox comboBoxTipoServicio;
        private Label labelServicioMinimaDemanda;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label labelTotalServicio1;
        private Label labelTotalServicio2;
        private Label labelTotalServicio3;
        private Label labelPromedioLavado;
        private DataGridView dgAtenciones;
    }
}