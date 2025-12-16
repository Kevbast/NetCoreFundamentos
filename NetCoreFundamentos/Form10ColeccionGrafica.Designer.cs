namespace NetCoreFundamentos
{
    partial class Form10ColeccionGrafica
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
            lstElementos = new ListBox();
            label2 = new Label();
            txtElemento = new TextBox();
            btnInsert = new Button();
            btnEliminar = new Button();
            btnBorrarTodo = new Button();
            lblitem = new Label();
            lblindex = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 40);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Elementos";
            // 
            // lstElementos
            // 
            lstElementos.FormattingEnabled = true;
            lstElementos.Location = new Point(58, 80);
            lstElementos.Name = "lstElementos";
            lstElementos.Size = new Size(120, 94);
            lstElementos.TabIndex = 1;
            lstElementos.SelectedIndexChanged += lstElementos_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(283, 40);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 2;
            label2.Text = "Nuevo Elemento";
            // 
            // txtElemento
            // 
            txtElemento.Location = new Point(283, 80);
            txtElemento.Name = "txtElemento";
            txtElemento.Size = new Size(100, 23);
            txtElemento.TabIndex = 3;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(292, 135);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(75, 23);
            btnInsert.TabIndex = 4;
            btnInsert.Text = "Insertar";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(292, 177);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnBorrarTodo
            // 
            btnBorrarTodo.Location = new Point(292, 223);
            btnBorrarTodo.Name = "btnBorrarTodo";
            btnBorrarTodo.Size = new Size(75, 23);
            btnBorrarTodo.TabIndex = 6;
            btnBorrarTodo.Text = "Borrar todo";
            btnBorrarTodo.UseVisualStyleBackColor = true;
            btnBorrarTodo.Click += btnBorrarTodo_Click;
            // 
            // lblitem
            // 
            lblitem.AutoSize = true;
            lblitem.Location = new Point(68, 223);
            lblitem.Name = "lblitem";
            lblitem.Size = new Size(44, 15);
            lblitem.TabIndex = 7;
            lblitem.Text = "lblitem";
            // 
            // lblindex
            // 
            lblindex.AutoSize = true;
            lblindex.Location = new Point(68, 276);
            lblindex.Name = "lblindex";
            lblindex.Size = new Size(49, 15);
            lblindex.TabIndex = 8;
            lblindex.Text = "lblindex";
            lblindex.Click += lblindex_Click;
            // 
            // Form10ColeccionGrafica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblindex);
            Controls.Add(lblitem);
            Controls.Add(btnBorrarTodo);
            Controls.Add(btnEliminar);
            Controls.Add(btnInsert);
            Controls.Add(txtElemento);
            Controls.Add(label2);
            Controls.Add(lstElementos);
            Controls.Add(label1);
            Name = "Form10ColeccionGrafica";
            Text = "Form10ColeccionGrafica";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstElementos;
        private Label label2;
        private TextBox txtElemento;
        private Button btnInsert;
        private Button btnEliminar;
        private Button btnBorrarTodo;
        private Label lblitem;
        private Label lblindex;
    }
}