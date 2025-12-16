namespace NetCoreFundamentos
{
    partial class Form12ColeccionNumeros
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
            label2 = new Label();
            label3 = new Label();
            lstNumeros = new ListBox();
            btnGenerar = new Button();
            btnMostrar = new Button();
            txtSuma = new TextBox();
            txtPares = new TextBox();
            txtImpares = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 42);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "Numeros";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(330, 203);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 1;
            label2.Text = "Suma";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(330, 251);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 2;
            label3.Text = "Pares";
            label3.Click += label3_Click;
            // 
            // lstNumeros
            // 
            lstNumeros.FormattingEnabled = true;
            lstNumeros.Location = new Point(46, 80);
            lstNumeros.Name = "lstNumeros";
            lstNumeros.Size = new Size(120, 169);
            lstNumeros.TabIndex = 3;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(330, 106);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(211, 37);
            btnGenerar.TabIndex = 4;
            btnGenerar.Text = "Generar Numeros";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(330, 149);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(211, 36);
            btnMostrar.TabIndex = 5;
            btnMostrar.Text = "Mostrar Datos";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // txtSuma
            // 
            txtSuma.Location = new Point(412, 200);
            txtSuma.Name = "txtSuma";
            txtSuma.Size = new Size(156, 23);
            txtSuma.TabIndex = 6;
            // 
            // txtPares
            // 
            txtPares.Location = new Point(412, 248);
            txtPares.Name = "txtPares";
            txtPares.Size = new Size(195, 23);
            txtPares.TabIndex = 7;
            // 
            // txtImpares
            // 
            txtImpares.Location = new Point(412, 294);
            txtImpares.Name = "txtImpares";
            txtImpares.Size = new Size(205, 23);
            txtImpares.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(330, 302);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 9;
            label4.Text = "Impares";
            // 
            // Form12ColeccionNumeros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 428);
            Controls.Add(label4);
            Controls.Add(txtImpares);
            Controls.Add(txtPares);
            Controls.Add(txtSuma);
            Controls.Add(btnMostrar);
            Controls.Add(btnGenerar);
            Controls.Add(lstNumeros);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form12ColeccionNumeros";
            Text = "Form12ColeccionNumeros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox lstNumeros;
        private Button btnGenerar;
        private Button btnMostrar;
        private TextBox txtSuma;
        private TextBox txtPares;
        private TextBox txtImpares;
        private Label label4;
    }
}