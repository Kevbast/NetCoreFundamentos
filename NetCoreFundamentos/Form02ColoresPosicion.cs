using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form02ColoresPosicion : Form
    {
        public Form02ColoresPosicion()
        {
            InitializeComponent();
        }

        private void btnFunciones_Click(object sender, EventArgs e)
        {   
            //FUNCIONALIDAD CÓDIGO
            //int posicionX = int.Parse(this.txtPosX.Text);
            //int posicionY = int.Parse(this.txtPosY.Text);
            //this.btnFunciones.Location = new Point(posicionX, posicionY);

            //COLORES
            int azul = int.Parse(this.txtAzul.Text);
            int rojo = int.Parse(this.txtRojo.Text);
            int verde = int.Parse(this.txtVerde.Text);
            //Condicionales
            if (rojo < 0 || rojo > 255)
            {
                MessageBox.Show("EL VALOR DE ROJO DEBE ESTAR COMPRENDIDO ENTRE 0 Y 255");
            }else if (azul < 0 || azul > 255)
            {
                MessageBox.Show("EL VALOR DE AZUL DEBE ESTAR COMPRENDIDO ENTRE 0 Y 255");
            }
            else if (verde < 0 || verde > 255)
            {
                MessageBox.Show("EL VALOR DE VERDE DEBE ESTAR COMPRENDIDO ENTRE 0 Y 255");
            }
            else
            {
                this.BackColor = Color.FromArgb(rojo, verde, azul);
            }

        }   


    }
}
