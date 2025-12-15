namespace NetCoreFundamentos
{
    partial class Form03DiaNacimiento
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
            txtDia = new TextBox();
            txtMes = new TextBox();
            txtYear = new TextBox();
            lblMostrarDia = new Label();
            btnMostrarDia = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 49);
            label1.Name = "label1";
            label1.Size = new Size(23, 15);
            label1.TabIndex = 0;
            label1.Text = "día";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 96);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 1;
            label2.Text = "mes";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 135);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 2;
            label3.Text = "año";
            // 
            // txtDia
            // 
            txtDia.Location = new Point(141, 49);
            txtDia.Name = "txtDia";
            txtDia.Size = new Size(100, 23);
            txtDia.TabIndex = 3;
            // 
            // txtMes
            // 
            txtMes.Location = new Point(141, 93);
            txtMes.Name = "txtMes";
            txtMes.Size = new Size(100, 23);
            txtMes.TabIndex = 4;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(141, 132);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(100, 23);
            txtYear.TabIndex = 5;
            // 
            // lblMostrarDia
            // 
            lblMostrarDia.AutoSize = true;
            lblMostrarDia.ForeColor = Color.Teal;
            lblMostrarDia.Location = new Point(54, 240);
            lblMostrarDia.Name = "lblMostrarDia";
            lblMostrarDia.Size = new Size(38, 15);
            lblMostrarDia.TabIndex = 6;
            lblMostrarDia.Text = "label4";
            // 
            // btnMostrarDia
            // 
            btnMostrarDia.Location = new Point(227, 173);
            btnMostrarDia.Name = "btnMostrarDia";
            btnMostrarDia.Size = new Size(145, 49);
            btnMostrarDia.TabIndex = 7;
            btnMostrarDia.Text = "Mostrar día";
            btnMostrarDia.UseVisualStyleBackColor = true;
            btnMostrarDia.Click += btnMostrarDia_Click;
            // 
            // Form03DiaNacimiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMostrarDia);
            Controls.Add(lblMostrarDia);
            Controls.Add(txtYear);
            Controls.Add(txtMes);
            Controls.Add(txtDia);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form03DiaNacimiento";
            Text = "Form03DiaNacimiento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtDia;
        private TextBox txtMes;
        private TextBox txtYear;
        private Label lblMostrarDia;
        private Button btnMostrarDia;
    }
}