using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form14Metodos : Form
    {
        public Form14Metodos()
        {
            InitializeComponent();
            //Ejemplo abstraccion
            ArrayList botones = new ArrayList();
            botones.Add(this.btnDobleValor);
            botones.Add(this.btnDobleReferencia);
            botones.Add(this.btnObjetoReferencia);
            //foreach (Button cosa in botones)
            //{
            //    cosa.BackColor = Color.Beige;
            //}
            //WORK COMPILACION Y EJECUCION. 
            foreach (Control cosa in botones)
            {
                cosa.BackColor = Color.Coral;
            }

        }
        //CREAMOS UN MÉTODO
        void getDobleValor(int numero)
        {
            numero = numero * 2;

        }
        //COMO DEBERIA SER 
        /*int getdoble(int numero)
        {
            return numero * 2;
        }*/


        private void btnDobleValor_Click(object sender, EventArgs e)
        {//este código no funciona,num y numero son diferentes y no cambia
            int num = int.Parse(this.txtNumero.Text);
            this.getDobleValor(num);
            this.lblResultado.Text = "El resultado es: " + num;
        }

        //método objetoReferencia
        void CambiarColor(Button boton)
        {
            boton.BackColor = Color.BlueViolet;
        }
        private void btnObjetoReferencia_Click(object sender, EventArgs e)
        {
            this.CambiarColor(this.btnDobleReferencia);
            this.CambiarColor(this.btnDobleValor);
        }

        //metodo doble referencia
        void getDobleReferencia(ref int numero)
        {
            numero = numero * 2;
        }

        private void btnDobleReferencia_Click(object sender, EventArgs e)
        {
            int num = int.Parse(this.txtNumero.Text);
            this.getDobleReferencia(ref num);//se pone ref en os 2 lados
            this.lblResultado.Text = "El resultado es: " + num;
        }

        private void getDobleReferencia_MouseMove(object sender, MouseEventArgs e)
        {
            this.lblResultado.Text = "Hola";
        }

        private void lblRaton_MouseMove(object sender, MouseEventArgs e)
        {
            this.lblRaton.Text = "X" + e.X + "Y : " + e.Y;
        }

        private void txtSoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Tenemos una enumeracion que nos permite acceder a los codigos del teclado Keys
            //Debemos sabe el codigo ASCI de la tecla borrar
            char teclaBorrar = (char)8;
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != teclaBorrar)
            {
                e.Handled = true;
            }

        }

        private void txtSoloLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            char teclaBorrar = (char)Keys.Back;
            if (char.IsLetter(e.KeyChar) == false && e.KeyChar != teclaBorrar)
            {
                e.Handled = true;
            }
        }
    }
}
