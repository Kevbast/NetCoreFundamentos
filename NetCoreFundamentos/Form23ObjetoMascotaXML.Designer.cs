namespace NetCoreFundamentos
{
    partial class Form23ObjetoMascotaXML
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
            Nombre = new Label();
            label2 = new Label();
            txtNombre = new TextBox();
            txtRaza = new TextBox();
            label3 = new Label();
            txtEdad = new TextBox();
            label4 = new Label();
            btnLeer = new Button();
            btnGuardar = new Button();
            btnExaminar = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(51, 36);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(51, 15);
            Nombre.TabIndex = 0;
            Nombre.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(206, 36);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 1;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(51, 63);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 2;
            // 
            // txtRaza
            // 
            txtRaza.Location = new Point(51, 131);
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(100, 23);
            txtRaza.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 104);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 3;
            label3.Text = "Raza";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(51, 207);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(100, 23);
            txtEdad.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 180);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 5;
            label4.Text = "Edad";
            // 
            // btnLeer
            // 
            btnLeer.Location = new Point(484, 73);
            btnLeer.Name = "btnLeer";
            btnLeer.Size = new Size(109, 35);
            btnLeer.TabIndex = 7;
            btnLeer.Text = "Leer Clase";
            btnLeer.UseVisualStyleBackColor = true;
            btnLeer.Click += btnLeer_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(484, 125);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(109, 32);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar Clase";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += button2_Click;
            // 
            // btnExaminar
            // 
            btnExaminar.Location = new Point(266, 216);
            btnExaminar.Name = "btnExaminar";
            btnExaminar.Size = new Size(75, 23);
            btnExaminar.TabIndex = 22;
            btnExaminar.Text = "Examinar";
            btnExaminar.UseVisualStyleBackColor = true;
            btnExaminar.Click += btnExaminar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(187, 245);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(247, 158);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(187, 220);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 23;
            label1.Text = "Mascota";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form23ObjetoMascotaXML
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 474);
            Controls.Add(label1);
            Controls.Add(btnExaminar);
            Controls.Add(pictureBox1);
            Controls.Add(btnGuardar);
            Controls.Add(btnLeer);
            Controls.Add(txtEdad);
            Controls.Add(label4);
            Controls.Add(txtRaza);
            Controls.Add(label3);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(Nombre);
            Name = "Form23ObjetoMascotaXML";
            Text = "Form23ObjetoMascotaXML";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Nombre;
        private Label label2;
        private TextBox txtNombre;
        private TextBox txtRaza;
        private Label label3;
        private TextBox txtEdad;
        private Label label4;
        private Button btnLeer;
        private Button btnGuardar;
        private Button btnExaminar;
        private PictureBox pictureBox1;
        private Label label1;
        private OpenFileDialog openFileDialog1;
    }
}