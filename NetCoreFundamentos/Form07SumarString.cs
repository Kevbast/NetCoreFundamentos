using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form07SumarString : Form
    {
        public Form07SumarString()
        {
            InitializeComponent();
        }

        private void lblresultado_Click(object sender, EventArgs e)
        {

        }

        private void btnSumarNums_Click(object sender, EventArgs e)
        {
            //FUNCIONALIDAD
            string cadenaNumeros = this.txtNumeros.Text;
            int suma = 0;
            for (int i = 0; i < cadenaNumeros.Length; i++)
            {
                //RECUPERAMOS CADA CARACTER DEL TEXTO
                char caracter = cadenaNumeros[i];

                //CONVERTIMOS CADA CARACTER A NUMERO
                //int numero = caracter;//esta no vale,solo nos recupera el ascii
                int numero =int.Parse(caracter.ToString());

                suma += numero;
            }
            this.lblresultado.Text = "La suma de " + cadenaNumeros+ " es: "+ suma;

        }
    }
}
