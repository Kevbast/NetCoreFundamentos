using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form16ListDelegados : Form
    {
        int contador;
        public Form16ListDelegados()
        {
            
            InitializeComponent();
            //Inicializamos la variable contador
            this.contador = 0;
            //ALMACENAMOS TODOS LOS BOTONES EN UNA NUEVA COLECCION
            List<Button> botones = new List<Button>();
                //botones.Add(this.button1);
                //botones.Add(this.button2);
                //botones.Add(this.button3);
                //botones.Add(this.button4);
                //botones.Add(this.button5);
                //botones.Add(this.button6);
            //VAMOS A AÑADIR DINAMICAMENTE TODOS LOS BOTONES DEL FORMULARIO
                foreach(Control control in this.Controls)
                {
                //preguntamos por el tipo de control,puesto que control no es un boton,es todo el form
                    if (control is Button)
                    {
                    botones.Add((Button)control);
                    }

                }


            //VAMOS A RECORRER TODOS LOS BOTONES
            foreach (Button boton in botones)
            {
                boton.Click += PulsarBoton;                   
            }

        }
        //tab despues del +=
        private void PulsarBoton(object? sender, EventArgs e)
        {
            this.contador += 1;
            this.txtText.Text = this.contador.ToString();
            //Queremos acceder al objeto que ha realizado la peticion
            //al metodo mediante sender se captura dicho objeto
            ((Button)sender).BackColor = Color.DarkRed;//puesto que sender es un object hay que hacer casting
            ((Button)sender).Text = "KLK";
        }


       
    }
}
