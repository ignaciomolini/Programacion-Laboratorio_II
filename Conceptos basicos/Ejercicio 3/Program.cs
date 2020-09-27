using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroAux;

            Console.Write("Ingrese un numero: ");

            if (int.TryParse(Console.ReadLine(), out numeroAux))
            {
                int i = 0;

                for (int j = 2; j <= numeroAux; j++)
                {
                    for (i = 2; i <= j; i++)
                    {
                        if ((j % i) == 0)
                        {
                            break;
                        }
                    }

                    if (i == j)
                    {
                        Console.WriteLine("{0} es primo", j);
                    }
                }   
            }

            Console.ReadKey();    
        }
    }
}
