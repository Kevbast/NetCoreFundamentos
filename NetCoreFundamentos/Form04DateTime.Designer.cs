namespace NetCoreFundamentos
{
    partial class Form04DateTime
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
            txtFechaActual = new TextBox();
            chkFormato = new CheckBox();
            rdbDias = new RadioButton();
            rdbMes = new RadioButton();
            rdbAnyos = new RadioButton();
            label2 = new Label();
            txtFechaFinal = new TextBox();
            label3 = new Label();
            txtIncremento = new TextBox();
            btnIncrementar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 24);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 0;
            label1.Text = "Fecha actual";
            // 
            // txtFechaActual
            // 
            txtFechaActual.Location = new Point(65, 58);
            txtFechaActual.Name = "txtFechaActual";
            txtFechaActual.Size = new Size(438, 23);
            txtFechaActual.TabIndex = 1;
            // 
            // chkFormato
            // 
            chkFormato.AutoSize = true;
            chkFormato.Location = new Point(68, 100);
            chkFormato.Name = "chkFormato";
            chkFormato.Size = new Size(117, 19);
            chkFormato.TabIndex = 2;
            chkFormato.Text = "Cambiar formato";
            chkFormato.UseVisualStyleBackColor = true;
            chkFormato.CheckedChanged += chkFormato_CheckedChanged;
            // 
            // rdbDias
            // 
            rdbDias.AutoSize = true;
            rdbDias.Location = new Point(68, 125);
            rdbDias.Name = "rdbDias";
            rdbDias.Size = new Size(47, 19);
            rdbDias.TabIndex = 3;
            rdbDias.TabStop = true;
            rdbDias.Text = "Dias";
            rdbDias.UseVisualStyleBackColor = true;
            // 
            // rdbMes
            // 
            rdbMes.AutoSize = true;
            rdbMes.Location = new Point(65, 150);
            rdbMes.Name = "rdbMes";
            rdbMes.Size = new Size(58, 19);
            rdbMes.TabIndex = 4;
            rdbMes.TabStop = true;
            rdbMes.Text = "Meses";
            rdbMes.UseVisualStyleBackColor = true;
            // 
            // rdbAnyos
            // 
            rdbAnyos.AutoSize = true;
            rdbAnyos.Location = new Point(65, 175);
            rdbAnyos.Name = "rdbAnyos";
            rdbAnyos.Size = new Size(52, 19);
            rdbAnyos.TabIndex = 5;
            rdbAnyos.TabStop = true;
            rdbAnyos.Text = "Años";
            rdbAnyos.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 248);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 6;
            label2.Text = "Fecha final";
            // 
            // txtFechaFinal
            // 
            txtFechaFinal.Location = new Point(68, 279);
            txtFechaFinal.Name = "txtFechaFinal";
            txtFechaFinal.Size = new Size(435, 23);
            txtFechaFinal.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(299, 129);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 8;
            label3.Text = "Incremento";
            // 
            // txtIncremento
            // 
            txtIncremento.Location = new Point(373, 125);
            txtIncremento.Name = "txtIncremento";
            txtIncremento.Size = new Size(100, 23);
            txtIncremento.TabIndex = 9;
            // 
            // btnIncrementar
            // 
            btnIncrementar.Location = new Point(373, 171);
            btnIncrementar.Name = "btnIncrementar";
            btnIncrementar.Size = new Size(109, 23);
            btnIncrementar.TabIndex = 10;
            btnIncrementar.Text = "Incrementar";
            btnIncrementar.UseVisualStyleBackColor = true;
            btnIncrementar.Click += btnIncrementar_Click;
            // 
            // Form04DateTime
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnIncrementar);
            Controls.Add(txtIncremento);
            Controls.Add(label3);
            Controls.Add(txtFechaFinal);
            Controls.Add(label2);
            Controls.Add(rdbAnyos);
            Controls.Add(rdbMes);
            Controls.Add(rdbDias);
            Controls.Add(chkFormato);
            Controls.Add(txtFechaActual);
            Controls.Add(label1);
            Name = "Form04DateTime";
            Text = "Form04DateTime";
            Load += Form04DateTime_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFechaActual;
        private CheckBox chkFormato;
        private RadioButton rdbDias;
        private RadioButton rdbMes;
        private RadioButton rdbAnyos;
        private Label label2;
        private TextBox txtFechaFinal;
        private Label label3;
        private TextBox txtIncremento;
        private Button btnIncrementar;
    }
}