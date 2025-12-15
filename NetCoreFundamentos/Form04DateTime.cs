using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form04DateTime : Form
    {
        public Form04DateTime()
        {
            InitializeComponent();
            this.txtFechaActual.Text = DateTime.Now.ToString();
        }

        private void Form04DateTime_Load(object sender, EventArgs e)
        {

        }

        private void chkFormato_CheckedChanged(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Parse(this.txtFechaActual.Text);
            if (this.chkFormato.Checked)
            {
                this.txtFechaActual.Text = fecha.ToLongDateString();
            }
            else
            {
                this.txtFechaActual.Text = fecha.ToShortDateString();
            }
        }

        private void btnIncrementar_Click(object sender, EventArgs e)
        {
            int incremento = int.Parse(this.txtIncremento.Text);
            DateTime fecha= DateTime.Parse(this.txtFechaActual.Text);

            if (this.rdbDias.Checked)
            {
                fecha = fecha.AddDays(incremento);//añadimos días
            }else if (this.rdbMes.Checked)
            {
                fecha = fecha.AddMonths(incremento);//añadimos meses
            }
            else if (this.rdbAnyos.Checked)
            {
                fecha = fecha.AddYears(incremento);//añadimos años
            }

            this.txtFechaFinal.Text = fecha.ToString();
        }
    }
}
