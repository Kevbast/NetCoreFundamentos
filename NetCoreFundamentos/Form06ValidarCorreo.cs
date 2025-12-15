using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form06ValidarCorreo : Form
    {
        public Form06ValidarCorreo()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string correo = this.txtEmail.Text;

            

            if (correo.Contains('@'))
            {
                if (correo.StartsWith('@'))
                {
                    MessageBox.Show("No se puede empezar con @ en un correo");
                }else if (correo.EndsWith('@'))
                {
                    MessageBox.Show("No se puede acabar con @ en un correo");
                }else if (correo.Count(c=> c =='@') > 1)
                {
                    MessageBox.Show("Contiene más de 1 @");
                }
                else
                {
                    if (correo.Contains('.'))
                    {
                        if (correo.LastIndexOf(".", correo.IndexOf('@')) != -1)
                        {
                            MessageBox.Show("No tiene punto depsues del @");
                        }
                        else
                        {
                            int posP = correo.IndexOf('.');
                            //comprobar si el dominio es de 2 a 3 caracteres
                            if (correo.Substring(posP).Length < 3 || correo.Substring(posP).Length > 4)
                            {
                                MessageBox.Show("EL DOMINIO TIENE QUE TENER 2 O 3 CARACTERES");
                            }
                            else
                            {
                                this.lblValidar.Text = "SE HA VALIDADO CORRECTAMENTE";
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("No contine puntos el correo '.' ");
                    }

                }

            }
            else
            {
                MessageBox.Show("No tiene un @ el correo");
            }

        }
    }
}
