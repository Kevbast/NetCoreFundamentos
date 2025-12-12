namespace NetCoreFundamentos
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
            btnSaludo = new Button();
            lblSaludo = new Label();
            label2 = new Label();
            txtNombre = new TextBox();
            SuspendLayout();
            // 
            // btnSaludo
            // 
            btnSaludo.Location = new Point(433, 208);
            btnSaludo.Name = "btnSaludo";
            btnSaludo.Size = new Size(140, 45);
            btnSaludo.TabIndex = 0;
            btnSaludo.Text = "HI";
            btnSaludo.UseVisualStyleBackColor = true;
            btnSaludo.Click += btnSaludo_Click;
            // 
            // lblSaludo
            // 
            lblSaludo.AutoSize = true;
            lblSaludo.Location = new Point(433, 118);
            lblSaludo.Name = "lblSaludo";
            lblSaludo.Size = new Size(140, 15);
            lblSaludo.TabIndex = 1;
            lblSaludo.Text = "INTRODUCE TU NOMBRE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(290, 139);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(433, 165);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(140, 23);
            txtNombre.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(890, 521);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(lblSaludo);
            Controls.Add(btnSaludo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSaludo;
        private Label lblSaludo;
        private Label label2;
        private TextBox txtNombre;
    }
}
