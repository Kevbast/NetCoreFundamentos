namespace NetCoreFundamentos
{
    partial class Form07SumarString
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
            txtNumeros = new TextBox();
            lblresultado = new Label();
            btnSumarNums = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 37);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 0;
            label1.Text = "Intrduzca numeros";
            // 
            // txtNumeros
            // 
            txtNumeros.Location = new Point(51, 69);
            txtNumeros.Name = "txtNumeros";
            txtNumeros.Size = new Size(114, 23);
            txtNumeros.TabIndex = 1;
            // 
            // lblresultado
            // 
            lblresultado.AutoSize = true;
            lblresultado.Location = new Point(109, 154);
            lblresultado.Name = "lblresultado";
            lblresultado.Size = new Size(56, 15);
            lblresultado.TabIndex = 2;
            lblresultado.Text = "resultado";
            lblresultado.Click += lblresultado_Click;
            // 
            // btnSumarNums
            // 
            btnSumarNums.Location = new Point(51, 98);
            btnSumarNums.Name = "btnSumarNums";
            btnSumarNums.Size = new Size(114, 23);
            btnSumarNums.TabIndex = 3;
            btnSumarNums.Text = "Sumar números";
            btnSumarNums.UseVisualStyleBackColor = true;
            btnSumarNums.Click += btnSumarNums_Click;
            // 
            // Form07SumarString
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSumarNums);
            Controls.Add(lblresultado);
            Controls.Add(txtNumeros);
            Controls.Add(label1);
            Name = "Form07SumarString";
            Text = "Form07SumarString";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumeros;
        private Label lblresultado;
        private Button btnSumarNums;
    }
}