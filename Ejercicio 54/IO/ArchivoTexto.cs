using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    public static class ArchivoTexto
    {
        public static void Guardar(string ruta, string informacion)
        {
            try
            {
                using(StreamWriter sw = new StreamWriter(ruta, true))
                {
                    sw.WriteLine(informacion);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static string Leer(string ruta)
        {
            string contenido = "";

            if(File.Exists(ruta))
            {
                using (StreamReader sr = new StreamReader(ruta))
                {
                    contenido = sr.ReadToEnd();
                }
            }
            else
            {
                throw new FileNotFoundException(); // la fuerzo ya que puede tirar otro tipo de excepciones
                                                   // como ArgumentException o ArgumentNullException por ej
            }

            return contenido;
        }
    }
}
