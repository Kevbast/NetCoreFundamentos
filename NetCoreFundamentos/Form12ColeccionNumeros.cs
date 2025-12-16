using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form12ColeccionNumeros : Form
    {
        public Form12ColeccionNumeros()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                this.lstNumeros.Items.Add(random.Next(1, 100));

            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int suma = 0;
            int sumapares = 0;
            int sumaimpares = 0;
            //VAMOS A RECORRER LA COLECCION DE ITEMS SELECCIONADOS
            for (int i = 0; i < this.lstNumeros.Items.Count; i++)
            {
                object cosa = this.lstNumeros.Items[i];
                string texto = cosa.ToString();
                int numero = int.Parse(texto);
                suma += numero;
                //Ver pares
                if (numero % 2 == 0)
                {
                    sumapares += numero;
                }
                else
                {
                    sumaimpares += numero;
                }
            }
            this.txtSuma.Text = "La suma es: " + suma;
            //Pares
            this.txtPares.Text = "Suma de pares:"+ sumapares;
            this.txtImpares.Text = "Suma impares: "+ sumaimpares;

        }
    }
}
