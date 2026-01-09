using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;


namespace ProyectoClases
{
    

    //Vamos a crear 2 enums,están entre la clase y el namespace
    public enum TipoGenero { Masculino=0, Femenino=1}
    public enum Paises { España,Francia,Alemania,Andorra,Ecuador }

    
    public class Persona
    {
        //SE PODRÍA INSTANCIAR AQUÍ TAMBIÉN
        #region CONSTRUCTORES
        public Persona()
        {
            Debug.WriteLine("Constructor persona vacío");
        }

        public Persona(String nombre,string apellidos)
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            Debug.WriteLine("Constructor persona con 2 parámetros");
        }
        #endregion


        #region PROPIEDADES
        //PROPIEDADES INDIZADAS 
        private string _DescripcionThis;
        public string this[int indice]
        {
            get { return this._DescripcionThis; }
            set {
                //DEVOLVEMOS  UNA DESCRIPCIÓN ALEATORIA DE NUESTRO NUMERO
                Random random = new Random();
                int dato = random.Next(1, 20);
                this._DescripcionThis = "Descripción " + dato;
            }
        }

        public Direccion Domicilio { get; set; }
        public Direccion DomicilioVacaciones { get; set; }

        public TipoGenero _Genero;
        public TipoGenero Genero {
            get { return this._Genero; }
            set { 
                if(value !=TipoGenero.Femenino && value != TipoGenero.Masculino)
                {
                    throw new Exception("Error en el enum de genero");
                }
                else
                {
                    this._Genero = value;
                }
            }
        }
        public Paises Nacionalidad { get; set; }



        public string Nombre { get; set; } //propiedades autoimplementadas Cuando NO necesitamos comprobar
        public string Apellidos { get; set; }

        //CAMPO PROPIEDAD,solo se va a usar dentro de esta clase

        private int _Edad;

        //establecemos como propiedad para poder aplicar restricciones
        public int Edad
        {   //Devolvemos un valor
            get { return this._Edad; }
            //Establecemos un valor
            //programador person.Edad=-25
            set {
                //estamos haciendo un bucle infinito,vamos a crear fieds _Edad
                if (value >= 0)
                {
                    this._Edad = value;
                }//SI NO PASA POR AQUI SE ESTABLECE COMO 0

                 // O Se puede lanzar una excepción
                 //else
                 //{
                 //    throw new Exception("La edad no puede ser negativa");
                 //}
            }
        }

        #endregion

        #region METODOS
        //SIMPLES MÉTODOS SEPARADOS

        //POLIMORFISMO,nos permite tener un solo nombre de acción y múltiples métodos
        //no importa la firma en estos casos,la cosa es que se llama igual
        //y dependiendo lo que nos llegue se mete en dicho método
        public string GetNombreCompleto()
        {
            return this.Nombre + " " + this.Apellidos;
        }

        public string GetNombreCompleto(bool orden)
        {
            return this.Apellidos + " " + this.Nombre;
        }

        public string GetNombreCompleto(int num1)
        {
            return (this.Apellidos + " " + this.Nombre).ToUpper();
        }



        #endregion

    }

}
