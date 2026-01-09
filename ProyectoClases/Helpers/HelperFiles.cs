using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace ProyectoClases.Helpers
{
    public class HelperFiles
    {
        //NECESITAMOS 2 MÉTODOS,LEER Y ESCRIBIR
        //LOS MÉTODOS DEBENSER ASYNC
        //EN LOS MÉTODOS DE CLASE NO GRÁFICAS DEBEMOS
        //UTILIZAR LA CLASE TASK PARA MÉTODOS ASYNCRONOS,NO SE USA VOID
        //1)Si es un void se utiliza task
        //2)Si es un return,utilizamos Task<ClaseReturn>

        public async Task WriteFileAsync(string path, string content)
        {
            FileInfo file = new FileInfo(path);
            using (TextWriter writer = file.CreateText())
            {
                await writer.WriteAsync(content);
                await writer.FlushAsync();
                writer.Close();

            }
        }

        public async Task<string> ReadFileAsync(string path)
        {
            FileInfo file = new FileInfo(path);
            using (TextReader reader = file.OpenText())
            {
                string data = await reader.ReadToEndAsync();
                reader.Close();
                return data;
            }
        }

    }
}
