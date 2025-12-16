using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics; //NAMESPACE IMPLEMENTADO

namespace NetCoreFundamentos
{
    public partial class Form09Isbn : Form
    {
        public Form09Isbn()
        {
            InitializeComponent();
        }

        private void btnValidarIsbn_Click(object sender, EventArgs e)
        {
            //FUNCIONALIDAD
            string cadena = this.txtIsbn.Text;
            int longitud = cadena.Length;
            if (longitud==10)
            {
                int suma = 0;
                for (int i = 0; i < longitud; i++)
                {
                    char caracter = cadena[i];
                    int numero = int.Parse(caracter.ToString());
                    int multi = numero * (i + 1);
                    suma += multi;
                }

                if ((suma % 11) == 0)
                {
                    this.lblResultado.Text = "ISBN VALIDADO";
                }
                else
                {
                    MessageBox.Show("Error al validar el ISBN");
                }
            }
            else
            {
                MessageBox.Show("TIENE QUE TENER 10 CARACTERES");
            }

        }
    }
}
