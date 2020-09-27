using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using IO;

namespace Ej42
{
    class Program
    {
        static void Main(string[] args)
        {
            string rutaDelArchivo = DateTime.Now.ToString("yyyyMMdd-HHmm") + ".txt";

            try
            {
                OtraClase oc = new OtraClase();
                oc.MetodoDeInstancia();
            }
            catch (MiExcepcion ex)
            {
                ArchivoTexto.Guardar(rutaDelArchivo, ex.Message);

                if (ex.InnerException != null)
                {
                    Exception e = ex.InnerException;
                    do
                    {
                        ArchivoTexto.Guardar(rutaDelArchivo, e.Message); //Muestra los msj de las InnerException
                        e = e.InnerException;
                    }
                    while (e != null);
                }
            }

            try
            {
                Console.WriteLine(ArchivoTexto.Leer(rutaDelArchivo));
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
