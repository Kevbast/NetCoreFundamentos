namespace NetCoreFundamentos
{
    partial class Form22MascotasFiles
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
            txtNombre = new TextBox();
            txtRaza = new TextBox();
            Raza = new Label();
            btnNuevo = new Button();
            btnReadFile = new Button();
            btnWrite = new Button();
            Mascotas = new Label();
            lstMascotas = new ListBox();
            SuspendLayout();
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(53, 63);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(51, 15);
            Nombre.TabIndex = 0;
            Nombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(53, 91);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtRaza
            // 
            txtRaza.Location = new Point(53, 183);
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(100, 23);
            txtRaza.TabIndex = 3;
            // 
            // Raza
            // 
            Raza.AutoSize = true;
            Raza.Location = new Point(53, 152);
            Raza.Name = "Raza";
            Raza.Size = new Size(31, 15);
            Raza.TabIndex = 2;
            Raza.Text = "Raza";
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(53, 239);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(100, 34);
            btnNuevo.TabIndex = 4;
            btnNuevo.Text = "Nueva mascota";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnReadFile
            // 
            btnReadFile.Location = new Point(53, 298);
            btnReadFile.Name = "btnReadFile";
            btnReadFile.Size = new Size(100, 30);
            btnReadFile.TabIndex = 5;
            btnReadFile.Text = "Read File";
            btnReadFile.UseVisualStyleBackColor = true;
            btnReadFile.Click += btnReadFile_Click;
            // 
            // btnWrite
            // 
            btnWrite.Location = new Point(53, 353);
            btnWrite.Name = "btnWrite";
            btnWrite.Size = new Size(100, 32);
            btnWrite.TabIndex = 6;
            btnWrite.Text = "Write File";
            btnWrite.UseVisualStyleBackColor = true;
            btnWrite.Click += btnWrite_Click;
            // 
            // Mascotas
            // 
            Mascotas.AutoSize = true;
            Mascotas.Location = new Point(320, 53);
            Mascotas.Name = "Mascotas";
            Mascotas.Size = new Size(57, 15);
            Mascotas.TabIndex = 7;
            Mascotas.Text = "Mascotas";
            // 
            // lstMascotas
            // 
            lstMascotas.FormattingEnabled = true;
            lstMascotas.Location = new Point(320, 80);
            lstMascotas.Name = "lstMascotas";
            lstMascotas.Size = new Size(203, 319);
            lstMascotas.TabIndex = 8;
            lstMascotas.SelectedIndexChanged += lstMascotas_SelectedIndexChanged;
            // 
            // Form22MascotasFiles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstMascotas);
            Controls.Add(Mascotas);
            Controls.Add(btnWrite);
            Controls.Add(btnReadFile);
            Controls.Add(btnNuevo);
            Controls.Add(txtRaza);
            Controls.Add(Raza);
            Controls.Add(txtNombre);
            Controls.Add(Nombre);
            Name = "Form22MascotasFiles";
            Text = "Form22MascotasFiles";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Nombre;
        private TextBox txtNombre;
        private TextBox txtRaza;
        private Label Raza;
        private Button btnNuevo;
        private Button btnReadFile;
        private Button btnWrite;
        private Label Mascotas;
        private ListBox lstMascotas;
    }
}