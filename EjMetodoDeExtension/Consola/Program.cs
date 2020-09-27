using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now.ObtenerPlacaCronica(Entidades.Estaciones.Invierno));
            Console.WriteLine(DateTime.Now.ObtenerPlacaCronica(Entidades.Estaciones.Primavera));
            Console.WriteLine(DateTime.Now.ObtenerPlacaCronica(Entidades.Estaciones.Verano));
            Console.WriteLine(DateTime.Now.ObtenerPlacaCronica(Entidades.Estaciones.Otonio));
           
            Console.ReadKey();
        }
    }
}
