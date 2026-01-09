namespace NetCoreFundamentos
{
    partial class Form21Files
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
            txtContenido = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            lstNombres = new ListBox();
            btnNuevo = new Button();
            btnLeer = new Button();
            btnWrite = new Button();
            SuspendLayout();
            // 
            // txtContenido
            // 
            txtContenido.Location = new Point(47, 99);
            txtContenido.Multiline = true;
            txtContenido.Name = "txtContenido";
            txtContenido.Size = new Size(344, 303);
            txtContenido.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 66);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 1;
            label1.Text = "Contenido File";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(412, 66);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(412, 99);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 23);
            txtNombre.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(570, 66);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 4;
            label3.Text = "Nombres";
            // 
            // lstNombres
            // 
            lstNombres.FormattingEnabled = true;
            lstNombres.Location = new Point(570, 99);
            lstNombres.Name = "lstNombres";
            lstNombres.Size = new Size(198, 304);
            lstNombres.TabIndex = 5;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(412, 158);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(125, 23);
            btnNuevo.TabIndex = 6;
            btnNuevo.Text = "Nuevo Nombre";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnLeer
            // 
            btnLeer.Location = new Point(412, 213);
            btnLeer.Name = "btnLeer";
            btnLeer.Size = new Size(125, 23);
            btnLeer.TabIndex = 7;
            btnLeer.Text = "Leer file";
            btnLeer.UseVisualStyleBackColor = true;
            btnLeer.Click += btnLeer_Click;
            // 
            // btnWrite
            // 
            btnWrite.Location = new Point(412, 269);
            btnWrite.Name = "btnWrite";
            btnWrite.Size = new Size(125, 23);
            btnWrite.TabIndex = 8;
            btnWrite.Text = "Write file";
            btnWrite.UseVisualStyleBackColor = true;
            btnWrite.Click += btnWrite_Click;
            // 
            // Form21Files
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnWrite);
            Controls.Add(btnLeer);
            Controls.Add(btnNuevo);
            Controls.Add(lstNombres);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtContenido);
            Name = "Form21Files";
            Text = "Form21Files";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtContenido;
        private Label label1;
        private Label label2;
        private TextBox txtNombre;
        private Label label3;
        private ListBox lstNombres;
        private Button btnNuevo;
        private Button btnLeer;
        private Button btnWrite;
    }
}