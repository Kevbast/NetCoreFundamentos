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
    public partial class Form15ArrayList : Form
    {
        public Form15ArrayList()
        {
            InitializeComponent();
            //Creamos una coleeion generica
            List<Button> botones = new List<Button>();
            //DETECTA AUTOMATICAMENTE ELEMENTOS
            botones.Add(this.button1);
            botones.Add(this.button2);
            botones.Add(this.button3);
            botones[0].BackColor = Color.Indigo;


            //VAMOS A CREAR UNA COLECCION NO TIPADA
            ArrayList coleccion = new ArrayList();
            coleccion.Add(this.button1);
            coleccion.Add(this.button2);
            coleccion.Add(this.button3);
            //SI DESEAMOS ACCEDER A UN OBJETO Y MDOFICAR ALGUNA CARACTERISTICA
            //NECESITAMOS UN CASTING
                //((Button)coleccion[0]).BackColor = Color.Yellow;
                //foreach (Button boton in coleccion)
                //{
                //    boton.BackColor = Color.LightGreen;
                //}
            //Y si agregamos otro control pues funcionará igual
            coleccion.Add(this.textBox1);
            foreach (Control boton in coleccion)
            {
                boton.BackColor = Color.DarkRed;
                //CUANDO TENEMOS MULTIPLES OBJETOS DE DIFERENTES CLASES,
                //NOS PODEMOS ABSTRAER EN EL RECORRIDO,PERO A LO MEJOR 
                //NECESITAMOS ALGUNA CARACTERÍSTICA ESPECIAL DE CADA UNO
                //UNA CAJA TIENE UN MÉTODO LLAMADA Paste()

                if(boton is TextBox)
                {
                    ((TextBox)boton).Paste()    ;
                }

            }

            this.button1.Click += MetodoDelegado;
        }
        //CREAMOS UN METODO DELEGADO
        void MetodoDelegado(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
