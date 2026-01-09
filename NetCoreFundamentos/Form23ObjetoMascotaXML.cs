using ProyectoClases.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//namespace
using System.Xml.Serialization;

namespace NetCoreFundamentos
{
    public partial class Form23ObjetoMascotaXML : Form
    {
        XmlSerializer serializer;
        public Form23ObjetoMascotaXML()
        {
            InitializeComponent();
            serializer = new XmlSerializer(typeof(Mascota));//hay que tiparlo
        }



        private async void button2_Click(object sender, EventArgs e)
        {//GUARDAR CLASE 
            
            Mascota mascota = new Mascota();
            mascota.Nombre = this.txtNombre.Text;
            mascota.Raza = this.txtRaza.Text;
            mascota.Edad = int.Parse(this.txtEdad.Text);

            string path = this.openFileDialog1.FileName;
            mascota.Datos = File.ReadAllBytes(path);
            //LAS CLASES QUE SE UTILIZAN SON DE TIPO STREAM
            //PARA ESCRIBIR NECESITAMOS LA CLASE DE STREAMWRITER
            using (StreamWriter writer = new StreamWriter("mascota.xml"))
            {
                this.serializer.Serialize(writer, mascota);//Guardamos objeto y mascota
                await writer.FlushAsync();
                writer.Close();
            }
            this.txtNombre.Text = "";
            this.txtRaza.Text = "";
            this.txtEdad.Text = "";

        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            Mascota mascota = null;
            using (StreamReader reader = new StreamReader("mascota.xml"))
            {   //devuelve un object,hay que hacer casting
                mascota = (Mascota)this.serializer.Deserialize(reader);
                reader.Close();
                this.txtNombre.Text = mascota.Nombre;
                this.txtRaza.Text = mascota.Raza;
                this.txtEdad.Text = mascota.Edad.ToString();
                if (mascota.Datos != null && mascota.Datos.Length > 0)
                {
                    // Usamos MemoryStream para que los bytes actúen como un archivo en memoria
                    using (MemoryStream ms = new MemoryStream(mascota.Datos))
                    {
                        // Image.FromStream crea la imagen visual a partir de la memoria
                        this.pictureBox1.Image = Image.FromStream(ms);
                    }
                }
            }

        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            //Abrir el opneFileDalog
            this.openFileDialog1.ShowDialog();
            //recuperamos la ruta de la imagen
            string path = this.openFileDialog1.FileName;
            //dibujamos la imagen en el form
            this.pictureBox1.Image = Image.FromFile(path);
        }
    }
}
