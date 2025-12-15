namespace NetCoreFundamentos
{
    partial class Form06ValidarCorreo
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
            txtEmail = new TextBox();
            btnValidar = new Button();
            lblValidar = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 68);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 0;
            label1.Text = "Introduce tu correo";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(78, 95);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(159, 42);
            txtEmail.TabIndex = 1;
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(78, 143);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(75, 23);
            btnValidar.TabIndex = 2;
            btnValidar.Text = "Validar";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // lblValidar
            // 
            lblValidar.AutoSize = true;
            lblValidar.Location = new Point(272, 168);
            lblValidar.Name = "lblValidar";
            lblValidar.Size = new Size(38, 15);
            lblValidar.TabIndex = 3;
            lblValidar.Text = "label2";
            // 
            // Form06ValidarCorreo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblValidar);
            Controls.Add(btnValidar);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Name = "Form06ValidarCorreo";
            Text = "Form06ValidarCorreo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtEmail;
        private Button btnValidar;
        private Label lblValidar;
    }
}