using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

//VAMOS A UTILIZAR EL PROYECTO DE CLASES
using ProyectoClases;

namespace NetCoreFundamentos
{
    public partial class Form20TestClases : Form
    {
        public Form20TestClases()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Persona person = new Persona();
            person.Nombre = "Kevbast";
            person.Apellidos = "77";
            person.Edad = 21;//clase funcional pero sin restricciones,si ponemos -num también lo aceptaría

            person[0] = "Vamos 1";
            person[1] = "Vamos 2";
            person[2] = "Vamos 3";
            this.lstClases.Items.Add(person[0]);
            this.lstClases.Items.Add(person[2]);
            //enums
            person.Genero = TipoGenero.Masculino;//se puede hacer casting (TipoGenero) 1
            //debemos hacer extendidas las propiedades
            person.Nacionalidad = Paises.España;

            this.lstClases.Items.Add("Nombre: " + person.Nombre
                + ", Apellidos: " + person.Apellidos + ", Edad: " + person.Edad
                + ", Genero: " + person.Genero + " Nacionalidad: " + person.Nacionalidad
                );

            this.lstClases.Items.Add(person.GetNombreCompleto(4));
            //COnstructor de clases etc + polimorfismo

            //se puede crear la instancia aquí
            person.Domicilio = new Direccion();//daba error puesto que no habíamos creado la instancia a Direccion

            person.Domicilio.Calle = "Alondra";
            person.Domicilio.Ciudad = "Madrid";
            person.Domicilio.CodigoPostal = 28025;
            this.lstClases.Items.Add("Direccion: " + person.Domicilio.Calle + ", " +
                person.Domicilio.Ciudad + ", " + person.Domicilio.CodigoPostal);

        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            Empleado emp = new Empleado();
            emp.Nombre = "Becario";
            emp.Apellidos = "Becario";
            this.lstClases.Items.Add("VacacionesEmpleado: "+ emp.GetDiasVacaciones());
            this.lstClases.Items.Add("Empleado: "+ emp.GetNombreCompleto());
            this.lstClases.Items.Add("Empleado: "+ emp.GetSalarioMinimo()+"$");

            Director dire = new Director();
            dire.Nombre = "Director";
            dire.Apellidos = "Director";
            this.lstClases.Items.Add("VacacionesDirector: " + dire.GetDiasVacaciones());
            this.lstClases.Items.Add("Empleado: " + dire.GetNombreCompleto());
            this.lstClases.Items.Add("Empleado: " + dire.GetSalarioMinimo() + "$");

        }
    }
}
