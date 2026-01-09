using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ProyectoClases
{
    public class Direccion
    {
        public string Calle { get; set; }
        public string Ciudad { get; set; }
        public int CodigoPostal{ get; set; }

        //CONSTRUCTOR DE CLASES 
        public Direccion()
        {
            Debug.WriteLine("Constructor sin parámetros");
        }
        public Direccion(string calle,string ciudad)
        {
            //Inicializamos las variables de la clase
            this.Calle = calle;
            this.Ciudad = ciudad;
            Debug.WriteLine("Constructor con 2 parámetros");
        }

        public Direccion(string calle, string ciudad,int cp)
        {
            //Inicializamos las variables de la clase
            this.Calle = calle;
            this.Ciudad = ciudad;
            this.CodigoPostal = cp;
            Debug.WriteLine("Constructor con 3 parámetros");
        }

    }
}
