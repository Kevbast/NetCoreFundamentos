namespace NetCoreFundamentos
{
    partial class Form11ColeccionMultiple
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
            lblindex = new Label();
            lblitem = new Label();
            btnBorrarTodo = new Button();
            btnEliminar = new Button();
            btnInsert = new Button();
            txtElemento = new TextBox();
            label2 = new Label();
            lstElementos = new ListBox();
            label1 = new Label();
            btnSeleccionados = new Button();
            SuspendLayout();
            // 
            // lblindex
            // 
            lblindex.AutoSize = true;
            lblindex.Location = new Point(248, 336);
            lblindex.Name = "lblindex";
            lblindex.Size = new Size(49, 15);
            lblindex.TabIndex = 17;
            lblindex.Text = "lblindex";
            // 
            // lblitem
            // 
            lblitem.AutoSize = true;
            lblitem.Location = new Point(248, 283);
            lblitem.Name = "lblitem";
            lblitem.Size = new Size(44, 15);
            lblitem.TabIndex = 16;
            lblitem.Text = "lblitem";
            // 
            // btnBorrarTodo
            // 
            btnBorrarTodo.Location = new Point(472, 283);
            btnBorrarTodo.Name = "btnBorrarTodo";
            btnBorrarTodo.Size = new Size(75, 23);
            btnBorrarTodo.TabIndex = 15;
            btnBorrarTodo.Text = "Borrar todo";
            btnBorrarTodo.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(472, 237);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(472, 195);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(75, 23);
            btnInsert.TabIndex = 13;
            btnInsert.Text = "Insertar";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // txtElemento
            // 
            txtElemento.Location = new Point(463, 140);
            txtElemento.Name = "txtElemento";
            txtElemento.Size = new Size(100, 23);
            txtElemento.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(463, 100);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 11;
            label2.Text = "Nuevo Elemento";
            // 
            // lstElementos
            // 
            lstElementos.FormattingEnabled = true;
            lstElementos.Location = new Point(238, 140);
            lstElementos.Name = "lstElementos";
            lstElementos.Size = new Size(120, 94);
            lstElementos.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(258, 100);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 9;
            label1.Text = "Elementos";
            // 
            // btnSeleccionados
            // 
            btnSeleccionados.Location = new Point(442, 330);
            btnSeleccionados.Name = "btnSeleccionados";
            btnSeleccionados.Size = new Size(148, 35);
            btnSeleccionados.TabIndex = 18;
            btnSeleccionados.Text = "Seleccionados";
            btnSeleccionados.UseVisualStyleBackColor = true;
            btnSeleccionados.Click += btnSeleccionados_Click;
            // 
            // Form11ColeccionMultiple
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSeleccionados);
            Controls.Add(lblindex);
            Controls.Add(lblitem);
            Controls.Add(btnBorrarTodo);
            Controls.Add(btnEliminar);
            Controls.Add(btnInsert);
            Controls.Add(txtElemento);
            Controls.Add(label2);
            Controls.Add(lstElementos);
            Controls.Add(label1);
            Name = "Form11ColeccionMultiple";
            Text = "Form11ColeccionMultiple";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblindex;
        private Label lblitem;
        private Button btnBorrarTodo;
        private Button btnEliminar;
        private Button btnInsert;
        private TextBox txtElemento;
        private Label label2;
        private ListBox lstElementos;
        private Label label1;
        private Button btnSeleccionados;
    }
}