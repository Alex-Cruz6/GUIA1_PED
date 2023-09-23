namespace Guia1_Drawing_Jose_Alexander_Cruz_Alvarado
{
    partial class Ejercicio2
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
            this.btndibujar = new System.Windows.Forms.Button();
            this.areadibujo = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtespaciado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.cmbcolor = new System.Windows.Forms.ComboBox();
            this.cmborientacion = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblrequerido = new System.Windows.Forms.Label();
            this.lblerrorpi = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtpuntofin = new System.Windows.Forms.TextBox();
            this.txtpuntoinicio = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.areadibujo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btndibujar
            // 
            this.btndibujar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btndibujar.Location = new System.Drawing.Point(46, 336);
            this.btndibujar.Name = "btndibujar";
            this.btndibujar.Size = new System.Drawing.Size(187, 42);
            this.btndibujar.TabIndex = 19;
            this.btndibujar.Text = "DIBUJAR LÍNEAS";
            this.btndibujar.UseVisualStyleBackColor = true;
            this.btndibujar.Click += new System.EventHandler(this.btndibujar_Click);
            // 
            // areadibujo
            // 
            this.areadibujo.Location = new System.Drawing.Point(282, 12);
            this.areadibujo.Name = "areadibujo";
            this.areadibujo.Size = new System.Drawing.Size(506, 426);
            this.areadibujo.TabIndex = 18;
            this.areadibujo.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblrequerido);
            this.groupBox1.Controls.Add(this.lblerrorpi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtpuntofin);
            this.groupBox1.Controls.Add(this.txtpuntoinicio);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmborientacion);
            this.groupBox1.Controls.Add(this.txtespaciado);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtcantidad);
            this.groupBox1.Controls.Add(this.cmbcolor);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 293);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // txtespaciado
            // 
            this.txtespaciado.Location = new System.Drawing.Point(105, 58);
            this.txtespaciado.Name = "txtespaciado";
            this.txtespaciado.Size = new System.Drawing.Size(139, 20);
            this.txtespaciado.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Espaciado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Color";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(105, 19);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(139, 20);
            this.txtcantidad.TabIndex = 3;
            // 
            // cmbcolor
            // 
            this.cmbcolor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbcolor.FormattingEnabled = true;
            this.cmbcolor.Items.AddRange(new object[] {
            "amarillo",
            "rojo",
            "azul",
            "negro"});
            this.cmbcolor.Location = new System.Drawing.Point(105, 98);
            this.cmbcolor.Name = "cmbcolor";
            this.cmbcolor.Size = new System.Drawing.Size(139, 21);
            this.cmbcolor.TabIndex = 5;
            // 
            // cmborientacion
            // 
            this.cmborientacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmborientacion.FormattingEnabled = true;
            this.cmborientacion.Items.AddRange(new object[] {
            "Horizontal",
            "Vertical",
            "Inclinacion"});
            this.cmborientacion.Location = new System.Drawing.Point(107, 162);
            this.cmborientacion.Name = "cmborientacion";
            this.cmborientacion.Size = new System.Drawing.Size(137, 21);
            this.cmborientacion.TabIndex = 13;
            this.cmborientacion.TextChanged += new System.EventHandler(this.cmborientacion_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Orientación";
            // 
            // lblrequerido
            // 
            this.lblrequerido.AutoSize = true;
            this.lblrequerido.Font = new System.Drawing.Font("Segoe UI", 6.75F);
            this.lblrequerido.ForeColor = System.Drawing.Color.Red;
            this.lblrequerido.Location = new System.Drawing.Point(91, 140);
            this.lblrequerido.Name = "lblrequerido";
            this.lblrequerido.Size = new System.Drawing.Size(0, 12);
            this.lblrequerido.TabIndex = 20;
            // 
            // lblerrorpi
            // 
            this.lblerrorpi.AutoSize = true;
            this.lblerrorpi.Font = new System.Drawing.Font("Segoe UI", 6.75F);
            this.lblerrorpi.ForeColor = System.Drawing.Color.Red;
            this.lblerrorpi.Location = new System.Drawing.Point(105, 243);
            this.lblerrorpi.Name = "lblerrorpi";
            this.lblerrorpi.Size = new System.Drawing.Size(0, 12);
            this.lblerrorpi.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Punto de inicio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Punto final";
            // 
            // txtpuntofin
            // 
            this.txtpuntofin.Location = new System.Drawing.Point(108, 243);
            this.txtpuntofin.Name = "txtpuntofin";
            this.txtpuntofin.Size = new System.Drawing.Size(138, 20);
            this.txtpuntofin.TabIndex = 19;
            // 
            // txtpuntoinicio
            // 
            this.txtpuntoinicio.Location = new System.Drawing.Point(108, 199);
            this.txtpuntoinicio.Name = "txtpuntoinicio";
            this.txtpuntoinicio.Size = new System.Drawing.Size(139, 20);
            this.txtpuntoinicio.TabIndex = 18;
            // 
            // Ejercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btndibujar);
            this.Controls.Add(this.areadibujo);
            this.Controls.Add(this.groupBox1);
            this.Name = "Ejercicio2";
            this.Text = "Ejercicio2";
            ((System.ComponentModel.ISupportInitialize)(this.areadibujo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btndibujar;
        private System.Windows.Forms.PictureBox areadibujo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtespaciado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.ComboBox cmbcolor;
        private System.Windows.Forms.ComboBox cmborientacion;
        private System.Windows.Forms.Label lblrequerido;
        private System.Windows.Forms.Label lblerrorpi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtpuntofin;
        private System.Windows.Forms.TextBox txtpuntoinicio;
        private System.Windows.Forms.Label label4;
    }
}