using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{   
    public partial class Form18SumarCheckboxs : Form
    {
        List<CheckBox> checkboxs;
        public Form18SumarCheckboxs()
        {
            InitializeComponent();
            //asignacion
            this.checkboxs = new List<CheckBox>();

            foreach (CheckBox checkbox in this.panel1.Controls)
            {
                this.checkboxs.Add(checkbox);
                checkbox.Click += SumarCheckboxs; //le asignamos funcionalidad a un boton

            }
        }

        private void SumarCheckboxs(object? sender, EventArgs e)
        {
            CheckBox checkBoxPulsado = (CheckBox)sender;

            if (checkBoxPulsado.Checked)
            {
                int numero = int.Parse(checkBoxPulsado.Text);
                int suma = int.Parse(txtSuma.Text);//sumamos el boton con el numero del txt
                suma += numero;
                this.txtSuma.Text = suma.ToString();
            }
            else
            {
                int numero = int.Parse(checkBoxPulsado.Text);
                int suma = int.Parse(txtSuma.Text);//sumamos el boton con el numero del txt
                suma -= numero;
                this.txtSuma.Text = suma.ToString();
            }

            
            
        }

        private void btnIniciarApp_Click(object sender, EventArgs e)
        {
            //hacemos esto después de rellenar la lista
            Random random = new Random();
            foreach (CheckBox checkbox in this.checkboxs)
            {
                int aleat = random.Next(1, 100);
                checkbox.Text = aleat.ToString();
            }
        }
    }
}
