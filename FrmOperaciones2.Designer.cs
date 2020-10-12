namespace WindowsForms_Laboratorio_OswaldoCHINO
{
    partial class FrmOperaciones2
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
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnSuma = new System.Windows.Forms.RadioButton();
            this.rbtnResta = new System.Windows.Forms.RadioButton();
            this.rbtnMultiplicacion = new System.Windows.Forms.RadioButton();
            this.rbtnDivision = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtResultado.Location = new System.Drawing.Point(179, 209);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 20);
            this.txtResultado.TabIndex = 27;
            // 
            // txtNumero2
            // 
            this.txtNumero2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtNumero2.Location = new System.Drawing.Point(179, 151);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(100, 20);
            this.txtNumero2.TabIndex = 26;
            // 
            // txtNumero1
            // 
            this.txtNumero1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtNumero1.Location = new System.Drawing.Point(179, 96);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(100, 20);
            this.txtNumero1.TabIndex = 25;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(450, 148);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 24;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(450, 94);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 23;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Resultado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Numero 2:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Numero 1:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(176, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Operaciones de dos numeros";
            // 
            // rbtnSuma
            // 
            this.rbtnSuma.AutoSize = true;
            this.rbtnSuma.Location = new System.Drawing.Point(328, 99);
            this.rbtnSuma.Name = "rbtnSuma";
            this.rbtnSuma.Size = new System.Drawing.Size(52, 17);
            this.rbtnSuma.TabIndex = 28;
            this.rbtnSuma.TabStop = true;
            this.rbtnSuma.Text = "Suma";
            this.rbtnSuma.UseVisualStyleBackColor = true;
            this.rbtnSuma.CheckedChanged += new System.EventHandler(this.rbtnSuma_CheckedChanged);
            // 
            // rbtnResta
            // 
            this.rbtnResta.AutoSize = true;
            this.rbtnResta.Location = new System.Drawing.Point(328, 132);
            this.rbtnResta.Name = "rbtnResta";
            this.rbtnResta.Size = new System.Drawing.Size(53, 17);
            this.rbtnResta.TabIndex = 29;
            this.rbtnResta.TabStop = true;
            this.rbtnResta.Text = "Resta";
            this.rbtnResta.UseVisualStyleBackColor = true;
            this.rbtnResta.CheckedChanged += new System.EventHandler(this.rbtnResta_CheckedChanged);
            // 
            // rbtnMultiplicacion
            // 
            this.rbtnMultiplicacion.AutoSize = true;
            this.rbtnMultiplicacion.Location = new System.Drawing.Point(328, 158);
            this.rbtnMultiplicacion.Name = "rbtnMultiplicacion";
            this.rbtnMultiplicacion.Size = new System.Drawing.Size(89, 17);
            this.rbtnMultiplicacion.TabIndex = 30;
            this.rbtnMultiplicacion.TabStop = true;
            this.rbtnMultiplicacion.Text = "Multiplicacion";
            this.rbtnMultiplicacion.UseVisualStyleBackColor = true;
            this.rbtnMultiplicacion.CheckedChanged += new System.EventHandler(this.rbtnMultiplicacion_CheckedChanged);
            // 
            // rbtnDivision
            // 
            this.rbtnDivision.AutoSize = true;
            this.rbtnDivision.Location = new System.Drawing.Point(328, 190);
            this.rbtnDivision.Name = "rbtnDivision";
            this.rbtnDivision.Size = new System.Drawing.Size(62, 17);
            this.rbtnDivision.TabIndex = 31;
            this.rbtnDivision.TabStop = true;
            this.rbtnDivision.Text = "Division";
            this.rbtnDivision.UseVisualStyleBackColor = true;
            this.rbtnDivision.CheckedChanged += new System.EventHandler(this.rbtnDivision_CheckedChanged);
            // 
            // FrmOperaciones2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbtnDivision);
            this.Controls.Add(this.rbtnMultiplicacion);
            this.Controls.Add(this.rbtnResta);
            this.Controls.Add(this.rbtnSuma);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmOperaciones2";
            this.Text = "FrmOperaciones2";
            this.Load += new System.EventHandler(this.FrmOperaciones2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnSuma;
        private System.Windows.Forms.RadioButton rbtnResta;
        private System.Windows.Forms.RadioButton rbtnMultiplicacion;
        private System.Windows.Forms.RadioButton rbtnDivision;
    }
}