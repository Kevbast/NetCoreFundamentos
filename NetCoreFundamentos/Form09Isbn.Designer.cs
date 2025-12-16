namespace NetCoreFundamentos
{
    partial class Form09Isbn
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
            lblResultado = new Label();
            txtIsbn = new TextBox();
            btnValidarIsbn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 57);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 0;
            label1.Text = "Introduce un ISBN";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(61, 228);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(59, 15);
            lblResultado.TabIndex = 1;
            lblResultado.Text = "Resultado";
            // 
            // txtIsbn
            // 
            txtIsbn.Location = new Point(61, 75);
            txtIsbn.Name = "txtIsbn";
            txtIsbn.Size = new Size(160, 23);
            txtIsbn.TabIndex = 2;
            // 
            // btnValidarIsbn
            // 
            btnValidarIsbn.Location = new Point(81, 120);
            btnValidarIsbn.Name = "btnValidarIsbn";
            btnValidarIsbn.Size = new Size(75, 23);
            btnValidarIsbn.TabIndex = 3;
            btnValidarIsbn.Text = "Validar ISBN";
            btnValidarIsbn.UseVisualStyleBackColor = true;
            btnValidarIsbn.Click += btnValidarIsbn_Click;
            // 
            // Form09Isbn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnValidarIsbn);
            Controls.Add(txtIsbn);
            Controls.Add(lblResultado);
            Controls.Add(label1);
            Name = "Form09Isbn";
            Text = "Form09Isbn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblResultado;
        private TextBox txtIsbn;
        private Button btnValidarIsbn;
    }
}