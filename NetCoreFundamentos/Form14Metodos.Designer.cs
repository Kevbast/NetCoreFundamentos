namespace NetCoreFundamentos
{
    partial class Form14Metodos
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
            label1 = new Label();
            txtNumero = new TextBox();
            lblResultado = new Label();
            btnDobleValor = new Button();
            btnDobleReferencia = new Button();
            btnObjetoReferencia = new Button();
            label2 = new Label();
            label3 = new Label();
            txtSoloNumeros = new TextBox();
            txtSoloLetras = new TextBox();
            lblRaton = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 35);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Número";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(72, 80);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 1;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(90, 168);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(72, 15);
            lblResultado.TabIndex = 2;
            lblResultado.Text = "lblResultado";
            // 
            // btnDobleValor
            // 
            btnDobleValor.Location = new Point(72, 230);
            btnDobleValor.Name = "btnDobleValor";
            btnDobleValor.Size = new Size(114, 40);
            btnDobleValor.TabIndex = 4;
            btnDobleValor.Text = "Doble valor";
            btnDobleValor.UseVisualStyleBackColor = true;
            btnDobleValor.Click += btnDobleValor_Click;
            // 
            // btnDobleReferencia
            // 
            btnDobleReferencia.Location = new Point(72, 293);
            btnDobleReferencia.Name = "btnDobleReferencia";
            btnDobleReferencia.Size = new Size(139, 47);
            btnDobleReferencia.TabIndex = 5;
            btnDobleReferencia.Text = "Doble por Referencia";
            btnDobleReferencia.UseVisualStyleBackColor = true;
            btnDobleReferencia.Click += btnDobleReferencia_Click;
            // 
            // btnObjetoReferencia
            // 
            btnObjetoReferencia.Location = new Point(72, 362);
            btnObjetoReferencia.Name = "btnObjetoReferencia";
            btnObjetoReferencia.Size = new Size(201, 40);
            btnObjetoReferencia.TabIndex = 6;
            btnObjetoReferencia.Text = "Objeto Referencia";
            btnObjetoReferencia.UseVisualStyleBackColor = true;
            btnObjetoReferencia.Click += btnObjetoReferencia_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(299, 34);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 8;
            label2.Text = "Solo números";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(306, 68);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 9;
            label3.Text = "Solo letras";
            // 
            // txtSoloNumeros
            // 
            txtSoloNumeros.Location = new Point(406, 31);
            txtSoloNumeros.Name = "txtSoloNumeros";
            txtSoloNumeros.Size = new Size(100, 23);
            txtSoloNumeros.TabIndex = 10;
            txtSoloNumeros.KeyPress += txtSoloNumeros_KeyPress;
            // 
            // txtSoloLetras
            // 
            txtSoloLetras.Location = new Point(406, 68);
            txtSoloLetras.Name = "txtSoloLetras";
            txtSoloLetras.Size = new Size(100, 23);
            txtSoloLetras.TabIndex = 11;
            txtSoloLetras.KeyPress += txtSoloLetras_KeyPress;
            // 
            // lblRaton
            // 
            lblRaton.BackColor = SystemColors.ActiveCaption;
            lblRaton.Location = new Point(406, 168);
            lblRaton.Name = "lblRaton";
            lblRaton.Size = new Size(231, 136);
            lblRaton.TabIndex = 12;
            lblRaton.Text = "lblRaton";
            lblRaton.MouseMove += lblRaton_MouseMove;
            // 
            // Form14Metodos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblRaton);
            Controls.Add(txtSoloLetras);
            Controls.Add(txtSoloNumeros);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnObjetoReferencia);
            Controls.Add(btnDobleReferencia);
            Controls.Add(btnDobleValor);
            Controls.Add(lblResultado);
            Controls.Add(txtNumero);
            Controls.Add(label1);
            Name = "Form14Metodos";
            Text = "Form14Metodos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumero;
        private Label lblResultado;
        private Button btnDobleValor;
        private Button btnDobleReferencia;
        private Button btnObjetoReferencia;
        private Label label2;
        private Label label3;
        private TextBox txtSoloNumeros;
        private TextBox txtSoloLetras;
        private Label lblRaton;
    }
}