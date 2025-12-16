using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form10ColeccionGrafica : Form
    {
        public Form10ColeccionGrafica()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string elem = this.txtElemento.Text;
            this.lstElementos.Items.Add(elem);

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //RECUPERAMOS EL ELEMENTO SELECCIONADO DE LA LISTA
            string elemSeleccionado = this.lstElementos.SelectedItem.ToString();
            //Eliminamos el objeto de coleccon
            this.lstElementos.Items.Remove(elemSeleccionado);

            //repetidos en la coleccion
            //int index = this.lstElementos.SelectedIndex;
            //this.lstElementos.Items.Remove(index);
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            this.lstElementos.Items.Clear();
        }

        private void lstElementos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstElementos.SelectedIndex != -1)
            {
                this.lblindex.Text = this.lstElementos.SelectedIndex.ToString();
                this.lblindex.Text = this.lstElementos.SelectedItem.ToString();
            }
        }

        private void lblindex_Click(object sender, EventArgs e)
        {

        }
    }
}
