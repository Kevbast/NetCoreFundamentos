using ProyectoClases.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoClases.Helpers
{
    public class HelperMascotas
    {
        //Deberiamos tener una coleccion y devolver una lista
        public List <Mascota> Mascotas { get; set;}
        //QUEREMOS ALMACENAR DE FORMA FISICA LAS MASCOTAS EN FILES
        private HelperFiles helper;//no se lo ofrecemos al form
        private string path;//ruta privada

        public HelperMascotas()
        {
            this.Mascotas = new List<Mascota>();//instanciamos
            this.helper = new HelperFiles();
            this.path = "mascotas.txt";
        }
        //nos encargamos de los métodos de conversión aquí
        //CONVERTIR EL STRING DEL READ A LIST
        private void ConvertirMascotasList(string data)
        {
            //GARFIELD,GATO@PLUTO,PERRO
            this.Mascotas.Clear();//limpiamos la colección
            //SEPARAMOS CADA MASCOTA CON @
            string[] datosMascota = data.Split('@');
            foreach (string stringMascota in datosMascota)
            {
                //SEPARAMOS MEDIANTE COMA
                string[] propiedades = stringMascota.Split(',');
                //CONVERTIMOS EL TRISTE STRING EN OBJETOS
                Mascota mascota = new Mascota();
                //mirar bien la cadena que recibo mediante puntos de interrupción,
                //si me funciona una vez y las siguientes no,
                //podría ser por el número de propiedades que me devuelve
                mascota.Nombre = propiedades[0];
                mascota.Raza = propiedades[1];
                this.Mascotas.Add(mascota);
            }

        }

        //El PROGRAMADOR ESCRIBA read y LEEMOS STRING Y RELLENAMOS COLECCION
        public async Task ReadMascotasAsync()
        {
            //leemos el fichero de mascotas
            string data= await this.helper.ReadFileAsync(this.path);
            //CONVERTIMOS STRING A LIST
            this.ConvertirMascotasList(data);//llamamos al método
        }

        //CONVERTIMOS LA COLECCIONA STRING Y LO DEVOLVEMOS
        private string ConvertirMascotasString()
        {//GARFIELD,GATO@PLUTO,PERRO
            string data = "";
            foreach (Mascota mascota in this.Mascotas)
            {
                //SEPARAMOS LAS PROPIEDADES MEDIANTE
                string propiedades = mascota.Nombre + "," + mascota.Raza;
                //SEPARAMOS CADA OBJETO STRING DE MASCOTA
                data += propiedades + "@";
            }

            data = data.Trim('@');
            return data;
        }

        //EL PROGRAMADOR ESCRIBA write y GUARDAMOS LAS MASCOTAS
        public async Task WriteMascotaAsync()
        {
            //CONVERTIMOS LA COLECCION A STRING
            string data = this.ConvertirMascotasString();//llamamos al método
            //ESCRIBIMOS LOS DATOS EN EL FILE
            await this.helper.WriteFileAsync(this.path, data);
        }

    }
}
