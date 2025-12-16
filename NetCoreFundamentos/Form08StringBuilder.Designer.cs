namespace NetCoreFundamentos
{
    partial class Form08StringBuilder
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
            txtStringBuilder = new RichTextBox();
            label1 = new Label();
            lblTiempo = new Label();
            btnInvertirString = new Button();
            btnInvertirStringBuilder = new Button();
            SuspendLayout();
            // 
            // txtStringBuilder
            // 
            txtStringBuilder.Location = new Point(71, 84);
            txtStringBuilder.Name = "txtStringBuilder";
            txtStringBuilder.Size = new Size(467, 240);
            txtStringBuilder.TabIndex = 0;
            txtStringBuilder.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 27);
            label1.Name = "label1";
            label1.Size = new Size(137, 15);
            label1.TabIndex = 1;
            label1.Text = "Copie texto para trabajar";
            // 
            // lblTiempo
            // 
            lblTiempo.AutoSize = true;
            lblTiempo.ForeColor = Color.FromArgb(255, 128, 0);
            lblTiempo.Location = new Point(71, 347);
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(60, 15);
            lblTiempo.TabIndex = 2;
            lblTiempo.Text = "lblTiempo";
            // 
            // btnInvertirString
            // 
            btnInvertirString.Location = new Point(161, 377);
            btnInvertirString.Name = "btnInvertirString";
            btnInvertirString.Size = new Size(130, 48);
            btnInvertirString.TabIndex = 3;
            btnInvertirString.Text = "Invertir String";
            btnInvertirString.UseVisualStyleBackColor = true;
            btnInvertirString.Click += btnInvertirString_Click;
            // 
            // btnInvertirStringBuilder
            // 
            btnInvertirStringBuilder.Location = new Point(337, 377);
            btnInvertirStringBuilder.Name = "btnInvertirStringBuilder";
            btnInvertirStringBuilder.Size = new Size(145, 48);
            btnInvertirStringBuilder.TabIndex = 4;
            btnInvertirStringBuilder.Text = "Invertir StringBuilder";
            btnInvertirStringBuilder.UseVisualStyleBackColor = true;
            btnInvertirStringBuilder.Click += btnInvertirStringBuilder_Click;
            // 
            // Form08StringBuilder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnInvertirStringBuilder);
            Controls.Add(btnInvertirString);
            Controls.Add(lblTiempo);
            Controls.Add(label1);
            Controls.Add(txtStringBuilder);
            Name = "Form08StringBuilder";
            Text = "Form08StringBuilder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtStringBuilder;
        private Label label1;
        private Label lblTiempo;
        private Button btnInvertirString;
        private Button btnInvertirStringBuilder;
    }
}