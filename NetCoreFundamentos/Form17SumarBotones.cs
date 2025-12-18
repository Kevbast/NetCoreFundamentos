using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form17SumarBotones : Form
    {
        List<Button> botones;
        public Form17SumarBotones()
        {
            InitializeComponent();
            //asignacion
            this.botones = new List<Button>();
            //RECORREMOS TODOS LOS BOTONES DEL PANEL
            //COMO SOLO HE DIBUJADO BOTONES SOLO HACEMOS UNA ABSTRACCION A BUTTON
            foreach (Button boton in this.panel1.Controls)
            {
                this.botones.Add(boton);
                boton.Click += SumarNumeros;//le asignamos funcionalidad a un boton

            }
        }

        private void SumarNumeros(object? sender, EventArgs e)
        {
            Button botonPulsado = (Button)sender;
            int numero = int.Parse(botonPulsado.Text);
            int suma = int.Parse(txtSuma.Text);//sumamos el boton con el numero del txt
            suma += numero;
            this.txtSuma.Text = suma.ToString();
        }

        private void btnIniciarApp_Click(object sender, EventArgs e)
        {
            //hacemos esto después de rellenar la lista
            Random random = new Random();
            foreach (Button boton in  this.botones)
            {
                int aleat = random.Next(1, 100);
                boton.Text = aleat.ToString();
            }
        }
    }
}
