using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int anioInicio;
            int anioFin;

            Console.Write("Ingrese año de inicio: ");

            while (!int.TryParse(Console.ReadLine(), out anioInicio))
            {
                Console.Write("Error. Ingrese año de inicio: ");
            }

            Console.Write("Ingrese año de fin: ");

            while (!int.TryParse(Console.ReadLine(), out anioFin))
            {
                Console.Write("Error. Ingrese año de fin: ");
            }

            for(int i = anioInicio; i <= anioFin; i++)
            {
                if ((i % 400) == 0 || (i % 100) != 0 && (i % 4) == 0  )
                {
                    Console.WriteLine("El año {0} es bisiesto", i);
                }
            }

            Console.ReadKey();
        }
    }
}
