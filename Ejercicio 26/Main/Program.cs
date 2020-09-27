using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[20];
            int aux;
            Random numerosRandom = new Random();

            for(int i =0; i < 20; i++)
            {
                aux = numerosRandom.Next(-50, 50);

                while (aux == 0)
                {
                    aux = numerosRandom.Next(-50, 50);
                }

                numeros[i] = aux;
            }

            Console.Write("A. Vector como fue ingrresado: ");

            for (int i = 0; i < 20; i++)
            {
                Console.Write($"{numeros[i]} ");
            }

            Console.Write("\nB. Positivos ordenados en forma decreciente: ");
            Array.Sort(numeros);
            Array.Reverse(numeros);

            for (int i = 0; i < 20; i++)
            {
                if(numeros[i] > 0)
                {
                    Console.Write($"{numeros[i]} ");
                }
            }

            Console.Write("\nC. Negativos ordenados en forma creciente: ");
            Array.Reverse(numeros);

            for (int i = 0; i < 20; i++)
            {
                if (numeros[i] < 0)
                {
                    Console.Write($"{numeros[i]} ");
                }
            }

            Console.ReadKey();
        }
    }
}
