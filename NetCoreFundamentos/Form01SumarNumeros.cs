using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form01SumarNumeros : Form
    {
        public Form01SumarNumeros()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            //AQUÍ ESCRBIBIMOS CODIGO
            int num1 = int.Parse(this.txtNumero1.Text);
            int num2 = int.Parse(this.txtNumero2.Text);
            int resultado = 0;
             resultado = num1 + num2;
            this.lblResultado.Text=" Resultado: "+ resultado.ToString();
        }
    }
}
