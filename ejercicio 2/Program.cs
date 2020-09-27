using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            double numeroAlCuadrado;
            double numeroAlCubo;
            string lectura;

            Console.Write("Ingrese un numero mayor a 0: ");
            lectura = Console.ReadLine();

            while(!int.TryParse(lectura, out numero) || numero < 0)
            {
                Console.Write("Error. Ingrese un numero mayor a 0: ");
                lectura = Console.ReadLine();
            }

            numeroAlCuadrado = Math.Pow(numero, 2);
            numeroAlCubo = Math.Pow(numero, 3);

            Console.Write($"El numero {numero} al cuadrado es {numeroAlCuadrado} y al cubo {numeroAlCubo}");
            Console.ReadKey();

        }
    }
}
