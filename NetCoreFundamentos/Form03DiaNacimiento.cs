using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form03DiaNacimiento : Form
    {
        public Form03DiaNacimiento()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnMostrarDia_Click(object sender, EventArgs e)
        {
            int dia = int.Parse(this.txtDia.Text);
            int mes = int.Parse(this.txtMes.Text);
            int year = int.Parse(this.txtYear.Text);


            
            if (mes == 1)
            {
                mes = 13;
                year = year - 1;
            }
            else if (mes == 2)
            {
                mes = 14;
                year = year - 1;
            }

            //FUNCIONALIDAD CODIGO
                int operacion1 = ((mes + 1) * 3) / 5;
                int operacion2 = year / 4;
                int operacion3 = year / 100;
                int operacion4 = year / 400;
                int resultado = dia + (mes * 2) + year + operacion1 + operacion2 - operacion3 + operacion4 + 2;

                int resultado2 = resultado / 7;
                int resultadofinal = resultado - (resultado2 * 7);

                if (resultadofinal==0)
                {
                    this.lblMostrarDia.Text = "El dia de la semana es: sábado";
                } else if (resultadofinal == 1)
                {
                    this.lblMostrarDia.Text = "El dia de la semana es: domigo";
                }else if (resultadofinal == 2)
                {
                    this.lblMostrarDia.Text = "El dia de la semana es: lunes";
                }
                else if (resultadofinal == 3)
                {
                    this.lblMostrarDia.Text = "El dia de la semana es: martes";
                }
                else if (resultadofinal == 4)
                {
                    this.lblMostrarDia.Text = "El dia de la semana es: miercoles";
                }
                else if (resultadofinal == 5)
                {
                    this.lblMostrarDia.Text = "El dia de la semana es: jueves";
                }
                else
                {
                    this.lblMostrarDia.Text = "El dia de la semana es: viernes";
                }



        }
    }
}
