using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//nuevo name space
using System.IO;
using ProyectoClases.Helpers;

namespace NetCoreFundamentos
{
    public partial class Form21Files : Form
    {
        //creamos 
        public string path { get; set; }
        //helperFile
        HelperFiles helper;

        public Form21Files()
        {
            InitializeComponent();
            this.helper = new HelperFiles();//INSTANCIAMOS LA CLASE

            //cuando hablamos de ruta o caracteres especiales
            //dentro de string,tenemos 2 formas de escribir dichos caracteres
            //1) C:\carpeta\fsdfsd.txt
            //utilizar doble barra
            //C:\\carpeta\\fsdfsd.txt
            //o usar @"C:\carpeta\fsdfsd.txt"
            this.path = "file1.txt";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.lstNombres.Items.Add(this.txtNombre.Text);
            this.txtNombre.SelectAll();

        }

        private async void btnLeer_Click(object sender, EventArgs e)
        {
            string content = await this.helper.ReadFileAsync(this.path);
            this.txtContenido.Text = content;//lo pintamos
            //FileInfo file = new FileInfo(this.path);
            //using (TextReader reader = file.OpenText())
            //{
            //    //leemos el objeto
            //    string content = await reader.ReadToEndAsync();
            //    reader.Close();//lo cerramos siempre
            //    this.txtContenido.Text = content;//lo pintamos
            //}
            
            //si queremos pegarlo en la listbox
            string[] nombres = content.Split(',');
            this.lstNombres.Items.Clear();
            foreach(string name in nombres)
            {
                this.lstNombres.Items.Add(name);
            }

        }

        //WRITE LO HACEMOS ASYNCRONO
        private async void btnWrite_Click(object sender, EventArgs e)
        {
            string content = this.getNombresListBox();

            await this.helper.WriteFileAsync(this.path, content);//lo hacemos desde una clase
            MessageBox.Show("Datos almacenados");

            ////tenemos una clase llamada FILEINFO que nos devuelve un file
            ////y podemos generar un writer/reader
            //FileInfo file = new FileInfo(this.path);
            ////creamos el fichero
            //using (TextWriter writer = file.CreateText())
            //{
            //    string content = this.getNombresListBox();
            //    //escribimos en el fichero 
            //    //como es async usamos await en la petición
            //    await writer.WriteAsync(content);
            //    //después de escribir debemos liberar la memoria para hacerlo fijo
            //    await writer.FlushAsync();
            //    //cerramos el fichero
            //    writer.Close();
            //    MessageBox.Show("Fichero almacenado");
            //}

        }
        //Nos hacemos un metodo que nos devuelva los nombres del listbox

        public string getNombresListBox()
        {
            string data = "";
            foreach(string name in this.lstNombres.Items)
            {
                data += name + ",";

            }
            data = data.Trim(',');
            return data;
        }

    }
}
