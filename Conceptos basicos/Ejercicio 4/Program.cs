using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int perfectosEncontrados = 0;
            int numero = 1;

            do
            {
                int sumador = 0;

                for (int i = numero - 1; i > 0; i--)
                {
                    if ((numero % i) == 0)
                    {
                        sumador += i;

                        if (sumador > numero)
                        {
                            break;
                        }
                    }
                }

                if (sumador == numero)
                {
                    perfectosEncontrados++;
                    Console.WriteLine("El número {0} es PERFECTO", numero);
                }
                numero++;

            } while (perfectosEncontrados < 4);

            Console.ReadKey();
        }
    }
}
