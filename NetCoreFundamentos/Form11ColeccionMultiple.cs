using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form11ColeccionMultiple : Form
    {
        public Form11ColeccionMultiple()
        {
            InitializeComponent();
            //LA LISTA TENDRÁ SELECCIÓN MULTIPLE
            this.lstElementos.SelectionMode =
                SelectionMode.MultiSimple;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string elem = this.txtElemento.Text;
            this.lstElementos.Items.Add(elem);
            this.txtElemento.Focus();
            this.txtElemento.SelectAll();
        }

        private void btnSeleccionados_Click(object sender, EventArgs e)
        {
            string indices = "";
            string items = "";
            //VAMOS A RECORRER LA COLECCION DE ITEMS SELECCIONADOS
            for (int i = 0; i < this.lstElementos.Items.Count; i++)
            {
                object cosa = this.lstElementos.Items[i];
                string texto = cosa.ToString();
            }
            //UNA VENTAJA DEL FOREACH ES QUE PODEMOS RECORRER Y HACER EL CASTING DE LOS OBJETOS A LA VEZ
            foreach (string item in this.lstElementos.SelectedItems)
            {
                items += item + ",";
            }
            //VISUALIZAMOS LOS INDICES SELECCIONADOS
            foreach (int index in this.lstElementos.SelectedIndices)
            {
                indices += index + ",";
            }
            this.lblindex.Text = indices.Trim(',');
            this.lblitem.Text = items.Trim(',');


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string data = "";
            //QUIERO ELIMINAR LOS ELEMENTOS SELECCIONADOS
            //PARA  LAS ACCIONES SOBRE LAS COLECCIONES SIEMPRE CON BUCLES AL CONTADOR
            //VOY A UTILIZAR EL METODO RemoveAt por lo que recorremos la coleccion selectedindices

            //for (int i = 0; i < this.lstElementos.SelectedIndices.Count; i++)
            //{
            //    int index = this.lstElementos.SelectedIndices[i];
            //    //ELIMINAMOS DE LA COLECCION
            //    this.lstElementos.Items.RemoveAt(index);
            //}

            int numElementos = this.lstElementos.SelectedIndices.Count - 1;
            for (int i = numElementos; i >=0; i--)
            {
                int index = this.lstElementos.SelectedIndices[i];
                this.lstElementos.Items.RemoveAt(index);
            }

        }
    }
}
