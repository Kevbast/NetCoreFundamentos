using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form05Char : Form
    {
        public Form05Char()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRun_Click(object sender, EventArgs e)
        {//FUNCIONALIDAD
            for (int i = 0; i <=255 ; i++)
            {
                //CONVERTIMOS CADA NUMERO A SU CHAR CORRESPONDIENTE
                char caracter =(char) i;//se pasaría asi,puesto que es pequeño
                if (char.IsLetter(caracter))
                {
                    this.txtLetras.Text = this.txtLetras.Text + caracter;
                }else if (char.IsNumber(caracter))
                {
                    this.txtNumeros.Text += caracter;
                }else if (char.IsSymbol(caracter))
                {
                    this.txtSimbolos.Text += caracter;
                } else if (char.IsPunctuation(caracter))
                {
                    this.txtPuntuacion.Text += caracter;
                }
            }
        }
    }
}
