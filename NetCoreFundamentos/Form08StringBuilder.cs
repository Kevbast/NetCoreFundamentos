using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics; //NAMESPACE IMPLEMENTADO
using System.Text;

namespace NetCoreFundamentos
{
    public partial class Form08StringBuilder : Form
    {
        public Form08StringBuilder()
        {
            InitializeComponent();
        }

        private void btnInvertirString_Click(object sender, EventArgs e)
        {
            Stopwatch krono = new Stopwatch();
            string cadena = this.txtStringBuilder.Text;
            int longitud = cadena.Length;
            //COMENZAMOS EL PROCESO
            krono.Start();

            for (int i = 0; i < longitud; i++)
            {
                //SIEMPRE RECUPERAMOS LA ULTIMA LETRA
                char letra = cadena[longitud - 1];
                //ELIMINAMOS LA ULTIMA LETRA
                cadena = cadena.Remove(longitud - 1, 1);
                //INSERTAMOS LA LETRA DE LA POSICION I DEL BUCLE
                cadena = cadena.Insert(i, letra.ToString());
            }
            //FINALIZAMOS EL RPOCESO
            krono.Stop();
            //EL OBJETO StopWatch contiene una serie de propiedades 
            //PARA COMPROBAR EL TIMEPO DEL PROCESO
            this.lblTiempo.Text = "Segundos" + krono.Elapsed.Seconds +
                " Milisegundos:" + krono.Elapsed.Microseconds;
            this.txtStringBuilder.Text = cadena;

        }

        private void btnInvertirStringBuilder_Click(object sender, EventArgs e)
        {
            Stopwatch krono = new Stopwatch();
            //VAMOS A UTILIZAR LA CLASE STRINGBUILDER
            StringBuilder cadena = new StringBuilder();
            //PARA AÑADIR CONTENIDO TIENE UN METODO LLAMADO APPEND
            cadena.Append(this.txtStringBuilder.Text);
            int longitud = cadena.Length;
            //COMENZAMOS EL PROCESO
            krono.Start();

            for (int i = 0; i < longitud; i++)
            {
                //SIEMPRE RECUPERAMOS LA ULTIMA LETRA
                char letra = cadena[longitud - 1];
                //ELIMINAMOS LA ULTIMA LETRA
                cadena = cadena.Remove(longitud - 1, 1);
                //INSERTAMOS LA LETRA DE LA POSICION I DEL BUCLE
                cadena = cadena.Insert(i, letra.ToString());
            }
            //FINALIZAMOS EL RPOCESO
            krono.Stop();
            //EL OBJETO StopWatch contiene una serie de propiedades 
            //PARA COMPROBAR EL TIMEPO DEL PROCESO
            this.lblTiempo.Text = "Segundos" + krono.Elapsed.Seconds +
                " Milisegundos:" + krono.Elapsed.Microseconds;
            this.txtStringBuilder.Text = cadena.ToString();

        }
    }
}
