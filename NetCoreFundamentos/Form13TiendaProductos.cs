using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form13TiendaProductos : Form
    {
        public Form13TiendaProductos()
        {
            InitializeComponent();
            //LA LISTA TENDRÁ SELECCIÓN MULTIPLE
            this.lstProductos.SelectionMode =
                SelectionMode.MultiSimple;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            string producto = this.txtProducto.Text;

            if (lstProductos.Items.Contains(producto))
            {   //SEÑALAR
                MessageBox.Show("Este producto ya está en la lista");
                int index = this.lstProductos.Items.IndexOf(producto);
                this.lstProductos.SelectedIndex= index;
            }
            else
            {
                this.lstProductos.Items.Add(producto);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string data = "";

            int numElementos = this.lstProductos.SelectedIndices.Count - 1;
            for (int i = numElementos; i >= 0; i--)
            {
                int index = this.lstProductos.SelectedIndices[i];
                this.lstProductos.Items.RemoveAt(index);
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            this.lstProductos.Items.Clear();
        }

        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            //VAMOS A RECORRER LA COLECCION DE ITEMS SELECCIONADOS
           
            int numElementos = this.lstProductos.SelectedIndices.Count - 1;
            for (int i = numElementos; i >= 0; i--)
            {
                int index = this.lstProductos.SelectedIndices[i];
                string texto = this.lstProductos.Items[index].ToString();
                this.lstAlmacen.Items.Add(texto);
                this.lstProductos.Items.RemoveAt(index);
            }


        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            foreach (string elemento in this.lstProductos.Items)
            {
                this.lstAlmacen.Items.Add(elemento);
            }
            this.lstProductos.Items.Clear();
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {

        }

        private void btnBajar_Click(object sender, EventArgs e)
        {

        }
    }
}
