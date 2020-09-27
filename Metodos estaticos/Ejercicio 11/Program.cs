using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int max = int.MinValue;
            int min = int.MaxValue;
            int contador = 0;
            float promedio;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Ingrese un numero: ");

                while (!int.TryParse(Console.ReadLine(), out numero) || !Validacion.Validar(numero, -100, 100))
                {
                    Console.Write("Error. No es un numero o no se encuentra en el rango: ");
                }

                if (numero > max)
                {
                    max = numero;
                }
                if (numero < min)
                {
                    min = numero;
                }
                
                contador += numero;
            }

            promedio = (float)contador / 10;

            Console.WriteLine($"\nEl numero maximo es {max}, el minimo {min} y el promedio es {promedio}");

            Console.ReadKey();
        }
    }
}
