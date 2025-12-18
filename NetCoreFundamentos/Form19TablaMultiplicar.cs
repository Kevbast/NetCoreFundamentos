using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form19TablaMultiplicar : Form
    {
        List<TextBox> texts;
        List<Button> botones;
        public Form19TablaMultiplicar()
        {
            InitializeComponent();
            botones = new List<Button>();
            texts = new List<TextBox>();

            foreach (Control control in this.Controls)
            {
                //preguntamos por el tipo de control,puesto que control no es un boton,es todo el form
                if (control is Button)
                {
                    botones.Add((Button)control);
                }
                else if(control is TextBox)
                {
                    texts.Add((TextBox)control);
                }
              
            }
            //VAMOS A RECORRER TODOS LOS BOTONES
            foreach (Button boton in botones)
            {
                boton.Click += Multiplicacion; ;
            }
            //Se revierte la lista para verlo
            this.texts.Reverse();
        }

        private void Multiplicacion(object? sender, EventArgs e)
        {
            //FUNCIONALIDAD
            Button botonPulsado = (Button)sender;
            int numero = int.Parse(botonPulsado.Text);
            int resultado = 0;
            for (int i = 0; i < this.texts.Count; i++)
            {
                resultado = numero * i;
                this.texts[i].Text = resultado.ToString();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
