namespace NetCoreFundamentos
{
    partial class Form02ColoresPosicion
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
            btnFunciones = new Button();
            txtPosX = new TextBox();
            txtPosY = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtVerde = new TextBox();
            txtAzul = new TextBox();
            txtRojo = new TextBox();
            txtcolor = new TextBox();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // btnFunciones
            // 
            btnFunciones.Location = new Point(320, 236);
            btnFunciones.Name = "btnFunciones";
            btnFunciones.Size = new Size(146, 62);
            btnFunciones.TabIndex = 0;
            btnFunciones.Text = "Cambiar posición";
            btnFunciones.UseVisualStyleBackColor = true;
            btnFunciones.Click += btnFunciones_Click;
            // 
            // txtPosX
            // 
            txtPosX.Location = new Point(115, 104);
            txtPosX.Name = "txtPosX";
            txtPosX.Size = new Size(100, 23);
            txtPosX.TabIndex = 1;
            // 
            // txtPosY
            // 
            txtPosY.Location = new Point(115, 175);
            txtPosY.Name = "txtPosY";
            txtPosY.Size = new Size(100, 23);
            txtPosY.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(125, 56);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 3;
            label1.Text = "Posicion X";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(125, 143);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 4;
            label2.Text = "Posicion Y";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(512, 114);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 5;
            label3.Text = "verde";
            // 
            // txtVerde
            // 
            txtVerde.Location = new Point(599, 106);
            txtVerde.Name = "txtVerde";
            txtVerde.Size = new Size(100, 23);
            txtVerde.TabIndex = 6;
            // 
            // txtAzul
            // 
            txtAzul.Location = new Point(599, 163);
            txtAzul.Name = "txtAzul";
            txtAzul.Size = new Size(100, 23);
            txtAzul.TabIndex = 7;
            // 
            // txtRojo
            // 
            txtRojo.Location = new Point(599, 206);
            txtRojo.Name = "txtRojo";
            txtRojo.Size = new Size(100, 23);
            txtRojo.TabIndex = 8;
            // 
            // txtcolor
            // 
            txtcolor.Location = new Point(320, 111);
            txtcolor.Name = "txtcolor";
            txtcolor.Size = new Size(123, 23);
            txtcolor.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(512, 166);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 10;
            label4.Text = "azul";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(512, 209);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 11;
            label5.Text = "rojo";
            // 
            // Form02ColoresPosicion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtcolor);
            Controls.Add(txtRojo);
            Controls.Add(txtAzul);
            Controls.Add(txtVerde);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPosY);
            Controls.Add(txtPosX);
            Controls.Add(btnFunciones);
            Name = "Form02ColoresPosicion";
            Text = "Form02ColoresPosicion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFunciones;
        private TextBox txtPosX;
        private TextBox txtPosY;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtVerde;
        private TextBox txtAzul;
        private TextBox txtRojo;
        private TextBox txtcolor;
        private Label label4;
        private Label label5;
    }
}