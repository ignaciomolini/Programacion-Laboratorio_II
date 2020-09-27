using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Ej42
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                OtraClase oc = new OtraClase();
                oc.MetodoDeInstancia();
            }
            catch(MiExcepcion ex)
            {
                Console.WriteLine(ex.Message);

                if (ex.InnerException != null)
                {
                    Exception e = ex.InnerException;
                    do
                    {
                        Console.WriteLine(e.Message); //Muestra los msj de las InnerException
                        e = e.InnerException;
                    } 
                    while (e != null);
                }
            }

            Console.ReadKey();
            
        }
    }
}
