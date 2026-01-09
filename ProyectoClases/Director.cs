using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ProyectoClases
{
    public class Director:Empleado
    {
        public Director()
        {
            Debug.WriteLine("CONTRUCTOR DIRECTOR");
            this.salarioMinimo = this.salarioMinimo + 200;
        }
        //METODO SOBREESCRITO DE EMPLEADO
        public override int GetDiasVacaciones()
        {
            int vacasEmpleado = base.GetDiasVacaciones();
            Debug.WriteLine("CONTRUCTOR GetDiasVacaciones() director");
            return vacasEmpleado + 8 ;
        }
        

    }
}
