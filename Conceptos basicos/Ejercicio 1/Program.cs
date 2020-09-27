using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int maximo = int.MinValue;
            int minimo = int.MaxValue;
            int acumulador = 0;
            float promedio;

            for(int i=0; i < 5; i++)
            {
                Console.Write("Ingrese un numero: ");
                while(!int.TryParse(Console.ReadLine(), out numero))
                {
                    Console.Write("Error. Ingrese un numero: ");
                }

                if(numero > maximo)
                {
                    maximo = numero;
                }

                if(numero < minimo)
                {
                    minimo = numero;
                }

                acumulador += numero;
            }

            promedio = acumulador / 5;

            Console.WriteLine($"\nEl valor maximo es {maximo}, el minimo {minimo} y el promedio es {promedio}");

            Console.ReadKey();
        }
    }
}
