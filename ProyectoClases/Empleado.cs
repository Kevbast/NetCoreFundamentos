using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ProyectoClases
{
    public class Empleado:Persona
    {//EMPELADO VA A HEREDAR DE PERSONA

        public virtual int GetDiasVacaciones()//al poner virtual va a ser más fácil ver que se va a sobreescibir
        {
            Debug.WriteLine("Get vacaciones empleado");//si sebreescribimos el método no se verá
            return 22;
        }

        protected int salarioMinimo { get; set;}//lo queremos protected para que pueda verlo
                                                //el director y que el form no lo modifique
        public int GetSalarioMinimo()
        {
            return this.salarioMinimo;
        }
            
        //Creamos un constructor vacio
        public Empleado() 
        {
            Debug.WriteLine("CONSTRUCTOR EMPLEADO VACIO");
            this.salarioMinimo = 1600;
        }
        public Empleado(String nombre, string apellidos) 
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            Debug.WriteLine("Constructor EMPLEADO con 2 parámetros");
        }
    }
}
